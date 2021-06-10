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
    public partial class frmLabelFormats : Form
    {
        private LabelFormat m_labelFormat;
        private readonly IConfigService _configService;

        public delegate void LabelFormatAddedOrUpdated();

        public event LabelFormatAddedOrUpdated AddedOrUpdated;

        public frmLabelFormats(int appConfigId)
        {
            InitializeComponent();
            //m_labelFormat = new LabelFormat();
            //_configService = new ConfigService();
            this.m_labelFormat = new LabelFormat();
            this.m_labelFormat.AppConfigId = appConfigId;
            _configService = new ConfigService();
        }

        public frmLabelFormats(LabelFormat labelFormat)
        {
            InitializeComponent();

            this.m_labelFormat = labelFormat;
            _configService = new ConfigService();
        }
        
        private void frmLabelFormats_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            txtName.Text = m_labelFormat.Name;
            txtWidth.Text = m_labelFormat.Width == 0 ? "" : m_labelFormat.Width.ToString();
            txtHeight.Text = m_labelFormat.Height == 0 ? "" : m_labelFormat.Height.ToString();
            cboPrintDensity.SelectedItem = m_labelFormat.PrintDensity;
            chkDefault.Checked = m_labelFormat.IsDefault;

        }

        private void Sync()
        {
            m_labelFormat.Name = txtName.Text;
            m_labelFormat.Width = int.TryParse(txtWidth.Text, out int width) ? width : 0;
            m_labelFormat.Height = int.TryParse(txtHeight.Text, out int height) ? height : 0;
            m_labelFormat.PrintDensity =
                cboPrintDensity.SelectedItem == null ? "" : cboPrintDensity.SelectedItem.ToString();
            m_labelFormat.IsDefault = chkDefault.Checked;
        }

        private bool FormValid()
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Name cannot be empty.");
                txtName.Focus();
                return false;
            }
            
            if (string.IsNullOrWhiteSpace(txtWidth.Text))
            {
                MessageBox.Show("Width cannot be empty.");
                txtWidth.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtHeight.Text))
            {
                MessageBox.Show("Height cannot be empty.");
                txtHeight.Focus();
                return false;
            }

            if (cboPrintDensity.SelectedItem == null)
            {
                MessageBox.Show("Print Density must be selected.");
                cboPrintDensity.Focus();
                return false;
            }

            return true;
        }

        private void btnSaveExit_Click(object sender, EventArgs e)
        {
            if (FormValid())
            {
                Sync();
                _configService.SaveLabelFormat(m_labelFormat);
                AddedOrUpdated.Invoke();
                this.Close();
            }


        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
