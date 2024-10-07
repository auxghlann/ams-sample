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

        // Add and update forms

        crud_frm_for_students.frmAddStudent frmAddStudent;
        crud_frm_for_students.frmUpdateStudent frmUpdateStudent;


        // Selected row of gridData holder
        private int selected_id_num, selected_year;
        private string selected_fName, selected_lName, selected_program;


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



        private void grdData_SelectionChanged(object sender, EventArgs e)
        {

            if (grdData.SelectedRows.Count > 0)
            {

                var selectedRow = grdData.SelectedRows[0].DataBoundItem as DataRowView;

                if (selectedRow != null)
                {
                    btnDel.Enabled = true;
                    btnUpdate.Enabled = true;

                    this.selected_id_num = Convert.ToInt32(selectedRow["ID_number"]);
                    this.selected_fName = selectedRow["First_Name"].ToString();
                    this.selected_lName = selectedRow["Last_Name"].ToString();
                    this.selected_program = selectedRow["Program"].ToString();
                    this.selected_year = Convert.ToInt16(selectedRow["Year_Level"]);

                }


            }
        }

        private void frmAmsStudent_Load(object sender, EventArgs e)
        {
            fill_student_dataGrid();
            btnUpdate.Enabled = false;
            btnDel.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddStudent = new crud_frm_for_students.frmAddStudent(_db);
            frmAddStudent.ShowDialog();
            fill_student_dataGrid();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmUpdateStudent = new crud_frm_for_students.frmUpdateStudent(selected_id_num, selected_fName, 
                selected_lName, selected_program, selected_year, _db);

            frmUpdateStudent.ShowDialog();
            fill_student_dataGrid();
        }
    }
}
