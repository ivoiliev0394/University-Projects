using DocumentFormat.OpenXml.Office.Word;
using DocumentFormat.OpenXml.Wordprocessing;
using School.Utilities;
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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        string connectionString = @"Server=IVO_LAPTOP\SQLEXPRESS;Database=School;Integrated Security = True";

        void Reset()
        {
            txtExamId.Text = string.Empty;
            txtStId.Text = string.Empty;
            txtTId.Text = string.Empty;
            txtSubject.Text = string.Empty;
            txtExamDate.Text = string.Empty;
            txtGarde.Text = string.Empty;
            txtMaxGrade.Text = string.Empty;
            txtComment.Text = string.Empty;

        }
        bool ValidateDate()
        {
            bool isValid = DateTime.TryParse(txtExamDate.Text, out DateTime birthDate);

            return isValid;
        }
        bool IsDecimal(string textboox)
        {
            return Decimal.TryParse(textboox, out decimal result);
        }
        bool IsInt(string textboox)
        {
            return int.TryParse(textboox, out int result);
        }
        bool IdStudent()
        {
            if (!IsInt(txtStId.Text))
                throw new ArgumentException(Messages.incorrectId);
            bool exists = false;
            using (SqlConnection cnn = new SqlConnection(@"Server=IVO_LAPTOP\SQLEXPRESS;Database=School;Integrated Security=True"))
            {
                cnn.Open();
                string query = "SELECT 1 FROM Students WHERE ID = " + int.Parse(txtStId.Text);

                using (SqlCommand cmmd = new SqlCommand(query, cnn))
                {
                    var res = cmmd.ExecuteScalar();
                    exists = res == null;
                }
            }
            return exists;
        }
        bool IdTeacher()
        {
            if (!IsInt(txtTId.Text))
                throw new ArgumentException(Messages.incorrectId);
            bool exists = false;
            using (SqlConnection cnn = new SqlConnection(@"Server=IVO_LAPTOP\SQLEXPRESS;Database=School;Integrated Security=True"))
            {
                cnn.Open();
                string query = "SELECT 1 FROM Teachers WHERE ID = " + int.Parse(txtTId.Text);

                using (SqlCommand cmmd = new SqlCommand(query, cnn))
                {
                    var res = cmmd.ExecuteScalar();
                    exists = res == null;
                }
            }
            return exists;
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                if (IdStudent())
                {
                    throw new ArgumentException(Messages.stExist);
                }
                if (IdTeacher())
                {
                    throw new ArgumentException(Messages.tExist);
                }
                if (!ValidateDate())
                {
                    throw new ArgumentException(Messages.InvalidDate);
                }
                if (!IsDecimal(txtGarde.Text) && !IsDecimal(txtMaxGrade.Text))
                {
                    throw new ArgumentException(Messages.notDecimal);
                }
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = @"INSERT INTO Exams (StudentID, TeacherID, Subject, ExamDate, Grade, MaxGrade, Comments) VALUES (@StudentID, @TeacherID, @Subject, @ExamDate, @Grade, @MaxGrade, @Comments)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@StudentID", int.Parse(txtStId.Text));
                        cmd.Parameters.AddWithValue("@TeacherID", int.Parse(txtTId.Text));
                        cmd.Parameters.AddWithValue("@Subject", txtSubject.Text);
                        cmd.Parameters.AddWithValue("@ExamDate", DateTime.Parse(txtExamDate.Text));
                        cmd.Parameters.AddWithValue("@Grade", Decimal.Parse(txtGarde.Text));
                        cmd.Parameters.AddWithValue("@MaxGrade", Decimal.Parse(txtMaxGrade.Text));
                        cmd.Parameters.AddWithValue("@Comments", txtComment.Text ?? (object)DBNull.Value);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("New exam has been registered!", "Message", MessageBoxButtons.OK);
                }
                Reset();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            /*
            using (SqlConnection cn = new SqlConnection(@"Server=IVO_LAPTOP\SQLEXPRESS;Database=School;Integrated Security = True;"))
            {
                cn.Open();
                string query = "DELETE FROM Exams WHERE ID = @ID";
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@ID", int.Parse(txtExamId.Text));
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Записът е изтрит успешно!", "Съобщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Reset();
                }
                else
                {
                    MessageBox.Show("Записът не беше намерен!", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            */
            using (SqlConnection cn = new SqlConnection(@"Server=IVO_LAPTOP\SQLEXPRESS;Database=School;Integrated Security=True;"))
            {
                cn.Open();

                // Delete the exam by ID
                string deleteQuery = "DELETE FROM Exams WHERE ID = @ID";
                using (SqlCommand cmd = new SqlCommand(deleteQuery, cn))
                {
                    cmd.Parameters.AddWithValue("@ID", int.Parse(txtExamId.Text));
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("The exam record was deleted successfully!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Reset();

                        // Optional: Reseed IDENTITY to the current MAX(ID)
                        string reseedQuery = @"
                DECLARE @maxId INT = ISNULL((SELECT MAX(ID) FROM Exams), 0);
                DBCC CHECKIDENT ('Exams', RESEED, @maxId);";

                        using (SqlCommand reseedCmd = new SqlCommand(reseedQuery, cn))
                        {
                            reseedCmd.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                        MessageBox.Show("The record was not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (IdStudent())
                {
                    throw new ArgumentException(Messages.stExist);
                }
                if (IdTeacher())
                {
                    throw new ArgumentException(Messages.tExist);
                }
                if (!ValidateDate())
                {
                    throw new ArgumentException(Messages.InvalidDate);
                }
                if (!IsDecimal(txtGarde.Text) && !IsDecimal(txtMaxGrade.Text))
                {
                    throw new ArgumentException(Messages.notDecimal);
                }
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = @"
            UPDATE Exams 
            SET StudentID = @StudentID, TeacherID = @TeacherID, Subject = @Subject, ExamDate = @ExamDate, 
                Grade = @Grade, MaxGrade = @MaxGrade, Comments = @Comments
            WHERE ID = " + int.Parse(txtExamId.Text);

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@StudentID", int.Parse(txtStId.Text));
                        cmd.Parameters.AddWithValue("@TeacherID", int.Parse(txtTId.Text));
                        cmd.Parameters.AddWithValue("@Subject", txtSubject.Text);
                        cmd.Parameters.AddWithValue("@ExamDate", DateTime.Parse(txtExamDate.Text));
                        cmd.Parameters.AddWithValue("@Grade", Decimal.Parse(txtGarde.Text));
                        cmd.Parameters.AddWithValue("@MaxGrade", Decimal.Parse(txtMaxGrade.Text));
                        cmd.Parameters.AddWithValue("@Comments", txtComment.Text ?? (object)DBNull.Value);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Edit successful!", "Message", MessageBoxButtons.OK);
                }
                Reset();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtExamId.Text, out int result))
                    throw new ArgumentException(Messages.incorrectId);
                else
                {
                    bool exists = false;
                    using (SqlConnection cnn = new SqlConnection(@"Server=IVO_LAPTOP\SQLEXPRESS;Database=School;Integrated Security=True"))
                    {
                        cnn.Open();
                        string query = "SELECT 1 FROM Exams WHERE ID = " + int.Parse(txtExamId.Text);

                        using (SqlCommand cmmd = new SqlCommand(query, cnn))
                        {
                            var res = cmmd.ExecuteScalar();
                            exists = res == null;
                        }
                    }

                    if (exists)
                    {
                        throw new ArgumentException(Messages.doesntExist);
                    }
                    //SqlConnection cn = new SqlConnection(@"Server=IVO03_HELIOS\SQLEXPRESS;Database=School;Integrated Security = True");
                    SqlConnection cn = new SqlConnection(@"Server=IVO_LAPTOP\SQLEXPRESS;Database=School;Integrated Security = True");
                    string queryString = "SELECT * FROM Exams WHERE ID = " + int.Parse(txtExamId.Text);
                    SqlCommand cmd = new SqlCommand(queryString, cn);
                    cn.Open();
                    using (SqlDataReader sqlDataReader = cmd.ExecuteReader())
                    {
                        while (sqlDataReader.Read())
                        {
                            //txtName.Text = sqlDataReader["Name"].ToString();
                            txtExamId.Text = sqlDataReader["ID"].ToString();
                            txtStId.Text = sqlDataReader["StudentID"].ToString();
                            txtTId.Text = sqlDataReader["TeacherID"].ToString();
                            txtSubject.Text = sqlDataReader["Subject"].ToString();
                            txtExamDate.Text = sqlDataReader["ExamDate"].ToString();
                            txtGarde.Text = sqlDataReader["Grade"].ToString();
                            txtMaxGrade.Text = sqlDataReader["MaxGrade"].ToString();
                            txtComment.Text = sqlDataReader["Comments"].ToString();

                        }
                    }
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}
