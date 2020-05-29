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
    public partial class HistoryReports : Form
    {
        public HistoryReports()
        {
            InitializeComponent();
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
            cmd.CommandText = "SELECT * FROM REPORTS";
            cmd.Connection = ccn;
            adapt.SelectCommand = cmd;
            //adapt.Fill(dt);
            adapt = new SQLiteDataAdapter("select * from REPORTS", ccn);
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;

        }
        private void HistoryReports_Load(object sender, EventArgs e)
        {
            ShowAllBook();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string searchresult = searchbox.Text;

            SQLiteConnection ccn;
            ccn = new SQLiteConnection(); // Create an instance of the object
            ccn.ConnectionString = "Data Source=./db.db;Version=3;New=True;Compress=True;"; // Set the ConnectionString
            SQLiteCommand cmd = new SQLiteCommand(ccn);
            ccn.Open();
            cmd.CommandText = "select * from REPORTS where ABSENCE_STUDENT like '" + searchresult + "%'";
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

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Refresh();
            //Get All Records of tbBooks 
            ShowAllBook();
        }
    }
}
