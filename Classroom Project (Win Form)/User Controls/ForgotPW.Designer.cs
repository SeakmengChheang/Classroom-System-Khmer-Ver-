namespace Classroom_Project__Win_Form_.User_Controls
{
    partial class ForgotPw
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgotPw));
            this.label5 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblSubject = new System.Windows.Forms.Label();
            this.btnSendPW = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.metroProgressBar = new MetroFramework.Controls.MetroProgressBar();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(137, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 43);
            this.label5.TabIndex = 78;
            this.label5.Text = "Email ៖";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(243, 37);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(367, 51);
            this.txtUserName.TabIndex = 75;
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Location = new System.Drawing.Point(73, 42);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(163, 43);
            this.lblSubject.TabIndex = 77;
            this.lblSubject.Text = "ឈ្មោះអ្នកប្រើ ៖";
            // 
            // btnSendPW
            // 
            this.btnSendPW.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSendPW.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnSendPW.Image = ((System.Drawing.Image)(resources.GetObject("btnSendPW.Image")));
            this.btnSendPW.Location = new System.Drawing.Point(386, 189);
            this.btnSendPW.Name = "btnSendPW";
            this.btnSendPW.Size = new System.Drawing.Size(224, 66);
            this.btnSendPW.TabIndex = 79;
            this.btnSendPW.Text = "ផ្ញើលេខសំងាត់";
            this.btnSendPW.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSendPW.UseVisualStyleBackColor = true;
            this.btnSendPW.Click += new System.EventHandler(this.btnSendPW_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Khmer OS Battambang", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(12, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 66);
            this.label1.TabIndex = 80;
            this.label1.Text = "*លេខសំងាត់ចាស់នឹងត្រូវ     ផ្ញើទៅ Email របស់អ្នក";
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.WorkerSupportsCancellation = true;
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_ProgressChanged);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // metroProgressBar
            // 
            this.metroProgressBar.FontSize = MetroFramework.MetroProgressBarSize.Tall;
            this.metroProgressBar.FontWeight = MetroFramework.MetroProgressBarWeight.Regular;
            this.metroProgressBar.HideProgressText = false;
            this.metroProgressBar.Location = new System.Drawing.Point(145, 78);
            this.metroProgressBar.Name = "metroProgressBar";
            this.metroProgressBar.Size = new System.Drawing.Size(390, 38);
            this.metroProgressBar.Step = 1;
            this.metroProgressBar.TabIndex = 81;
            this.metroProgressBar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroProgressBar.Visible = false;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(243, 111);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(367, 51);
            this.txtEmail.TabIndex = 76;
            // 
            // ForgotPw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(676, 277);
            this.Controls.Add(this.metroProgressBar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSendPW);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.lblSubject);
            this.Font = new System.Drawing.Font("Khmer OS Battambang", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ForgotPw";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ភ្លេចលេខសំងាត់";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.Button btnSendPW;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private MetroFramework.Controls.MetroProgressBar metroProgressBar;
        private System.Windows.Forms.TextBox txtEmail;
    }
}