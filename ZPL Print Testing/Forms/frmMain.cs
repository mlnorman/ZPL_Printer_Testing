using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZPL_Print_Testing.Forms;
using ZPL_Print_Testing.Models;
using ZPL_Print_Testing.Servers;
using ZPL_Print_Testing.Services;
using ZPL_Print_Testing.ViewModels;
using Message = ZPL_Print_Testing.Models.Message;

namespace ZPL_Print_Testing
{
    public partial class frmMain : Form
    {
        private CancellationTokenSource m_cancellationTokenSource;
        private CancellationToken m_cancellationToken;
        private ConcurrentBag<Task> m_tasks;
        private ConcurrentQueue<Models.Message> messages;
        private readonly IConfigService _configService;
        private Server m_server;

        private AppConfig m_settings;
        //private DispatcherTimer timer;


        public frmMain()
        {
            InitializeComponent();

            _configService = new ConfigService();

            
        }

        private void txtIp_KeyPress(object sender, KeyPressEventArgs e)
        {
            var key = (Keys)e.KeyChar;
            if ((Keys)e.KeyChar != Keys.Delete && (Keys)e.KeyChar != Keys.Back)
            {
                Regex regex = new Regex("[^0-9]+");
                e.Handled = regex.IsMatch(e.KeyChar.ToString());
            }
        }

        private void btnStartStop_Click(object sender, EventArgs e)
        {
            if (!ValidateForm()) return;

            var mainViewModel = Sync();


            if (btnStartStop.Text.ToLower().Equals("start"))
            {
                m_tasks = new ConcurrentBag<Task>();
                m_cancellationTokenSource = new CancellationTokenSource();
                m_cancellationToken = m_cancellationTokenSource.Token;
                messages = new ConcurrentQueue<Message>();

                var t = Task.Run(
                    () => { m_server = new Server(mainViewModel, m_cancellationToken, m_tasks, messages); },
                    m_cancellationToken);

                btnStartStop.Text = "Stop";
                picRunning.Visible = true;
                SetFieldsReadOnly();
                m_tasks.Add(t);
                timerTick.Start();
            }
            else
            {
                m_cancellationTokenSource.Cancel();
                SetFieldsEnabled();
                picRunning.Visible = false;
                Console.WriteLine("Task cancellation requested");
                btnStartStop.Text = "Start";
                timerTick.Stop();
            }
            
        }

        private bool ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(txtIp.Text))
            {
                MessageBox.Show("Must enter an Ip Address.");
                txtIp.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPort.Text))
            {
                MessageBox.Show("Must enter an Port.");
                txtPort.Focus();
                return false;
            }

            int port;

            if (!int.TryParse(txtPort.Text, out port))
            {
                MessageBox.Show("Port must be an integer.");
                txtPort.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtHeight.Text))
            {
                MessageBox.Show("Must enter a height.");
                txtHeight.Focus();
                return false;
            }

            int height;
            if (!int.TryParse(txtHeight.Text, out height))
            {
                MessageBox.Show("Height must be a integer.");
                txtHeight.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtWidth.Text))
            {
                MessageBox.Show("Must enter a width.");
                txtWidth.Focus();
                return false;
            }

            int width;
            if (!int.TryParse(txtHeight.Text, out width))
            {
                MessageBox.Show("Width must be a integer.");
                txtWidth.Focus();
                return false;
            }

            if (cboPrintDensity.SelectedItem == null)
            {
                MessageBox.Show("Must select a print density.");
                cboPrintDensity.Focus();
                return false;
            }

            if (chkSaveLabels.Checked)
            {
                if (string.IsNullOrWhiteSpace(txtPath.Text))
                {
                    MessageBox.Show("Must enter a path if Save Labels is checked.");
                    txtPath.Focus();
                    return false;
                }
            }

            return true;

        }

        private MainViewModel Sync()
        {
            var mainViewModel = new MainViewModel(txtIp.Text, int.Parse(txtPort.Text), int.Parse(txtHeight.Text),
                int.Parse(txtWidth.Text), cboPrintDensity.SelectedItem.ToString(), chkUseBitonal.Checked, txtPath.Text, chkSaveLabels.Checked);

            return mainViewModel;
        }

        private void timerTick_Tick(object sender, EventArgs e)
        {
            if (messages != null && messages.Count > 0)
            {
                messages.TryDequeue(out Message message);

                if (message != null)
                {

                    imgLabel.Image = Image.FromStream(new MemoryStream(message.ImageBytes));
                }
            }
        }

        private void btnPath_Click(object sender, EventArgs e)
        {
            using (var fd = new FolderBrowserDialog())
            {
                DialogResult result = fd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fd.SelectedPath))
                {
                    txtPath.Text = fd.SelectedPath;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            picRunning.Visible = false;

            // load default from appsettings if they are set
            m_settings = _configService.GetAppConfig();

            txtIp.Text = m_settings.IpAddress;
            txtPort.Text = m_settings.Port.ToString();

            //add each format,  look for a default label format, if it exist, set it and set values
            cboSavedFormats.Items.Clear();
            foreach (var format in m_settings.LabelFormats)
            {
                cboSavedFormats.Items.Add(format.Name);

                if (format.IsDefault)
                {
                    cboSavedFormats.SelectedItem = format.Name;
                    txtHeight.Text = format.Height.ToString();
                    txtWidth.Text = format.Width.ToString();
                    cboPrintDensity.SelectedItem = format.PrintDensity;
                }
            }

            chkSaveLabels.Checked = m_settings.SaveLabels;
            txtPath.Text = m_settings.SaveLabelPath;

            toolStripMenuConfig.Click += (sender, e) => { OpenConfigForm(); };


        }

        private void cboSavedFormats_SelectedIndexChanged(object sender, EventArgs e)
        {
            ;

            if (cboSavedFormats.SelectedItem != null)
            {
                // try and find item, then update fields if it exists
                foreach (var format in m_settings.LabelFormats)
                {
                    if (format.Name.Equals(cboSavedFormats.SelectedItem.ToString()))
                    {
                        cboSavedFormats.SelectedItem = format.Name;
                        txtHeight.Text = format.Height.ToString();
                        txtWidth.Text = format.Width.ToString();
                        cboPrintDensity.SelectedItem = format.PrintDensity;
                        chkUseBitonal.Checked = format.UseBitonal;
                    }
                }
            }
        }

        private void SetFieldsReadOnly()
        {
            txtIp.Enabled = false;
            txtPort.Enabled = false;
            cboPrintDensity.Enabled = false;
            cboSavedFormats.Enabled = false;
            txtHeight.Enabled = false;
            txtWidth.Enabled = false;
            txtPath.Enabled = false;
            chkSaveLabels.Enabled = false;
            btnPath.Enabled = false;
            toolStripMenuConfig.Enabled = false;
            chkUseBitonal.Enabled = false;
        }

        private void SetFieldsEnabled()
        {
            txtIp.Enabled = true;
            txtPort.Enabled = true;
            cboPrintDensity.Enabled = true;
            cboSavedFormats.Enabled = true;
            txtHeight.Enabled = true;
            txtWidth.Enabled = true;
            txtPath.Enabled = true;
            chkSaveLabels.Enabled = true;
            btnPath.Enabled = true;
            toolStripMenuConfig.Enabled = true;
            chkUseBitonal.Enabled = true;
        }

        private void OpenConfigForm()
        {
            var f = new frmConfig();
            f.ConfigHasChanged += LoadData;
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }
    }
}
