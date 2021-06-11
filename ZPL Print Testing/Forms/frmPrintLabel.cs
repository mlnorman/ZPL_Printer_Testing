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
    public partial class frmPrintLabel : Form
    {
        private readonly IConfigService _configService;
        private readonly ILabelService _labelService;
        private string m_zpl;
        private List<Printer> m_printers = new List<Printer>();
        private Printer m_selectedPrinter;

        public frmPrintLabel(string zpl)
        {
            InitializeComponent();
            m_zpl = zpl;
            _configService = new ConfigService();
            _labelService = new LabelService();
        }

        private void frmPrintLabel_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            var m_printers = _configService.GetAppConfig().Printers;

            cboPrinters.Items.Clear();
            foreach (var printer in m_printers)
            {
                cboPrinters.Items.Add(printer.Name);

                if (printer.IsDefault)
                {
                    cboPrinters.SelectedItem = printer.Name;
                }
            }
        }

        private bool IsValid()
        {

            if (cboPrinters.SelectedItem == null)
            {
                MessageBox.Show("A Printer must be selected.", "Print Label", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                cboPrinters.Focus();
                return false;
            }

            return true;
        }

        private void Sync()
        {
            m_selectedPrinter =
                m_printers.FirstOrDefault(x => x.Name.Trim() == cboPrinters.SelectedItem.ToString().Trim());
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                try
                {
                    Sync();
                    _labelService.PrintLabel(m_zpl, m_selectedPrinter);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception exception)
                {
                    string message =
                        $"There was an issue sending the label to the printer.{Environment.NewLine} {Environment.NewLine}{exception.Message}";
                    MessageBox.Show(message, "Printers",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
               
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
