using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppManagement
{
    public partial class frmDone : Form
    {
        public frmDone()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Hide();
            var frmMain = new GUI.frmMain();
            frmMain.Closed += (s, args) => this.Close();
            frmMain.Show();
        }
    }
}
