
namespace ZPL_Print_Testing.Forms
{
    partial class frmLabelFormats
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
            this.label5 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtWidth = new System.Windows.Forms.MaskedTextBox();
            this.txtHeight = new System.Windows.Forms.MaskedTextBox();
            this.cboPrintDensity = new System.Windows.Forms.ComboBox();
            this.chkDefault = new System.Windows.Forms.CheckBox();
            this.btnSaveExit = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Default";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Print Density";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Height";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Width";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(92, 24);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(137, 23);
            this.txtName.TabIndex = 0;
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(92, 53);
            this.txtWidth.Mask = "00";
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.PromptChar = ' ';
            this.txtWidth.Size = new System.Drawing.Size(70, 23);
            this.txtWidth.TabIndex = 1;
            this.txtWidth.ValidatingType = typeof(int);
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(92, 82);
            this.txtHeight.Mask = "00";
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.PromptChar = ' ';
            this.txtHeight.Size = new System.Drawing.Size(70, 23);
            this.txtHeight.TabIndex = 2;
            this.txtHeight.ValidatingType = typeof(int);
            // 
            // cboPrintDensity
            // 
            this.cboPrintDensity.FormattingEnabled = true;
            this.cboPrintDensity.Items.AddRange(new object[] {
            "6dpmm",
            "8dpmm",
            "12dpmm",
            "24dpmm"});
            this.cboPrintDensity.Location = new System.Drawing.Point(92, 112);
            this.cboPrintDensity.Name = "cboPrintDensity";
            this.cboPrintDensity.Size = new System.Drawing.Size(132, 23);
            this.cboPrintDensity.TabIndex = 3;
            // 
            // chkDefault
            // 
            this.chkDefault.AutoSize = true;
            this.chkDefault.Location = new System.Drawing.Point(92, 141);
            this.chkDefault.Name = "chkDefault";
            this.chkDefault.Size = new System.Drawing.Size(15, 14);
            this.chkDefault.TabIndex = 4;
            this.chkDefault.UseVisualStyleBackColor = true;
            // 
            // btnSaveExit
            // 
            this.btnSaveExit.Location = new System.Drawing.Point(146, 205);
            this.btnSaveExit.Name = "btnSaveExit";
            this.btnSaveExit.Size = new System.Drawing.Size(70, 24);
            this.btnSaveExit.TabIndex = 5;
            this.btnSaveExit.Text = "Save/Exit";
            this.btnSaveExit.UseVisualStyleBackColor = true;
            this.btnSaveExit.Click += new System.EventHandler(this.btnSaveExit_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(222, 205);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(70, 24);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmLabelFormats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(305, 240);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSaveExit);
            this.Controls.Add(this.chkDefault);
            this.Controls.Add(this.txtWidth);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.cboPrintDensity);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(321, 279);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(321, 279);
            this.Name = "frmLabelFormats";
            this.ShowIcon = false;
            this.Text = "Label Format";
            this.Load += new System.EventHandler(this.frmLabelFormats_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.MaskedTextBox txtWidth;
        private System.Windows.Forms.MaskedTextBox txtHeight;
        private System.Windows.Forms.ComboBox cboPrintDensity;
        private System.Windows.Forms.CheckBox chkDefault;
        private System.Windows.Forms.Button btnSaveExit;
        private System.Windows.Forms.Button btnExit;
    }
}