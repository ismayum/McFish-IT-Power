using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameLauncher.GUI.Pages
{
    public partial class PageGames : UserControl
    {
        public PageGames()
        {
            if (Program.IsInDesignMode()) return;
            InitializeComponent();
        }
    }
}