namespace Codeathon.Desktop.Components
{
    partial class ChallengePanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.challengeCoding1 = new Codeathon.Desktop.Components.ChallengeCoding();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.dockPanel1 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.challengeExplore1 = new Codeathon.Desktop.Components.ChallengeExplore();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            this.dockPanel1.SuspendLayout();
            this.dockPanel1_Container.SuspendLayout();
            this.SuspendLayout();
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InActiveTabPageHeader;
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(724, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(1284, 1323);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.challengeCoding1);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(1280, 1251);
            this.xtraTabPage1.Text = "xtraTabPage1";
            // 
            // challengeCoding1
            // 
            this.challengeCoding1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.challengeCoding1.Location = new System.Drawing.Point(0, 0);
            this.challengeCoding1.Name = "challengeCoding1";
            this.challengeCoding1.Size = new System.Drawing.Size(1280, 1251);
            this.challengeCoding1.TabIndex = 0;
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(1280, 1251);
            this.xtraTabPage2.Text = "xtraTabPage2";
            // 
            // dockManager1
            // 
            this.dockManager1.AutoHideSpeed = 5;
            this.dockManager1.DockingOptions.ShowCaptionImage = true;
            this.dockManager1.DockMode = DevExpress.XtraBars.Docking.Helpers.DockMode.Standard;
            this.dockManager1.DockModeVS2005FadeFramesCount = 120;
            this.dockManager1.DockModeVS2005FadeSpeed = 20000;
            this.dockManager1.Form = this;
            this.dockManager1.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.dockPanel1});
            this.dockManager1.Style = DevExpress.XtraBars.Docking2010.Views.DockingViewStyle.Light;
            this.dockManager1.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "System.Windows.Forms.MenuStrip",
            "System.Windows.Forms.StatusStrip",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl",
            "DevExpress.XtraBars.Navigation.OfficeNavigationBar",
            "DevExpress.XtraBars.Navigation.TileNavPane",
            "DevExpress.XtraBars.TabFormControl",
            "DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl",
            "DevExpress.XtraBars.ToolbarForm.ToolbarFormControl"});
            // 
            // dockPanel1
            // 
            this.dockPanel1.Controls.Add(this.dockPanel1_Container);
            this.dockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.dockPanel1.FloatSize = new System.Drawing.Size(1279, 939);
            this.dockPanel1.ID = new System.Guid("599121d5-7fe5-498e-a0c5-edf07861c50b");
            this.dockPanel1.Location = new System.Drawing.Point(0, 0);
            this.dockPanel1.Name = "dockPanel1";
            this.dockPanel1.Options.ShowCloseButton = false;
            this.dockPanel1.OriginalSize = new System.Drawing.Size(724, 200);
            this.dockPanel1.Size = new System.Drawing.Size(724, 1323);
            this.dockPanel1.Text = "Challenge Explore";
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Controls.Add(this.challengeExplore1);
            this.dockPanel1_Container.Location = new System.Drawing.Point(0, 107);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(722, 1216);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // challengeExplore1
            // 
            this.challengeExplore1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.challengeExplore1.Location = new System.Drawing.Point(0, 0);
            this.challengeExplore1.Name = "challengeExplore1";
            this.challengeExplore1.Size = new System.Drawing.Size(722, 1216);
            this.challengeExplore1.TabIndex = 2;
            // 
            // ChallengePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.dockPanel1);
            this.Name = "ChallengePanel";
            this.Size = new System.Drawing.Size(2008, 1323);
            this.Load += new System.EventHandler(this.ChallengePanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            this.dockPanel1.ResumeLayout(false);
            this.dockPanel1_Container.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private ChallengeCoding challengeCoding1;
        private DevExpress.XtraBars.Docking.DockManager dockManager1;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel1;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private ChallengeExplore challengeExplore1;
    }
}
