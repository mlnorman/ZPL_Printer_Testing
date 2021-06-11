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
    public partial class frmPrinter : Form
    {

        private Printer m_printer;
        private readonly IConfigService _configService;

        public delegate void PrinterAddedOrUpdated();

        public event PrinterAddedOrUpdated AddedOrUpdated;

        public frmPrinter(int appConfigId)
        {
            InitializeComponent();
            m_printer = new Printer();
            m_printer.AppConfigId = appConfigId;
            _configService = new ConfigService();
        }

        public frmPrinter(Printer printer)
        {
            InitializeComponent();
            m_printer = printer;
            _configService = new ConfigService();
        }


        private void frmPrinter_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            txtName.Text = m_printer.Name;
            txtIp.Text = m_printer.IpAddress;
            txtPort.Text = m_printer.Port.ToString();
            chkDefault.Checked = m_printer.IsDefault;

        }

        private bool IsValid()
        {

            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Name cannot be blank.", "Printer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtName.Focus();
                return false;
            }
            
            if (string.IsNullOrWhiteSpace(txtIp.Text))
            {
                MessageBox.Show("An IP Address must be entered.", "Printer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtIp.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPort.Text))
            {
                MessageBox.Show("A port must be entered.", "Printer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPort.Focus();
                return false;
            }

            int port;

            if (!int.TryParse(txtPort.Text, out port))
            {
                MessageBox.Show("Port must be a number.", "Printer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPort.Focus();
                return false;
            }
            
            return true;
        }

        private void Sync()
        {
            m_printer.Name = txtName.Text;
            m_printer.IpAddress = txtIp.Text;
            m_printer.Port = int.TryParse(txtPort.Text, out int port) ? port : 0;
            m_printer.IsDefault = chkDefault.Checked;
        }

        private void btnSaveExit_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                try
                {
                    Sync();
                    _configService.SavePrinter(m_printer);
                    AddedOrUpdated?.Invoke();
                    this.Close();
                }
                catch (Exception exception)
                {
                    string message =
                        $"There was an issue adding the printer to the database.{Environment.NewLine} {Environment.NewLine}{exception.Message}";
                    MessageBox.Show(message, "Printer",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
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
