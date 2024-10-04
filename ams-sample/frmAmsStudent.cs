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
        public frmAmsStudent(frmAmsMain mainForm)
        {
            InitializeComponent();
            this.frmMain = mainForm;
        }

        

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
    }
}
