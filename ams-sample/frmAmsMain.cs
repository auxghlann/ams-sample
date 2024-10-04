using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace ams_sample
{
    public partial class frmAmsMain : Form
    {
        public frmAmsMain()
        {
            InitializeComponent();
        }

        Database _db = new Database();

        private OleDbCommand command;
        private OleDbDataAdapter adapter;
        private DataTable dt;

        private int selected_id_num = -1;


        // Forms
        private frmAmsStudent frmStudent;


        // Helper Functions

        private void fill_dataGrid()
        {
            _db.get_all_attendances(_db.Connection, dt = new DataTable(), grdData);
        }

        private string get_time_status()
        {
            string time_status = "";

            if (rdrTimeIn.Checked)
            {
                time_status = rdrTimeIn.Text;
            }
            else if (rdrTimeOut.Checked) { }
            {
                time_status = rdrTimeOut.Text;
            }


            return time_status;
        }

        // WinForm functions

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtIDnumber.Text) || !(rdrTimeIn.Checked || rdrTimeOut.Checked))
            {
                MessageBox.Show("Id Number and Time Status should not be empty", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int id_number = Convert.ToInt32(txtIDnumber.Text);
            string time_status = get_time_status();

            _db.add_attendance(id_number, time_status, _db.Connection);

            fill_dataGrid();

        }

        private void frmAms_Load(object sender, EventArgs e)
        {
            fill_dataGrid();
            btnDel.Enabled = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtIDnumber.Clear();
            rdrTimeOut.Checked = false;
            rdrTimeIn.Checked = false;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {

            DialogResult dg = MessageBox.Show("Are you sure you want to delete the selected record?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dg == DialogResult.Yes)
            {
                _db.remove_attendance(selected_id_num, _db.Connection);
            }

        }

        private void toolStripClearAttendance_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Do you want to clear the attendance?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.Yes)
            {
                DialogResult res2 = MessageBox.Show("Doing this action will delete all the attendance from the database. Do you want to proceed?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);


                if (res2 == DialogResult.Yes)
                {
                    _db.clear_all_attendance(_db.Connection);
                    fill_dataGrid();
                }

            }
        }

        private void grdData_SelectionChanged(object sender, EventArgs e)
        {

            if (grdData.SelectedRows.Count > 0)
            {

                var selectedRow = grdData.SelectedRows[0].DataBoundItem as DataRowView;
                
                if (selectedRow != null)
                {
                    btnDel.Enabled = true;

                    this.selected_id_num = Convert.ToInt32(selectedRow["ID_number"]);
                }


            }
        }

        private void toolStripManageStudent_Click(object sender, EventArgs e)
        {
            frmStudent = new frmAmsStudent(this);
            frmStudent.Show();
            this.Hide();
            
            
            
        }

        private void frmAmsMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dg = MessageBox.Show("Are you sure you want to close the app?", "Confirmation", MessageBoxButtons.YesNo);
            if (dg == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
