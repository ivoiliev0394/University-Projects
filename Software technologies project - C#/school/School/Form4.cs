using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace School
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        string connectionString = @"Server=IVO_LAPTOP\SQLEXPRESS;Database=School;Integrated Security = True";

        private void LoadExamData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"
                SELECT 
                    e.ID AS ExamID,
                    s.ID AS StudentID,
                    s.Name + ' ' + s.Surname + ' ' + s.Family AS StudentName,
                    t.ID AS TeacherID,
                    t.FirstName + ' ' + t.LastName AS TeacherName,
                    e.Subject,
                    e.ExamDate,
                    e.Grade,
                    e.MaxGrade,
                    e.Comments
                FROM Exams e
                JOIN Students s ON e.StudentID = s.ID
                JOIN Teachers t ON e.TeacherID = t.ID";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable; 
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }


        private void Form4_Load(object sender, EventArgs e)
        {
            LoadExamData();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                label1.Text = row.Cells["ExamID"].Value.ToString();
                label2.Text = row.Cells["StudentID"].Value.ToString();
                label3.Text = row.Cells["StudentName"].Value.ToString();
                label4.Text = row.Cells["TeacherID"].Value.ToString();
                label5.Text = row.Cells["TeacherName"].Value.ToString();
                label6.Text = row.Cells["Subject"].Value.ToString();
                label7.Text = row.Cells["ExamDate"].Value.ToString();
                label8.Text = row.Cells["Grade"].Value.ToString();
                label9.Text = row.Cells["MaxGrade"].Value.ToString();
                label10.Text = row.Cells["Comments"].Value?.ToString();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void LoadStudentsByGrade(decimal grade)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
                    SELECT 
                    e.ID AS ExamID,
                    s.ID AS StudentID,
                    s.Name + ' ' + s.Surname + ' ' + s.Family AS StudentName,
                    t.ID AS TeacherID,
                    t.FirstName + ' ' + t.LastName AS TeacherName,
                    e.Subject,
                    e.ExamDate,
                    e.Grade,
                    e.MaxGrade,
                    e.Comments
                    FROM Exams e
                    JOIN Students s ON e.StudentID = s.ID
                    JOIN Teachers t ON e.TeacherID = t.ID
                    WHERE e.Grade = @Grade
                    ORDER BY e.StudentID;";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                adapter.SelectCommand.Parameters.AddWithValue("@Grade", grade);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
        }


        private void btnGradeFilter_Click(object sender, EventArgs e)
        {
            decimal grade;
            if (decimal.TryParse(txtBoxInputFilter.Text, out grade))
            {
                LoadStudentsByGrade(grade);
            }
            else
            {
                MessageBox.Show("Please enter a valid grade.","Info",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            txtBoxInputFilter.Text = string.Empty;
        }

        private void LoadTopStudentsBySubject(string subject)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
            SELECT 
                    e.ID AS ExamID,
                    s.ID AS StudentID,
                    s.Name + ' ' + s.Surname + ' ' + s.Family AS StudentName,
                    t.ID AS TeacherID,
                    t.FirstName + ' ' + t.LastName AS TeacherName,
                    e.Subject,
                    e.ExamDate,
                    e.Grade,
                    e.MaxGrade,
                    e.Comments
                    FROM Exams e
                    JOIN Students s ON e.StudentID = s.ID
                    JOIN Teachers t ON e.TeacherID = t.ID
                WHERE e.Subject = @Subject
            ORDER BY e.Grade DESC;";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                adapter.SelectCommand.Parameters.AddWithValue("@Subject", subject);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }

        }


        private void btnSubjectFilter_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtBoxInputFilter.Text) &&!String.IsNullOrWhiteSpace(txtBoxInputFilter.Text))
            {
                LoadTopStudentsBySubject(txtBoxInputFilter.Text);
                txtBoxInputFilter.Text = string.Empty;
            }
            else
                MessageBox.Show("Please enter a valid Subject.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void LoadStudentAverageGrade(int studentID)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
            SELECT 
                s.ID AS StudentID,
                s.Name + ' ' + s.Surname + ' ' + s.Family AS StudentName,
                ROUND(CAST(AVG(e.Grade) AS DECIMAL(10, 2)), 2) AS AverageGrade
            FROM Exams e
            JOIN Students s ON e.StudentID = s.ID
            WHERE s.ID = @StudentID
            GROUP BY s.ID, s.Name, s.Surname, s.Family;";


                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                adapter.SelectCommand.Parameters.AddWithValue("@StudentID", studentID);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;

            }
        }


        private void btnStAVGGrade_Click(object sender, EventArgs e)
        {
            int studentID;
            if (int.TryParse(txtBoxInputFilter.Text, out studentID))
            {
                LoadStudentAverageGrade(studentID);
            }
            else
            {
                MessageBox.Show("Please enter a valid student ID.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void LoadTopTeachers()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
            SELECT 
                t.ID AS TeacherID,
                t.FirstName + ' ' + t.LastName AS TeacherName,
                COUNT(e.ID) AS ExamCount
            FROM Exams e
            JOIN Teachers t ON e.TeacherID = t.ID
            GROUP BY t.ID, t.FirstName, t.LastName
            ORDER BY ExamCount DESC;";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            LoadTopTeachers();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Form5 form = new Form5();
            form.Show();
        }

        private void ExportToExcel()
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Excel Files|*.xlsx";
                saveFileDialog.Title = "Save as Excel file";
                saveFileDialog.FileName = "ExamResults.xlsx";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (XLWorkbook workbook = new XLWorkbook())
                        {
                            var worksheet = workbook.Worksheets.Add("Exams");

                            // Заглавия на колоните
                            for (int col = 0; col < dataGridView1.Columns.Count; col++)
                            {
                                worksheet.Cell(1, col + 1).Value = dataGridView1.Columns[col].HeaderText;
                                worksheet.Cell(1, col + 1).Style.Font.Bold = true; // Подчертаване на заглавията
                            }

                            // Данни от DataGridView
                            for (int row = 0; row < dataGridView1.Rows.Count; row++)
                            {
                                for (int col = 0; col < dataGridView1.Columns.Count; col++)
                                {
                                    worksheet.Cell(row + 2, col + 1).Value = dataGridView1.Rows[row].Cells[col].Value?.ToString();
                                }
                            }

                            // Автоматично нагласяне на ширината на колоните
                            worksheet.Columns().AdjustToContents();

                            // Запазване на файла
                            workbook.SaveAs(saveFileDialog.FileName);
                        }

                        MessageBox.Show("Exported to Excel successfully!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error exporting to Excel: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


        private void btnExportToExcel_Click(object sender, EventArgs e)
        {
            ExportToExcel();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            LoadExamData();
        }
    }
}
