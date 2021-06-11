
namespace ZPL_Print_Testing.Forms
{
    partial class frmConfig
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.MaskedTextBox();
            this.txtIp = new System.Windows.Forms.TextBox();
            this.chkSaveLabels = new System.Windows.Forms.CheckBox();
            this.btnPath = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.grdLabelFormats = new System.Windows.Forms.DataGridView();
            this.ctxGrid = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSaveExit = new System.Windows.Forms.Button();
            this.grdPrinters = new System.Windows.Forms.DataGridView();
            this.ctxPrinters = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuPrinterAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPrinterDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdLabelFormats)).BeginInit();
            this.ctxGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPrinters)).BeginInit();
            this.ctxPrinters.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Port";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Save Labels";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Label Path";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(96, 50);
            this.txtPort.Mask = "0";
            this.txtPort.Name = "txtPort";
            this.txtPort.PromptChar = ' ';
            this.txtPort.Size = new System.Drawing.Size(70, 23);
            this.txtPort.TabIndex = 1;
            this.txtPort.ValidatingType = typeof(int);
            // 
            // txtIp
            // 
            this.txtIp.Location = new System.Drawing.Point(96, 22);
            this.txtIp.Name = "txtIp";
            this.txtIp.Size = new System.Drawing.Size(119, 23);
            this.txtIp.TabIndex = 0;
            this.txtIp.Text = "127.0.0.1";
            this.txtIp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIp_KeyPress);
            // 
            // chkSaveLabels
            // 
            this.chkSaveLabels.AutoSize = true;
            this.chkSaveLabels.Location = new System.Drawing.Point(96, 83);
            this.chkSaveLabels.Name = "chkSaveLabels";
            this.chkSaveLabels.Size = new System.Drawing.Size(15, 14);
            this.chkSaveLabels.TabIndex = 2;
            this.chkSaveLabels.UseVisualStyleBackColor = true;
            // 
            // btnPath
            // 
            this.btnPath.Location = new System.Drawing.Point(379, 103);
            this.btnPath.Name = "btnPath";
            this.btnPath.Size = new System.Drawing.Size(26, 23);
            this.btnPath.TabIndex = 4;
            this.btnPath.UseVisualStyleBackColor = true;
            this.btnPath.Click += new System.EventHandler(this.btnPath_Click);
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(96, 103);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(277, 23);
            this.txtPath.TabIndex = 3;
            // 
            // grdLabelFormats
            // 
            this.grdLabelFormats.AllowUserToAddRows = false;
            this.grdLabelFormats.AllowUserToDeleteRows = false;
            this.grdLabelFormats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdLabelFormats.ContextMenuStrip = this.ctxGrid;
            this.grdLabelFormats.Location = new System.Drawing.Point(12, 158);
            this.grdLabelFormats.MultiSelect = false;
            this.grdLabelFormats.Name = "grdLabelFormats";
            this.grdLabelFormats.ReadOnly = true;
            this.grdLabelFormats.RowTemplate.Height = 25;
            this.grdLabelFormats.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdLabelFormats.ShowCellErrors = false;
            this.grdLabelFormats.ShowCellToolTips = false;
            this.grdLabelFormats.Size = new System.Drawing.Size(583, 196);
            this.grdLabelFormats.TabIndex = 5;
            this.grdLabelFormats.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grdLabelFormats_CellMouseDoubleClick);
            // 
            // ctxGrid
            // 
            this.ctxGrid.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAdd,
            this.menuDelete});
            this.ctxGrid.Name = "ctxGrid";
            this.ctxGrid.Size = new System.Drawing.Size(108, 48);
            // 
            // menuAdd
            // 
            this.menuAdd.Name = "menuAdd";
            this.menuAdd.Size = new System.Drawing.Size(107, 22);
            this.menuAdd.Text = "Add";
            // 
            // menuDelete
            // 
            this.menuDelete.Name = "menuDelete";
            this.menuDelete.Size = new System.Drawing.Size(107, 22);
            this.menuDelete.Text = "Delete";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(525, 572);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(70, 24);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSaveExit
            // 
            this.btnSaveExit.Location = new System.Drawing.Point(449, 572);
            this.btnSaveExit.Name = "btnSaveExit";
            this.btnSaveExit.Size = new System.Drawing.Size(70, 24);
            this.btnSaveExit.TabIndex = 6;
            this.btnSaveExit.Text = "Save/Exit";
            this.btnSaveExit.UseVisualStyleBackColor = true;
            this.btnSaveExit.Click += new System.EventHandler(this.btnSaveExit_Click);
            // 
            // grdPrinters
            // 
            this.grdPrinters.AllowUserToAddRows = false;
            this.grdPrinters.AllowUserToDeleteRows = false;
            this.grdPrinters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPrinters.ContextMenuStrip = this.ctxPrinters;
            this.grdPrinters.Location = new System.Drawing.Point(12, 391);
            this.grdPrinters.MultiSelect = false;
            this.grdPrinters.Name = "grdPrinters";
            this.grdPrinters.ReadOnly = true;
            this.grdPrinters.RowTemplate.Height = 25;
            this.grdPrinters.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdPrinters.ShowCellErrors = false;
            this.grdPrinters.ShowCellToolTips = false;
            this.grdPrinters.Size = new System.Drawing.Size(583, 162);
            this.grdPrinters.TabIndex = 8;
            // 
            // ctxPrinters
            // 
            this.ctxPrinters.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuPrinterAdd,
            this.menuPrinterDelete});
            this.ctxPrinters.Name = "ctxPrinters";
            this.ctxPrinters.Size = new System.Drawing.Size(108, 48);
            // 
            // menuPrinterAdd
            // 
            this.menuPrinterAdd.Name = "menuPrinterAdd";
            this.menuPrinterAdd.Size = new System.Drawing.Size(107, 22);
            this.menuPrinterAdd.Text = "Add";
            // 
            // menuPrinterDelete
            // 
            this.menuPrinterDelete.Name = "menuPrinterDelete";
            this.menuPrinterDelete.Size = new System.Drawing.Size(107, 22);
            this.menuPrinterDelete.Text = "Delete";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Saved Label Formats";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 373);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Printers";
            // 
            // frmConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(609, 604);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.grdPrinters);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSaveExit);
            this.Controls.Add(this.grdLabelFormats);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.txtIp);
            this.Controls.Add(this.chkSaveLabels);
            this.Controls.Add(this.btnPath);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConfig";
            this.ShowIcon = false;
            this.Text = "Configuration";
            this.Load += new System.EventHandler(this.frmConfig_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdLabelFormats)).EndInit();
            this.ctxGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdPrinters)).EndInit();
            this.ctxPrinters.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox txtPort;
        private System.Windows.Forms.TextBox txtIp;
        private System.Windows.Forms.CheckBox chkSaveLabels;
        private System.Windows.Forms.Button btnPath;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.DataGridView grdLabelFormats;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSaveExit;
        private System.Windows.Forms.ContextMenuStrip ctxGrid;
        private System.Windows.Forms.ToolStripMenuItem menuAdd;
        private System.Windows.Forms.ToolStripMenuItem menuDelete;
        private System.Windows.Forms.DataGridView grdPrinters;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ContextMenuStrip ctxPrinters;
        private System.Windows.Forms.ToolStripMenuItem menuPrinterAdd;
        private System.Windows.Forms.ToolStripMenuItem menuPrinterDelete;
    }
}