
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
            ((System.ComponentModel.ISupportInitialize)(this.grdLabelFormats)).BeginInit();
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
            this.txtPort.Mask = "0000";
            this.txtPort.Name = "txtPort";
            this.txtPort.PromptChar = ' ';
            this.txtPort.Size = new System.Drawing.Size(70, 23);
            this.txtPort.TabIndex = 10;
            this.txtPort.Text = "9100";
            this.txtPort.ValidatingType = typeof(int);
            // 
            // txtIp
            // 
            this.txtIp.Location = new System.Drawing.Point(96, 22);
            this.txtIp.Name = "txtIp";
            this.txtIp.Size = new System.Drawing.Size(119, 23);
            this.txtIp.TabIndex = 9;
            this.txtIp.Text = "127.0.0.1";
            // 
            // chkSaveLabels
            // 
            this.chkSaveLabels.AutoSize = true;
            this.chkSaveLabels.Location = new System.Drawing.Point(96, 83);
            this.chkSaveLabels.Name = "chkSaveLabels";
            this.chkSaveLabels.Size = new System.Drawing.Size(15, 14);
            this.chkSaveLabels.TabIndex = 11;
            this.chkSaveLabels.UseVisualStyleBackColor = true;
            // 
            // btnPath
            // 
            this.btnPath.Location = new System.Drawing.Point(379, 103);
            this.btnPath.Name = "btnPath";
            this.btnPath.Size = new System.Drawing.Size(26, 23);
            this.btnPath.TabIndex = 13;
            this.btnPath.UseVisualStyleBackColor = true;
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(96, 103);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(277, 23);
            this.txtPath.TabIndex = 12;
            // 
            // grdLabelFormats
            // 
            this.grdLabelFormats.AllowUserToAddRows = false;
            this.grdLabelFormats.AllowUserToDeleteRows = false;
            this.grdLabelFormats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdLabelFormats.Location = new System.Drawing.Point(12, 143);
            this.grdLabelFormats.Name = "grdLabelFormats";
            this.grdLabelFormats.ReadOnly = true;
            this.grdLabelFormats.RowTemplate.Height = 25;
            this.grdLabelFormats.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdLabelFormats.Size = new System.Drawing.Size(583, 196);
            this.grdLabelFormats.TabIndex = 14;
            // 
            // frmConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 408);
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
            this.MaximumSize = new System.Drawing.Size(627, 447);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(627, 447);
            this.Name = "frmConfig";
            this.ShowIcon = false;
            this.Text = "Configuration";
            this.Load += new System.EventHandler(this.frmConfig_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdLabelFormats)).EndInit();
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

    }
}