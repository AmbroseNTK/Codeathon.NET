namespace Codeathon.Desktop.Components
{
    partial class ProfilePanel
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
            this.tabPane1 = new DevExpress.XtraBars.Navigation.TabPane();
            this.tabNavigationPage1 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.tabNavigationPage2 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.tabNavigationPage3 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.profileInfo1 = new Codeathon.Desktop.Components.ProfileInfo();
            this.challengeExplore1 = new Codeathon.Desktop.Components.ChallengeExplore();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).BeginInit();
            this.tabPane1.SuspendLayout();
            this.tabNavigationPage1.SuspendLayout();
            this.tabNavigationPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPane1
            // 
            this.tabPane1.Controls.Add(this.tabNavigationPage1);
            this.tabPane1.Controls.Add(this.tabNavigationPage2);
            this.tabPane1.Controls.Add(this.tabNavigationPage3);
            this.tabPane1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPane1.Location = new System.Drawing.Point(0, 0);
            this.tabPane1.Name = "tabPane1";
            this.tabPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tabNavigationPage1,
            this.tabNavigationPage2,
            this.tabNavigationPage3});
            this.tabPane1.RegularSize = new System.Drawing.Size(1831, 1236);
            this.tabPane1.SelectedPage = this.tabNavigationPage1;
            this.tabPane1.Size = new System.Drawing.Size(1831, 1236);
            this.tabPane1.TabIndex = 0;
            this.tabPane1.Text = "tabPane1";
            // 
            // tabNavigationPage1
            // 
            this.tabNavigationPage1.Caption = "Personal Information";
            this.tabNavigationPage1.Controls.Add(this.profileInfo1);
            this.tabNavigationPage1.Name = "tabNavigationPage1";
            this.tabNavigationPage1.Size = new System.Drawing.Size(1831, 1142);
            // 
            // tabNavigationPage2
            // 
            this.tabNavigationPage2.Caption = "Achievement";
            this.tabNavigationPage2.Name = "tabNavigationPage2";
            this.tabNavigationPage2.Size = new System.Drawing.Size(1831, 1142);
            // 
            // tabNavigationPage3
            // 
            this.tabNavigationPage3.Caption = "Contributing";
            this.tabNavigationPage3.Controls.Add(this.challengeExplore1);
            this.tabNavigationPage3.Name = "tabNavigationPage3";
            this.tabNavigationPage3.Size = new System.Drawing.Size(1831, 1142);
            // 
            // profileInfo1
            // 
            this.profileInfo1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.profileInfo1.Location = new System.Drawing.Point(0, 0);
            this.profileInfo1.Name = "profileInfo1";
            this.profileInfo1.Size = new System.Drawing.Size(1831, 1142);
            this.profileInfo1.TabIndex = 0;
            // 
            // challengeExplore1
            // 
            this.challengeExplore1.Dataset = null;
            this.challengeExplore1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.challengeExplore1.Location = new System.Drawing.Point(0, 123);
            this.challengeExplore1.Name = "challengeExplore1";
            this.challengeExplore1.Size = new System.Drawing.Size(1831, 1019);
            this.challengeExplore1.TabIndex = 0;
            // 
            // ProfilePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabPane1);
            this.Name = "ProfilePanel";
            this.Size = new System.Drawing.Size(1831, 1236);
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).EndInit();
            this.tabPane1.ResumeLayout(false);
            this.tabNavigationPage1.ResumeLayout(false);
            this.tabNavigationPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.TabPane tabPane1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage2;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage3;
        private ProfileInfo profileInfo1;
        private ChallengeExplore challengeExplore1;
    }
}
