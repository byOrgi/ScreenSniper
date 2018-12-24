namespace screen_sniper_version_1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.icon = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnclose = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnmicon = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnmicoff = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnfilebrowse = new Bunifu.Framework.UI.BunifuFlatButton();
            this.buttonencode = new Bunifu.Framework.UI.BunifuFlatButton();
            this.buttondelete = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuProgressBar1 = new Bunifu.UI.Winforms.BunifuProgressBar();
            this.lblvalue = new System.Windows.Forms.Label();
            this.lblstage = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnsettings = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnrecord = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnstop = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnmenu = new Bunifu.Framework.UI.BunifuImageButton();
            this.saveurl = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.txtstart = new System.Windows.Forms.Label();
            this.buttonpause = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnresume = new Bunifu.Framework.UI.BunifuImageButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsrename = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnclose)).BeginInit();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnmicon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnmicoff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnsettings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnrecord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnstop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnmenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonpause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnresume)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
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
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(439, 33);
            this.panel1.TabIndex = 8;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Violet;
            this.label1.Location = new System.Drawing.Point(36, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "ScreenSnipr";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            // 
            // icon
            // 
            this.icon.BackColor = System.Drawing.Color.Transparent;
            this.icon.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.icon.Image = global::screen_sniper_version_1.Properties.Resources.Blocks_1s_25px;
            this.icon.ImageActive = null;
            this.icon.Location = new System.Drawing.Point(6, 2);
            this.icon.Margin = new System.Windows.Forms.Padding(4);
            this.icon.Name = "icon";
            this.icon.Size = new System.Drawing.Size(25, 25);
            this.icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
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
            this.btnclose.Location = new System.Drawing.Point(399, 4);
            this.btnclose.Margin = new System.Windows.Forms.Padding(4);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(35, 27);
            this.btnclose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnclose.TabIndex = 9;
            this.btnclose.TabStop = false;
            this.btnclose.Zoom = 10;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.btnmicon);
            this.bunifuGradientPanel1.Controls.Add(this.btnmicoff);
            this.bunifuGradientPanel1.Controls.Add(this.btnfilebrowse);
            this.bunifuGradientPanel1.Controls.Add(this.buttonencode);
            this.bunifuGradientPanel1.Controls.Add(this.buttondelete);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuProgressBar1);
            this.bunifuGradientPanel1.Controls.Add(this.lblvalue);
            this.bunifuGradientPanel1.Controls.Add(this.lblstage);
            this.bunifuGradientPanel1.Controls.Add(this.label3);
            this.bunifuGradientPanel1.Controls.Add(this.label2);
            this.bunifuGradientPanel1.Controls.Add(this.btnsettings);
            this.bunifuGradientPanel1.Controls.Add(this.btnrecord);
            this.bunifuGradientPanel1.Controls.Add(this.btnstop);
            this.bunifuGradientPanel1.Controls.Add(this.btnmenu);
            this.bunifuGradientPanel1.Controls.Add(this.saveurl);
            this.bunifuGradientPanel1.Controls.Add(this.listView1);
            this.bunifuGradientPanel1.Controls.Add(this.txtstart);
            this.bunifuGradientPanel1.Controls.Add(this.buttonpause);
            this.bunifuGradientPanel1.Controls.Add(this.btnresume);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Teal;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.Black;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.Black;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 33);
            this.bunifuGradientPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(439, 601);
            this.bunifuGradientPanel1.TabIndex = 0;
            // 
            // btnmicon
            // 
            this.btnmicon.BackColor = System.Drawing.Color.Transparent;
            this.btnmicon.Image = global::screen_sniper_version_1.Properties.Resources.iconfinder_Audio_1891017;
            this.btnmicon.ImageActive = null;
            this.btnmicon.Location = new System.Drawing.Point(224, 7);
            this.btnmicon.Name = "btnmicon";
            this.btnmicon.Size = new System.Drawing.Size(32, 32);
            this.btnmicon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnmicon.TabIndex = 26;
            this.btnmicon.TabStop = false;
            this.btnmicon.Zoom = 10;
            this.btnmicon.Click += new System.EventHandler(this.btnmicon_Click);
            // 
            // btnmicoff
            // 
            this.btnmicoff.BackColor = System.Drawing.Color.Transparent;
            this.btnmicoff.Image = global::screen_sniper_version_1.Properties.Resources.iconfinder_Mic_music_record_live_multimedia_off_1887015;
            this.btnmicoff.ImageActive = null;
            this.btnmicoff.Location = new System.Drawing.Point(224, 7);
            this.btnmicoff.Name = "btnmicoff";
            this.btnmicoff.Size = new System.Drawing.Size(32, 32);
            this.btnmicoff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnmicoff.TabIndex = 25;
            this.btnmicoff.TabStop = false;
            this.btnmicoff.Zoom = 10;
            this.btnmicoff.Click += new System.EventHandler(this.btnmicoff_Click);
            // 
            // btnfilebrowse
            // 
            this.btnfilebrowse.Active = false;
            this.btnfilebrowse.Activecolor = System.Drawing.Color.Purple;
            this.btnfilebrowse.BackColor = System.Drawing.Color.Teal;
            this.btnfilebrowse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnfilebrowse.BorderRadius = 0;
            this.btnfilebrowse.ButtonText = "...";
            this.btnfilebrowse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnfilebrowse.DisabledColor = System.Drawing.Color.Gray;
            this.btnfilebrowse.Iconcolor = System.Drawing.Color.Transparent;
            this.btnfilebrowse.Iconimage = null;
            this.btnfilebrowse.Iconimage_right = null;
            this.btnfilebrowse.Iconimage_right_Selected = null;
            this.btnfilebrowse.Iconimage_Selected = null;
            this.btnfilebrowse.IconMarginLeft = 0;
            this.btnfilebrowse.IconMarginRight = 0;
            this.btnfilebrowse.IconRightVisible = true;
            this.btnfilebrowse.IconRightZoom = 0D;
            this.btnfilebrowse.IconVisible = true;
            this.btnfilebrowse.IconZoom = 90D;
            this.btnfilebrowse.IsTab = false;
            this.btnfilebrowse.Location = new System.Drawing.Point(397, 54);
            this.btnfilebrowse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnfilebrowse.Name = "btnfilebrowse";
            this.btnfilebrowse.Normalcolor = System.Drawing.Color.Teal;
            this.btnfilebrowse.OnHovercolor = System.Drawing.Color.Purple;
            this.btnfilebrowse.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnfilebrowse.selected = false;
            this.btnfilebrowse.Size = new System.Drawing.Size(24, 22);
            this.btnfilebrowse.TabIndex = 23;
            this.btnfilebrowse.Text = "...";
            this.btnfilebrowse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnfilebrowse.Textcolor = System.Drawing.Color.Black;
            this.btnfilebrowse.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfilebrowse.Click += new System.EventHandler(this.btnfilebrowse_Click);
            // 
            // buttonencode
            // 
            this.buttonencode.Active = false;
            this.buttonencode.Activecolor = System.Drawing.Color.Teal;
            this.buttonencode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.buttonencode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonencode.BorderRadius = 0;
            this.buttonencode.ButtonText = "Encode";
            this.buttonencode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonencode.DisabledColor = System.Drawing.Color.Gray;
            this.buttonencode.Iconcolor = System.Drawing.Color.Transparent;
            this.buttonencode.Iconimage = null;
            this.buttonencode.Iconimage_right = null;
            this.buttonencode.Iconimage_right_Selected = null;
            this.buttonencode.Iconimage_Selected = null;
            this.buttonencode.IconMarginLeft = 0;
            this.buttonencode.IconMarginRight = 0;
            this.buttonencode.IconRightVisible = true;
            this.buttonencode.IconRightZoom = 0D;
            this.buttonencode.IconVisible = true;
            this.buttonencode.IconZoom = 90D;
            this.buttonencode.IsTab = false;
            this.buttonencode.Location = new System.Drawing.Point(320, 542);
            this.buttonencode.Margin = new System.Windows.Forms.Padding(5);
            this.buttonencode.Name = "buttonencode";
            this.buttonencode.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.buttonencode.OnHovercolor = System.Drawing.Color.Thistle;
            this.buttonencode.OnHoverTextColor = System.Drawing.Color.Black;
            this.buttonencode.selected = false;
            this.buttonencode.Size = new System.Drawing.Size(101, 28);
            this.buttonencode.TabIndex = 22;
            this.buttonencode.Text = "Encode";
            this.buttonencode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonencode.Textcolor = System.Drawing.Color.Black;
            this.buttonencode.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonencode.Click += new System.EventHandler(this.buttonencode_Click);
            // 
            // buttondelete
            // 
            this.buttondelete.Active = false;
            this.buttondelete.Activecolor = System.Drawing.Color.Teal;
            this.buttondelete.BackColor = System.Drawing.Color.IndianRed;
            this.buttondelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttondelete.BorderRadius = 0;
            this.buttondelete.ButtonText = "Delete";
            this.buttondelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttondelete.DisabledColor = System.Drawing.Color.Gray;
            this.buttondelete.ForeColor = System.Drawing.Color.Thistle;
            this.buttondelete.Iconcolor = System.Drawing.Color.Transparent;
            this.buttondelete.Iconimage = null;
            this.buttondelete.Iconimage_right = null;
            this.buttondelete.Iconimage_right_Selected = null;
            this.buttondelete.Iconimage_Selected = null;
            this.buttondelete.IconMarginLeft = 0;
            this.buttondelete.IconMarginRight = 0;
            this.buttondelete.IconRightVisible = true;
            this.buttondelete.IconRightZoom = 0D;
            this.buttondelete.IconVisible = true;
            this.buttondelete.IconZoom = 90D;
            this.buttondelete.IsTab = false;
            this.buttondelete.Location = new System.Drawing.Point(211, 542);
            this.buttondelete.Margin = new System.Windows.Forms.Padding(5);
            this.buttondelete.Name = "buttondelete";
            this.buttondelete.Normalcolor = System.Drawing.Color.IndianRed;
            this.buttondelete.OnHovercolor = System.Drawing.Color.Thistle;
            this.buttondelete.OnHoverTextColor = System.Drawing.Color.Black;
            this.buttondelete.selected = false;
            this.buttondelete.Size = new System.Drawing.Size(101, 28);
            this.buttondelete.TabIndex = 21;
            this.buttondelete.Text = "Delete";
            this.buttondelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttondelete.Textcolor = System.Drawing.Color.Black;
            this.buttondelete.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttondelete.Click += new System.EventHandler(this.buttondelete_Click);
            // 
            // bunifuProgressBar1
            // 
            this.bunifuProgressBar1.Animation = 0;
            this.bunifuProgressBar1.AnimationStep = 10;
            this.bunifuProgressBar1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuProgressBar1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuProgressBar1.BackgroundImage")));
            this.bunifuProgressBar1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bunifuProgressBar1.BorderRadius = 5;
            this.bunifuProgressBar1.BorderThickness = 2;
            this.bunifuProgressBar1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.bunifuProgressBar1.Location = new System.Drawing.Point(12, 577);
            this.bunifuProgressBar1.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuProgressBar1.MaximumValue = 100;
            this.bunifuProgressBar1.MinimumValue = 0;
            this.bunifuProgressBar1.Name = "bunifuProgressBar1";
            this.bunifuProgressBar1.ProgressBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bunifuProgressBar1.ProgressColorLeft = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bunifuProgressBar1.ProgressColorRight = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bunifuProgressBar1.Size = new System.Drawing.Size(415, 12);
            this.bunifuProgressBar1.TabIndex = 20;
            this.bunifuProgressBar1.Value = 0;
            // 
            // lblvalue
            // 
            this.lblvalue.AutoSize = true;
            this.lblvalue.BackColor = System.Drawing.Color.Transparent;
            this.lblvalue.ForeColor = System.Drawing.Color.Thistle;
            this.lblvalue.Location = new System.Drawing.Point(71, 559);
            this.lblvalue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblvalue.Name = "lblvalue";
            this.lblvalue.Size = new System.Drawing.Size(16, 17);
            this.lblvalue.TabIndex = 18;
            this.lblvalue.Text = "0";
            // 
            // lblstage
            // 
            this.lblstage.AutoSize = true;
            this.lblstage.BackColor = System.Drawing.Color.Transparent;
            this.lblstage.ForeColor = System.Drawing.Color.Thistle;
            this.lblstage.Location = new System.Drawing.Point(71, 534);
            this.lblstage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblstage.Name = "lblstage";
            this.lblstage.Size = new System.Drawing.Size(44, 17);
            this.lblstage.TabIndex = 17;
            this.lblstage.Text = "1 of 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Thistle;
            this.label3.Location = new System.Drawing.Point(16, 559);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Value";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Thistle;
            this.label2.Location = new System.Drawing.Point(16, 534);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Stage";
            // 
            // btnsettings
            // 
            this.btnsettings.BackColor = System.Drawing.Color.Transparent;
            this.btnsettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsettings.Image = global::screen_sniper_version_1.Properties.Resources.iconfinder_setting_icon_2541669;
            this.btnsettings.ImageActive = null;
            this.btnsettings.Location = new System.Drawing.Point(281, 7);
            this.btnsettings.Margin = new System.Windows.Forms.Padding(4);
            this.btnsettings.Name = "btnsettings";
            this.btnsettings.Size = new System.Drawing.Size(32, 32);
            this.btnsettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnsettings.TabIndex = 14;
            this.btnsettings.TabStop = false;
            this.btnsettings.Zoom = 10;
            this.btnsettings.Click += new System.EventHandler(this.btnsettings_Click);
            // 
            // btnrecord
            // 
            this.btnrecord.BackColor = System.Drawing.Color.Transparent;
            this.btnrecord.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnrecord.Image = global::screen_sniper_version_1.Properties.Resources.iconfinder_Record_Button_38829;
            this.btnrecord.ImageActive = null;
            this.btnrecord.Location = new System.Drawing.Point(389, 7);
            this.btnrecord.Margin = new System.Windows.Forms.Padding(4);
            this.btnrecord.Name = "btnrecord";
            this.btnrecord.Size = new System.Drawing.Size(32, 32);
            this.btnrecord.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnrecord.TabIndex = 13;
            this.btnrecord.TabStop = false;
            this.btnrecord.Zoom = 10;
            this.btnrecord.Click += new System.EventHandler(this.btnrecord_Click_1);
            // 
            // btnstop
            // 
            this.btnstop.BackColor = System.Drawing.Color.Transparent;
            this.btnstop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnstop.Image = global::screen_sniper_version_1.Properties.Resources.iconfinder_Stop1NormalRed_22947;
            this.btnstop.ImageActive = null;
            this.btnstop.Location = new System.Drawing.Point(389, 7);
            this.btnstop.Margin = new System.Windows.Forms.Padding(4);
            this.btnstop.Name = "btnstop";
            this.btnstop.Size = new System.Drawing.Size(32, 32);
            this.btnstop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnstop.TabIndex = 12;
            this.btnstop.TabStop = false;
            this.btnstop.Zoom = 10;
            this.btnstop.Click += new System.EventHandler(this.btnstop_Click_1);
            // 
            // btnmenu
            // 
            this.btnmenu.BackColor = System.Drawing.Color.Transparent;
            this.btnmenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnmenu.Image = global::screen_sniper_version_1.Properties.Resources.iconfinder_Blocks_381637;
            this.btnmenu.ImageActive = null;
            this.btnmenu.Location = new System.Drawing.Point(165, 6);
            this.btnmenu.Margin = new System.Windows.Forms.Padding(4);
            this.btnmenu.Name = "btnmenu";
            this.btnmenu.Size = new System.Drawing.Size(32, 32);
            this.btnmenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnmenu.TabIndex = 9;
            this.btnmenu.TabStop = false;
            this.btnmenu.Zoom = 10;
            this.btnmenu.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // saveurl
            // 
            this.saveurl.Location = new System.Drawing.Point(15, 54);
            this.saveurl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.saveurl.Name = "saveurl";
            this.saveurl.Size = new System.Drawing.Size(375, 22);
            this.saveurl.TabIndex = 6;
            this.saveurl.TextChanged += new System.EventHandler(this.saveurl_TextChanged);
            // 
            // listView1
            // 
            this.listView1.AllowColumnReorder = true;
            this.listView1.LabelEdit = true;
            this.listView1.Location = new System.Drawing.Point(15, 82);
            this.listView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(408, 447);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            this.listView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseClick);
            // 
            // txtstart
            // 
            this.txtstart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtstart.AutoSize = true;
            this.txtstart.BackColor = System.Drawing.Color.Transparent;
            this.txtstart.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstart.ForeColor = System.Drawing.Color.Thistle;
            this.txtstart.Location = new System.Drawing.Point(23, 13);
            this.txtstart.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtstart.Name = "txtstart";
            this.txtstart.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtstart.Size = new System.Drawing.Size(120, 25);
            this.txtstart.TabIndex = 4;
            this.txtstart.Text = "Press Record";
            this.txtstart.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // buttonpause
            // 
            this.buttonpause.BackColor = System.Drawing.Color.Transparent;
            this.buttonpause.Image = global::screen_sniper_version_1.Properties.Resources.iconfinder_Pause_3213445;
            this.buttonpause.ImageActive = null;
            this.buttonpause.Location = new System.Drawing.Point(336, 7);
            this.buttonpause.Name = "buttonpause";
            this.buttonpause.Size = new System.Drawing.Size(32, 32);
            this.buttonpause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.buttonpause.TabIndex = 24;
            this.buttonpause.TabStop = false;
            this.buttonpause.Zoom = 10;
            this.buttonpause.Click += new System.EventHandler(this.buttonpause_Click);
            // 
            // btnresume
            // 
            this.btnresume.BackColor = System.Drawing.Color.Transparent;
            this.btnresume.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnresume.Image = global::screen_sniper_version_1.Properties.Resources.iconfinder_Movie_play_video_you_tube_youtube_271505;
            this.btnresume.ImageActive = null;
            this.btnresume.Location = new System.Drawing.Point(336, 7);
            this.btnresume.Margin = new System.Windows.Forms.Padding(4);
            this.btnresume.Name = "btnresume";
            this.btnresume.Size = new System.Drawing.Size(32, 32);
            this.btnresume.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnresume.TabIndex = 11;
            this.btnresume.TabStop = false;
            this.btnresume.Zoom = 10;
            this.btnresume.Click += new System.EventHandler(this.btnresume_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsrename});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(133, 28);
            
            // 
            // tsrename
            // 
            this.tsrename.Name = "tsrename";
            this.tsrename.Size = new System.Drawing.Size(132, 24);
            this.tsrename.Text = "Rename";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 628);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Screen Sniper";
            
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnclose)).EndInit();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnmicon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnmicoff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnsettings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnrecord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnstop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnmenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonpause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnresume)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.Label txtstart;
        private System.Windows.Forms.TextBox saveurl;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton btnclose;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuImageButton icon;
        private Bunifu.Framework.UI.BunifuImageButton btnmenu;
        private Bunifu.Framework.UI.BunifuImageButton btnrecord;
        private Bunifu.Framework.UI.BunifuImageButton btnstop;
        private Bunifu.Framework.UI.BunifuImageButton btnresume;
        private Bunifu.Framework.UI.BunifuImageButton btnsettings;
        private System.Windows.Forms.Label lblvalue;
        private System.Windows.Forms.Label lblstage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Bunifu.UI.Winforms.BunifuProgressBar bunifuProgressBar1;
        private Bunifu.Framework.UI.BunifuFlatButton buttondelete;
        private Bunifu.Framework.UI.BunifuFlatButton buttonencode;
        private Bunifu.Framework.UI.BunifuFlatButton btnfilebrowse;
        private Bunifu.Framework.UI.BunifuImageButton buttonpause;
        private Bunifu.Framework.UI.BunifuImageButton btnmicon;
        private Bunifu.Framework.UI.BunifuImageButton btnmicoff;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsrename;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
    }
}

