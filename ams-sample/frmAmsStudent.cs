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
            this.frmMain.Show();
            this.Close();
            
        }
    }
}
