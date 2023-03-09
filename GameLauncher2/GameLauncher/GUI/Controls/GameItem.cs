using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;


namespace GameLauncher.GUI.Controls
{
    public partial class GameItem : UserControl
    {

        private string selectedApplicationPath;
        public GameItem()
        {

            InitializeComponent();
        }

        public Image Image
        {
            get => pictureBox1.Image;
            set => pictureBox1.Image = value;
        }

        public string Title
        {
            get => label1.Text;
            set => label1.Text = value;
        }

        public string Category
        {
            get => label2.Text;
            set => label2.Text = value;
        }

        private void GameItem_Load(object sender, EventArgs e)
        {
            this.BackColor = label1.BackColor = label2.BackColor = bunifuImageButton1.BackColor = bunifuImageButton2.BackColor = Color.FromArgb(66, 66, 66);
        }

        private void init_Tick(object sender, EventArgs e)
        {
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(selectedApplicationPath))
            {
                Process.Start(selectedApplicationPath);
            }
            else
            {
                MessageBox.Show("Please select an application first.");
            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Applications (*.exe)|*.exe";
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    selectedApplicationPath = openFileDialog.FileName;
                    string appName = Path.GetFileNameWithoutExtension(selectedApplicationPath);
                    label1.Text = appName;

                    selectedApplicationPath = openFileDialog.FileName;
                    Icon appIcon = Icon.ExtractAssociatedIcon(selectedApplicationPath);
                    pictureBox1.Image = appIcon.ToBitmap();
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
