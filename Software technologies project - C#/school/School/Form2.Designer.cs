
namespace School
{
    partial class Form2
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
            btnSearch = new System.Windows.Forms.Button();
            btnSave = new System.Windows.Forms.Button();
            btnClose = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            txtID = new System.Windows.Forms.TextBox();
            txtName = new System.Windows.Forms.TextBox();
            txtSurname = new System.Windows.Forms.TextBox();
            txtFamily = new System.Windows.Forms.TextBox();
            txtEmail = new System.Windows.Forms.TextBox();
            txtDistrict = new System.Windows.Forms.TextBox();
            txtCity = new System.Windows.Forms.TextBox();
            txtBorn = new System.Windows.Forms.TextBox();
            txtEGN = new System.Windows.Forms.TextBox();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            btnNew = new System.Windows.Forms.Button();
            txtTownBorn = new System.Windows.Forms.TextBox();
            label10 = new System.Windows.Forms.Label();
            btnReset = new System.Windows.Forms.Button();
            btnDelete = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // btnSearch
            // 
            btnSearch.BackColor = System.Drawing.Color.FromArgb(0, 64, 64);
            btnSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnSearch.ForeColor = System.Drawing.Color.Silver;
            btnSearch.Location = new System.Drawing.Point(12, 489);
            btnSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new System.Drawing.Size(93, 49);
            btnSearch.TabIndex = 0;
            btnSearch.Text = "Търси";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = System.Drawing.Color.FromArgb(0, 64, 64);
            btnSave.Enabled = false;
            btnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnSave.ForeColor = System.Drawing.Color.Silver;
            btnSave.Location = new System.Drawing.Point(130, 489);
            btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(94, 49);
            btnSave.TabIndex = 1;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = System.Drawing.Color.FromArgb(0, 64, 64);
            btnClose.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnClose.ForeColor = System.Drawing.Color.Silver;
            btnClose.Location = new System.Drawing.Point(445, 489);
            btnClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(99, 49);
            btnClose.TabIndex = 2;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(24, 15);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(175, 25);
            label1.TabIndex = 3;
            label1.Text = "Индентификатор";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(130, 64);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(52, 25);
            label2.TabIndex = 4;
            label2.Text = "Име";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(94, 112);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(95, 25);
            label3.TabIndex = 5;
            label3.Text = "Презиме";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(88, 165);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(99, 25);
            label4.TabIndex = 6;
            label4.Text = "Фамилия";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label5.Location = new System.Drawing.Point(117, 216);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(67, 25);
            label5.TabIndex = 7;
            label5.Text = "e-mail";
            // 
            // txtID
            // 
            txtID.Location = new System.Drawing.Point(205, 16);
            txtID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtID.Name = "txtID";
            txtID.Size = new System.Drawing.Size(290, 27);
            txtID.TabIndex = 8;
            // 
            // txtName
            // 
            txtName.Location = new System.Drawing.Point(205, 65);
            txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtName.Name = "txtName";
            txtName.Size = new System.Drawing.Size(290, 27);
            txtName.TabIndex = 9;
            // 
            // txtSurname
            // 
            txtSurname.Location = new System.Drawing.Point(205, 113);
            txtSurname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new System.Drawing.Size(290, 27);
            txtSurname.TabIndex = 10;
            // 
            // txtFamily
            // 
            txtFamily.Location = new System.Drawing.Point(205, 163);
            txtFamily.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtFamily.Name = "txtFamily";
            txtFamily.Size = new System.Drawing.Size(290, 27);
            txtFamily.TabIndex = 11;
            // 
            // txtEmail
            // 
            txtEmail.Location = new System.Drawing.Point(205, 214);
            txtEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new System.Drawing.Size(290, 27);
            txtEmail.TabIndex = 12;
            // 
            // txtDistrict
            // 
            txtDistrict.Location = new System.Drawing.Point(205, 442);
            txtDistrict.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtDistrict.Name = "txtDistrict";
            txtDistrict.Size = new System.Drawing.Size(290, 27);
            txtDistrict.TabIndex = 20;
            // 
            // txtCity
            // 
            txtCity.Location = new System.Drawing.Point(205, 394);
            txtCity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtCity.Name = "txtCity";
            txtCity.Size = new System.Drawing.Size(290, 27);
            txtCity.TabIndex = 19;
            // 
            // txtBorn
            // 
            txtBorn.Location = new System.Drawing.Point(205, 310);
            txtBorn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtBorn.Name = "txtBorn";
            txtBorn.Size = new System.Drawing.Size(290, 27);
            txtBorn.TabIndex = 18;
            // 
            // txtEGN
            // 
            txtEGN.Location = new System.Drawing.Point(205, 262);
            txtEGN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtEGN.Name = "txtEGN";
            txtEGN.Size = new System.Drawing.Size(290, 27);
            txtEGN.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label6.Location = new System.Drawing.Point(109, 444);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(77, 25);
            label6.TabIndex = 16;
            label6.Text = "Област";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label7.Location = new System.Drawing.Point(78, 393);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(111, 25);
            label7.TabIndex = 15;
            label7.Text = "Град(село)";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label8.Location = new System.Drawing.Point(70, 309);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(120, 25);
            label8.TabIndex = 14;
            label8.Text = "Роден(а) на";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label9.Location = new System.Drawing.Point(130, 261);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(47, 25);
            label9.TabIndex = 13;
            label9.Text = "ЕГН";
            // 
            // btnNew
            // 
            btnNew.BackColor = System.Drawing.Color.FromArgb(0, 64, 64);
            btnNew.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnNew.ForeColor = System.Drawing.Color.Silver;
            btnNew.Location = new System.Drawing.Point(244, 489);
            btnNew.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnNew.Name = "btnNew";
            btnNew.Size = new System.Drawing.Size(78, 49);
            btnNew.TabIndex = 21;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = false;
            btnNew.Click += btnNew_Click;
            // 
            // txtTownBorn
            // 
            txtTownBorn.Location = new System.Drawing.Point(205, 350);
            txtTownBorn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtTownBorn.Name = "txtTownBorn";
            txtTownBorn.Size = new System.Drawing.Size(290, 27);
            txtTownBorn.TabIndex = 23;
            txtTownBorn.TextChanged += txtTownBorn_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label10.Location = new System.Drawing.Point(73, 349);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(109, 25);
            label10.TabIndex = 22;
            label10.Text = "Роден(а) в";
            label10.Click += label10_Click;
            // 
            // btnReset
            // 
            btnReset.BackColor = System.Drawing.Color.FromArgb(0, 64, 64);
            btnReset.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnReset.ForeColor = System.Drawing.Color.Silver;
            btnReset.Location = new System.Drawing.Point(340, 489);
            btnReset.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnReset.Name = "btnReset";
            btnReset.Size = new System.Drawing.Size(99, 49);
            btnReset.TabIndex = 24;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = System.Drawing.Color.FromArgb(0, 64, 64);
            btnDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnDelete.ForeColor = System.Drawing.Color.Silver;
            btnDelete.Location = new System.Drawing.Point(12, 432);
            btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(91, 49);
            btnDelete.TabIndex = 25;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(192, 255, 255);
            ClientSize = new System.Drawing.Size(585, 557);
            Controls.Add(btnDelete);
            Controls.Add(btnReset);
            Controls.Add(txtTownBorn);
            Controls.Add(label10);
            Controls.Add(btnNew);
            Controls.Add(txtDistrict);
            Controls.Add(txtCity);
            Controls.Add(txtBorn);
            Controls.Add(txtEGN);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(txtEmail);
            Controls.Add(txtFamily);
            Controls.Add(txtSurname);
            Controls.Add(txtName);
            Controls.Add(txtID);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnClose);
            Controls.Add(btnSave);
            Controls.Add(btnSearch);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "Form2";
            Text = "Редактиране на ученик";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtFamily;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtDistrict;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtBorn;
        private System.Windows.Forms.TextBox txtEGN;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.TextBox txtTownBorn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnDelete;
    }
}