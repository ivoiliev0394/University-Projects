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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        void Reset()
        {
            txtID.Text = string.Empty;
            txtName.Text = string.Empty;
            txtSurname.Text = string.Empty;
            txtFamily.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtEGN.Text = string.Empty;
            txtBorn.Text = string.Empty;
            txtTownBorn.Text = string.Empty;
            txtCity.Text = string.Empty;
            txtDistrict.Text = string.Empty;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            //Form1 form1 = new Form1();
            //form1.Show();

        }
        bool CheckEGN()
        {
            if (txtEGN.Text.Length != 10) throw new ArgumentException(Messages.sizeEGN);

            bool exists = false;
            using (SqlConnection cnn = new SqlConnection(@"Server=IVO_LAPTOP\SQLEXPRESS;Database=School;Integrated Security=True"))
            {
                cnn.Open();
                string query = "SELECT 1 FROM Students WHERE EGN = " + txtEGN.Text;

                using (SqlCommand cmmd = new SqlCommand(query, cnn))
                {
                    cmmd.Parameters.AddWithValue("@egn", txtEGN.Text);

                    var res = cmmd.ExecuteScalar();
                    exists = res == null;
                }
            }
            return exists;
        }
        bool ValidateBirthDate()
        {
            bool isValid = DateTime.TryParse(txtBorn.Text, out DateTime birthDate);

            return isValid;
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (!int.TryParse(txtID.Text, out int result) && ((string.IsNullOrEmpty(txtEGN.Text) || string.IsNullOrWhiteSpace(txtEGN.Text))))
                    throw new ArgumentException(Messages.IdOrEGN);
                else if (int.TryParse(txtID.Text, out int result2))
                {
                    bool exists = false;
                    using (SqlConnection cnn = new SqlConnection(@"Server=IVO_LAPTOP\SQLEXPRESS;Database=School;Integrated Security=True"))
                    {
                        cnn.Open();
                        string query = "SELECT 1 FROM Students WHERE ID = " + int.Parse(txtID.Text);
                       
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
                    else
                    {
                        //SqlConnection cn = new SqlConnection(@"Server=IVO03_HELIOS\SQLEXPRESS;Database=School;Integrated Security = True");
                        SqlConnection cn = new SqlConnection(@"Server=IVO_LAPTOP\SQLEXPRESS;Database=School;Integrated Security = True");
                        string queryString = "SELECT * FROM Students WHERE ID = " + int.Parse(txtID.Text);
                        SqlCommand cmd = new SqlCommand(queryString, cn);
                        cn.Open();
                        using (SqlDataReader sqlDataReader = cmd.ExecuteReader())
                        {
                            while (sqlDataReader.Read())
                            {
                                txtName.Text = sqlDataReader["Name"].ToString();
                                txtSurname.Text = sqlDataReader["Surname"].ToString();
                                txtFamily.Text = sqlDataReader["Family"].ToString();
                                txtEmail.Text = sqlDataReader["Email"].ToString();
                                txtEGN.Text = sqlDataReader["EGN"].ToString();
                                txtBorn.Text = sqlDataReader["BirthDate"].ToString();
                                txtTownBorn.Text = sqlDataReader["BornTown"].ToString();
                                txtCity.Text = sqlDataReader["City"].ToString();
                                txtDistrict.Text = sqlDataReader["District"].ToString();
                            }
                        }
                    }
                }
                else if (!(string.IsNullOrEmpty(txtEGN.Text) || string.IsNullOrWhiteSpace(txtEGN.Text)))
                {
                  /*  if(txtEGN.Text.Length != 10) throw new ArgumentException(Messages.sizeEGN);

                    bool exists = false;
                    using (SqlConnection cnn = new SqlConnection(@"Server=IVO_LAPTOP\SQLEXPRESS;Database=School;Integrated Security=True"))
                    {
                        cnn.Open();
                        string query = "SELECT 1 FROM Students WHERE EGN = " + txtEGN.Text;

                        using (SqlCommand cmmd = new SqlCommand(query, cnn))
                        {
                            cmmd.Parameters.AddWithValue("@egn", txtEGN.Text);

                            var res = cmmd.ExecuteScalar();
                            exists = res == null;
                        }
                    }
                  */
                    if (CheckEGN())
                    {
                        throw new ArgumentException(Messages.doesntExist);
                    }
                    else
                    {

                        //SqlConnection cn = new SqlConnection(@"Server=IVO03_HELIOS\SQLEXPRESS;Database=School;Integrated Security = True");
                        SqlConnection cn = new SqlConnection(@"Server=IVO_LAPTOP\SQLEXPRESS;Database=School;Integrated Security = True");
                        string queryString = "SELECT * FROM Students WHERE EGN = " + txtEGN.Text;
                        SqlCommand cmd = new SqlCommand(queryString, cn);
                        cn.Open();
                        using (SqlDataReader sqlDataReader = cmd.ExecuteReader())
                        {
                            while (sqlDataReader.Read())
                            {
                                txtID.Text = sqlDataReader["ID"].ToString();
                                txtName.Text = sqlDataReader["Name"].ToString();
                                txtSurname.Text = sqlDataReader["Surname"].ToString();
                                txtFamily.Text = sqlDataReader["Family"].ToString();
                                txtEmail.Text = sqlDataReader["Email"].ToString();
                                txtEGN.Text = sqlDataReader["EGN"].ToString();
                                txtBorn.Text = sqlDataReader["BirthDate"].ToString();
                                txtTownBorn.Text = sqlDataReader["BornTown"].ToString();
                                txtCity.Text = sqlDataReader["City"].ToString();
                                txtDistrict.Text = sqlDataReader["District"].ToString();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            if (txtName.Text != "" || txtSurname.Text != "" || txtFamily.Text != "" || txtEmail.Text != "") btnSave.Enabled = true;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtEGN.Text.Length != 10) throw new ArgumentException(Messages.sizeEGN);

                if (!ValidateBirthDate())
                {
                    throw new ArgumentException(Messages.InvalidDate);
                }
                //SqlConnection cn = new SqlConnection(@"Server=IVO03_HELIOS\SQLEXPRESS;Database=School;Integrated Security = True");
                SqlConnection cn = new SqlConnection(@"Server=IVO_LAPTOP\SQLEXPRESS;Database=School;Integrated Security = True");
                cn.Open();
                string queryString = "UPDATE Students set Name=@Name, Surname=@Surname, Family=@Family, " +
                    "Email=@Email, EGN=@EGN, BornTown=@BornTown, City=@City, " +
                    "District=@District, BirthDate=@BirthDate WHERE ID = @ID";
                SqlCommand cmd = new SqlCommand(queryString, cn);
                cmd.Parameters.AddWithValue("@ID", txtID.Text);
                cmd.Parameters.AddWithValue("@Name", txtName.Text);
                cmd.Parameters.AddWithValue("@Surname", txtSurname.Text);
                cmd.Parameters.AddWithValue("@Family", txtFamily.Text);
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@EGN", txtEGN.Text);
                cmd.Parameters.AddWithValue("@BornTown", txtTownBorn.Text);
                cmd.Parameters.AddWithValue("@City", txtCity.Text);
                cmd.Parameters.AddWithValue("@District", txtDistrict.Text);
                cmd.Parameters.AddWithValue("@BirthDate", DateTime.Parse(txtBorn.Text));
                cmd.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("Edit successful!", "Message", MessageBoxButtons.OK);
                Reset();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            try
            {
                if (!CheckEGN())
                {
                    throw new ArgumentException(Messages.EGNExist);
                }
                if (!ValidateBirthDate())
                {
                    throw new ArgumentException(Messages.InvalidDate);
                }
                //SqlConnection cn = new SqlConnection(@"Server=IVO03_HELIOS\SQLEXPRESS;Database=School;Integrated Security = True");
                SqlConnection cn = new SqlConnection(@"Server=IVO_LAPTOP\SQLEXPRESS;Database=School;Integrated Security = True");
                cn.Open();
                string queryString = "INSERT INTO Students VALUES (@Name,@Surname,@Family,@Email,@EGN,@BirthDate,@BornTown,@City,@District)";
                SqlCommand cmd = new SqlCommand(queryString, cn);
                //cmd.Parameters.AddWithValue("@ID", txtID.Text);
                cmd.Parameters.AddWithValue("@Name", txtName.Text);
                cmd.Parameters.AddWithValue("@Surname", txtSurname.Text);
                cmd.Parameters.AddWithValue("@Family", txtFamily.Text);
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@EGN", txtEGN.Text);
                cmd.Parameters.AddWithValue("@BirthDate", DateTime.Parse(txtBorn.Text));
                cmd.Parameters.AddWithValue("@BornTown", txtTownBorn.Text);
                cmd.Parameters.AddWithValue("@City", txtCity.Text);
                cmd.Parameters.AddWithValue("@District", txtDistrict.Text);

                cmd.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("New student has been registered!", "Message", MessageBoxButtons.OK);
                Reset();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void txtTownBorn_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            /*
            using (SqlConnection cn = new SqlConnection(@"Server=IVO_LAPTOP\SQLEXPRESS;Database=School;Integrated Security = True;"))
            {
                cn.Open();
                string query = "DELETE FROM Students WHERE ID = @ID";
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@ID", int.Parse(txtID.Text));
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

                // Delete the student
                string deleteQuery = "DELETE FROM Students WHERE ID = @ID";
                using (SqlCommand cmd = new SqlCommand(deleteQuery, cn))
                {
                    cmd.Parameters.AddWithValue("@ID", int.Parse(txtID.Text));
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("The record was successfully deleted!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Reset();

                        // OPTIONAL: Reset identity to the MAX(ID)
                        string reseedQuery = "DECLARE @maxId INT = ISNULL((SELECT MAX(ID) FROM Students), 0); " +
                                             "DBCC CHECKIDENT ('Students', RESEED, @maxId)";
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
