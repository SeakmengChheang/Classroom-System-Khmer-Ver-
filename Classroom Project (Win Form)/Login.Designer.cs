namespace Classroom_Project__Win_Form_
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.checkRememberUserName = new System.Windows.Forms.CheckBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnSignIn = new System.Windows.Forms.Button();
            this.checkShowPW = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.linkForgotPw = new System.Windows.Forms.LinkLabel();
            this.linkCreateNew = new System.Windows.Forms.LinkLabel();
            this.linkChangePw = new System.Windows.Forms.LinkLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picQuit = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picQuit)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUserName
            // 
            this.txtUserName.AcceptsTab = true;
            this.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserName.Font = new System.Drawing.Font("Lucida Sans", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(94, 94);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(350, 39);
            this.txtUserName.TabIndex = 0;
            this.txtUserName.Enter += new System.EventHandler(this.txtUserName_Enter);
            this.txtUserName.Leave += new System.EventHandler(this.txtUserName_Leave);
            // 
            // txtPassword
            // 
            this.txtPassword.AcceptsTab = true;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Lucida Sans", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(94, 198);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.Size = new System.Drawing.Size(350, 39);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.Enter += new System.EventHandler(this.panel2_Enter);
            this.txtPassword.Leave += new System.EventHandler(this.panel2_Leave);
            // 
            // checkRememberUserName
            // 
            this.checkRememberUserName.AutoSize = true;
            this.checkRememberUserName.Font = new System.Drawing.Font("Khmer OS Battambang", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkRememberUserName.Location = new System.Drawing.Point(94, 273);
            this.checkRememberUserName.Name = "checkRememberUserName";
            this.checkRememberUserName.Size = new System.Drawing.Size(167, 35);
            this.checkRememberUserName.TabIndex = 68;
            this.checkRememberUserName.TabStop = false;
            this.checkRememberUserName.Text = "ចងចាំឈ្មោះគណនី";
            this.checkRememberUserName.UseVisualStyleBackColor = true;
            this.checkRememberUserName.CheckedChanged += new System.EventHandler(this.checkRememberUserName_CheckedChanged);
            // 
            // btnSignIn
            // 
            this.btnSignIn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSignIn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSignIn.BackColor = System.Drawing.Color.White;
            this.btnSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignIn.ForeColor = System.Drawing.Color.Blue;
            this.btnSignIn.Location = new System.Drawing.Point(94, 468);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(349, 74);
            this.btnSignIn.TabIndex = 2;
            this.btnSignIn.Text = "ចូល";
            this.btnSignIn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.btnSignIn, "Enter");
            this.btnSignIn.UseVisualStyleBackColor = false;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            this.btnSignIn.MouseEnter += new System.EventHandler(this.btnSignIn_MouseEnter);
            this.btnSignIn.MouseLeave += new System.EventHandler(this.btnSignIn_MouseLeave);
            // 
            // checkShowPW
            // 
            this.checkShowPW.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkShowPW.AutoSize = true;
            this.checkShowPW.Font = new System.Drawing.Font("Khmer OS Battambang", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkShowPW.Image = ((System.Drawing.Image)(resources.GetObject("checkShowPW.Image")));
            this.checkShowPW.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.checkShowPW.Location = new System.Drawing.Point(458, 200);
            this.checkShowPW.Name = "checkShowPW";
            this.checkShowPW.Size = new System.Drawing.Size(66, 48);
            this.checkShowPW.TabIndex = 67;
            this.checkShowPW.TabStop = false;
            this.toolTip1.SetToolTip(this.checkShowPW, "បង្ហាញលេខសំងាត់");
            this.checkShowPW.UseVisualStyleBackColor = true;
            this.checkShowPW.CheckedChanged += new System.EventHandler(this.checkShowPW_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Font = new System.Drawing.Font("Lucida Sans", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(94, 132);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 2);
            this.panel1.TabIndex = 71;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Blue;
            this.panel2.Font = new System.Drawing.Font("Lucida Sans", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(94, 236);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(350, 2);
            this.panel2.TabIndex = 72;
            this.panel2.Enter += new System.EventHandler(this.panel2_Enter);
            this.panel2.Leave += new System.EventHandler(this.panel2_Leave);
            // 
            // linkForgotPw
            // 
            this.linkForgotPw.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.linkForgotPw.AutoSize = true;
            this.linkForgotPw.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkForgotPw.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkForgotPw.LinkColor = System.Drawing.Color.DarkGray;
            this.linkForgotPw.Location = new System.Drawing.Point(199, 429);
            this.linkForgotPw.Name = "linkForgotPw";
            this.linkForgotPw.Size = new System.Drawing.Size(155, 36);
            this.linkForgotPw.TabIndex = 75;
            this.linkForgotPw.TabStop = true;
            this.linkForgotPw.Text = "ភ្លេចលេខសំងាត់?";
            this.linkForgotPw.VisitedLinkColor = System.Drawing.Color.Navy;
            this.linkForgotPw.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkForgotPw_LinkClicked);
            // 
            // linkCreateNew
            // 
            this.linkCreateNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.linkCreateNew.AutoSize = true;
            this.linkCreateNew.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkCreateNew.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkCreateNew.LinkColor = System.Drawing.Color.DarkBlue;
            this.linkCreateNew.Location = new System.Drawing.Point(88, 554);
            this.linkCreateNew.Name = "linkCreateNew";
            this.linkCreateNew.Size = new System.Drawing.Size(132, 36);
            this.linkCreateNew.TabIndex = 76;
            this.linkCreateNew.TabStop = true;
            this.linkCreateNew.Text = "បង្កើតគណនីថ្មី";
            this.linkCreateNew.VisitedLinkColor = System.Drawing.Color.Navy;
            this.linkCreateNew.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkCreateNew_LinkClicked);
            // 
            // linkChangePw
            // 
            this.linkChangePw.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.linkChangePw.AutoSize = true;
            this.linkChangePw.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkChangePw.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkChangePw.LinkColor = System.Drawing.Color.DarkBlue;
            this.linkChangePw.Location = new System.Drawing.Point(312, 554);
            this.linkChangePw.Name = "linkChangePw";
            this.linkChangePw.Size = new System.Drawing.Size(131, 36);
            this.linkChangePw.TabIndex = 77;
            this.linkChangePw.TabStop = true;
            this.linkChangePw.Text = "ប្តូរលេខសំងាត់";
            this.linkChangePw.VisitedLinkColor = System.Drawing.Color.Navy;
            this.linkChangePw.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkChangePw_LinkClicked);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(40, 197);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 45);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 74;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(40, 88);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 73;
            this.pictureBox1.TabStop = false;
            // 
            // picQuit
            // 
            this.picQuit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picQuit.Cursor = System.Windows.Forms.Cursors.Default;
            this.picQuit.Image = ((System.Drawing.Image)(resources.GetObject("picQuit.Image")));
            this.picQuit.Location = new System.Drawing.Point(489, 11);
            this.picQuit.Name = "picQuit";
            this.picQuit.Size = new System.Drawing.Size(53, 44);
            this.picQuit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picQuit.TabIndex = 79;
            this.picQuit.TabStop = false;
            this.toolTip1.SetToolTip(this.picQuit, "Close");
            this.picQuit.Click += new System.EventHandler(this.picQuit_Click);
            // 
            // Login
            // 
            this.AcceptButton = this.btnSignIn;
            this.ApplyImageInvert = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(547, 649);
            this.ControlBox = false;
            this.Controls.Add(this.picQuit);
            this.Controls.Add(this.linkChangePw);
            this.Controls.Add(this.linkCreateNew);
            this.Controls.Add(this.linkForgotPw);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.checkRememberUserName);
            this.Controls.Add(this.checkShowPW);
            this.Controls.Add(this.btnSignIn);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Font = new System.Drawing.Font("Khmer OS Battambang", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Text = "Login";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picQuit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.CheckBox checkShowPW;
        private System.Windows.Forms.CheckBox checkRememberUserName;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.LinkLabel linkForgotPw;
        private System.Windows.Forms.LinkLabel linkCreateNew;
        private System.Windows.Forms.LinkLabel linkChangePw;
        private System.Windows.Forms.PictureBox picQuit;
    }
}