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
    public partial class frmAddDetails : Form
    {
        
        
        public frmAddDetails()
        {
            InitializeComponent();
        }
        public string filePath;
        public bool fileAcknowledgement;
        private void btnChoose_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog file = new OpenFileDialog();
            if (file.ShowDialog() == DialogResult.OK)
            {
                filePath = file.FileName;
                fileAcknowledgement = true;
            }
            else { fileAcknowledgement = false; }

        }

        private bool emptyFields()
        {
            if (tbxCategory.Text == "" || richTextBoxDescription.Text == "" || fileAcknowledgement==false)
            {
                return true;
            }
            return false;
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            if (emptyFields())
            {
                MessageBox.Show("Please fill all the fields... Dankeschööön!");
                return;
            }
            AppList list = new AppList(filePath, tbxCategory.Text, richTextBoxDescription.Text);
            GUI.frmMain frmMain=new GUI.frmMain();
            frmMain.addAppList(list);

            this.Hide();
            frmMain.Closed += (s, args) => this.Close();
            frmMain.Show();
        }

        private void richTextBoxDescription_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
