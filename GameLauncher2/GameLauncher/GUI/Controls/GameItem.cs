using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameLauncher.GUI.Controls
{
    public partial class GameItem : UserControl
    {
        public GameItem()
        {
            //if (Program.IsInDesignMode()) return;

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
    }
}