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
    public partial class frmAddStudent : Form
    {
        private Database _db;
        public frmAddStudent(Database db)
        {
            InitializeComponent();
            this._db = db;
        }

        // Helper Functions

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

        // WinForm Functions

        private void frmAddStudent_Load(object sender, EventArgs e)
        {
            InitializeProgramCBO();
            InitializeYearCBO();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            _db.add_student(Convert.ToInt32(txtIdNum.Text), txtFName.Text, txtLName.Text, cboProgram.Text, Convert.ToInt16(cboYear.Text), _db.Connection);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
