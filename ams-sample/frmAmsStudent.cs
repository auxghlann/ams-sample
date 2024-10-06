using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ams_sample
{
    public partial class frmAmsStudent : Form
    {

        private frmAmsMain frmMain;
        private Database _db;
        private DataTable dt;

        public frmAmsStudent(frmAmsMain mainForm, Database db)
        {
            InitializeComponent();
            this.frmMain = mainForm;
            this._db = db;
        }



        // Helper Functions

        private void fill_student_dataGrid()
        {
            _db.get_all_students(_db.Connection, dt = new DataTable(), grdData);
        }


        // WinForm Functions

        private void toolStripManageAttendance_Click(object sender, EventArgs e)
        {
            
            this.Close();
            this.frmMain.Show();

        }

 

        private void frmAmsStudent_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dg = MessageBox.Show("Are you sure you want to close the manage student form?", "Confirmation", MessageBoxButtons.YesNo);
            if (dg == DialogResult.No)
            {
                e.Cancel = true;
                return;
            }

            this.frmMain.Show();

        }

        private void frmAmsStudent_Load(object sender, EventArgs e)
        {
            fill_student_dataGrid();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            crud_frm_for_students.frmAddStudent frmAddStudent = new crud_frm_for_students.frmAddStudent(_db);
            frmAddStudent.ShowDialog();
            fill_student_dataGrid();
        }
    }
}
