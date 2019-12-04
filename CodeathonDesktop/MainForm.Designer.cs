namespace CodeathonDesktop
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.formAssistant1 = new DevExpress.XtraBars.FormAssistant();
            this.fluentDesignFormContainer1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            this.loginPanel1 = new CodeathonDesktop.Components.LoginPanel();
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.menuCodeathon = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btMenuProfile = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btMenuContent = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btMenuChallenge = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btMenuCompetition = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.menuChallenges = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btMenuExploreChallenge = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.menuCompetition = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btMenuJoinCompetition = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btMenuEnrollCompetition = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.menuCommunity = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btFindNewFriends = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.fluentDesignFormContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // fluentDesignFormContainer1
            // 
            this.fluentDesignFormContainer1.Controls.Add(this.loginPanel1);
            this.fluentDesignFormContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fluentDesignFormContainer1.Location = new System.Drawing.Point(530, 77);
            this.fluentDesignFormContainer1.Name = "fluentDesignFormContainer1";
            this.fluentDesignFormContainer1.Size = new System.Drawing.Size(1744, 1381);
            this.fluentDesignFormContainer1.TabIndex = 0;
            // 
            // loginPanel1
            // 
            this.loginPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginPanel1.Location = new System.Drawing.Point(0, 0);
            this.loginPanel1.Name = "loginPanel1";
            this.loginPanel1.Size = new System.Drawing.Size(1744, 1381);
            this.loginPanel1.TabIndex = 0;
            // 
            // accordionControl1
            // 
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.menuCodeathon,
            this.menuChallenges,
            this.menuCompetition,
            this.menuCommunity});
            this.accordionControl1.Location = new System.Drawing.Point(0, 77);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch;
            this.accordionControl1.Size = new System.Drawing.Size(530, 1381);
            this.accordionControl1.TabIndex = 1;
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // menuCodeathon
            // 
            this.menuCodeathon.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.btMenuProfile,
            this.btMenuContent});
            this.menuCodeathon.Expanded = true;
            this.menuCodeathon.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("menuCodeathon.ImageOptions.SvgImage")));
            this.menuCodeathon.Name = "menuCodeathon";
            this.menuCodeathon.Text = "Codeathon";
            // 
            // btMenuProfile
            // 
            this.btMenuProfile.Name = "btMenuProfile";
            this.btMenuProfile.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btMenuProfile.Text = "Your profile";
            // 
            // btMenuContent
            // 
            this.btMenuContent.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.btMenuChallenge,
            this.btMenuCompetition});
            this.btMenuContent.Expanded = true;
            this.btMenuContent.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btMenuContent.ImageOptions.SvgImage")));
            this.btMenuContent.Name = "btMenuContent";
            this.btMenuContent.Text = "Your contents";
            // 
            // btMenuChallenge
            // 
            this.btMenuChallenge.Name = "btMenuChallenge";
            this.btMenuChallenge.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btMenuChallenge.Text = "Challenges";
            // 
            // btMenuCompetition
            // 
            this.btMenuCompetition.Name = "btMenuCompetition";
            this.btMenuCompetition.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btMenuCompetition.Text = "Competition";
            // 
            // menuChallenges
            // 
            this.menuChallenges.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.btMenuExploreChallenge});
            this.menuChallenges.Expanded = true;
            this.menuChallenges.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("menuChallenges.ImageOptions.SvgImage")));
            this.menuChallenges.Name = "menuChallenges";
            this.menuChallenges.Text = "Challenges";
            // 
            // btMenuExploreChallenge
            // 
            this.btMenuExploreChallenge.Name = "btMenuExploreChallenge";
            this.btMenuExploreChallenge.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btMenuExploreChallenge.Text = "Explore";
            // 
            // menuCompetition
            // 
            this.menuCompetition.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.btMenuJoinCompetition,
            this.btMenuEnrollCompetition});
            this.menuCompetition.Expanded = true;
            this.menuCompetition.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("menuCompetition.ImageOptions.SvgImage")));
            this.menuCompetition.Name = "menuCompetition";
            this.menuCompetition.Text = "Competition";
            // 
            // btMenuJoinCompetition
            // 
            this.btMenuJoinCompetition.Name = "btMenuJoinCompetition";
            this.btMenuJoinCompetition.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btMenuJoinCompetition.Text = "Joining";
            // 
            // btMenuEnrollCompetition
            // 
            this.btMenuEnrollCompetition.Name = "btMenuEnrollCompetition";
            this.btMenuEnrollCompetition.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btMenuEnrollCompetition.Text = "Enrolled";
            // 
            // menuCommunity
            // 
            this.menuCommunity.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.btFindNewFriends});
            this.menuCommunity.Expanded = true;
            this.menuCommunity.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("menuCommunity.ImageOptions.SvgImage")));
            this.menuCommunity.Name = "menuCommunity";
            this.menuCommunity.Text = "Community";
            // 
            // btFindNewFriends
            // 
            this.btFindNewFriends.Name = "btFindNewFriends";
            this.btFindNewFriends.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btFindNewFriends.Text = "Find new friends";
            // 
            // fluentDesignFormControl1
            // 
            this.fluentDesignFormControl1.FluentDesignForm = this;
            this.fluentDesignFormControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1});
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(2274, 77);
            this.fluentDesignFormControl1.TabIndex = 2;
            this.fluentDesignFormControl1.TabStop = false;
            this.fluentDesignFormControl1.TitleItemLinks.Add(this.barButtonItem1);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barButtonItem1.Caption = "Annonymous";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem1.ImageOptions.SvgImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(2274, 1458);
            this.ControlContainer = this.fluentDesignFormContainer1;
            this.Controls.Add(this.fluentDesignFormContainer1);
            this.Controls.Add(this.accordionControl1);
            this.Controls.Add(this.fluentDesignFormControl1);
            this.FluentDesignFormControl = this.fluentDesignFormControl1;
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.NavigationControl = this.accordionControl1;
            this.Text = "Codeathon Desktop";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(83)))));
            this.fluentDesignFormContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

     
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
      
        private DevExpress.XtraBars.FormAssistant formAssistant1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer fluentDesignFormContainer1;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement menuCodeathon;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btMenuProfile;
        private DevExpress.XtraBars.Navigation.AccordionControlElement menuChallenges;
        private DevExpress.XtraBars.Navigation.AccordionControlElement menuCompetition;
        private DevExpress.XtraBars.Navigation.AccordionControlElement menuCommunity;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btMenuExploreChallenge;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btMenuJoinCompetition;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btMenuEnrollCompetition;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btFindNewFriends;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btMenuCompetition;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btMenuChallenge;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btMenuContent;
        private Components.LoginPanel loginPanel1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
    }
}

