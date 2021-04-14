using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
    }
}
