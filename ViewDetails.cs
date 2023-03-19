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
    public partial class frmViewDetails : Form
    {
        private List<AppList> newApp;

        public frmViewDetails()
        {
            InitializeComponent();
        }

        public frmViewDetails(List<AppList> newApp)
        {
            InitializeComponent();
            this.newApp = newApp;
            foreach (AppList item in newApp)
            {
                lbPath.Text += item.appPath;
                lbCate.Text += item.category;
                lbDescrip.Text += item.description;
            }
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
