using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Google_Class_Absence_System
{
    class sqlccn
    {
        public sqlccn()
        {
            SQLiteConnection ccn = new SQLiteConnection(); 
            ccn.ConnectionString = "Data Source=./db.db;Version=3;New=True;Compress=True;"; 
            SQLiteCommand cmd = new SQLiteCommand(ccn);
            ccn.Open();

            //MessageBox.Show("Db connected");
            ccn.Close();
        }
    }
}
