using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace ams_sample
{
    public class Database
    {

        const string conn_str = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\khest\\Documents\\C#\\app_dev\\ams-sample\\db\\db_attendance.mdb";
        private OleDbConnection connection;

        public Database()
        {
            this.connection = new OleDbConnection(conn_str);
        }


        public OleDbConnection Connection
        {
           get { return connection;}
        }





        // student query functions
        public void get_all_students(OleDbConnection conn)
        {

        }

        public void add_student(OleDbConnection conn)
        {
            
        }

        public void update_student(OleDbConnection conn)
        {

        }

        public void remove_student(OleDbConnection conn)
        {

        }

        // Attendance query functions

        public void get_all_attendances(OleDbConnection conn)
        {

        }

        public void add_attendance(OleDbConnection conn)
        {

        }

        public void update_attendance(OleDbConnection conn)
        {

        }

        public void remove_attaendance(OleDbConnection conn)
        {

        }


    }
}
