using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Google_Class_Absence_System
{
    public partial class student : Form
    {
        public student()
        {
            InitializeComponent();
        }

        private void submitloan_Click(object sender, EventArgs e)
        {
            foreach (Control obj in panel1.Controls)
            {
                if (obj is TextBox)
                {
                    if (obj.Text == "")
                    {
                        MessageBox.Show("Please Fill all the form", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                }
            }
           
           
            string name = usernametext.Text;
            string email = useremail.Text;
            string stage ="";
            string study = "";
            if (ST1.Checked==true) {
                stage = "1";
            }
            if (SEC2.Checked == true)
            {
                stage = "2";
            }
            if (THRD3.Checked == true)
            {
                stage = "3";
            }
            if (RTH4.Checked == true)
            {
                stage = "4";
            }
            if (radioButton2.Checked == true)
            {
                study = "Evening";
            }
            if (radioButton1.Checked == true)
            {
                study = "Day Study";
            }



          
            SQLiteConnection ccn;
            ccn = new SQLiteConnection(); // Create an instance of the object
            ccn.ConnectionString = "Data Source=./db.db;Version=3;New=True;Compress=True;"; // Set the ConnectionString
            SQLiteCommand cmd = new SQLiteCommand(ccn);
            ccn.Open(); // Open the connection. Now you can fire SQL-Queries
            cmd.CommandText = "INSERT INTO STUDENTS(STUDENT_NAME,STUDENT_EMAIL,STUDENT_GRADE,STUDENT_STUDY) VALUES (@name, @email,@stage,@study)";
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@stage", stage);
            cmd.Parameters.AddWithValue("@study", study);
            cmd.ExecuteNonQuery();
            ccn.Close();
            MessageBox.Show("Student Add Secssfuly", "Done !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            foreach (Control obj in panel1.Controls)
            {
                if (obj is TextBox)
                {
                    if (obj.Text != "")
                    {
                        obj.Text = "";
                    }
                }
            }
            dataGridView1.Refresh();
            //Get All Records of tbBooks 
            ShowAllBook();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string searchresult = searchbox.Text;

            SQLiteConnection ccn;
            ccn = new SQLiteConnection(); // Create an instance of the object
            ccn.ConnectionString = "Data Source=./db.db;Version=3;New=True;Compress=True;"; // Set the ConnectionString
            SQLiteCommand cmd = new SQLiteCommand(ccn);
            ccn.Open();
            cmd.CommandText = "select * from STUDENTS where STUDENT_NAME like '" + searchresult + "%'";
            try
            {
                DataSet ds = new DataSet();
                var da = new SQLiteDataAdapter(cmd);
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0].DefaultView;
            }
            catch (Exception)
            {
                throw;
            }
            ccn.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
        }
        public void ShowAllBook()
        {

            SQLiteDataAdapter adapt = new SQLiteDataAdapter();
            DataTable dt = new DataTable();
            SQLiteConnection ccn;
            ccn = new SQLiteConnection(); // Create an instance of the object
            ccn.ConnectionString = "Data Source=./db.db;Version=3;New=True;Compress=True;"; // Set the ConnectionString
            SQLiteCommand cmd = new SQLiteCommand(ccn);
            ccn.Open();

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM STUDENTS";
            cmd.Connection = ccn;
            adapt.SelectCommand = cmd;
            //adapt.Fill(dt);
            adapt = new SQLiteDataAdapter("select * from STUDENTS", ccn);
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;

        }
        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void student_Load(object sender, EventArgs e)
        {
            //Update Sql Table
            dataGridView1.Refresh();
            //Get All Records of tbBooks 
            ShowAllBook();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            dataGridView1.Refresh();
            //Get All Records of tbBooks 
            ShowAllBook();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
