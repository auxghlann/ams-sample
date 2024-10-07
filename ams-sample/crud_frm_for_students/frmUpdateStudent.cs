using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ams_sample.crud_frm_for_students
{
    public partial class frmUpdateStudent : Form
    {

        private Database _db;


        // Selected row of gridData holder
        private int selected_id_num, selected_year;
        private string selected_fName, selected_lName, selected_program;

        public frmUpdateStudent(int id_num, string fname, string lname, string program, int year, Database db)
        {
            InitializeComponent();
            InitializeProgramCBO();
            InitializeYearCBO();
            this.selected_id_num = id_num;
            this.selected_fName = fname;
            this.selected_lName = lname;
            this.selected_program = program;
            this.selected_year = year;
            this._db = db;
        }


        // Helper function

        private void InitializeProgramCBO()
        {
            cboProgram.Items.Add("BSCS");
            cboProgram.Items.Add("BSIT");
        }


        private void InitializeYearCBO()
        {
            cboYear.Items.Add("1");
            cboYear.Items.Add("2");
            cboYear.Items.Add("3");
            cboYear.Items.Add("4");
        }


        // WinForm FUnctions
        private void frmUpdateStudent_Load(object sender, EventArgs e)
        {
            this.txtIdNum.Text = selected_id_num.ToString();
            this.txtFName.Text = selected_fName;
            this.txtLName.Text = selected_lName;
            this.cboProgram.Text = selected_program;
            this.cboYear.Text = selected_year.ToString();

        }




        private void btnSave_Click(object sender, EventArgs e)
        {
            _db.update_student(Convert.ToInt32(txtIdNum.Text), txtFName.Text, txtLName.Text, 
                        cboProgram.Text, Convert.ToInt16(cboYear.Text), this._db.Connection);
            this.Close();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }




    }
}
