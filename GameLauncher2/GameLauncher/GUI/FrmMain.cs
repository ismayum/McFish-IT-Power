using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace GameLauncher.GUI
{
    public partial class FrmMain : MaterialForm
    {
        public FrmMain()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Grey800, Primary.Grey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void sideMenu_OnItemSelected(object sender, string path, EventArgs e)
        {
            if (path.ToString().Trim() == "Settings" || path.ToString().Trim() == "Info")
            {
                pages.SetPage(path.ToString().Trim());
            }
            else
            {
                pages.SetPage("Games");
            }
        }

        private void sideMenu_SizeChanged(object sender, EventArgs e)
        {
            line.Left = sideMenu.Right + 1;
        }
    }
}