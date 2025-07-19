
namespace School
{
    partial class Form1
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
            lblSchoolSystem = new System.Windows.Forms.Label();
            lblName = new System.Windows.Forms.Label();
            lblPatron = new System.Windows.Forms.Label();
            lblCity = new System.Windows.Forms.Label();
            lblDistrict = new System.Windows.Forms.Label();
            lblAddress = new System.Windows.Forms.Label();
            lblWebpage = new System.Windows.Forms.Label();
            lblTelephone = new System.Windows.Forms.Label();
            pbLogo = new System.Windows.Forms.PictureBox();
            btnStudents = new System.Windows.Forms.Button();
            btnClose = new System.Windows.Forms.Button();
            listBox1 = new System.Windows.Forms.ListBox();
            button1 = new System.Windows.Forms.Button();
            listBox2 = new System.Windows.Forms.ListBox();
            btnTeachers = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            btnExams = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            SuspendLayout();
            // 
            // lblSchoolSystem
            // 
            lblSchoolSystem.AutoSize = true;
            lblSchoolSystem.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblSchoolSystem.Location = new System.Drawing.Point(199, 29);
            lblSchoolSystem.Name = "lblSchoolSystem";
            lblSchoolSystem.Size = new System.Drawing.Size(560, 37);
            lblSchoolSystem.TabIndex = 0;
            lblSchoolSystem.Text = "Информационна система SchoolSystem";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblName.Location = new System.Drawing.Point(90, 101);
            lblName.Name = "lblName";
            lblName.Size = new System.Drawing.Size(155, 32);
            lblName.TabIndex = 1;
            lblName.Text = "schoolName";
            // 
            // lblPatron
            // 
            lblPatron.AutoSize = true;
            lblPatron.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblPatron.Location = new System.Drawing.Point(235, 101);
            lblPatron.Name = "lblPatron";
            lblPatron.Size = new System.Drawing.Size(164, 32);
            lblPatron.TabIndex = 2;
            lblPatron.Text = "schoolPatron";
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblCity.Location = new System.Drawing.Point(111, 185);
            lblCity.Name = "lblCity";
            lblCity.Size = new System.Drawing.Size(132, 32);
            lblCity.TabIndex = 3;
            lblCity.Text = "schoolCity";
            // 
            // lblDistrict
            // 
            lblDistrict.AutoSize = true;
            lblDistrict.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblDistrict.Location = new System.Drawing.Point(235, 185);
            lblDistrict.Name = "lblDistrict";
            lblDistrict.Size = new System.Drawing.Size(171, 32);
            lblDistrict.TabIndex = 4;
            lblDistrict.Text = "schoolDistrict";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblAddress.Location = new System.Drawing.Point(149, 257);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new System.Drawing.Size(180, 32);
            lblAddress.TabIndex = 5;
            lblAddress.Text = "schoolAddress";
            // 
            // lblWebpage
            // 
            lblWebpage.AutoSize = true;
            lblWebpage.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblWebpage.Location = new System.Drawing.Point(33, 373);
            lblWebpage.Name = "lblWebpage";
            lblWebpage.Size = new System.Drawing.Size(195, 32);
            lblWebpage.TabIndex = 6;
            lblWebpage.Text = "schoolWebpage";
            // 
            // lblTelephone
            // 
            lblTelephone.AutoSize = true;
            lblTelephone.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblTelephone.Location = new System.Drawing.Point(317, 373);
            lblTelephone.Name = "lblTelephone";
            lblTelephone.Size = new System.Drawing.Size(205, 32);
            lblTelephone.TabIndex = 7;
            lblTelephone.Text = "schoolTelephone";
            // 
            // pbLogo
            // 
            pbLogo.Location = new System.Drawing.Point(536, 85);
            pbLogo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new System.Drawing.Size(375, 344);
            pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pbLogo.TabIndex = 8;
            pbLogo.TabStop = false;
            // 
            // btnStudents
            // 
            btnStudents.BackColor = System.Drawing.Color.SpringGreen;
            btnStudents.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnStudents.Location = new System.Drawing.Point(128, 437);
            btnStudents.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnStudents.Name = "btnStudents";
            btnStudents.Size = new System.Drawing.Size(133, 44);
            btnStudents.TabIndex = 9;
            btnStudents.Text = "Students";
            btnStudents.UseVisualStyleBackColor = false;
            btnStudents.Click += btnStudents_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = System.Drawing.Color.SpringGreen;
            btnClose.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnClose.Location = new System.Drawing.Point(766, 685);
            btnClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(145, 56);
            btnClose.TabIndex = 10;
            btnClose.Text = "Exit";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new System.Drawing.Point(33, 489);
            listBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            listBox1.Name = "listBox1";
            listBox1.Size = new System.Drawing.Size(337, 264);
            listBox1.TabIndex = 11;
            listBox1.Visible = false;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.Color.SpringGreen;
            button1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button1.Location = new System.Drawing.Point(766, 520);
            button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(145, 69);
            button1.TabIndex = 12;
            button1.Text = "Editing Students";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 20;
            listBox2.Location = new System.Drawing.Point(377, 489);
            listBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            listBox2.Name = "listBox2";
            listBox2.Size = new System.Drawing.Size(381, 264);
            listBox2.TabIndex = 13;
            listBox2.Visible = false;
            // 
            // btnTeachers
            // 
            btnTeachers.BackColor = System.Drawing.Color.SpringGreen;
            btnTeachers.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnTeachers.Location = new System.Drawing.Point(469, 437);
            btnTeachers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnTeachers.Name = "btnTeachers";
            btnTeachers.Size = new System.Drawing.Size(133, 44);
            btnTeachers.TabIndex = 14;
            btnTeachers.Text = "Teachers";
            btnTeachers.UseVisualStyleBackColor = false;
            btnTeachers.Click += btnTeachers_Click;
            // 
            // button2
            // 
            button2.BackColor = System.Drawing.Color.SpringGreen;
            button2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button2.Location = new System.Drawing.Point(766, 597);
            button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(145, 69);
            button2.TabIndex = 15;
            button2.Text = "Editing Teachers";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // btnExams
            // 
            btnExams.BackColor = System.Drawing.Color.SpringGreen;
            btnExams.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnExams.Location = new System.Drawing.Point(763, 443);
            btnExams.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnExams.Name = "btnExams";
            btnExams.Size = new System.Drawing.Size(149, 69);
            btnExams.TabIndex = 16;
            btnExams.Text = "EXAMS";
            btnExams.UseVisualStyleBackColor = false;
            btnExams.Click += btnExams_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.DarkCyan;
            ClientSize = new System.Drawing.Size(942, 778);
            Controls.Add(btnExams);
            Controls.Add(button2);
            Controls.Add(btnTeachers);
            Controls.Add(listBox2);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Controls.Add(btnClose);
            Controls.Add(btnStudents);
            Controls.Add(pbLogo);
            Controls.Add(lblTelephone);
            Controls.Add(lblWebpage);
            Controls.Add(lblAddress);
            Controls.Add(lblDistrict);
            Controls.Add(lblCity);
            Controls.Add(lblPatron);
            Controls.Add(lblName);
            Controls.Add(lblSchoolSystem);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Информационна система SchoolSystem";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblSchoolSystem;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPatron;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblDistrict;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblWebpage;
        private System.Windows.Forms.Label lblTelephone;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Button btnStudents;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button btnTeachers;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnExams;
    }
}

