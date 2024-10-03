using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Data;

namespace ams_sample
{
    public class Database
    {

        const string conn_str = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\khest\\Documents\\C#\\app_dev\\ams-sample\\db\\db_attendance.mdb";
        private OleDbConnection connection;
        private OleDbCommand command;
        private OleDbDataAdapter adapter;

        private DateTime date_now;

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

        public void add_student(int id_number, string fname, string lname, string program, int year, OleDbConnection conn)
        {
            
        }

        public void update_student(int id_number, string fname, string lname, string program, int year, OleDbConnection conn)
        {

        }

        public void remove_student(int id_number, OleDbConnection conn)
        {

        }

        // Attendance query functions



        public void get_all_attendances(OleDbConnection conn, DataTable dt, DataGridView grdData)
        {

            string query = "select id_num as ID_Number, time_status as Time_Status, time_attend as Time_Attended from attendances";

            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }

            using (command = new OleDbCommand(query, conn))
            {

                using (adapter = new OleDbDataAdapter(command))
                {
                    adapter.Fill(dt);
                    grdData.DataSource = dt;

                }
            }

        }

        public void add_attendance(int id_number, string time_status, OleDbConnection conn)
        {
            // Guard clause
            if (!is_id_num_exist(id_number, conn))
            {
                MessageBox.Show($"Student Number {id_number} does not exist!", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            // Main code
            string query = "INSERT INTO attendances (id_num, time_status, time_attend) VALUES (?, ?, ?)";

            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }

            using (command = new OleDbCommand(query, conn))
            {
                command.Parameters.AddWithValue("?", id_number);
                command.Parameters.AddWithValue("?", time_status);
                command.Parameters.AddWithValue("?", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));

                int res = command.ExecuteNonQuery();
                if (res != 0)
                {
                    DialogResult dgRes = MessageBox.Show("Attendance Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Failed to add to the Database", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

                conn.Close();
            }
        }

        //public void update_attendance(OleDbConnection conn)
        //{

        //}

        public void remove_attaendance(int idx, OleDbConnection conn)
        {

        }

        public void clear_all_attendance(OleDbConnection conn)
        {
            string query = "DELETE FROM attendances";

            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }

            using (command = new OleDbCommand(query, conn))
            {
                int res = command.ExecuteNonQuery();
                if (res != 0)
                {
                    DialogResult dgRes = MessageBox.Show("Attendance Cleared Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Failed to clear the Attendance", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                conn.Close();
            }
        }

        // Helper function
        
        private bool is_id_num_exist(int id_num, OleDbConnection conn)
        {

            string query = "Select * from students where id_num=?";

            using (command = new OleDbCommand(query, conn))
            {

                command.Parameters.AddWithValue("?", id_num);

                using (OleDbDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        int count = reader.GetInt32(0);
                        return true;
                    }
                }
            }

            return false;
        }



    }
}
