namespace School
{
    partial class Form4
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
            dataGridView1 = new System.Windows.Forms.DataGridView();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            btnClose = new System.Windows.Forms.Button();
            txtBoxInputFilter = new System.Windows.Forms.TextBox();
            btnEdit = new System.Windows.Forms.Button();
            btnGradeFilter = new System.Windows.Forms.Button();
            btnSubjectFilter = new System.Windows.Forms.Button();
            btnStAVGGrade = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            btnExportToExcel = new System.Windows.Forms.Button();
            buttonReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            dataGridView1.Location = new System.Drawing.Point(0, 104);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new System.Drawing.Size(1132, 385);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellMouseClick += dataGridView1_CellMouseClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(15, 34);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(63, 20);
            label1.TabIndex = 1;
            label1.Text = "ExamID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(78, 29);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(39, 20);
            label2.TabIndex = 2;
            label2.Text = "StID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(141, 29);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(65, 20);
            label3.TabIndex = 3;
            label3.Text = "StName";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(78, 58);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(34, 20);
            label4.TabIndex = 4;
            label4.Text = "TID";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(141, 58);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(60, 20);
            label5.TabIndex = 5;
            label5.Text = "TName";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(416, 9);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(60, 20);
            label6.TabIndex = 6;
            label6.Text = "Subject";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(416, 29);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(40, 20);
            label7.TabIndex = 7;
            label7.Text = "date";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(416, 49);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(51, 20);
            label8.TabIndex = 8;
            label8.Text = "Grade";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(416, 68);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(79, 20);
            label9.TabIndex = 9;
            label9.Text = "Maxgrade";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(141, 81);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(78, 20);
            label10.TabIndex = 10;
            label10.Text = "Comment";
            // 
            // btnClose
            // 
            btnClose.BackColor = System.Drawing.Color.MediumSlateBlue;
            btnClose.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnClose.Location = new System.Drawing.Point(1031, 65);
            btnClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(89, 32);
            btnClose.TabIndex = 11;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // txtBoxInputFilter
            // 
            txtBoxInputFilter.Location = new System.Drawing.Point(653, 6);
            txtBoxInputFilter.Name = "txtBoxInputFilter";
            txtBoxInputFilter.Size = new System.Drawing.Size(339, 27);
            txtBoxInputFilter.TabIndex = 12;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = System.Drawing.Color.RoyalBlue;
            btnEdit.Location = new System.Drawing.Point(1031, 6);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new System.Drawing.Size(89, 27);
            btnEdit.TabIndex = 13;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnGradeFilter
            // 
            btnGradeFilter.BackColor = System.Drawing.Color.SlateBlue;
            btnGradeFilter.Location = new System.Drawing.Point(842, 71);
            btnGradeFilter.Name = "btnGradeFilter";
            btnGradeFilter.Size = new System.Drawing.Size(150, 30);
            btnGradeFilter.TabIndex = 14;
            btnGradeFilter.Text = "Students By Grade";
            btnGradeFilter.UseVisualStyleBackColor = false;
            btnGradeFilter.Click += btnGradeFilter_Click;
            // 
            // btnSubjectFilter
            // 
            btnSubjectFilter.BackColor = System.Drawing.Color.SlateBlue;
            btnSubjectFilter.Location = new System.Drawing.Point(653, 71);
            btnSubjectFilter.Name = "btnSubjectFilter";
            btnSubjectFilter.Size = new System.Drawing.Size(169, 30);
            btnSubjectFilter.TabIndex = 15;
            btnSubjectFilter.Text = "Top Students By Subject";
            btnSubjectFilter.UseVisualStyleBackColor = false;
            btnSubjectFilter.Click += btnSubjectFilter_Click;
            // 
            // btnStAVGGrade
            // 
            btnStAVGGrade.BackColor = System.Drawing.Color.SlateBlue;
            btnStAVGGrade.Location = new System.Drawing.Point(653, 38);
            btnStAVGGrade.Name = "btnStAVGGrade";
            btnStAVGGrade.Size = new System.Drawing.Size(169, 31);
            btnStAVGGrade.TabIndex = 16;
            btnStAVGGrade.Text = "Student Average Grade";
            btnStAVGGrade.UseVisualStyleBackColor = false;
            btnStAVGGrade.Click += btnStAVGGrade_Click;
            // 
            // button2
            // 
            button2.BackColor = System.Drawing.Color.SlateBlue;
            button2.Location = new System.Drawing.Point(842, 38);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(150, 31);
            button2.TabIndex = 17;
            button2.Text = "Top Teachers";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // btnExportToExcel
            // 
            btnExportToExcel.BackColor = System.Drawing.Color.RoyalBlue;
            btnExportToExcel.Location = new System.Drawing.Point(1031, 34);
            btnExportToExcel.Name = "btnExportToExcel";
            btnExportToExcel.Size = new System.Drawing.Size(89, 27);
            btnExportToExcel.TabIndex = 18;
            btnExportToExcel.Text = "Excel";
            btnExportToExcel.UseVisualStyleBackColor = false;
            btnExportToExcel.Click += btnExportToExcel_Click;
            // 
            // buttonReset
            // 
            buttonReset.BackColor = System.Drawing.Color.LightSteelBlue;
            buttonReset.Location = new System.Drawing.Point(553, 5);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new System.Drawing.Size(94, 29);
            buttonReset.TabIndex = 19;
            buttonReset.Text = "Reset";
            buttonReset.UseVisualStyleBackColor = false;
            buttonReset.Click += buttonReset_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.DarkOrchid;
            ClientSize = new System.Drawing.Size(1132, 489);
            Controls.Add(buttonReset);
            Controls.Add(btnExportToExcel);
            Controls.Add(button2);
            Controls.Add(btnStAVGGrade);
            Controls.Add(btnSubjectFilter);
            Controls.Add(btnGradeFilter);
            Controls.Add(btnEdit);
            Controls.Add(txtBoxInputFilter);
            Controls.Add(btnClose);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            Name = "Form4";
            Text = "Exam View";
            Load += Form4_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtBoxInputFilter;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnGradeFilter;
        private System.Windows.Forms.Button btnSubjectFilter;
        private System.Windows.Forms.Button btnStAVGGrade;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnExportToExcel;
        private System.Windows.Forms.Button buttonReset;
    }
}