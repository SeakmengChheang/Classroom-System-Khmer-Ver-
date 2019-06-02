namespace Classroom_Project__Win_Form_
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTotalAbsence = new System.Windows.Forms.Button();
            this.btnAbsence = new System.Windows.Forms.Button();
            this.btnGrade = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.panelShow = new System.Windows.Forms.Panel();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.picAppBrand = new System.Windows.Forms.PictureBox();
            this.picMinimize = new System.Windows.Forms.PictureBox();
            this.picExit = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearAllStudentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkForUpdateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.usageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutAppToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teacherInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.payGoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aBAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.payPalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shareMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.timerFadeIn = new System.Windows.Forms.Timer(this.components);
            this.folderBackup = new System.Windows.Forms.FolderBrowserDialog();
            this.bunifuElipse4 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse5 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse6 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse7 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse8 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse9 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.sendDataBackground = new System.ComponentModel.BackgroundWorker();
            this.home = new Classroom_Project__Win_Form_.User_Controls.Home();
            this.view = new Classroom_Project__Win_Form_.User_Controls.View();
            this.totalAbsence = new Classroom_Project__Win_Form_.User_Controls.TotalAbsence();
            this.absence = new Classroom_Project__Win_Form_.User_Controls.Absence();
            this.score = new Classroom_Project__Win_Form_.User_Controls.Score();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelShow.SuspendLayout();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAppBrand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.6914F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.3086F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panelShow, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.bunifuGradientPanel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.menuStrip1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Khmer OS Battambang", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.898084F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.960438F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.14147F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1634, 882);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.btnTotalAbsence);
            this.panel1.Controls.Add(this.btnAbsence);
            this.panel1.Controls.Add(this.btnGrade);
            this.panel1.Controls.Add(this.btnView);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Khmer OS Battambang", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(3, 97);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(315, 769);
            this.panel1.TabIndex = 0;
            // 
            // btnTotalAbsence
            // 
            this.btnTotalAbsence.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTotalAbsence.AutoEllipsis = true;
            this.btnTotalAbsence.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnTotalAbsence.BackColor = System.Drawing.Color.LightGray;
            this.btnTotalAbsence.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTotalAbsence.FlatAppearance.BorderSize = 0;
            this.btnTotalAbsence.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btnTotalAbsence.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTotalAbsence.Font = new System.Drawing.Font("Khmer OS Muol Pali", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTotalAbsence.ForeColor = System.Drawing.Color.Black;
            this.btnTotalAbsence.Image = ((System.Drawing.Image)(resources.GetObject("btnTotalAbsence.Image")));
            this.btnTotalAbsence.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTotalAbsence.Location = new System.Drawing.Point(1, 396);
            this.btnTotalAbsence.Margin = new System.Windows.Forms.Padding(0, 20, 0, 20);
            this.btnTotalAbsence.Name = "btnTotalAbsence";
            this.btnTotalAbsence.Size = new System.Drawing.Size(315, 90);
            this.btnTotalAbsence.TabIndex = 6;
            this.btnTotalAbsence.Text = "អវត្តមានសរុប";
            this.btnTotalAbsence.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTotalAbsence.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.btnTotalAbsence, "Ctrl+5");
            this.btnTotalAbsence.UseVisualStyleBackColor = false;
            this.btnTotalAbsence.Click += new System.EventHandler(this.btnTotalAbsence_Click);
            // 
            // btnAbsence
            // 
            this.btnAbsence.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAbsence.AutoEllipsis = true;
            this.btnAbsence.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAbsence.BackColor = System.Drawing.Color.White;
            this.btnAbsence.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAbsence.FlatAppearance.BorderSize = 0;
            this.btnAbsence.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btnAbsence.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbsence.Font = new System.Drawing.Font("Khmer OS Muol Pali", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbsence.ForeColor = System.Drawing.Color.Black;
            this.btnAbsence.Image = ((System.Drawing.Image)(resources.GetObject("btnAbsence.Image")));
            this.btnAbsence.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbsence.Location = new System.Drawing.Point(1, 297);
            this.btnAbsence.Margin = new System.Windows.Forms.Padding(0, 20, 0, 20);
            this.btnAbsence.Name = "btnAbsence";
            this.btnAbsence.Size = new System.Drawing.Size(315, 90);
            this.btnAbsence.TabIndex = 4;
            this.btnAbsence.Text = "តារាងអវត្តមាន";
            this.btnAbsence.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbsence.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.btnAbsence, "Ctrl+4");
            this.btnAbsence.UseVisualStyleBackColor = false;
            this.btnAbsence.Click += new System.EventHandler(this.btnAbsence_Click);
            // 
            // btnGrade
            // 
            this.btnGrade.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGrade.AutoEllipsis = true;
            this.btnGrade.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGrade.BackColor = System.Drawing.Color.LightGray;
            this.btnGrade.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGrade.FlatAppearance.BorderSize = 0;
            this.btnGrade.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btnGrade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGrade.Font = new System.Drawing.Font("Khmer OS Muol Pali", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrade.ForeColor = System.Drawing.Color.Black;
            this.btnGrade.Image = ((System.Drawing.Image)(resources.GetObject("btnGrade.Image")));
            this.btnGrade.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGrade.Location = new System.Drawing.Point(1, 198);
            this.btnGrade.Margin = new System.Windows.Forms.Padding(0, 20, 0, 20);
            this.btnGrade.Name = "btnGrade";
            this.btnGrade.Size = new System.Drawing.Size(315, 90);
            this.btnGrade.TabIndex = 3;
            this.btnGrade.Text = "តារាងពិន្ទុ";
            this.btnGrade.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGrade.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.btnGrade, "Ctrl+3");
            this.btnGrade.UseVisualStyleBackColor = false;
            this.btnGrade.Click += new System.EventHandler(this.btnGrade_Click);
            // 
            // btnView
            // 
            this.btnView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnView.AutoEllipsis = true;
            this.btnView.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnView.BackColor = System.Drawing.Color.White;
            this.btnView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnView.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnView.FlatAppearance.BorderSize = 0;
            this.btnView.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnView.Font = new System.Drawing.Font("Khmer OS Muol Pali", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.ForeColor = System.Drawing.Color.Black;
            this.btnView.Image = ((System.Drawing.Image)(resources.GetObject("btnView.Image")));
            this.btnView.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnView.Location = new System.Drawing.Point(1, 99);
            this.btnView.Margin = new System.Windows.Forms.Padding(0, 20, 0, 20);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(315, 90);
            this.btnView.TabIndex = 1;
            this.btnView.Text = "តារាងឈ្មោះ";
            this.btnView.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnView.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.btnView, "Ctrl+2");
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnHome
            // 
            this.btnHome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHome.AutoEllipsis = true;
            this.btnHome.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnHome.BackColor = System.Drawing.Color.LightGray;
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Khmer OS Muol Pali", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.Black;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(1, 2);
            this.btnHome.Margin = new System.Windows.Forms.Padding(0, 0, 0, 200);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(10);
            this.btnHome.Size = new System.Drawing.Size(314, 90);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "ទំព័រដើម";
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.btnHome, "Ctrl+1");
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panelShow
            // 
            this.panelShow.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelShow.BackColor = System.Drawing.Color.White;
            this.panelShow.Controls.Add(this.home);
            this.panelShow.Controls.Add(this.view);
            this.panelShow.Controls.Add(this.totalAbsence);
            this.panelShow.Controls.Add(this.absence);
            this.panelShow.Controls.Add(this.score);
            this.panelShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelShow.Font = new System.Drawing.Font("Khmer OS Battambang", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelShow.Location = new System.Drawing.Point(324, 97);
            this.panelShow.Name = "panelShow";
            this.panelShow.Size = new System.Drawing.Size(1307, 769);
            this.panelShow.TabIndex = 1;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel1.SetColumnSpan(this.bunifuGradientPanel1, 2);
            this.bunifuGradientPanel1.Controls.Add(this.label1);
            this.bunifuGradientPanel1.Controls.Add(this.picAppBrand);
            this.bunifuGradientPanel1.Controls.Add(this.picMinimize);
            this.bunifuGradientPanel1.Controls.Add(this.picExit);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.RoyalBlue;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.DodgerBlue;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.MediumBlue;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(3, 3);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(1628, 54);
            this.bunifuGradientPanel1.TabIndex = 2;
            this.bunifuGradientPanel1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.bunifuGradientPanel1_MouseDoubleClick);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoEllipsis = true;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Khmer OS Battambang", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(607, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 43);
            this.label1.TabIndex = 6;
            this.label1.Text = "Link ត្រូវបានចម្លង";
            this.label1.Visible = false;
            // 
            // picAppBrand
            // 
            this.picAppBrand.BackColor = System.Drawing.Color.Transparent;
            this.picAppBrand.Dock = System.Windows.Forms.DockStyle.Left;
            this.picAppBrand.Image = ((System.Drawing.Image)(resources.GetObject("picAppBrand.Image")));
            this.picAppBrand.Location = new System.Drawing.Point(0, 0);
            this.picAppBrand.Margin = new System.Windows.Forms.Padding(10);
            this.picAppBrand.Name = "picAppBrand";
            this.picAppBrand.Size = new System.Drawing.Size(64, 54);
            this.picAppBrand.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAppBrand.TabIndex = 5;
            this.picAppBrand.TabStop = false;
            // 
            // picMinimize
            // 
            this.picMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picMinimize.BackColor = System.Drawing.Color.Transparent;
            this.picMinimize.Image = ((System.Drawing.Image)(resources.GetObject("picMinimize.Image")));
            this.picMinimize.Location = new System.Drawing.Point(1490, 0);
            this.picMinimize.Margin = new System.Windows.Forms.Padding(10);
            this.picMinimize.Name = "picMinimize";
            this.picMinimize.Size = new System.Drawing.Size(64, 54);
            this.picMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMinimize.TabIndex = 4;
            this.picMinimize.TabStop = false;
            this.toolTip1.SetToolTip(this.picMinimize, "Minimize");
            this.picMinimize.Click += new System.EventHandler(this.picMinimize_Click);
            // 
            // picExit
            // 
            this.picExit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picExit.BackColor = System.Drawing.Color.Transparent;
            this.picExit.Image = ((System.Drawing.Image)(resources.GetObject("picExit.Image")));
            this.picExit.Location = new System.Drawing.Point(1564, 0);
            this.picExit.Name = "picExit";
            this.picExit.Size = new System.Drawing.Size(64, 54);
            this.picExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picExit.TabIndex = 3;
            this.picExit.TabStop = false;
            this.toolTip1.SetToolTip(this.picExit, "Close");
            this.picExit.Click += new System.EventHandler(this.picExit_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.SetColumnSpan(this.menuStrip1, 2);
            this.menuStrip1.Font = new System.Drawing.Font("Khmer OS Battambang", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.contactUsToolStripMenuItem,
            this.teacherInfoToolStripMenuItem,
            this.toolStripMenuItem1,
            this.shareMenuItem,
            this.logOffToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 60);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.ShowItemToolTips = true;
            this.menuStrip1.Size = new System.Drawing.Size(1634, 34);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearAllStudentsToolStripMenuItem,
            this.toolStripSeparator3,
            this.exitToolStripMenuItem1});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Khmer OS Battambang", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(70, 30);
            this.fileToolStripMenuItem.Text = "ឯកសារ";
            this.fileToolStripMenuItem.ToolTipText = "Files";
            // 
            // clearAllStudentsToolStripMenuItem
            // 
            this.clearAllStudentsToolStripMenuItem.Name = "clearAllStudentsToolStripMenuItem";
            this.clearAllStudentsToolStripMenuItem.Size = new System.Drawing.Size(200, 32);
            this.clearAllStudentsToolStripMenuItem.Text = "លុបសិស្សទាំងអស់";
            this.clearAllStudentsToolStripMenuItem.Click += new System.EventHandler(this.clearAllStudentsToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(197, 6);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem1.Image")));
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(200, 32);
            this.exitToolStripMenuItem1.Text = "បិទកម្មវិធី";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkForUpdateToolStripMenuItem,
            this.toolStripSeparator1,
            this.usageToolStripMenuItem,
            this.creatorToolStripMenuItem,
            this.aboutAppToolStripMenuItem,
            this.toolStripSeparator5,
            this.logOutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(59, 30);
            this.helpToolStripMenuItem.Text = "កម្មវិធី";
            // 
            // checkForUpdateToolStripMenuItem
            // 
            this.checkForUpdateToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("checkForUpdateToolStripMenuItem.Image")));
            this.checkForUpdateToolStripMenuItem.Name = "checkForUpdateToolStripMenuItem";
            this.checkForUpdateToolStripMenuItem.Size = new System.Drawing.Size(200, 32);
            this.checkForUpdateToolStripMenuItem.Text = "ធ្វើឲ្យទាន់សម័យ";
            this.checkForUpdateToolStripMenuItem.Click += new System.EventHandler(this.checkForUpdateToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(197, 6);
            // 
            // usageToolStripMenuItem
            // 
            this.usageToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("usageToolStripMenuItem.Image")));
            this.usageToolStripMenuItem.Name = "usageToolStripMenuItem";
            this.usageToolStripMenuItem.Size = new System.Drawing.Size(200, 32);
            this.usageToolStripMenuItem.Text = "អំពីការប្រើប្រាស់";
            this.usageToolStripMenuItem.Click += new System.EventHandler(this.usageToolStripMenuItem_Click);
            // 
            // creatorToolStripMenuItem
            // 
            this.creatorToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("creatorToolStripMenuItem.Image")));
            this.creatorToolStripMenuItem.Name = "creatorToolStripMenuItem";
            this.creatorToolStripMenuItem.Size = new System.Drawing.Size(200, 32);
            this.creatorToolStripMenuItem.Text = "អំពីអ្នកបង្កើតកម្មវិធី";
            this.creatorToolStripMenuItem.Click += new System.EventHandler(this.creatorToolStripMenuItem_Click);
            // 
            // aboutAppToolStripMenuItem
            // 
            this.aboutAppToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aboutAppToolStripMenuItem.Image")));
            this.aboutAppToolStripMenuItem.Name = "aboutAppToolStripMenuItem";
            this.aboutAppToolStripMenuItem.Size = new System.Drawing.Size(200, 32);
            this.aboutAppToolStripMenuItem.Text = "អំពីកម្មវិធី";
            this.aboutAppToolStripMenuItem.Click += new System.EventHandler(this.aboutAppToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(197, 6);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("logOutToolStripMenuItem.Image")));
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(200, 32);
            this.logOutToolStripMenuItem.Text = "ចាកចេញ";
            this.logOutToolStripMenuItem.ToolTipText = "ទៅទំព័រ Log In";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // contactUsToolStripMenuItem
            // 
            this.contactUsToolStripMenuItem.Name = "contactUsToolStripMenuItem";
            this.contactUsToolStripMenuItem.Size = new System.Drawing.Size(90, 30);
            this.contactUsToolStripMenuItem.Text = "រាយការណ៏";
            this.contactUsToolStripMenuItem.ToolTipText = "Send report to us";
            this.contactUsToolStripMenuItem.Click += new System.EventHandler(this.contactUsToolStripMenuItem_Click);
            // 
            // teacherInfoToolStripMenuItem
            // 
            this.teacherInfoToolStripMenuItem.Name = "teacherInfoToolStripMenuItem";
            this.teacherInfoToolStripMenuItem.Size = new System.Drawing.Size(69, 30);
            this.teacherInfoToolStripMenuItem.Text = "ព័ត៍មាន";
            this.teacherInfoToolStripMenuItem.ToolTipText = "Show Teacher Info";
            this.teacherInfoToolStripMenuItem.Click += new System.EventHandler(this.teacherInfoToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.payGoToolStripMenuItem,
            this.aBAToolStripMenuItem,
            this.payPalToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(54, 30);
            this.toolStripMenuItem1.Text = "គាំទ្រ";
            // 
            // payGoToolStripMenuItem
            // 
            this.payGoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("payGoToolStripMenuItem.Image")));
            this.payGoToolStripMenuItem.Name = "payGoToolStripMenuItem";
            this.payGoToolStripMenuItem.Size = new System.Drawing.Size(137, 32);
            this.payGoToolStripMenuItem.Text = "PayGo";
            this.payGoToolStripMenuItem.ToolTipText = "ID: 64386";
            // 
            // aBAToolStripMenuItem
            // 
            this.aBAToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aBAToolStripMenuItem.Image")));
            this.aBAToolStripMenuItem.Name = "aBAToolStripMenuItem";
            this.aBAToolStripMenuItem.Size = new System.Drawing.Size(137, 32);
            this.aBAToolStripMenuItem.Text = "ABA";
            this.aBAToolStripMenuItem.ToolTipText = "ABA: 000366550";
            // 
            // payPalToolStripMenuItem
            // 
            this.payPalToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("payPalToolStripMenuItem.Image")));
            this.payPalToolStripMenuItem.Name = "payPalToolStripMenuItem";
            this.payPalToolStripMenuItem.Size = new System.Drawing.Size(137, 32);
            this.payPalToolStripMenuItem.Text = "PayPal";
            this.payPalToolStripMenuItem.ToolTipText = "Click to go";
            this.payPalToolStripMenuItem.Click += new System.EventHandler(this.payPalToolStripMenuItem_Click);
            // 
            // shareMenuItem
            // 
            this.shareMenuItem.Name = "shareMenuItem";
            this.shareMenuItem.Size = new System.Drawing.Size(84, 30);
            this.shareMenuItem.Text = "ចែករំលែក";
            this.shareMenuItem.Click += new System.EventHandler(this.shareMenuItem_Click);
            // 
            // logOffToolStripMenuItem
            // 
            this.logOffToolStripMenuItem.Name = "logOffToolStripMenuItem";
            this.logOffToolStripMenuItem.Size = new System.Drawing.Size(79, 30);
            this.logOffToolStripMenuItem.Text = "ចាកចេញ";
            this.logOffToolStripMenuItem.ToolTipText = "Log Out";
            this.logOffToolStripMenuItem.Click += new System.EventHandler(this.logOffToolStripMenuItem_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this.bunifuGradientPanel1;
            // 
            // timerFadeIn
            // 
            this.timerFadeIn.Interval = 10;
            this.timerFadeIn.Tick += new System.EventHandler(this.timerFadeIn_Tick);
            // 
            // folderBackup
            // 
            this.folderBackup.Description = "Select A Directory to store your backup data";
            // 
            // bunifuElipse4
            // 
            this.bunifuElipse4.ElipseRadius = 25;
            this.bunifuElipse4.TargetControl = this.panel1;
            // 
            // bunifuElipse5
            // 
            this.bunifuElipse5.ElipseRadius = 25;
            this.bunifuElipse5.TargetControl = this.btnHome;
            // 
            // bunifuElipse6
            // 
            this.bunifuElipse6.ElipseRadius = 25;
            this.bunifuElipse6.TargetControl = this.btnView;
            // 
            // bunifuElipse7
            // 
            this.bunifuElipse7.ElipseRadius = 25;
            this.bunifuElipse7.TargetControl = this.btnGrade;
            // 
            // bunifuElipse8
            // 
            this.bunifuElipse8.ElipseRadius = 25;
            this.bunifuElipse8.TargetControl = this.btnAbsence;
            // 
            // bunifuElipse9
            // 
            this.bunifuElipse9.ElipseRadius = 25;
            this.bunifuElipse9.TargetControl = this.btnTotalAbsence;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.bunifuGradientPanel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // sendDataBackground
            // 
            this.sendDataBackground.DoWork += new System.ComponentModel.DoWorkEventHandler(this.sendDataBackground_DoWork);
            this.sendDataBackground.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.sendDataBackground_RunWorkerCompleted);
            // 
            // home
            // 
            this.home.AutoSize = true;
            this.home.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.home.BackColor = System.Drawing.Color.Transparent;
            this.home.Dock = System.Windows.Forms.DockStyle.Fill;
            this.home.Font = new System.Drawing.Font("Khmer OS Battambang", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home.Location = new System.Drawing.Point(0, 0);
            this.home.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(1307, 769);
            this.home.TabIndex = 6;
            // 
            // view
            // 
            this.view.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.view.Dock = System.Windows.Forms.DockStyle.Fill;
            this.view.Font = new System.Drawing.Font("Kh Siemreap", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.view.Location = new System.Drawing.Point(0, 0);
            this.view.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.view.Name = "view";
            this.view.Size = new System.Drawing.Size(1307, 769);
            this.view.TabIndex = 1;
            // 
            // totalAbsence
            // 
            this.totalAbsence.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.totalAbsence.Dock = System.Windows.Forms.DockStyle.Fill;
            this.totalAbsence.Font = new System.Drawing.Font("Kh Siemreap", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalAbsence.Location = new System.Drawing.Point(0, 0);
            this.totalAbsence.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.totalAbsence.Name = "totalAbsence";
            this.totalAbsence.Size = new System.Drawing.Size(1307, 769);
            this.totalAbsence.TabIndex = 5;
            // 
            // absence
            // 
            this.absence.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.absence.Dock = System.Windows.Forms.DockStyle.Fill;
            this.absence.Font = new System.Drawing.Font("Kh Siemreap", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.absence.Location = new System.Drawing.Point(0, 0);
            this.absence.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.absence.Name = "absence";
            this.absence.Size = new System.Drawing.Size(1307, 769);
            this.absence.TabIndex = 4;
            this.absence.Click += new System.EventHandler(this.btnAbsence_Click);
            // 
            // score
            // 
            this.score.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.score.BackColor = System.Drawing.Color.Transparent;
            this.score.Dock = System.Windows.Forms.DockStyle.Fill;
            this.score.Font = new System.Drawing.Font("Kh Siemreap", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score.Location = new System.Drawing.Point(0, 0);
            this.score.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(1307, 769);
            this.score.TabIndex = 3;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1634, 882);
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Khmer OS Battambang", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Classroom System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMain_KeyDown);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panelShow.ResumeLayout(false);
            this.panelShow.PerformLayout();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAppBrand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGrade;
        private System.Windows.Forms.Button btnTotalAbsence;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel panelShow;
        private User_Controls.View view;
        private User_Controls.Score score;
        private System.Windows.Forms.ToolTip toolTip1;
        private User_Controls.Absence absence;
        private User_Controls.TotalAbsence totalAbsence;
        private System.Windows.Forms.Button btnAbsence;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.PictureBox picMinimize;
        private System.Windows.Forms.PictureBox picExit;
        private System.Windows.Forms.PictureBox picAppBrand;
        private System.Windows.Forms.Timer timerFadeIn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkForUpdateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearAllStudentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutAppToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactUsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teacherInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOffToolStripMenuItem;
        private User_Controls.Home home;
        private System.Windows.Forms.FolderBrowserDialog folderBackup;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse4;
        private System.Windows.Forms.ToolStripMenuItem creatorToolStripMenuItem;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse5;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse6;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse7;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse8;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse9;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem payGoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aBAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem payPalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shareMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.ComponentModel.BackgroundWorker sendDataBackground;
    }
}

