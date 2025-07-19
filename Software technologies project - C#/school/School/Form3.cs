using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Linq;
using School.Utilities;


namespace School
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtSurname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBorn_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        void Reset()
        {
            txtID.Text = string.Empty;
            txtName.Text = string.Empty;
            txtFamily.Text = string.Empty;
            txtSubject1.Text = string.Empty;
            txtSubject2.Text = string.Empty;
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {

                if (!int.TryParse(txtID.Text, out int result)) throw new ArgumentException(Messages.incorrectId);
                else
                {
                    bool exists = false;
                    using (SqlConnection cnn = new SqlConnection(@"Server=IVO_LAPTOP\SQLEXPRESS;Database=School;Integrated Security=True"))
                    {
                        cnn.Open();
                        string query = "SELECT 1 FROM Teachers WHERE ID = " + int.Parse(txtID.Text);

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
                    string queryString = "SELECT * FROM Teachers WHERE ID = " + int.Parse(txtID.Text);
                    SqlCommand cmd = new SqlCommand(queryString, cn);
                    cn.Open();
                    using (SqlDataReader sqlDataReader = cmd.ExecuteReader())
                    {
                        while (sqlDataReader.Read())
                        {
                            txtName.Text = sqlDataReader["FirstName"].ToString();
                            txtFamily.Text = sqlDataReader["LastName"].ToString();
                            txtSubject1.Text = sqlDataReader["Subject1"].ToString();
                            txtSubject2.Text = sqlDataReader["Subject2"].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            if (txtName.Text != "" || txtFamily.Text != "") btnSave.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //SqlConnection cn = new SqlConnection(@"Server=IVO03_HELIOS\SQLEXPRESS;Database=School;Integrated Security = True");
            SqlConnection cn = new SqlConnection(@"Server=IVO_LAPTOP\SQLEXPRESS;Database=School;Integrated Security = True");
            cn.Open();
            string queryString = "UPDATE Teachers set FirstName=@Name, LastName=@Family, Subject1=@Subject1, Subject2=@Subject2 WHERE ID = " + int.Parse(txtID.Text);
            SqlCommand cmd = new SqlCommand(queryString, cn);
            cmd.Parameters.AddWithValue("@Name", txtName.Text);
            cmd.Parameters.AddWithValue("@Family", txtFamily.Text);
            cmd.Parameters.AddWithValue("@Subject1", txtSubject1.Text);
            cmd.Parameters.AddWithValue("@Subject2", txtSubject2.Text);
            cmd.ExecuteNonQuery();
            cn.Close();
            MessageBox.Show("Edit successful!", "Message", MessageBoxButtons.OK);
            Reset();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            //SqlConnection cn = new SqlConnection(@"Server=IVO03_HELIOS\SQLEXPRESS;Database=School;Integrated Security = True");
            SqlConnection cn = new SqlConnection(@"Server=IVO_LAPTOP\SQLEXPRESS;Database=School;Integrated Security = True");
            cn.Open();
            string queryString = "INSERT INTO Teachers VALUES (@FirstName,@LastName,@Subject1,@Subject2)";
            SqlCommand cmd = new SqlCommand(queryString, cn);
            //cmd.Parameters.AddWithValue("@ID", txtID.Text);
            cmd.Parameters.AddWithValue("@FirstName", txtName.Text);
            cmd.Parameters.AddWithValue("@LastName", txtFamily.Text);
            cmd.Parameters.AddWithValue("@Subject1", txtSubject1.Text);
            cmd.Parameters.AddWithValue("@Subject2", txtSubject2.Text);
            cmd.ExecuteNonQuery();
            cn.Close();
            MessageBox.Show("New teacher has been registered!", "Message", MessageBoxButtons.OK);
            Reset();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
           // Form1 f1 = new Form1();
           // f1.Show();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
           /* using (SqlConnection cn = new SqlConnection(@"Server=IVO_LAPTOP\SQLEXPRESS;Database=School;Integrated Security = True;"))
            {
                cn.Open();
                string query = "DELETE FROM Teachers WHERE ID = " + int.Parse(txtID.Text);
                SqlCommand cmd = new SqlCommand(query, cn);
                //cmd.Parameters.AddWithValue("@ID", int.Parse(txtID.Text));
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
            }*/
            using (SqlConnection cn = new SqlConnection(@"Server=IVO_LAPTOP\SQLEXPRESS;Database=School;Integrated Security=True;"))
            {
                cn.Open();

                string deleteQuery = "DELETE FROM Teachers WHERE ID = @ID";
                using (SqlCommand cmd = new SqlCommand(deleteQuery, cn))
                {
                    cmd.Parameters.AddWithValue("@ID", int.Parse(txtID.Text));
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("The teacher record was deleted successfully!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Reset();

                        // Reset identity to the current MAX(ID)
                        string reseedQuery = @"
                DECLARE @maxId INT = ISNULL((SELECT MAX(ID) FROM Teachers), 0);
                DBCC CHECKIDENT ('Teachers', RESEED, @maxId);";

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
    }
}
