namespace screen_sniper_version_1
{
    partial class settingsform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(settingsform));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.pnlScreen = new System.Windows.Forms.Panel();
            this.chkFollowMC = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.chkShowFashing = new System.Windows.Forms.CheckBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cboCaptureRect = new System.Windows.Forms.ComboBox();
            this.chkShowCountdown = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cboCaptureMC = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtQuality = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cboFrameRate = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.icon = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnclose = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel1.SuspendLayout();
            this.bunifuGradientPanel1.SuspendLayout();
            this.pnlScreen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnclose)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.icon);
            this.panel1.Controls.Add(this.btnclose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(832, 33);
            this.panel1.TabIndex = 9;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Violet;
            this.label1.Location = new System.Drawing.Point(39, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "ScreenSnipr (Settings)";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.pnlScreen);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Teal;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.Black;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.Black;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 33);
            this.bunifuGradientPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(832, 479);
            this.bunifuGradientPanel1.TabIndex = 10;
            // 
            // pnlScreen
            // 
            this.pnlScreen.BackColor = System.Drawing.Color.Purple;
            this.pnlScreen.Controls.Add(this.chkFollowMC);
            this.pnlScreen.Controls.Add(this.label8);
            this.pnlScreen.Controls.Add(this.btnReset);
            this.pnlScreen.Controls.Add(this.btnSave);
            this.pnlScreen.Controls.Add(this.chkShowFashing);
            this.pnlScreen.Controls.Add(this.btnCancel);
            this.pnlScreen.Controls.Add(this.cboCaptureRect);
            this.pnlScreen.Controls.Add(this.chkShowCountdown);
            this.pnlScreen.Controls.Add(this.label9);
            this.pnlScreen.Controls.Add(this.cboCaptureMC);
            this.pnlScreen.Controls.Add(this.label7);
            this.pnlScreen.Controls.Add(this.txtQuality);
            this.pnlScreen.Controls.Add(this.label2);
            this.pnlScreen.Controls.Add(this.label6);
            this.pnlScreen.Controls.Add(this.cboFrameRate);
            this.pnlScreen.Controls.Add(this.label3);
            this.pnlScreen.Location = new System.Drawing.Point(79, 25);
            this.pnlScreen.Margin = new System.Windows.Forms.Padding(5);
            this.pnlScreen.Name = "pnlScreen";
            this.pnlScreen.Size = new System.Drawing.Size(665, 412);
            this.pnlScreen.TabIndex = 1;
            // 
            // chkFollowMC
            // 
            this.chkFollowMC.AutoSize = true;
            this.chkFollowMC.ForeColor = System.Drawing.Color.White;
            this.chkFollowMC.Location = new System.Drawing.Point(469, 288);
            this.chkFollowMC.Margin = new System.Windows.Forms.Padding(5);
            this.chkFollowMC.Name = "chkFollowMC";
            this.chkFollowMC.Size = new System.Drawing.Size(18, 17);
            this.chkFollowMC.TabIndex = 18;
            this.chkFollowMC.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Thistle;
            this.label8.Location = new System.Drawing.Point(324, 288);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "Follow mouse cursor";
            // 
            // btnReset
            // 
            this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnReset.BackColor = System.Drawing.Color.Gray;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.ForeColor = System.Drawing.Color.LightGray;
            this.btnReset.Location = new System.Drawing.Point(11, 375);
            this.btnReset.Margin = new System.Windows.Forms.Padding(5);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(97, 32);
            this.btnReset.TabIndex = 16;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.Gray;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.LightGray;
            this.btnSave.Location = new System.Drawing.Point(455, 375);
            this.btnSave.Margin = new System.Windows.Forms.Padding(5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(97, 32);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // chkShowFashing
            // 
            this.chkShowFashing.AutoSize = true;
            this.chkShowFashing.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkShowFashing.ForeColor = System.Drawing.Color.Thistle;
            this.chkShowFashing.Location = new System.Drawing.Point(303, 315);
            this.chkShowFashing.Margin = new System.Windows.Forms.Padding(5);
            this.chkShowFashing.Name = "chkShowFashing";
            this.chkShowFashing.Size = new System.Drawing.Size(181, 21);
            this.chkShowFashing.TabIndex = 13;
            this.chkShowFashing.Text = "Show flashing boundary";
            this.chkShowFashing.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.Gray;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.LightGray;
            this.btnCancel.Location = new System.Drawing.Point(563, 375);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(97, 32);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // cboCaptureRect
            // 
            this.cboCaptureRect.BackColor = System.Drawing.Color.Thistle;
            this.cboCaptureRect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCaptureRect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboCaptureRect.Font = new System.Drawing.Font("Tahoma", 8F);
            this.cboCaptureRect.ForeColor = System.Drawing.Color.Black;
            this.cboCaptureRect.FormattingEnabled = true;
            this.cboCaptureRect.Items.AddRange(new object[] {
            "Full Screen",
            "Working Area"});
            this.cboCaptureRect.Location = new System.Drawing.Point(339, 210);
            this.cboCaptureRect.Margin = new System.Windows.Forms.Padding(5);
            this.cboCaptureRect.Name = "cboCaptureRect";
            this.cboCaptureRect.Size = new System.Drawing.Size(148, 24);
            this.cboCaptureRect.TabIndex = 11;
            // 
            // chkShowCountdown
            // 
            this.chkShowCountdown.AutoSize = true;
            this.chkShowCountdown.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkShowCountdown.ForeColor = System.Drawing.Color.Thistle;
            this.chkShowCountdown.Location = new System.Drawing.Point(236, 257);
            this.chkShowCountdown.Margin = new System.Windows.Forms.Padding(5);
            this.chkShowCountdown.Name = "chkShowCountdown";
            this.chkShowCountdown.Size = new System.Drawing.Size(245, 21);
            this.chkShowCountdown.TabIndex = 12;
            this.chkShowCountdown.Text = "Show countdown before recording";
            this.chkShowCountdown.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Thistle;
            this.label9.Location = new System.Drawing.Point(139, 215);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(188, 17);
            this.label9.TabIndex = 10;
            this.label9.Text = "Capture Rectangle:";
            // 
            // cboCaptureMC
            // 
            this.cboCaptureMC.BackColor = System.Drawing.Color.Thistle;
            this.cboCaptureMC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCaptureMC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboCaptureMC.Font = new System.Drawing.Font("Tahoma", 8F);
            this.cboCaptureMC.ForeColor = System.Drawing.Color.Black;
            this.cboCaptureMC.FormattingEnabled = true;
            this.cboCaptureMC.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cboCaptureMC.Location = new System.Drawing.Point(339, 148);
            this.cboCaptureMC.Margin = new System.Windows.Forms.Padding(5);
            this.cboCaptureMC.Name = "cboCaptureMC";
            this.cboCaptureMC.Size = new System.Drawing.Size(148, 24);
            this.cboCaptureMC.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Thistle;
            this.label7.Location = new System.Drawing.Point(107, 153);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(218, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Capture mouse cursor:";
            // 
            // txtQuality
            // 
            this.txtQuality.BackColor = System.Drawing.Color.Thistle;
            this.txtQuality.ForeColor = System.Drawing.Color.Black;
            this.txtQuality.Location = new System.Drawing.Point(339, 86);
            this.txtQuality.Margin = new System.Windows.Forms.Padding(5);
            this.txtQuality.Name = "txtQuality";
            this.txtQuality.Size = new System.Drawing.Size(148, 22);
            this.txtQuality.TabIndex = 5;
            this.txtQuality.Text = "95";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Thistle;
            this.label2.Location = new System.Drawing.Point(160, 90);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Quality (1-100):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(491, 30);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "FPS";
            // 
            // cboFrameRate
            // 
            this.cboFrameRate.BackColor = System.Drawing.Color.Thistle;
            this.cboFrameRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFrameRate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboFrameRate.Font = new System.Drawing.Font("Tahoma", 8F);
            this.cboFrameRate.ForeColor = System.Drawing.Color.Black;
            this.cboFrameRate.FormattingEnabled = true;
            this.cboFrameRate.Items.AddRange(new object[] {
            "5",
            "10",
            "15",
            "20",
            "25",
            "30",
            "60"});
            this.cboFrameRate.Location = new System.Drawing.Point(339, 23);
            this.cboFrameRate.Margin = new System.Windows.Forms.Padding(5);
            this.cboFrameRate.Name = "cboFrameRate";
            this.cboFrameRate.Size = new System.Drawing.Size(148, 24);
            this.cboFrameRate.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Thistle;
            this.label3.Location = new System.Drawing.Point(213, 28);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Frame Rate:";
            // 
            // icon
            // 
            this.icon.BackColor = System.Drawing.Color.Transparent;
            this.icon.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.icon.Image = ((System.Drawing.Image)(resources.GetObject("icon.Image")));
            this.icon.ImageActive = null;
            this.icon.Location = new System.Drawing.Point(4, 2);
            this.icon.Margin = new System.Windows.Forms.Padding(4);
            this.icon.Name = "icon";
            this.icon.Size = new System.Drawing.Size(35, 27);
            this.icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.icon.TabIndex = 9;
            this.icon.TabStop = false;
            this.icon.Zoom = 10;
            this.icon.MouseDown += new System.Windows.Forms.MouseEventHandler(this.icon_MouseDown);
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.Color.Transparent;
            this.btnclose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnclose.Image = ((System.Drawing.Image)(resources.GetObject("btnclose.Image")));
            this.btnclose.ImageActive = null;
            this.btnclose.Location = new System.Drawing.Point(793, 2);
            this.btnclose.Margin = new System.Windows.Forms.Padding(4);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(35, 27);
            this.btnclose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnclose.TabIndex = 9;
            this.btnclose.TabStop = false;
            this.btnclose.Zoom = 10;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // settingsform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 498);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "settingsform";
            this.Text = "settingsform";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.pnlScreen.ResumeLayout(false);
            this.pnlScreen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnclose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuImageButton icon;
        private Bunifu.Framework.UI.BunifuImageButton btnclose;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.Panel pnlScreen;
        private System.Windows.Forms.CheckBox chkShowFashing;
        private System.Windows.Forms.ComboBox cboCaptureRect;
        private System.Windows.Forms.CheckBox chkShowCountdown;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboCaptureMC;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtQuality;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboFrameRate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox chkFollowMC;
        private System.Windows.Forms.Label label8;
    }
}