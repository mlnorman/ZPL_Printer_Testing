using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZPL_Print_Testing.Models;
using ZPL_Print_Testing.Services;

namespace ZPL_Print_Testing.Forms
{
    public partial class frmConfig : Form
    {

        private readonly IConfigService _configService;

        private AppConfig m_config;

        public delegate void ConfigChanged();

        public event ConfigChanged ConfigHasChanged;

        private bool m_labelFormatHasChanged = false;


        public frmConfig()
        {
            InitializeComponent();

            _configService = new ConfigService();
        }

        private void frmConfig_Load(object sender, EventArgs e)
        {
            // add events to context menu items
            menuAdd.Click += (sender, e) => { AddItem(); };
            menuDelete.Click += (sender, e) => { DeleteItem(e); };

            menuPrinterAdd.Click += (sender, e) => { AddPrinter(); };
            menuPrinterDelete.Click += (sender, e) => { DeletePrinter(e); };

            LoadData();
        }

        private void LoadData()
        {
            m_config = _configService.GetAppConfig();
            txtIp.Text = m_config.IpAddress;
            txtPort.Text = m_config.Port.ToString();
            chkSaveLabels.Checked = m_config.SaveLabels;
            txtPath.Text = m_config.SaveLabelPath;

            var labelFormatBindingList = new BindingList<LabelFormat>(m_config.LabelFormats);
            var labelFormatsSource = new BindingSource(labelFormatBindingList, null);
            grdLabelFormats.DataSource = labelFormatsSource;

            var printersBindingList = new BindingList<Printer>(m_config.Printers);
            var printersSource = new BindingSource(printersBindingList, null);
            grdPrinters.DataSource = printersSource;
            // Fix header names
            ChangeHeaders();

            // This is needed to clear the default first row selection 
            // when the form is loaded.
            grdLabelFormats.ClearSelection();
            grdPrinters.ClearSelection();

        }

        private void ChangeHeaders()
        {
            grdLabelFormats.Columns["IsDefault"].HeaderText = "Default";
            grdLabelFormats.Columns["PrintDensity"].HeaderText = "Print Density";
        }

        private void grdLabelFormats_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {


            var f = new frmLabelFormats(m_config.LabelFormats[e.RowIndex]);
            f.StartPosition = FormStartPosition.CenterScreen;
            f.AddedOrUpdated += RefreshGrid;
            f.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (m_labelFormatHasChanged) ConfigHasChanged.Invoke();
            this.Close();
        }

        private void btnSaveExit_Click(object sender, EventArgs e)
        {
            Sync();
            _configService.SaveAppConfig(m_config);
            ConfigHasChanged.Invoke();
            this.Close();
        }

        private void Sync()
        {
            m_config.IpAddress = txtIp.Text;
            m_config.Port = int.TryParse(txtPort.Text, out int port) ? port : 0;
            m_config.SaveLabels = chkSaveLabels.Checked;
            m_config.SaveLabelPath = txtPath.Text;
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

        private void RefreshGrid()
        {
            LoadData();
            m_labelFormatHasChanged = true;
        }

        private void AddItem()
        {
            var f = new frmLabelFormats(m_config.Id);
            f.StartPosition = FormStartPosition.CenterScreen;
            f.AddedOrUpdated += RefreshGrid;
            f.ShowDialog();
        }

        private void DeleteItem(EventArgs e)
        {
            if (grdLabelFormats.SelectedRows.Count == 0) return;

            var selectedRow = (grdLabelFormats.SelectedRows[0].DataBoundItem as LabelFormat);
            try
            {
                _configService.DeleteLabelFormat(selectedRow.Id);
                RefreshGrid();
            }
            catch (Exception exception)
            {
                string message =
                    $"There was an issue deleting the record from the database.{Environment.NewLine} {Environment.NewLine}{exception.Message}";
                MessageBox.Show(message, "Label Formats",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddPrinter()
        {
            var f = new frmPrinter(m_config.Id);
            f.StartPosition = FormStartPosition.CenterScreen;
            f.AddedOrUpdated += RefreshGrid;
            f.ShowDialog();
        }

        private void DeletePrinter(EventArgs e)
        {
            if (grdPrinters.SelectedRows.Count == 0) return;

            var selectedRow = (grdPrinters.SelectedRows[0].DataBoundItem as Printer);
            try
            {
                _configService.DeletePrinter(selectedRow.Id);
                RefreshGrid();
            }
            catch (Exception exception)
            {
                string message =
                    $"There was an issue deleting the record from the database.{Environment.NewLine} {Environment.NewLine}{exception.Message}";
                MessageBox.Show(message, "Printers",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
    }
}
