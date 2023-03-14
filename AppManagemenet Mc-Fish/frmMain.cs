using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppManagement.GUI
{
    public partial class frmMain : Form
    {
        List<AppList> apps;
        FileHandle filehandle;
        private PictureBox pic;

        public frmMain()
        {
            filehandle = new FileHandle();
            apps = filehandle.readFile();
 
            InitializeComponent();

        }


        public void addAppList(AppList applist)
        { 
            apps.Add(applist);
            filehandle.addApps(applist, apps.Count);
        } 

        public void viewList()
        {
            foreach (AppList item in apps)
            {
                pic = new PictureBox();
                pic.Width = 180;
                pic.Height = 150;
                pic.BackgroundImageLayout = ImageLayout.Stretch;
                pic.BorderStyle = BorderStyle.FixedSingle;


                Label pil = new Label();
                pil.Text = item.category;
                pil.Width = 180;
                pil.BackColor = Color.Black;
                pil.ForeColor = Color.White;
                pil.TextAlign = ContentAlignment.MiddleCenter;

                Label pil2 = new Label();
                pil2.Text = "Open";
                pil2.Width = 60;
                pil2.Height = 30;
                pil2.BackColor = Color.Blue;
                pil2.ForeColor = Color.White;
                pil2.TextAlign = ContentAlignment.MiddleCenter;
                pil2.Top = 120;
                pil2.Left = 0;
                pil2.Tag = item.appPath;

                Label pil3 = new Label();
                pil3.Text = "View";
                pil3.Width = 60;
                pil3.Height = 30;
                pil3.BackColor = Color.Green;
                pil3.ForeColor = Color.White;
                pil3.TextAlign = ContentAlignment.MiddleCenter;
                pil3.Top = 120;
                pil3.Left = 60;
                pil3.Tag = item.category;

                Label pil4 = new Label();
                pil4.Text = "Delete";
                pil4.Width = 60;
                pil4.Height = 30;
                pil4.BackColor = Color.Red;
                pil4.ForeColor = Color.White;
                pil4.TextAlign = ContentAlignment.MiddleCenter;
                pil4.Top = 120;
                pil4.Left = 120;
                pil4.Tag = item.category;

                pic.Controls.Add(pil);
                pic.Controls.Add(pil2);
                pic.Controls.Add(pil3);
                pic.Controls.Add(pil4);
                flowLayoutPanel1.Controls.Add(pic);

                
                pil2.Click += new EventHandler(Pil2Click);
                pil3.Click += new EventHandler(Pil3Click);
                pil4.Click += new EventHandler(Pil4Click);

            }
        }

        public void Pil2Click(object sender, EventArgs e)
        {
            string path = ((Label)sender).Tag.ToString();
            Process process = new Process();

            try
            {
                process.StartInfo.FileName = path;
                process.EnableRaisingEvents = true;
                process.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
        }
        public void Pil3Click(object sender, EventArgs e)
        {
            string category;
            List<AppList> newApp = new List<AppList>();
            try
            {


                category= ((Label)sender).Tag.ToString();

                foreach (AppList app in apps)
                {
                    if (app.category == category)
                        newApp.Add(app);
                }
                this.Hide();
                var frmView = new frmViewDetails(newApp);
                frmView.Closed += (s, args) => this.Close();
                frmView.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Pil4Click(object sender, EventArgs e)
        {
            string category;
            List<AppList> newApp = new List<AppList>();
            try
            {


                category = ((Label)sender).Tag.ToString();

                foreach (AppList app in apps)
                {
                    if (app.category != category)
                        newApp.Add(app);
                }
                filehandle.newAddApps(newApp, newApp.Count());
                apps = filehandle.readFile();
                this.Hide();
                var frmDone = new frmDone();
                frmDone.Closed += (s, args) => this.Close();
                frmDone.Show();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

 

        private void btnNew_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            var frmAdd = new frmAddDetails();
            frmAdd.Closed += (s, args) => this.Close();
            frmAdd.Show();
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMain_Load_1(object sender, EventArgs e)
        {
            viewList();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
