namespace Classroom_Project__Win_Form_.User_Controls
{
    partial class View_Update
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(View_Update));
            this.picQuit = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.comboYear = new System.Windows.Forms.ComboBox();
            this.comboMonth = new System.Windows.Forms.ComboBox();
            this.comboDay = new System.Windows.Forms.ComboBox();
            this.comboSex = new System.Windows.Forms.ComboBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblHeader = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picQuit)).BeginInit();
            this.SuspendLayout();
            // 
            // picQuit
            // 
            this.picQuit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picQuit.Image = ((System.Drawing.Image)(resources.GetObject("picQuit.Image")));
            this.picQuit.Location = new System.Drawing.Point(725, 9);
            this.picQuit.Name = "picQuit";
            this.picQuit.Size = new System.Drawing.Size(74, 55);
            this.picQuit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picQuit.TabIndex = 67;
            this.picQuit.TabStop = false;
            this.toolTip1.SetToolTip(this.picQuit, "Close");
            this.picQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(363, 391);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 43);
            this.label10.TabIndex = 66;
            this.label10.Text = "ខែ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(509, 391);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 43);
            this.label9.TabIndex = 65;
            this.label9.Text = "ឆ្នាំ";
            // 
            // btnQuit
            // 
            this.btnQuit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnQuit.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.ForeColor = System.Drawing.Color.Red;
            this.btnQuit.Image = ((System.Drawing.Image)(resources.GetObject("btnQuit.Image")));
            this.btnQuit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuit.Location = new System.Drawing.Point(335, 550);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(168, 66);
            this.btnQuit.TabIndex = 8;
            this.btnQuit.TabStop = false;
            this.btnQuit.Text = "ចាកចេញ";
            this.btnQuit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.btnQuit, "Close");
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnConfirm.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirm.Image")));
            this.btnConfirm.Location = new System.Drawing.Point(526, 550);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(168, 66);
            this.btnConfirm.TabIndex = 7;
            this.btnConfirm.Text = "កែ";
            this.btnConfirm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.btnConfirm, "Change");
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // comboYear
            // 
            this.comboYear.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboYear.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboYear.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboYear.DropDownHeight = 250;
            this.comboYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboYear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboYear.ForeColor = System.Drawing.Color.Black;
            this.comboYear.FormattingEnabled = true;
            this.comboYear.IntegralHeight = false;
            this.comboYear.Items.AddRange(new object[] {
            "1999"});
            this.comboYear.Location = new System.Drawing.Point(558, 388);
            this.comboYear.Name = "comboYear";
            this.comboYear.Size = new System.Drawing.Size(136, 49);
            this.comboYear.TabIndex = 5;
            // 
            // comboMonth
            // 
            this.comboMonth.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboMonth.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboMonth.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboMonth.DropDownHeight = 250;
            this.comboMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboMonth.DropDownWidth = 100;
            this.comboMonth.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboMonth.ForeColor = System.Drawing.Color.Black;
            this.comboMonth.FormattingEnabled = true;
            this.comboMonth.IntegralHeight = false;
            this.comboMonth.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.comboMonth.Location = new System.Drawing.Point(412, 388);
            this.comboMonth.Name = "comboMonth";
            this.comboMonth.Size = new System.Drawing.Size(91, 49);
            this.comboMonth.TabIndex = 4;
            // 
            // comboDay
            // 
            this.comboDay.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboDay.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboDay.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboDay.DropDownHeight = 250;
            this.comboDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboDay.ForeColor = System.Drawing.Color.Black;
            this.comboDay.FormattingEnabled = true;
            this.comboDay.IntegralHeight = false;
            this.comboDay.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.comboDay.Location = new System.Drawing.Point(269, 388);
            this.comboDay.Name = "comboDay";
            this.comboDay.Size = new System.Drawing.Size(88, 49);
            this.comboDay.TabIndex = 3;
            // 
            // comboSex
            // 
            this.comboSex.AutoCompleteCustomSource.AddRange(new string[] {
            "ប្រុស",
            "ស្រី"});
            this.comboSex.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboSex.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboSex.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSex.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboSex.ForeColor = System.Drawing.Color.Black;
            this.comboSex.FormattingEnabled = true;
            this.comboSex.Items.AddRange(new object[] {
            "ប្រុស",
            "ស្រី"});
            this.comboSex.Location = new System.Drawing.Point(240, 317);
            this.comboSex.Name = "comboSex";
            this.comboSex.Size = new System.Drawing.Size(117, 49);
            this.comboSex.TabIndex = 2;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.BackColor = System.Drawing.SystemColors.Window;
            this.txtPhoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhoneNumber.ForeColor = System.Drawing.Color.Black;
            this.txtPhoneNumber.Location = new System.Drawing.Point(240, 454);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(454, 51);
            this.txtPhoneNumber.TabIndex = 6;
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.SystemColors.Window;
            this.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLastName.ForeColor = System.Drawing.Color.Black;
            this.txtLastName.Location = new System.Drawing.Point(240, 244);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(454, 51);
            this.txtLastName.TabIndex = 1;
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.SystemColors.Window;
            this.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFirstName.ForeColor = System.Drawing.Color.Black;
            this.txtFirstName.Location = new System.Drawing.Point(240, 174);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(454, 51);
            this.txtFirstName.TabIndex = 0;
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.Gainsboro;
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtID.ForeColor = System.Drawing.Color.Black;
            this.txtID.Location = new System.Drawing.Point(240, 104);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(454, 51);
            this.txtID.TabIndex = 0;
            this.txtID.TabStop = false;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Khmer OS Metal Chrieng", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.Navy;
            this.lblHeader.Location = new System.Drawing.Point(306, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(247, 74);
            this.lblHeader.TabIndex = 52;
            this.lblHeader.Text = "កែប្រែទិន្នន័យ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(72, 249);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 43);
            this.label6.TabIndex = 51;
            this.label6.Text = "នាមឈ្មោះ ៖";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(130, 320);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 43);
            this.label5.TabIndex = 50;
            this.label5.Text = "ភេទ ៖";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 391);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 43);
            this.label4.TabIndex = 49;
            this.label4.Text = "ថ្ងៃខែឆ្នាំកំណើត ៖";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 462);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 43);
            this.label3.TabIndex = 48;
            this.label3.Text = "លេខទូរស័ព្ទ ៖";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 43);
            this.label2.TabIndex = 47;
            this.label2.Text = "នាមត្រកូល ៖";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 43);
            this.label1.TabIndex = 46;
            this.label1.Text = "លេខសម្គាល់ ៖";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(232, 391);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 43);
            this.label8.TabIndex = 64;
            this.label8.Text = "ថ្ងៃ";
            // 
            // View_Update
            // 
            this.AcceptButton = this.btnConfirm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(822, 654);
            this.ControlBox = false;
            this.Controls.Add(this.picQuit);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.comboYear);
            this.Controls.Add(this.comboMonth);
            this.Controls.Add(this.comboDay);
            this.Controls.Add(this.comboSex);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.DoubleBuffered = false;
            this.Font = new System.Drawing.Font("Khmer OS Battambang", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.Name = "View_Update";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Load += new System.EventHandler(this.View_Update_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picQuit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picQuit;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.ComboBox comboYear;
        private System.Windows.Forms.ComboBox comboMonth;
        private System.Windows.Forms.ComboBox comboDay;
        private System.Windows.Forms.ComboBox comboSex;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}