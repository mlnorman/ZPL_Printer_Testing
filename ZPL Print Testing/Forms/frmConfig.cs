using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
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
            m_config = _configService.GetAppConfig();

            LoadData();
        }

        private void LoadData()
        {
            txtIp.Text = m_config.IpAddress;
            txtPort.Text = m_config.Port.ToString();
            chkSaveLabels.Checked = m_config.SaveLabels;
            txtPath.Text = m_config.SaveLabelPath;

            var bindingList = new BindingList<LabelFormat>(m_config.LabelFormats);
            var source = new BindingSource(bindingList, null);
            grdLabelFormats.DataSource = source;

            // This is needed to clear the default first row selection 
            // when the form is loaded.
            grdLabelFormats.ClearSelection();

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
            var config = _configService.GetAppConfig();
            var bindingList = new BindingList<LabelFormat>(m_config.LabelFormats);
            var source = new BindingSource(bindingList, null);
            grdLabelFormats.DataSource = source;

            // This is needed to clear the default first row selection 
            // when the form is loaded.
            grdLabelFormats.ClearSelection();
            m_labelFormatHasChanged = true;
        }
    }
}
