
namespace ZPL_Print_Testing
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPort = new System.Windows.Forms.MaskedTextBox();
            this.txtIp = new System.Windows.Forms.TextBox();
            this.imgLabel = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cboSavedFormats = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtWidth = new System.Windows.Forms.MaskedTextBox();
            this.txtHeight = new System.Windows.Forms.MaskedTextBox();
            this.cboPrintDensity = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.chkSaveLabels = new System.Windows.Forms.CheckBox();
            this.btnPath = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnStartStop = new System.Windows.Forms.Button();
            this.timerTick = new System.Windows.Forms.Timer(this.components);
            this.picRunning = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLabel)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRunning)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ip Address";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(899, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuConfig,
            this.toolStripMenuAbout});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 20);
            this.mnuFile.Text = "File";
            // 
            // toolStripMenuConfig
            // 
            this.toolStripMenuConfig.Name = "toolStripMenuConfig";
            this.toolStripMenuConfig.Size = new System.Drawing.Size(110, 22);
            this.toolStripMenuConfig.Text = "Config";
            // 
            // toolStripMenuAbout
            // 
            this.toolStripMenuAbout.Name = "toolStripMenuAbout";
            this.toolStripMenuAbout.Size = new System.Drawing.Size(110, 22);
            this.toolStripMenuAbout.Text = "About";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Port";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPort);
            this.groupBox1.Controls.Add(this.txtIp);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 97);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Network";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(74, 61);
            this.txtPort.Mask = "0000";
            this.txtPort.Name = "txtPort";
            this.txtPort.PromptChar = ' ';
            this.txtPort.Size = new System.Drawing.Size(70, 23);
            this.txtPort.TabIndex = 1;
            this.txtPort.Text = "9100";
            this.txtPort.ValidatingType = typeof(int);
            // 
            // txtIp
            // 
            this.txtIp.Location = new System.Drawing.Point(74, 32);
            this.txtIp.Name = "txtIp";
            this.txtIp.Size = new System.Drawing.Size(119, 23);
            this.txtIp.TabIndex = 0;
            this.txtIp.Text = "127.0.0.1";
            this.txtIp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIp_KeyPress);
            // 
            // imgLabel
            // 
            this.imgLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imgLabel.BackColor = System.Drawing.Color.White;
            this.imgLabel.Location = new System.Drawing.Point(301, 45);
            this.imgLabel.Name = "imgLabel";
            this.imgLabel.Size = new System.Drawing.Size(586, 768);
            this.imgLabel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgLabel.TabIndex = 4;
            this.imgLabel.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cboSavedFormats);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtWidth);
            this.groupBox2.Controls.Add(this.txtHeight);
            this.groupBox2.Controls.Add(this.cboPrintDensity);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 139);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(283, 156);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Label";
            // 
            // cboSavedFormats
            // 
            this.cboSavedFormats.FormattingEnabled = true;
            this.cboSavedFormats.Location = new System.Drawing.Point(86, 31);
            this.cboSavedFormats.Name = "cboSavedFormats";
            this.cboSavedFormats.Size = new System.Drawing.Size(132, 23);
            this.cboSavedFormats.TabIndex = 2;
            this.cboSavedFormats.SelectedIndexChanged += new System.EventHandler(this.cboSavedFormats_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 15);
            this.label8.TabIndex = 8;
            this.label8.Text = "Saved Format";
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(86, 60);
            this.txtWidth.Mask = "00";
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.PromptChar = ' ';
            this.txtWidth.Size = new System.Drawing.Size(70, 23);
            this.txtWidth.TabIndex = 3;
            this.txtWidth.Text = "4";
            this.txtWidth.ValidatingType = typeof(int);
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(86, 89);
            this.txtHeight.Mask = "00";
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.PromptChar = ' ';
            this.txtHeight.Size = new System.Drawing.Size(70, 23);
            this.txtHeight.TabIndex = 4;
            this.txtHeight.Text = "6";
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
            this.cboPrintDensity.Location = new System.Drawing.Point(86, 120);
            this.cboPrintDensity.Name = "cboPrintDensity";
            this.cboPrintDensity.Size = new System.Drawing.Size(132, 23);
            this.cboPrintDensity.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Print Density";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Height (in)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Width (in)";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.chkSaveLabels);
            this.groupBox3.Controls.Add(this.btnPath);
            this.groupBox3.Controls.Add(this.txtPath);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(12, 301);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(283, 84);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Save";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "Save Labels";
            // 
            // chkSaveLabels
            // 
            this.chkSaveLabels.AutoSize = true;
            this.chkSaveLabels.Location = new System.Drawing.Point(87, 20);
            this.chkSaveLabels.Name = "chkSaveLabels";
            this.chkSaveLabels.Size = new System.Drawing.Size(15, 14);
            this.chkSaveLabels.TabIndex = 6;
            this.chkSaveLabels.UseVisualStyleBackColor = true;
            // 
            // btnPath
            // 
            this.btnPath.Location = new System.Drawing.Point(247, 45);
            this.btnPath.Name = "btnPath";
            this.btnPath.Size = new System.Drawing.Size(26, 23);
            this.btnPath.TabIndex = 8;
            this.btnPath.UseVisualStyleBackColor = true;
            this.btnPath.Click += new System.EventHandler(this.btnPath_Click);
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(86, 45);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(155, 23);
            this.txtPath.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "Path";
            // 
            // btnStartStop
            // 
            this.btnStartStop.Location = new System.Drawing.Point(12, 400);
            this.btnStartStop.Name = "btnStartStop";
            this.btnStartStop.Size = new System.Drawing.Size(283, 30);
            this.btnStartStop.TabIndex = 9;
            this.btnStartStop.Text = "Start";
            this.btnStartStop.UseVisualStyleBackColor = true;
            this.btnStartStop.Click += new System.EventHandler(this.btnStartStop_Click);
            // 
            // timerTick
            // 
            this.timerTick.Interval = 1000;
            this.timerTick.Tick += new System.EventHandler(this.timerTick_Tick);
            // 
            // picRunning
            // 
            this.picRunning.BackColor = System.Drawing.Color.Transparent;
            this.picRunning.Image = global::ZPL_Print_Testing.Properties.Resources.run;
            this.picRunning.Location = new System.Drawing.Point(115, 436);
            this.picRunning.Name = "picRunning";
            this.picRunning.Size = new System.Drawing.Size(69, 64);
            this.picRunning.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRunning.TabIndex = 10;
            this.picRunning.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 825);
            this.Controls.Add(this.picRunning);
            this.Controls.Add(this.btnStartStop);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.imgLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(915, 864);
            this.Name = "frmMain";
            this.ShowIcon = false;
            this.Text = "ZPL Print Tester";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLabel)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRunning)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuAbout;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtIp;
        private System.Windows.Forms.PictureBox imgLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cboPrintDensity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox txtWidth;
        private System.Windows.Forms.MaskedTextBox txtHeight;
        private System.Windows.Forms.MaskedTextBox txtPort;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chkSaveLabels;
        private System.Windows.Forms.Button btnPath;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnStartStop;
        private System.Windows.Forms.Timer timerTick;
        private System.Windows.Forms.ComboBox cboSavedFormats;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox picRunning;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuConfig;
    }
}

