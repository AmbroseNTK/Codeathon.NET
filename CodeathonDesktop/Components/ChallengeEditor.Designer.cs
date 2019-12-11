namespace Codeathon.Desktop.Components
{
    partial class ChallengeEditor
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
            this.tabPane1 = new DevExpress.XtraBars.Navigation.TabPane();
            this.tabNavigationPage1 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Input = new DevExpress.XtraGrid.Columns.GridColumn();
            this.editInput = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.ExpectedOutput = new DevExpress.XtraGrid.Columns.GridColumn();
            this.editExpectedOutput = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.Timeout = new DevExpress.XtraGrid.Columns.GridColumn();
            this.editTimeout = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.IsPublic = new DevExpress.XtraGrid.Columns.GridColumn();
            this.editIsPublic = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.comboCategory = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.checkViewSolution = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.checkIsPublic = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.stackPanel1 = new DevExpress.Utils.Layout.StackPanel();
            this.btCreate = new DevExpress.XtraEditors.SimpleButton();
            this.btUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btDelete = new DevExpress.XtraEditors.SimpleButton();
            this.textDescription = new DevExpress.XtraEditors.MemoEdit();
            this.textShortDescription = new DevExpress.XtraEditors.TextEdit();
            this.textTitle = new DevExpress.XtraEditors.TextEdit();
            this.textName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.comboChallengeId = new DevExpress.XtraEditors.ComboBoxEdit();
            this.tabNavigationPage2 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.challengeExplore1 = new Codeathon.Desktop.Components.ChallengeExplore();
            this.tabNavigationPage3 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.categoryEditor1 = new Codeathon.Desktop.Components.CategoryEditor();
            this.xtraOpenFileDialog1 = new DevExpress.XtraEditors.XtraOpenFileDialog(this.components);
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).BeginInit();
            this.tabPane1.SuspendLayout();
            this.tabNavigationPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editExpectedOutput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editTimeout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editIsPublic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboCategory.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkViewSolution.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkIsPublic.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stackPanel1)).BeginInit();
            this.stackPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textShortDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textTitle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboChallengeId.Properties)).BeginInit();
            this.tabNavigationPage2.SuspendLayout();
            this.tabNavigationPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
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
            this.tabNavigationPage3,
            this.tabNavigationPage1,
            this.tabNavigationPage2});
            this.tabPane1.RegularSize = new System.Drawing.Size(2196, 1536);
            this.tabPane1.SelectedPage = this.tabNavigationPage3;
            this.tabPane1.Size = new System.Drawing.Size(2196, 1536);
            this.tabPane1.TabIndex = 0;
            this.tabPane1.Text = "tabPane1";
            // 
            // tabNavigationPage1
            // 
            this.tabNavigationPage1.Caption = "Create";
            this.tabNavigationPage1.Controls.Add(this.gridControl1);
            this.tabNavigationPage1.Controls.Add(this.tablePanel1);
            this.tabNavigationPage1.Name = "tabNavigationPage1";
            this.tabNavigationPage1.Size = new System.Drawing.Size(2196, 1442);
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 916);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.editExpectedOutput,
            this.editInput,
            this.editIsPublic,
            this.editTimeout});
            this.gridControl1.Size = new System.Drawing.Size(2196, 526);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Id,
            this.Input,
            this.ExpectedOutput,
            this.Timeout,
            this.IsPublic});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.NewItemRowText = "Add new test case";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditFormInplace;
            this.gridView1.OptionsBehavior.UnboundColumnExpressionEditorMode = DevExpress.XtraEditors.ExpressionEditorMode.Standard;
            this.gridView1.OptionsCustomization.AllowRowSizing = true;
            this.gridView1.OptionsDetail.AllowExpandEmptyDetails = true;
            this.gridView1.OptionsEditForm.ActionOnModifiedRowChange = DevExpress.XtraGrid.Views.Grid.EditFormModifiedAction.Save;
            this.gridView1.OptionsEditForm.BindingMode = DevExpress.XtraGrid.Views.Grid.EditFormBindingMode.Direct;
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gridView1.OptionsView.RowAutoHeight = true;
            this.gridView1.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gridView1_InitNewRow);
            this.gridView1.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gridView1_RowUpdated);
            // 
            // Id
            // 
            this.Id.Caption = "ID";
            this.Id.FieldName = "Id";
            this.Id.MinWidth = 50;
            this.Id.Name = "Id";
            this.Id.OptionsColumn.AllowEdit = false;
            this.Id.OptionsColumn.ReadOnly = true;
            this.Id.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.Id.Visible = true;
            this.Id.VisibleIndex = 0;
            this.Id.Width = 193;
            // 
            // Input
            // 
            this.Input.Caption = "Input";
            this.Input.ColumnEdit = this.editInput;
            this.Input.FieldName = "Input";
            this.Input.MinWidth = 50;
            this.Input.Name = "Input";
            this.Input.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.Input.Visible = true;
            this.Input.VisibleIndex = 1;
            this.Input.Width = 579;
            // 
            // editInput
            // 
            this.editInput.Name = "editInput";
            // 
            // ExpectedOutput
            // 
            this.ExpectedOutput.Caption = "Expected Output";
            this.ExpectedOutput.ColumnEdit = this.editExpectedOutput;
            this.ExpectedOutput.FieldName = "ExpectedOutput";
            this.ExpectedOutput.MinWidth = 50;
            this.ExpectedOutput.Name = "ExpectedOutput";
            this.ExpectedOutput.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.ExpectedOutput.Visible = true;
            this.ExpectedOutput.VisibleIndex = 2;
            this.ExpectedOutput.Width = 579;
            // 
            // editExpectedOutput
            // 
            this.editExpectedOutput.Name = "editExpectedOutput";
            // 
            // Timeout
            // 
            this.Timeout.Caption = "Timeout";
            this.Timeout.ColumnEdit = this.editTimeout;
            this.Timeout.FieldName = "Timeout";
            this.Timeout.MinWidth = 50;
            this.Timeout.Name = "Timeout";
            this.Timeout.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.Timeout.Visible = true;
            this.Timeout.VisibleIndex = 3;
            this.Timeout.Width = 578;
            // 
            // editTimeout
            // 
            this.editTimeout.AutoHeight = false;
            this.editTimeout.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.editTimeout.Name = "editTimeout";
            // 
            // IsPublic
            // 
            this.IsPublic.Caption = "Is Public";
            this.IsPublic.ColumnEdit = this.editIsPublic;
            this.IsPublic.FieldName = "IsPublic";
            this.IsPublic.MinWidth = 50;
            this.IsPublic.Name = "IsPublic";
            this.IsPublic.UnboundType = DevExpress.Data.UnboundColumnType.Boolean;
            this.IsPublic.Visible = true;
            this.IsPublic.VisibleIndex = 4;
            this.IsPublic.Width = 626;
            // 
            // editIsPublic
            // 
            this.editIsPublic.AutoHeight = false;
            this.editIsPublic.Name = "editIsPublic";
            // 
            // tablePanel1
            // 
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 55F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 10F)});
            this.tablePanel1.Controls.Add(this.comboCategory);
            this.tablePanel1.Controls.Add(this.labelControl8);
            this.tablePanel1.Controls.Add(this.checkViewSolution);
            this.tablePanel1.Controls.Add(this.labelControl7);
            this.tablePanel1.Controls.Add(this.checkIsPublic);
            this.tablePanel1.Controls.Add(this.labelControl6);
            this.tablePanel1.Controls.Add(this.stackPanel1);
            this.tablePanel1.Controls.Add(this.textDescription);
            this.tablePanel1.Controls.Add(this.textShortDescription);
            this.tablePanel1.Controls.Add(this.textTitle);
            this.tablePanel1.Controls.Add(this.textName);
            this.tablePanel1.Controls.Add(this.labelControl5);
            this.tablePanel1.Controls.Add(this.labelControl4);
            this.tablePanel1.Controls.Add(this.labelControl3);
            this.tablePanel1.Controls.Add(this.labelControl2);
            this.tablePanel1.Controls.Add(this.labelControl1);
            this.tablePanel1.Controls.Add(this.comboChallengeId);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tablePanel1.Location = new System.Drawing.Point(0, 0);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 100F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanel1.Size = new System.Drawing.Size(2196, 916);
            this.tablePanel1.TabIndex = 1;
            // 
            // comboCategory
            // 
            this.tablePanel1.SetColumn(this.comboCategory, 2);
            this.comboCategory.Location = new System.Drawing.Point(1101, 137);
            this.comboCategory.Name = "comboCategory";
            this.comboCategory.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tablePanel1.SetRow(this.comboCategory, 2);
            this.comboCategory.Size = new System.Drawing.Size(909, 50);
            this.comboCategory.TabIndex = 16;
            // 
            // labelControl8
            // 
            this.tablePanel1.SetColumn(this.labelControl8, 1);
            this.labelControl8.Location = new System.Drawing.Point(95, 145);
            this.labelControl8.Name = "labelControl8";
            this.tablePanel1.SetRow(this.labelControl8, 2);
            this.labelControl8.Size = new System.Drawing.Size(196, 34);
            this.labelControl8.TabIndex = 15;
            this.labelControl8.Text = "Select Category";
            // 
            // checkViewSolution
            // 
            this.tablePanel1.SetColumn(this.checkViewSolution, 2);
            this.checkViewSolution.Location = new System.Drawing.Point(1101, 715);
            this.checkViewSolution.Name = "checkViewSolution";
            this.checkViewSolution.Properties.Caption = "View solution";
            this.tablePanel1.SetRow(this.checkViewSolution, 8);
            this.checkViewSolution.Size = new System.Drawing.Size(909, 45);
            this.checkViewSolution.TabIndex = 14;
            // 
            // labelControl7
            // 
            this.tablePanel1.SetColumn(this.labelControl7, 1);
            this.labelControl7.Location = new System.Drawing.Point(95, 720);
            this.labelControl7.Name = "labelControl7";
            this.tablePanel1.SetRow(this.labelControl7, 8);
            this.labelControl7.Size = new System.Drawing.Size(232, 34);
            this.labelControl7.TabIndex = 13;
            this.labelControl7.Text = "Allow view Solution";
            // 
            // checkIsPublic
            // 
            this.tablePanel1.SetColumn(this.checkIsPublic, 2);
            this.checkIsPublic.Location = new System.Drawing.Point(1101, 650);
            this.checkIsPublic.Name = "checkIsPublic";
            this.checkIsPublic.Properties.Caption = "Is Public";
            this.tablePanel1.SetRow(this.checkIsPublic, 7);
            this.checkIsPublic.Size = new System.Drawing.Size(909, 45);
            this.checkIsPublic.TabIndex = 12;
            // 
            // labelControl6
            // 
            this.tablePanel1.SetColumn(this.labelControl6, 1);
            this.labelControl6.Location = new System.Drawing.Point(95, 655);
            this.labelControl6.Name = "labelControl6";
            this.tablePanel1.SetRow(this.labelControl6, 7);
            this.labelControl6.Size = new System.Drawing.Size(97, 34);
            this.labelControl6.TabIndex = 11;
            this.labelControl6.Text = "Is Public";
            // 
            // stackPanel1
            // 
            this.tablePanel1.SetColumn(this.stackPanel1, 1);
            this.stackPanel1.Controls.Add(this.btCreate);
            this.stackPanel1.Controls.Add(this.btUpdate);
            this.stackPanel1.Controls.Add(this.btDelete);
            this.stackPanel1.Location = new System.Drawing.Point(95, 813);
            this.stackPanel1.Name = "stackPanel1";
            this.tablePanel1.SetRow(this.stackPanel1, 9);
            this.stackPanel1.Size = new System.Drawing.Size(1001, 59);
            this.stackPanel1.TabIndex = 10;
            // 
            // btCreate
            // 
            this.btCreate.Location = new System.Drawing.Point(3, 1);
            this.btCreate.Name = "btCreate";
            this.btCreate.Size = new System.Drawing.Size(187, 57);
            this.btCreate.TabIndex = 1;
            this.btCreate.Text = "Create";
            this.btCreate.Click += new System.EventHandler(this.btCreate_Click);
            // 
            // btUpdate
            // 
            this.btUpdate.Location = new System.Drawing.Point(196, 1);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(187, 57);
            this.btUpdate.TabIndex = 0;
            this.btUpdate.Text = "Update";
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(389, 1);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(187, 57);
            this.btDelete.TabIndex = 2;
            this.btDelete.Text = "Delete";
            // 
            // textDescription
            // 
            this.tablePanel1.SetColumn(this.textDescription, 2);
            this.textDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textDescription.Location = new System.Drawing.Point(1101, 393);
            this.textDescription.Name = "textDescription";
            this.textDescription.Properties.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tablePanel1.SetRow(this.textDescription, 6);
            this.textDescription.Size = new System.Drawing.Size(909, 244);
            this.textDescription.TabIndex = 9;
            // 
            // textShortDescription
            // 
            this.tablePanel1.SetColumn(this.textShortDescription, 2);
            this.textShortDescription.Location = new System.Drawing.Point(1101, 332);
            this.textShortDescription.Name = "textShortDescription";
            this.tablePanel1.SetRow(this.textShortDescription, 5);
            this.textShortDescription.Size = new System.Drawing.Size(909, 50);
            this.textShortDescription.TabIndex = 8;
            // 
            // textTitle
            // 
            this.tablePanel1.SetColumn(this.textTitle, 2);
            this.textTitle.Location = new System.Drawing.Point(1101, 267);
            this.textTitle.Name = "textTitle";
            this.tablePanel1.SetRow(this.textTitle, 4);
            this.textTitle.Size = new System.Drawing.Size(909, 50);
            this.textTitle.TabIndex = 7;
            // 
            // textName
            // 
            this.tablePanel1.SetColumn(this.textName, 2);
            this.textName.Location = new System.Drawing.Point(1101, 202);
            this.textName.Name = "textName";
            this.tablePanel1.SetRow(this.textName, 3);
            this.textName.Size = new System.Drawing.Size(909, 50);
            this.textName.TabIndex = 6;
            // 
            // labelControl5
            // 
            this.tablePanel1.SetColumn(this.labelControl5, 1);
            this.labelControl5.Location = new System.Drawing.Point(95, 498);
            this.labelControl5.Name = "labelControl5";
            this.tablePanel1.SetRow(this.labelControl5, 6);
            this.labelControl5.Size = new System.Drawing.Size(139, 34);
            this.labelControl5.TabIndex = 5;
            this.labelControl5.Text = "Description";
            // 
            // labelControl4
            // 
            this.tablePanel1.SetColumn(this.labelControl4, 1);
            this.labelControl4.Location = new System.Drawing.Point(95, 340);
            this.labelControl4.Name = "labelControl4";
            this.tablePanel1.SetRow(this.labelControl4, 5);
            this.labelControl4.Size = new System.Drawing.Size(211, 34);
            this.labelControl4.TabIndex = 4;
            this.labelControl4.Text = "Short Description";
            // 
            // labelControl3
            // 
            this.tablePanel1.SetColumn(this.labelControl3, 1);
            this.labelControl3.Location = new System.Drawing.Point(95, 275);
            this.labelControl3.Name = "labelControl3";
            this.tablePanel1.SetRow(this.labelControl3, 4);
            this.labelControl3.Size = new System.Drawing.Size(52, 34);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "Title";
            // 
            // labelControl2
            // 
            this.tablePanel1.SetColumn(this.labelControl2, 1);
            this.labelControl2.Location = new System.Drawing.Point(95, 210);
            this.labelControl2.Name = "labelControl2";
            this.tablePanel1.SetRow(this.labelControl2, 3);
            this.labelControl2.Size = new System.Drawing.Size(71, 34);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Name";
            // 
            // labelControl1
            // 
            this.tablePanel1.SetColumn(this.labelControl1, 1);
            this.labelControl1.Location = new System.Drawing.Point(95, 80);
            this.labelControl1.Name = "labelControl1";
            this.tablePanel1.SetRow(this.labelControl1, 1);
            this.labelControl1.Size = new System.Drawing.Size(232, 34);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Select Challenge Id";
            // 
            // comboChallengeId
            // 
            this.tablePanel1.SetColumn(this.comboChallengeId, 2);
            this.comboChallengeId.Location = new System.Drawing.Point(1101, 72);
            this.comboChallengeId.Name = "comboChallengeId";
            this.comboChallengeId.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tablePanel1.SetRow(this.comboChallengeId, 1);
            this.comboChallengeId.Size = new System.Drawing.Size(909, 50);
            this.comboChallengeId.TabIndex = 0;
            // 
            // tabNavigationPage2
            // 
            this.tabNavigationPage2.Caption = "Manage";
            this.tabNavigationPage2.Controls.Add(this.gridControl2);
            this.tabNavigationPage2.Controls.Add(this.challengeExplore1);
            this.tabNavigationPage2.Name = "tabNavigationPage2";
            this.tabNavigationPage2.Size = new System.Drawing.Size(2196, 1442);
            // 
            // challengeExplore1
            // 
            this.challengeExplore1.Dock = System.Windows.Forms.DockStyle.Top;
            this.challengeExplore1.Location = new System.Drawing.Point(0, 0);
            this.challengeExplore1.Name = "challengeExplore1";
            this.challengeExplore1.Size = new System.Drawing.Size(2196, 571);
            this.challengeExplore1.TabIndex = 0;
            // 
            // tabNavigationPage3
            // 
            this.tabNavigationPage3.Caption = "Categories";
            this.tabNavigationPage3.Controls.Add(this.categoryEditor1);
            this.tabNavigationPage3.Name = "tabNavigationPage3";
            this.tabNavigationPage3.Size = new System.Drawing.Size(2196, 1442);
            // 
            // categoryEditor1
            // 
            this.categoryEditor1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.categoryEditor1.Location = new System.Drawing.Point(0, 0);
            this.categoryEditor1.Name = "categoryEditor1";
            this.categoryEditor1.Size = new System.Drawing.Size(2196, 1442);
            this.categoryEditor1.TabIndex = 0;
            // 
            // xtraOpenFileDialog1
            // 
            this.xtraOpenFileDialog1.FileName = "xtraOpenFileDialog1";
            // 
            // gridControl2
            // 
            this.gridControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl2.Location = new System.Drawing.Point(0, 571);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(2196, 871);
            this.gridControl2.TabIndex = 1;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "ID";
            this.gridColumn1.FieldName = "Id";
            this.gridColumn1.MinWidth = 50;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 187;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "gridColumn2";
            this.gridColumn2.MinWidth = 50;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 187;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "gridColumn3";
            this.gridColumn3.MinWidth = 50;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 187;
            // 
            // ChallengeEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabPane1);
            this.Name = "ChallengeEditor";
            this.Size = new System.Drawing.Size(2196, 1536);
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).EndInit();
            this.tabPane1.ResumeLayout(false);
            this.tabNavigationPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editExpectedOutput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editTimeout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editIsPublic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            this.tablePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboCategory.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkViewSolution.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkIsPublic.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stackPanel1)).EndInit();
            this.stackPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.textDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textShortDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textTitle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboChallengeId.Properties)).EndInit();
            this.tabNavigationPage2.ResumeLayout(false);
            this.tabNavigationPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.TabPane tabPane1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage2;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage3;
        private DevExpress.XtraEditors.XtraOpenFileDialog xtraOpenFileDialog1;
        private CategoryEditor categoryEditor1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ComboBoxEdit comboChallengeId;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraGrid.Columns.GridColumn Id;
        private DevExpress.XtraGrid.Columns.GridColumn Input;
        private DevExpress.XtraGrid.Columns.GridColumn ExpectedOutput;
        private DevExpress.XtraGrid.Columns.GridColumn Timeout;
        private DevExpress.XtraGrid.Columns.GridColumn IsPublic;
        private DevExpress.XtraEditors.CheckEdit checkViewSolution;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.CheckEdit checkIsPublic;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.Utils.Layout.StackPanel stackPanel1;
        private DevExpress.XtraEditors.SimpleButton btCreate;
        private DevExpress.XtraEditors.SimpleButton btUpdate;
        private DevExpress.XtraEditors.SimpleButton btDelete;
        private DevExpress.XtraEditors.MemoEdit textDescription;
        private DevExpress.XtraEditors.TextEdit textShortDescription;
        private DevExpress.XtraEditors.TextEdit textName;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit editInput;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit editExpectedOutput;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit editIsPublic;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit editTimeout;
        private DevExpress.XtraEditors.TextEdit textTitle;
        private DevExpress.XtraEditors.ComboBoxEdit comboCategory;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private ChallengeExplore challengeExplore1;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
    }
}
