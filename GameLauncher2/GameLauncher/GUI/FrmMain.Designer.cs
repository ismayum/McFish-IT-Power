
namespace GameLauncher.GUI
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            Utilities.BunifuPages.BunifuAnimatorNS.Animation animation2 = new Utilities.BunifuPages.BunifuAnimatorNS.Animation();
            this.sideMenu = new NavigationMenu.NavigtionMenu();
            this.kimtooButtonGroup1 = new Kimtoo.KimtooButtonGroup();
            this.line = new Bunifu.UI.WinForms.BunifuSeparator();
            this.pages = new Bunifu.UI.WinForms.BunifuPages();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.pageGames1 = new GameLauncher.GUI.Pages.PageGames();
            this.pages.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sideMenu
            // 
            this.sideMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.sideMenu.AutoScroll = true;
            this.sideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.sideMenu.BackColor_Click = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.sideMenu.BackColor_Hover = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.sideMenu.BackColor_Selected = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.sideMenu.DisableToggling = new string[0];
            this.sideMenu.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sideMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.sideMenu.ForeColor_Selected = System.Drawing.Color.DeepSkyBlue;
            this.sideMenu.IsExpanded = true;
            this.sideMenu.IsExpandedable = true;
            this.sideMenu.ItemHeight = 50;
            this.sideMenu.ItemImageSize = new System.Drawing.Size(20, 20);
            this.sideMenu.ItemPadding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.sideMenu.ItemRightImageMargin = 20;
            this.sideMenu.ItemRightImageSize = new System.Drawing.Size(15, 15);
            this.sideMenu.Items = new NavigationMenu.ButtonItem[] {
        ((NavigationMenu.ButtonItem)(resources.GetObject("sideMenu.Items"))),
        ((NavigationMenu.ButtonItem)(resources.GetObject("sideMenu.Items1"))),
        ((NavigationMenu.ButtonItem)(resources.GetObject("sideMenu.Items2"))),
        ((NavigationMenu.ButtonItem)(resources.GetObject("sideMenu.Items3"))),
        ((NavigationMenu.ButtonItem)(resources.GetObject("sideMenu.Items4")))};
            this.sideMenu.ItemTextMargin = 8;
            this.sideMenu.Location = new System.Drawing.Point(6, 69);
            this.sideMenu.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.sideMenu.Name = "sideMenu";
            this.sideMenu.Size = new System.Drawing.Size(199, 633);
            this.sideMenu.TabIndex = 0;
            this.sideMenu.OnItemSelected += new NavigationMenu.NavigtionMenu.OnSelectEventHandler(this.sideMenu_OnItemSelected);
            this.sideMenu.SizeChanged += new System.EventHandler(this.sideMenu_SizeChanged);
            // 
            // kimtooButtonGroup1
            // 
            this.kimtooButtonGroup1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kimtooButtonGroup1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.kimtooButtonGroup1.BackColorActive = System.Drawing.Color.Empty;
            this.kimtooButtonGroup1.ButtonSpacing = 75;
            this.kimtooButtonGroup1.CurrentSelection = "All Games";
            this.kimtooButtonGroup1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kimtooButtonGroup1.FontActive = null;
            this.kimtooButtonGroup1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.kimtooButtonGroup1.ForeColorActive = System.Drawing.Color.DeepSkyBlue;
            this.kimtooButtonGroup1.Items = new string[] {
        "All Games",
        "Free",
        "InApp ",
        "Premium"};
            this.kimtooButtonGroup1.Location = new System.Drawing.Point(-2, 25);
            this.kimtooButtonGroup1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kimtooButtonGroup1.Name = "kimtooButtonGroup1";
            this.kimtooButtonGroup1.Orientation = Kimtoo.KimtooButtonGroup.ButtongrupOrientation.Horizontal;
            this.kimtooButtonGroup1.Size = new System.Drawing.Size(1182, 38);
            this.kimtooButtonGroup1.TabIndex = 1;
            this.kimtooButtonGroup1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // line
            // 
            this.line.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.line.BackColor = System.Drawing.Color.Transparent;
            this.line.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("line.BackgroundImage")));
            this.line.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.line.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
            this.line.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.line.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.RightEdgeFaded;
            this.line.LineThickness = 1;
            this.line.Location = new System.Drawing.Point(211, 69);
            this.line.Name = "line";
            this.line.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Vertical;
            this.line.Size = new System.Drawing.Size(12, 655);
            this.line.TabIndex = 2;
            // 
            // pages
            // 
            this.pages.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.pages.AllowTransitions = false;
            this.pages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pages.Controls.Add(this.tabPage1);
            this.pages.Controls.Add(this.tabPage2);
            this.pages.Controls.Add(this.tabPage3);
            this.pages.Location = new System.Drawing.Point(226, 70);
            this.pages.Multiline = true;
            this.pages.Name = "pages";
            this.pages.Page = this.tabPage3;
            this.pages.PageIndex = 2;
            this.pages.PageName = "tabPage3";
            this.pages.PageTitle = "Info";
            this.pages.SelectedIndex = 0;
            this.pages.Size = new System.Drawing.Size(948, 634);
            this.pages.TabIndex = 3;
            animation2.AnimateOnlyDifferences = false;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.pages.Transition = animation2;
            this.pages.TransitionType = Utilities.BunifuPages.BunifuAnimatorNS.AnimationType.Custom;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.tabPage1.Controls.Add(this.pageGames1);
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(940, 608);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Games";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(940, 608);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Settings";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.tabPage3.Location = new System.Drawing.Point(4, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(940, 608);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Info";
            // 
            // pageGames1
            // 
            this.pageGames1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pageGames1.Location = new System.Drawing.Point(3, 3);
            this.pageGames1.Name = "pageGames1";
            this.pageGames1.Size = new System.Drawing.Size(934, 602);
            this.pageGames1.TabIndex = 1;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(1180, 710);
            this.Controls.Add(this.pages);
            this.Controls.Add(this.line);
            this.Controls.Add(this.kimtooButtonGroup1);
            this.Controls.Add(this.sideMenu);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.pages.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private NavigationMenu.NavigtionMenu sideMenu;
        private Kimtoo.KimtooButtonGroup kimtooButtonGroup1;
        private Bunifu.UI.WinForms.BunifuSeparator line;
        private Bunifu.UI.WinForms.BunifuPages pages;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private Pages.PageGames pageGames1;
    }
}