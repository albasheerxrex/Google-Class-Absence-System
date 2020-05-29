using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Google_Class_Absence_System
{
    public partial class AddReport : Form
    {
        public AddReport()
        {
            InitializeComponent();
        }
        List<string> studentEmailFromExcel = new List<string>();
        List<string> E1 = new List<string>();
        List<string> E2 = new List<string>();
        List<string> E3 = new List<string>();
        List<string> E4 = new List<string>();
        List<string> M1 = new List<string>();
        List<string> M2 = new List<string>();
        List<string> M3 = new List<string>();
        List<string> M4 = new List<string>();
        List<string> selectedstageinfo= new List<string>();
        List<string> abcence = new List<string>();
        List<string> reportStudents = new List<string>();
        private void button1_Click(object sender, EventArgs e)
        {
           

            string fname = "";
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = "Excel File Dialog";
           
            fdlg.Filter = "CSV files (*.csv)|*.csv|Excel Files|*.xls;*.xlsx";
            fdlg.FilterIndex = 2;
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                fname = fdlg.FileName;
            }
            label3.Text = fname;


            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(fname);
            Microsoft.Office.Interop.Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            Microsoft.Office.Interop.Excel.Range xlRange = xlWorksheet.UsedRange;

            int rowCount = xlRange.Rows.Count;
            int colCount = xlRange.Columns.Count;

            for (int i = 1; i <= rowCount; i++)
            {
                for (int j = 2; j <= 2; j++)
                {
                    
              

                    if (xlRange.Cells[i, j] != null && xlRange.Cells[i, j].Value2 != null)
                    {

                        studentEmailFromExcel.Add(xlRange.Cells[i, j].Value2.ToString());
                        foreach (string x in studentEmailFromExcel)
                        {
                            reportStudents.Add(x);

                           
                        }
                        
                    }
                         
                }
            }
           List<string> a = new List<string>();
            foreach (string stednt in selectedstageinfo)
                
                {
               
                foreach (string reportResult in reportStudents)
                {


                    if (stednt  == reportResult)
                    {
                        a.Add(stednt);
                    }
                    

                }

            }
            foreach(var abs in selectedstageinfo) { 
            foreach (var attendent in a) { 
                if (attendent != abs)
                {
                        abcence.Add(abs);
                }
            }
            }
            foreach (string k in abcence)
            {
                Console.WriteLine(k);
            }
            GC.Collect();
            GC.WaitForPendingFinalizers();
            Marshal.ReleaseComObject(xlRange);
            Marshal.ReleaseComObject(xlWorksheet); 
            xlWorkbook.Close();
            Marshal.ReleaseComObject(xlWorkbook); 
            xlApp.Quit();
            Marshal.ReleaseComObject(xlApp);
            if (selectstudy.SelectedItem == null)
            {
                MessageBox.Show("Please Select a Stage");
            }
            MessageBox.Show("File Secssfully Added", "File Imported", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void AddReport_Load(object sender, EventArgs e)
        {

            SQLiteConnection ccn;
            ccn = new SQLiteConnection(); // Create an instance of the object
            ccn.ConnectionString = "Data Source=./db.db;Version=3;New=True;Compress=True;"; // Set the ConnectionString
            SQLiteCommand cmd = new SQLiteCommand(ccn);
            ccn.Open();
            cmd.CommandText = "SELECT STUDENT_EMAIL FROM STUDENTS WHERE STUDENT_STUDY = 'Evening' AND STUDENT_GRADE = '1'"
;
            try
            {
                DataSet ds = new DataSet();
                var da = new SQLiteDataAdapter(cmd);
                da.Fill(ds);
                SQLiteDataReader dr = cmd.ExecuteReader();
             
                while (dr.Read())
                {
                    E1.Add(dr.GetValue(0).ToString());
                }

           
                dr.Close();
                
            }
            catch (Exception)
            {
                throw;
            }
            cmd.CommandText = "SELECT STUDENT_EMAIL FROM STUDENTS WHERE STUDENT_STUDY = 'Evening' AND STUDENT_GRADE = '2'"
;
            try
            {
                DataSet ds = new DataSet();
                var da = new SQLiteDataAdapter(cmd);
                da.Fill(ds);
                SQLiteDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    E2.Add(dr.GetValue(0).ToString());
                }

                dr.Close();
            }
            catch (Exception)
            {
                throw;
            }
            cmd.CommandText = "SELECT STUDENT_EMAIL FROM STUDENTS WHERE STUDENT_STUDY = 'Evening' AND STUDENT_GRADE = '3'"
;
            try
            {
                DataSet ds = new DataSet();
                var da = new SQLiteDataAdapter(cmd);
                da.Fill(ds);
                SQLiteDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    E3.Add(dr.GetValue(0).ToString());
                }

               
                dr.Close();
            }
            catch (Exception)
            {
                throw;
            }
            cmd.CommandText = "SELECT STUDENT_EMAIL FROM STUDENTS WHERE STUDENT_STUDY = 'Evening' AND STUDENT_GRADE = '4'"
;
            try
            {
                DataSet ds = new DataSet();
                var da = new SQLiteDataAdapter(cmd);
                da.Fill(ds);
                SQLiteDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    E4.Add(dr.GetValue(0).ToString());
                }

              
                dr.Close();
            }
            catch (Exception)
            {
                throw;
            }
            cmd.CommandText = "SELECT STUDENT_EMAIL FROM STUDENTS WHERE STUDENT_STUDY = 'Day Study' AND STUDENT_GRADE = '4'"
;
            try
            {
                DataSet ds = new DataSet();
                var da = new SQLiteDataAdapter(cmd);
                da.Fill(ds);
                SQLiteDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    M4.Add(dr.GetValue(0).ToString());
                }

            
                dr.Close();
            }
            catch (Exception)
            {
                throw;
            }
            cmd.CommandText = "SELECT STUDENT_EMAIL FROM STUDENTS WHERE STUDENT_STUDY = 'Day Study' AND STUDENT_GRADE = '3'"
;
            try
            {
                DataSet ds = new DataSet();
                var da = new SQLiteDataAdapter(cmd);
                da.Fill(ds);
                SQLiteDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    M3.Add(dr.GetValue(0).ToString());
                }


                dr.Close();
            }
            catch (Exception)
            {
                throw;
            }
            cmd.CommandText = "SELECT STUDENT_EMAIL FROM STUDENTS WHERE STUDENT_STUDY = 'Day Study' AND STUDENT_GRADE = '2'"
;
            try
            {
                DataSet ds = new DataSet();
                var da = new SQLiteDataAdapter(cmd);
                da.Fill(ds);
                SQLiteDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    M2.Add(dr.GetValue(0).ToString());
                }


                dr.Close();
            }
            catch (Exception)
            {
                throw;
            }
            cmd.CommandText = "SELECT STUDENT_EMAIL FROM STUDENTS WHERE STUDENT_STUDY = 'Day Study' AND STUDENT_GRADE = '1'"
;
            try
            {
                DataSet ds = new DataSet();
                var da = new SQLiteDataAdapter(cmd);
                da.Fill(ds);
                SQLiteDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    M1.Add(dr.GetValue(0).ToString());
                }
              

                dr.Close();
            }
            catch (Exception)
            {
                throw;
            }

            ccn.Close();
           
           
         

        }

        private void selectstudy_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }

        private void button4_Click(object sender, EventArgs e)
        {
          
            if(selectstudy.SelectedItem.ToString()== "1ST-M")
            {
                selectedstageinfo = M1;
                MessageBox.Show("You Selected 1ST-M");
            }
            if (selectstudy.SelectedItem.ToString() == "2SE-M")
            {
                selectedstageinfo = M2;
                MessageBox.Show("You Selected 2SE-M");
            }
            if (selectstudy.SelectedItem.ToString() == "3TH-M")
            {
                selectedstageinfo = M3;
                MessageBox.Show("You Selected 3TH-M");
            }
            if (selectstudy.SelectedItem.ToString() == "4TH-M")
            {
                selectedstageinfo = M4;
                MessageBox.Show("You Selected 4TH-M");
            }
            if (selectstudy.SelectedItem.ToString() == "1ST-E") 
            {
                selectedstageinfo = E1;
                MessageBox.Show("You Selected 1ST-E");
            }
            if (selectstudy.SelectedItem.ToString() == "2SE-E")
            {
                selectedstageinfo = E2;
                MessageBox.Show("You Selected 2SE-E");
            }
            if (selectstudy.SelectedItem.ToString() == "3TH-E")
            {
                selectedstageinfo = E3;
                MessageBox.Show("You Selected 3TH-E");
            }
            if (selectstudy.SelectedItem.ToString() == "4TH-E")
            {
                selectedstageinfo =E4;
                MessageBox.Show("You Selected 4TH-E");
            }
            if (selectstudy.SelectedItem == null)
            {
                MessageBox.Show("Please Select a Stage");
            }
            if (selectstudy.SelectedItem == null)
            {
                MessageBox.Show("Please select a stage");
            }
        }

        private void AddReportButtem_Click(object sender, EventArgs e)
        {
            if (selectstudy.SelectedItem == null)
            {
                MessageBox.Show("Please Select a Stage");
            }
            if (label3.Text == "")
            {
                MessageBox.Show("Please Add an Excel File First");
            }
            string reportdate = DateTime.Now.ToString("yyyy-MM-dd");
            string email = "";
            string stage = "";
            string study = "";

            if (selectstudy.SelectedItem.ToString() == "1ST-M")
            {
               stage = "1";
               study = "Day Study";
            }
            if (selectstudy.SelectedItem.ToString() == "2SE-M")
            {
                stage = "2";
                study = "Day Study";
            }
            if (selectstudy.SelectedItem.ToString() == "3TH-M")
            {
                stage = "3";
                study = "Day Study";
            }
            if (selectstudy.SelectedItem.ToString() == "4TH-M")
            {
                stage = "4";
                study = "Day Study";
            }
            if (selectstudy.SelectedItem.ToString() == "1ST-E")
            {
                
                   stage = "1";
                study = "Evening";
            }
            if (selectstudy.SelectedItem.ToString() == "2SE-E")
            {
                stage = "2";
                study = "Evening";
            }
            if (selectstudy.SelectedItem.ToString() == "3TH-E")
            {
                stage = "3";
                study = "Evening";
            }
            if (selectstudy.SelectedItem.ToString() == "4TH-E")
            {
                stage = "4";
                study = "Evening";
            }
            if (selectstudy.SelectedItem == null)
            {
                MessageBox.Show("Please Select a Stage");
            }
            if (selectstudy.SelectedItem == null)
            {
                MessageBox.Show("Please select a stage");
            }




            SQLiteConnection ccn;
            ccn = new SQLiteConnection(); // Create an instance of the object
            ccn.ConnectionString = "Data Source=./db.db;Version=3;New=True;Compress=True;"; // Set the ConnectionString
            SQLiteCommand cmd = new SQLiteCommand(ccn);
            ccn.Open(); // Open the connection. Now you can fire SQL-Queries
            foreach (string em in abcence)
            {
                cmd.CommandText = "INSERT INTO REPORTS(ABSENCE_STUDENT,GRADE,STUDY,REPORT_TIME) VALUES (@student, @grade,@study,@time)";
                cmd.Parameters.AddWithValue("@student", em);
                cmd.Parameters.AddWithValue("@grade", stage);
                cmd.Parameters.AddWithValue("@study", study);
                cmd.Parameters.AddWithValue("@time", reportdate);

                cmd.ExecuteNonQuery();
               
            }
          

            ccn.Close();
            MessageBox.Show("Report Added Secssfuly", "Done !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            foreach (var x in abcence)
            {
                Console.WriteLine(x);
            }
            //var source = new BindingSource();
            //source.DataSource = abcence;
            //dataGridView1.DataSource = source;
            //dataGridView1.AutoGenerateColumns = true;

            //dataGridView1.Refresh();


        }

        private void Closebutton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
      
        }
    
