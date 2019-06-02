namespace Classroom_Project__Win_Form_.User_Controls
{
    partial class TeacherInfomations
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherInfomations));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.comboNumOfScore = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtClass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOpenImage = new System.Windows.Forms.Button();
            this.picTeacher = new System.Windows.Forms.PictureBox();
            this.txtTeacherName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.openImage = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTeacher)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.btnConfirm);
            this.groupBox1.Controls.Add(this.comboNumOfScore);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtClass);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnOpenImage);
            this.groupBox1.Controls.Add(this.picTeacher);
            this.groupBox1.Controls.Add(this.txtTeacherName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(883, 469);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ពត៍មានគ្រូបន្ទុក";
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.SystemColors.Control;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Font = new System.Drawing.Font("Khmer OS Battambang", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirm.Image")));
            this.btnConfirm.Location = new System.Drawing.Point(616, 358);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(231, 67);
            this.btnConfirm.TabIndex = 6;
            this.btnConfirm.Text = "យល់ព្រម";
            this.btnConfirm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // comboNumOfScore
            // 
            this.comboNumOfScore.AutoCompleteCustomSource.AddRange(new string[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.comboNumOfScore.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboNumOfScore.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboNumOfScore.BackColor = System.Drawing.Color.White;
            this.comboNumOfScore.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboNumOfScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboNumOfScore.ForeColor = System.Drawing.Color.Black;
            this.comboNumOfScore.FormattingEnabled = true;
            this.comboNumOfScore.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.comboNumOfScore.Location = new System.Drawing.Point(401, 263);
            this.comboNumOfScore.MaxDropDownItems = 6;
            this.comboNumOfScore.Name = "comboNumOfScore";
            this.comboNumOfScore.Size = new System.Drawing.Size(180, 49);
            this.comboNumOfScore.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(197, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 43);
            this.label4.TabIndex = 62;
            this.label4.Text = "ចំនួនតារាងពិន្ទុ ៖";
            this.toolTip1.SetToolTip(this.label4, "ចំនួន Columns ដែលនឹងបង្ហាញសម្រាប់ការដាក់ពិន្ទុ");
            // 
            // txtClass
            // 
            this.txtClass.BackColor = System.Drawing.Color.White;
            this.txtClass.Location = new System.Drawing.Point(401, 166);
            this.txtClass.Name = "txtClass";
            this.txtClass.Size = new System.Drawing.Size(446, 51);
            this.txtClass.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(244, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 43);
            this.label2.TabIndex = 58;
            this.label2.Text = "ថ្នាក់បន្ទុក ៖";
            // 
            // btnOpenImage
            // 
            this.btnOpenImage.BackColor = System.Drawing.SystemColors.Control;
            this.btnOpenImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenImage.Font = new System.Drawing.Font("Khmer OS Battambang", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenImage.Location = new System.Drawing.Point(45, 283);
            this.btnOpenImage.Name = "btnOpenImage";
            this.btnOpenImage.Size = new System.Drawing.Size(117, 50);
            this.btnOpenImage.TabIndex = 0;
            this.btnOpenImage.Text = "ចូល";
            this.btnOpenImage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOpenImage.UseVisualStyleBackColor = false;
            this.btnOpenImage.Click += new System.EventHandler(this.btnOpenImage_Click);
            // 
            // picTeacher
            // 
            this.picTeacher.Image = global::Classroom_Project__Win_Form_.Properties.Resources.Teacher;
            this.picTeacher.Location = new System.Drawing.Point(28, 75);
            this.picTeacher.Name = "picTeacher";
            this.picTeacher.Size = new System.Drawing.Size(150, 200);
            this.picTeacher.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTeacher.TabIndex = 56;
            this.picTeacher.TabStop = false;
            // 
            // txtTeacherName
            // 
            this.txtTeacherName.BackColor = System.Drawing.Color.White;
            this.txtTeacherName.Location = new System.Drawing.Point(401, 72);
            this.txtTeacherName.Name = "txtTeacherName";
            this.txtTeacherName.Size = new System.Drawing.Size(446, 51);
            this.txtTeacherName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(234, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 43);
            this.label1.TabIndex = 47;
            this.label1.Text = "នាមឈ្មោះ ៖";
            // 
            // openImage
            // 
            this.openImage.Filter = "Image Files|*jpg; *jpeg; *png";
            this.openImage.Title = "បញ្ជុលរូបភាព";
            // 
            // TeacherInfomations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(883, 469);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Khmer OS Battambang", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TeacherInfomations";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.TeacherInfo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTeacher)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.ComboBox comboNumOfScore;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox txtClass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOpenImage;
        private System.Windows.Forms.PictureBox picTeacher;
        private System.Windows.Forms.TextBox txtTeacherName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openImage;
    }
}