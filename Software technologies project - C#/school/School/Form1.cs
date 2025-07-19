
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace School
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static object schData { get; internal set; }

        private void Form1_Load(object sender, EventArgs e)
        {
            pbLogo.Image = Image.FromFile(@"C:\Users\iwail\Desktop\SQL+VS\school5\EmbeddedImage.jpg");
            //SqlConnection cn = new SqlConnection(@"Server=IVO03_HELIOS\SQLEXPRESS;Database=School;Integrated Security = True");
            SqlConnection cn = new SqlConnection(@"Server=IVO_LAPTOP\SQLEXPRESS;Database=School;Integrated Security = True");
            string queryString =
                "SELECT Name, Patron, City, District, Address, Website, Telephon FROM SchoolData";
            SqlCommand cmd = new SqlCommand(queryString, cn);
            cn.Open();
            using (SqlDataReader sqlDataReader = cmd.ExecuteReader())
            {
                if (sqlDataReader.Read())
                {
                    lblName.Text = sqlDataReader["Name"].ToString();
                    lblPatron.Text = sqlDataReader["Patron"].ToString();
                    lblCity.Text = sqlDataReader["City"].ToString();
                    lblDistrict.Text = sqlDataReader["District"].ToString();
                    lblAddress.Text = sqlDataReader["Address"].ToString(); 
                    lblWebpage.Text = sqlDataReader["Website"].ToString();
                    lblTelephone.Text = sqlDataReader["Telephon"].ToString();
                }
            }
        }

        private void btnStudents_Click(object sender, EventArgs e)
        {
            listBox1.Visible = true;
            listBox1.Items.Clear();
            //SqlConnection cn = new SqlConnection(@"Server=IVO03_HELIOS\SQLEXPRESS;Database=School;Integrated Security = True");
            SqlConnection cn = new SqlConnection(@"Server=IVO_LAPTOP\SQLEXPRESS;Database=School;Integrated Security = True");
            string queryString = "SELECT * FROM Students";
            SqlCommand cmd = new SqlCommand(queryString, cn);
            cn.Open();
            using (SqlDataReader sqlDataReader = cmd.ExecuteReader())
            {
                while (sqlDataReader.Read())
                {
                    listBox1.Items.Add(sqlDataReader["ID"] + " " + sqlDataReader["Name"] + " " + sqlDataReader["Surname"] + " " + sqlDataReader["Family"]);
                }
            }
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Form2 f = new Form2();
            f.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Form3 f = new Form3();
            f.Show();
        }

        private void btnTeachers_Click(object sender, EventArgs e)
        {
            listBox2.Visible = true;
            listBox2.Items.Clear();
            //SqlConnection cn = new SqlConnection(@"Server=IVO03_HELIOS\SQLEXPRESS;Database=School;Integrated Security = True");
            SqlConnection cn = new SqlConnection(@"Server=IVO_LAPTOP\SQLEXPRESS;Database=School;Integrated Security = True");
            string queryString = "SELECT * FROM Teachers";
            SqlCommand cmd = new SqlCommand(queryString, cn);
            cn.Open();
            using (SqlDataReader sqlDataReader = cmd.ExecuteReader())
            {
                while (sqlDataReader.Read())
                {
                    listBox2.Items.Add(sqlDataReader["ID"] + " " + sqlDataReader["FirstName"] + " " + sqlDataReader["LastName"] + "-" + sqlDataReader["Subject1"] + "-" + sqlDataReader["Subject2"]);
                }
            }
        }

        private void btnExams_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 f = new Form4();
            f.Show();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
