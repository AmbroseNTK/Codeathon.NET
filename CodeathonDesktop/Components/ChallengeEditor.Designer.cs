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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChallengeEditor));
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
            this.btReport = new DevExpress.XtraEditors.SimpleButton();
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
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.challengeExplore1 = new Codeathon.Desktop.Components.ChallengeExplore();
            this.tabNavigationPage3 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.categoryEditor1 = new Codeathon.Desktop.Components.CategoryEditor();
            this.pageReport = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.documentViewer1 = new DevExpress.XtraPrinting.Preview.DocumentViewer();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.documentViewerBarManager1 = new DevExpress.XtraPrinting.Preview.DocumentViewerBarManager(this.components);
            this.previewBar1 = new DevExpress.XtraPrinting.Preview.PreviewBar();
            this.bbiDocumentMap = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
            this.bbiParameters = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
            this.bbiThumbnails = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
            this.bbiFind = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
            this.bbiHighlightEditingFields = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
            this.bbiCustomize = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
            this.bbiOpen = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
            this.bbiSave = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
            this.bbiPrint = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
            this.bbiPrintDirect = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
            this.bbiPageSetup = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
            this.bbiEditPageHF = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
            this.bbiScale = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
            this.bbiHandTool = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
            this.bbiMagnifier = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
            this.bbiZoomOut = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
            this.bbiZoom = new DevExpress.XtraPrinting.Preview.ZoomBarEditItem();
            this.printPreviewRepositoryItemComboBox1 = new DevExpress.XtraPrinting.Preview.PrintPreviewRepositoryItemComboBox();
            this.bbiZoomIn = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
            this.bbiShowFirstPage = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
            this.bbiShowPrevPage = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
            this.bbiShowNextPage = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
            this.bbiShowLastPage = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
            this.bbiMultiplePages = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
            this.bbiFillBackground = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
            this.bbiWatermark = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
            this.bbiExportFile = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
            this.bbiSendFile = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
            this.bbiClosePreview = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
            this.previewBar2 = new DevExpress.XtraPrinting.Preview.PreviewBar();
            this.printPreviewStaticItem1 = new DevExpress.XtraPrinting.Preview.PrintPreviewStaticItem();
            this.progressBarEditItem1 = new DevExpress.XtraPrinting.Preview.ProgressBarEditItem();
            this.repositoryItemProgressBar1 = new DevExpress.XtraEditors.Repository.RepositoryItemProgressBar();
            this.printPreviewBarItem1 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
            this.printPreviewStaticItem2 = new DevExpress.XtraPrinting.Preview.PrintPreviewStaticItem();
            this.zoomTrackBarEditItem1 = new DevExpress.XtraPrinting.Preview.ZoomTrackBarEditItem();
            this.repositoryItemZoomTrackBar1 = new DevExpress.XtraEditors.Repository.RepositoryItemZoomTrackBar();
            this.previewBar3 = new DevExpress.XtraPrinting.Preview.PreviewBar();
            this.miFile = new DevExpress.XtraPrinting.Preview.PrintPreviewSubItem();
            this.miView = new DevExpress.XtraPrinting.Preview.PrintPreviewSubItem();
            this.miPageLayout = new DevExpress.XtraPrinting.Preview.PrintPreviewSubItem();
            this.miPageLayoutFacing = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
            this.miPageLayoutContinuous = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
            this.miToolbars = new DevExpress.XtraBars.BarToolbarsListItem();
            this.miBackground = new DevExpress.XtraPrinting.Preview.PrintPreviewSubItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.printPreviewBarCheckItem1 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem();
            this.printPreviewBarCheckItem2 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem();
            this.printPreviewBarCheckItem3 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem();
            this.printPreviewBarCheckItem4 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem();
            this.printPreviewBarCheckItem5 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem();
            this.printPreviewBarCheckItem6 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem();
            this.printPreviewBarCheckItem7 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem();
            this.printPreviewBarCheckItem8 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem();
            this.printPreviewBarCheckItem9 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem();
            this.printPreviewBarCheckItem10 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem();
            this.printPreviewBarCheckItem11 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem();
            this.printPreviewBarCheckItem12 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem();
            this.printPreviewBarCheckItem13 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem();
            this.printPreviewBarCheckItem14 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem();
            this.printPreviewBarCheckItem15 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem();
            this.printPreviewBarCheckItem16 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem();
            this.printPreviewBarCheckItem17 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem();
            this.printPreviewBarCheckItem18 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem();
            this.printPreviewBarCheckItem19 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem();
            this.xtraOpenFileDialog1 = new DevExpress.XtraEditors.XtraOpenFileDialog(this.components);
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
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
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.tabNavigationPage3.SuspendLayout();
            this.pageReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.documentViewerBarManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printPreviewRepositoryItemComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemProgressBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemZoomTrackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPane1
            // 
            this.tabPane1.Controls.Add(this.tabNavigationPage1);
            this.tabPane1.Controls.Add(this.tabNavigationPage2);
            this.tabPane1.Controls.Add(this.tabNavigationPage3);
            this.tabPane1.Controls.Add(this.pageReport);
            this.tabPane1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPane1.Location = new System.Drawing.Point(0, 0);
            this.tabPane1.Name = "tabPane1";
            this.tabPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tabNavigationPage3,
            this.tabNavigationPage1,
            this.tabNavigationPage2,
            this.pageReport});
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
            this.tabNavigationPage1.Size = new System.Drawing.Size(2196, 1536);
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
            this.gridControl1.Size = new System.Drawing.Size(2196, 620);
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
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 200F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F)});
            this.tablePanel1.Size = new System.Drawing.Size(2196, 916);
            this.tablePanel1.TabIndex = 1;
            // 
            // comboCategory
            // 
            this.tablePanel1.SetColumn(this.comboCategory, 2);
            this.comboCategory.Location = new System.Drawing.Point(1101, 79);
            this.comboCategory.Name = "comboCategory";
            this.comboCategory.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tablePanel1.SetRow(this.comboCategory, 2);
            this.comboCategory.Size = new System.Drawing.Size(909, 44);
            this.comboCategory.TabIndex = 16;
            // 
            // labelControl8
            // 
            this.tablePanel1.SetColumn(this.labelControl8, 1);
            this.labelControl8.Location = new System.Drawing.Point(95, 79);
            this.labelControl8.Name = "labelControl8";
            this.tablePanel1.SetRow(this.labelControl8, 2);
            this.labelControl8.Size = new System.Drawing.Size(287, 50);
            this.labelControl8.TabIndex = 15;
            this.labelControl8.Text = "Select Category";
            // 
            // checkViewSolution
            // 
            this.tablePanel1.SetColumn(this.checkViewSolution, 2);
            this.checkViewSolution.Location = new System.Drawing.Point(1101, 529);
            this.checkViewSolution.Name = "checkViewSolution";
            this.checkViewSolution.Properties.Caption = "View solution";
            this.tablePanel1.SetRow(this.checkViewSolution, 8);
            this.checkViewSolution.Size = new System.Drawing.Size(909, 44);
            this.checkViewSolution.TabIndex = 14;
            // 
            // labelControl7
            // 
            this.tablePanel1.SetColumn(this.labelControl7, 1);
            this.labelControl7.Location = new System.Drawing.Point(95, 529);
            this.labelControl7.Name = "labelControl7";
            this.tablePanel1.SetRow(this.labelControl7, 8);
            this.labelControl7.Size = new System.Drawing.Size(338, 50);
            this.labelControl7.TabIndex = 13;
            this.labelControl7.Text = "Allow view Solution";
            // 
            // checkIsPublic
            // 
            this.tablePanel1.SetColumn(this.checkIsPublic, 2);
            this.checkIsPublic.Location = new System.Drawing.Point(1101, 479);
            this.checkIsPublic.Name = "checkIsPublic";
            this.checkIsPublic.Properties.Caption = "Is Public";
            this.tablePanel1.SetRow(this.checkIsPublic, 7);
            this.checkIsPublic.Size = new System.Drawing.Size(909, 44);
            this.checkIsPublic.TabIndex = 12;
            // 
            // labelControl6
            // 
            this.tablePanel1.SetColumn(this.labelControl6, 1);
            this.labelControl6.Location = new System.Drawing.Point(95, 479);
            this.labelControl6.Name = "labelControl6";
            this.tablePanel1.SetRow(this.labelControl6, 7);
            this.labelControl6.Size = new System.Drawing.Size(145, 50);
            this.labelControl6.TabIndex = 11;
            this.labelControl6.Text = "Is Public";
            // 
            // stackPanel1
            // 
            this.tablePanel1.SetColumn(this.stackPanel1, 1);
            this.stackPanel1.Controls.Add(this.btCreate);
            this.stackPanel1.Controls.Add(this.btUpdate);
            this.stackPanel1.Controls.Add(this.btDelete);
            this.stackPanel1.Controls.Add(this.btReport);
            this.stackPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stackPanel1.Location = new System.Drawing.Point(95, 579);
            this.stackPanel1.Name = "stackPanel1";
            this.tablePanel1.SetRow(this.stackPanel1, 9);
            this.stackPanel1.Size = new System.Drawing.Size(1001, 334);
            this.stackPanel1.TabIndex = 10;
            // 
            // btCreate
            // 
            this.btCreate.Location = new System.Drawing.Point(3, 67);
            this.btCreate.Name = "btCreate";
            this.btCreate.Size = new System.Drawing.Size(187, 57);
            this.btCreate.TabIndex = 1;
            this.btCreate.Text = "Create";
            this.btCreate.Click += new System.EventHandler(this.btCreate_Click);
            // 
            // btUpdate
            // 
            this.btUpdate.Location = new System.Drawing.Point(196, 67);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(187, 57);
            this.btUpdate.TabIndex = 0;
            this.btUpdate.Text = "Update";
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(389, 67);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(187, 57);
            this.btDelete.TabIndex = 2;
            this.btDelete.Text = "Delete";
            // 
            // btReport
            // 
            this.btReport.Location = new System.Drawing.Point(582, 67);
            this.btReport.Name = "btReport";
            this.btReport.Size = new System.Drawing.Size(187, 57);
            this.btReport.TabIndex = 3;
            this.btReport.Text = "Report";
            this.btReport.Click += new System.EventHandler(this.btReport_Click);
            // 
            // textDescription
            // 
            this.tablePanel1.SetColumn(this.textDescription, 2);
            this.textDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textDescription.Location = new System.Drawing.Point(1101, 279);
            this.textDescription.Name = "textDescription";
            this.textDescription.Properties.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tablePanel1.SetRow(this.textDescription, 6);
            this.textDescription.Size = new System.Drawing.Size(909, 194);
            this.textDescription.TabIndex = 9;
            // 
            // textShortDescription
            // 
            this.tablePanel1.SetColumn(this.textShortDescription, 2);
            this.textShortDescription.Location = new System.Drawing.Point(1101, 229);
            this.textShortDescription.Name = "textShortDescription";
            this.tablePanel1.SetRow(this.textShortDescription, 5);
            this.textShortDescription.Size = new System.Drawing.Size(909, 44);
            this.textShortDescription.TabIndex = 8;
            // 
            // textTitle
            // 
            this.tablePanel1.SetColumn(this.textTitle, 2);
            this.textTitle.Location = new System.Drawing.Point(1101, 179);
            this.textTitle.Name = "textTitle";
            this.tablePanel1.SetRow(this.textTitle, 4);
            this.textTitle.Size = new System.Drawing.Size(909, 44);
            this.textTitle.TabIndex = 7;
            // 
            // textName
            // 
            this.tablePanel1.SetColumn(this.textName, 2);
            this.textName.Location = new System.Drawing.Point(1101, 129);
            this.textName.Name = "textName";
            this.tablePanel1.SetRow(this.textName, 3);
            this.textName.Size = new System.Drawing.Size(909, 44);
            this.textName.TabIndex = 6;
            // 
            // labelControl5
            // 
            this.tablePanel1.SetColumn(this.labelControl5, 1);
            this.labelControl5.Location = new System.Drawing.Point(95, 351);
            this.labelControl5.Name = "labelControl5";
            this.tablePanel1.SetRow(this.labelControl5, 6);
            this.labelControl5.Size = new System.Drawing.Size(205, 50);
            this.labelControl5.TabIndex = 5;
            this.labelControl5.Text = "Description";
            // 
            // labelControl4
            // 
            this.tablePanel1.SetColumn(this.labelControl4, 1);
            this.labelControl4.Location = new System.Drawing.Point(95, 229);
            this.labelControl4.Name = "labelControl4";
            this.tablePanel1.SetRow(this.labelControl4, 5);
            this.labelControl4.Size = new System.Drawing.Size(310, 50);
            this.labelControl4.TabIndex = 4;
            this.labelControl4.Text = "Short Description";
            // 
            // labelControl3
            // 
            this.tablePanel1.SetColumn(this.labelControl3, 1);
            this.labelControl3.Location = new System.Drawing.Point(95, 179);
            this.labelControl3.Name = "labelControl3";
            this.tablePanel1.SetRow(this.labelControl3, 4);
            this.labelControl3.Size = new System.Drawing.Size(75, 50);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "Title";
            // 
            // labelControl2
            // 
            this.tablePanel1.SetColumn(this.labelControl2, 1);
            this.labelControl2.Location = new System.Drawing.Point(95, 129);
            this.labelControl2.Name = "labelControl2";
            this.tablePanel1.SetRow(this.labelControl2, 3);
            this.labelControl2.Size = new System.Drawing.Size(106, 50);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Name";
            // 
            // labelControl1
            // 
            this.tablePanel1.SetColumn(this.labelControl1, 1);
            this.labelControl1.Location = new System.Drawing.Point(95, 29);
            this.labelControl1.Name = "labelControl1";
            this.tablePanel1.SetRow(this.labelControl1, 1);
            this.labelControl1.Size = new System.Drawing.Size(340, 50);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Select Challenge Id";
            // 
            // comboChallengeId
            // 
            this.tablePanel1.SetColumn(this.comboChallengeId, 2);
            this.comboChallengeId.Location = new System.Drawing.Point(1101, 29);
            this.comboChallengeId.Name = "comboChallengeId";
            this.comboChallengeId.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tablePanel1.SetRow(this.comboChallengeId, 1);
            this.comboChallengeId.Size = new System.Drawing.Size(909, 44);
            this.comboChallengeId.TabIndex = 0;
            // 
            // tabNavigationPage2
            // 
            this.tabNavigationPage2.Caption = "Manage";
            this.tabNavigationPage2.Controls.Add(this.gridControl2);
            this.tabNavigationPage2.Controls.Add(this.challengeExplore1);
            this.tabNavigationPage2.Name = "tabNavigationPage2";
            this.tabNavigationPage2.PageVisible = false;
            this.tabNavigationPage2.Size = new System.Drawing.Size(2196, 1536);
            // 
            // gridControl2
            // 
            this.gridControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl2.Location = new System.Drawing.Point(0, 571);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(2196, 965);
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
            this.tabNavigationPage3.Size = new System.Drawing.Size(2196, 1426);
            // 
            // categoryEditor1
            // 
            this.categoryEditor1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.categoryEditor1.Location = new System.Drawing.Point(0, 0);
            this.categoryEditor1.Name = "categoryEditor1";
            this.categoryEditor1.Size = new System.Drawing.Size(2196, 1426);
            this.categoryEditor1.TabIndex = 0;
            // 
            // pageReport
            // 
            this.pageReport.Caption = "Report";
            this.pageReport.Controls.Add(this.documentViewer1);
            this.pageReport.Controls.Add(this.barDockControlLeft);
            this.pageReport.Controls.Add(this.barDockControlRight);
            this.pageReport.Controls.Add(this.barDockControlBottom);
            this.pageReport.Controls.Add(this.barDockControlTop);
            this.pageReport.Name = "pageReport";
            this.pageReport.Size = new System.Drawing.Size(2196, 1536);
            // 
            // documentViewer1
            // 
            this.documentViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.documentViewer1.IsMetric = false;
            this.documentViewer1.Location = new System.Drawing.Point(0, 139);
            this.documentViewer1.Name = "documentViewer1";
            this.documentViewer1.Size = new System.Drawing.Size(2196, 1330);
            this.documentViewer1.TabIndex = 0;
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 139);
            this.barDockControlLeft.Manager = this.documentViewerBarManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 1330);
            // 
            // documentViewerBarManager1
            // 
            this.documentViewerBarManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.previewBar1,
            this.previewBar2,
            this.previewBar3});
            this.documentViewerBarManager1.DockControls.Add(this.barDockControlTop);
            this.documentViewerBarManager1.DockControls.Add(this.barDockControlBottom);
            this.documentViewerBarManager1.DockControls.Add(this.barDockControlLeft);
            this.documentViewerBarManager1.DockControls.Add(this.barDockControlRight);
            this.documentViewerBarManager1.DocumentViewer = this.documentViewer1;
            this.documentViewerBarManager1.Form = this.pageReport;
            this.documentViewerBarManager1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("documentViewerBarManager1.ImageStream")));
            this.documentViewerBarManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.printPreviewStaticItem1,
            this.progressBarEditItem1,
            this.printPreviewBarItem1,
            this.printPreviewStaticItem2,
            this.zoomTrackBarEditItem1,
            this.bbiDocumentMap,
            this.bbiParameters,
            this.bbiThumbnails,
            this.bbiFind,
            this.bbiHighlightEditingFields,
            this.bbiCustomize,
            this.bbiOpen,
            this.bbiSave,
            this.bbiPrint,
            this.bbiPrintDirect,
            this.bbiPageSetup,
            this.bbiEditPageHF,
            this.bbiScale,
            this.bbiHandTool,
            this.bbiMagnifier,
            this.bbiZoomOut,
            this.bbiZoom,
            this.bbiZoomIn,
            this.bbiShowFirstPage,
            this.bbiShowPrevPage,
            this.bbiShowNextPage,
            this.bbiShowLastPage,
            this.bbiMultiplePages,
            this.bbiFillBackground,
            this.bbiWatermark,
            this.bbiExportFile,
            this.bbiSendFile,
            this.bbiClosePreview,
            this.miFile,
            this.miView,
            this.miBackground,
            this.miPageLayout,
            this.miPageLayoutFacing,
            this.miPageLayoutContinuous,
            this.miToolbars,
            this.printPreviewBarCheckItem1,
            this.printPreviewBarCheckItem2,
            this.printPreviewBarCheckItem3,
            this.printPreviewBarCheckItem4,
            this.printPreviewBarCheckItem5,
            this.printPreviewBarCheckItem6,
            this.printPreviewBarCheckItem7,
            this.printPreviewBarCheckItem8,
            this.printPreviewBarCheckItem9,
            this.printPreviewBarCheckItem10,
            this.printPreviewBarCheckItem11,
            this.printPreviewBarCheckItem12,
            this.printPreviewBarCheckItem13,
            this.printPreviewBarCheckItem14,
            this.printPreviewBarCheckItem15,
            this.printPreviewBarCheckItem16,
            this.printPreviewBarCheckItem17,
            this.printPreviewBarCheckItem18,
            this.printPreviewBarCheckItem19});
            this.documentViewerBarManager1.MainMenu = this.previewBar3;
            this.documentViewerBarManager1.MaxItemId = 59;
            this.documentViewerBarManager1.PreviewBar = this.previewBar1;
            this.documentViewerBarManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemProgressBar1,
            this.repositoryItemZoomTrackBar1,
            this.printPreviewRepositoryItemComboBox1});
            this.documentViewerBarManager1.StatusBar = this.previewBar2;
            this.documentViewerBarManager1.TransparentEditorsMode = DevExpress.Utils.DefaultBoolean.True;
            // 
            // previewBar1
            // 
            this.previewBar1.BarName = "Toolbar";
            this.previewBar1.DockCol = 0;
            this.previewBar1.DockRow = 1;
            this.previewBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.previewBar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiDocumentMap),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiParameters),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiThumbnails),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiFind),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiHighlightEditingFields),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiCustomize, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiOpen, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiSave),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiPrint, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiPrintDirect),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiPageSetup),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiEditPageHF),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiScale),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiHandTool, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiMagnifier),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiZoomOut, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiZoom),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiZoomIn),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiShowFirstPage, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiShowPrevPage),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiShowNextPage),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiShowLastPage),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiMultiplePages, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiFillBackground),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiWatermark),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiExportFile, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiSendFile),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiClosePreview, true)});
            this.previewBar1.Text = "Toolbar";
            // 
            // bbiDocumentMap
            // 
            this.bbiDocumentMap.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check;
            this.bbiDocumentMap.Caption = "Document Map";
            this.bbiDocumentMap.Command = DevExpress.XtraPrinting.PrintingSystemCommand.DocumentMap;
            this.bbiDocumentMap.Enabled = false;
            this.bbiDocumentMap.Hint = "Document Map";
            this.bbiDocumentMap.Id = 5;
            this.bbiDocumentMap.Name = "bbiDocumentMap";
            // 
            // bbiParameters
            // 
            this.bbiParameters.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check;
            this.bbiParameters.Caption = "Parameters";
            this.bbiParameters.Command = DevExpress.XtraPrinting.PrintingSystemCommand.Parameters;
            this.bbiParameters.Enabled = false;
            this.bbiParameters.Hint = "Parameters";
            this.bbiParameters.Id = 6;
            this.bbiParameters.Name = "bbiParameters";
            // 
            // bbiThumbnails
            // 
            this.bbiThumbnails.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check;
            this.bbiThumbnails.Caption = "Thumbnails";
            this.bbiThumbnails.Command = DevExpress.XtraPrinting.PrintingSystemCommand.Thumbnails;
            this.bbiThumbnails.Enabled = false;
            this.bbiThumbnails.Hint = "Thumbnails";
            this.bbiThumbnails.Id = 7;
            this.bbiThumbnails.Name = "bbiThumbnails";
            // 
            // bbiFind
            // 
            this.bbiFind.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check;
            this.bbiFind.Caption = "Search";
            this.bbiFind.Command = DevExpress.XtraPrinting.PrintingSystemCommand.Find;
            this.bbiFind.Enabled = false;
            this.bbiFind.Hint = "Search";
            this.bbiFind.Id = 8;
            this.bbiFind.Name = "bbiFind";
            // 
            // bbiHighlightEditingFields
            // 
            this.bbiHighlightEditingFields.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check;
            this.bbiHighlightEditingFields.Caption = "Editing Fields";
            this.bbiHighlightEditingFields.Command = DevExpress.XtraPrinting.PrintingSystemCommand.HighlightEditingFields;
            this.bbiHighlightEditingFields.Enabled = false;
            this.bbiHighlightEditingFields.Hint = "Highlight Editing Fields";
            this.bbiHighlightEditingFields.Id = 9;
            this.bbiHighlightEditingFields.Name = "bbiHighlightEditingFields";
            // 
            // bbiCustomize
            // 
            this.bbiCustomize.Caption = "Customize";
            this.bbiCustomize.Command = DevExpress.XtraPrinting.PrintingSystemCommand.Customize;
            this.bbiCustomize.Enabled = false;
            this.bbiCustomize.Hint = "Customize";
            this.bbiCustomize.Id = 10;
            this.bbiCustomize.Name = "bbiCustomize";
            // 
            // bbiOpen
            // 
            this.bbiOpen.Caption = "Open";
            this.bbiOpen.Command = DevExpress.XtraPrinting.PrintingSystemCommand.Open;
            this.bbiOpen.Enabled = false;
            this.bbiOpen.Hint = "Open a document";
            this.bbiOpen.Id = 11;
            this.bbiOpen.Name = "bbiOpen";
            // 
            // bbiSave
            // 
            this.bbiSave.Caption = "Save";
            this.bbiSave.Command = DevExpress.XtraPrinting.PrintingSystemCommand.Save;
            this.bbiSave.Enabled = false;
            this.bbiSave.Hint = "Save the document";
            this.bbiSave.Id = 12;
            this.bbiSave.Name = "bbiSave";
            // 
            // bbiPrint
            // 
            this.bbiPrint.Caption = "&Print...";
            this.bbiPrint.Command = DevExpress.XtraPrinting.PrintingSystemCommand.Print;
            this.bbiPrint.Enabled = false;
            this.bbiPrint.Hint = "Print";
            this.bbiPrint.Id = 13;
            this.bbiPrint.Name = "bbiPrint";
            // 
            // bbiPrintDirect
            // 
            this.bbiPrintDirect.Caption = "P&rint";
            this.bbiPrintDirect.Command = DevExpress.XtraPrinting.PrintingSystemCommand.PrintDirect;
            this.bbiPrintDirect.Enabled = false;
            this.bbiPrintDirect.Hint = "Quick Print";
            this.bbiPrintDirect.Id = 14;
            this.bbiPrintDirect.Name = "bbiPrintDirect";
            // 
            // bbiPageSetup
            // 
            this.bbiPageSetup.Caption = "Page Set&up...";
            this.bbiPageSetup.Command = DevExpress.XtraPrinting.PrintingSystemCommand.PageSetup;
            this.bbiPageSetup.Enabled = false;
            this.bbiPageSetup.Hint = "Page Setup";
            this.bbiPageSetup.Id = 15;
            this.bbiPageSetup.Name = "bbiPageSetup";
            // 
            // bbiEditPageHF
            // 
            this.bbiEditPageHF.Caption = "Header And Footer";
            this.bbiEditPageHF.Command = DevExpress.XtraPrinting.PrintingSystemCommand.EditPageHF;
            this.bbiEditPageHF.Enabled = false;
            this.bbiEditPageHF.Hint = "Header And Footer";
            this.bbiEditPageHF.Id = 16;
            this.bbiEditPageHF.Name = "bbiEditPageHF";
            // 
            // bbiScale
            // 
            this.bbiScale.ActAsDropDown = true;
            this.bbiScale.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.bbiScale.Caption = "Scale";
            this.bbiScale.Command = DevExpress.XtraPrinting.PrintingSystemCommand.Scale;
            this.bbiScale.Enabled = false;
            this.bbiScale.Hint = "Scale";
            this.bbiScale.Id = 17;
            this.bbiScale.Name = "bbiScale";
            // 
            // bbiHandTool
            // 
            this.bbiHandTool.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check;
            this.bbiHandTool.Caption = "Hand Tool";
            this.bbiHandTool.Command = DevExpress.XtraPrinting.PrintingSystemCommand.HandTool;
            this.bbiHandTool.Enabled = false;
            this.bbiHandTool.Hint = "Hand Tool";
            this.bbiHandTool.Id = 18;
            this.bbiHandTool.Name = "bbiHandTool";
            // 
            // bbiMagnifier
            // 
            this.bbiMagnifier.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check;
            this.bbiMagnifier.Caption = "Magnifier";
            this.bbiMagnifier.Command = DevExpress.XtraPrinting.PrintingSystemCommand.Magnifier;
            this.bbiMagnifier.Enabled = false;
            this.bbiMagnifier.Hint = "Magnifier";
            this.bbiMagnifier.Id = 19;
            this.bbiMagnifier.Name = "bbiMagnifier";
            // 
            // bbiZoomOut
            // 
            this.bbiZoomOut.Caption = "Zoom Out";
            this.bbiZoomOut.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ZoomOut;
            this.bbiZoomOut.Enabled = false;
            this.bbiZoomOut.Hint = "Zoom Out";
            this.bbiZoomOut.Id = 20;
            this.bbiZoomOut.Name = "bbiZoomOut";
            // 
            // bbiZoom
            // 
            this.bbiZoom.Caption = "Zoom";
            this.bbiZoom.Edit = this.printPreviewRepositoryItemComboBox1;
            this.bbiZoom.EditValue = "100%";
            this.bbiZoom.EditWidth = 70;
            this.bbiZoom.Enabled = false;
            this.bbiZoom.Hint = "Zoom";
            this.bbiZoom.Id = 21;
            this.bbiZoom.Name = "bbiZoom";
            // 
            // printPreviewRepositoryItemComboBox1
            // 
            this.printPreviewRepositoryItemComboBox1.AutoComplete = false;
            this.printPreviewRepositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.printPreviewRepositoryItemComboBox1.DropDownRows = 11;
            this.printPreviewRepositoryItemComboBox1.Name = "printPreviewRepositoryItemComboBox1";
            // 
            // bbiZoomIn
            // 
            this.bbiZoomIn.Caption = "Zoom In";
            this.bbiZoomIn.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ZoomIn;
            this.bbiZoomIn.Enabled = false;
            this.bbiZoomIn.Hint = "Zoom In";
            this.bbiZoomIn.Id = 22;
            this.bbiZoomIn.Name = "bbiZoomIn";
            // 
            // bbiShowFirstPage
            // 
            this.bbiShowFirstPage.Caption = "First Page";
            this.bbiShowFirstPage.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ShowFirstPage;
            this.bbiShowFirstPage.Enabled = false;
            this.bbiShowFirstPage.Hint = "First Page";
            this.bbiShowFirstPage.Id = 23;
            this.bbiShowFirstPage.Name = "bbiShowFirstPage";
            // 
            // bbiShowPrevPage
            // 
            this.bbiShowPrevPage.Caption = "Previous Page";
            this.bbiShowPrevPage.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ShowPrevPage;
            this.bbiShowPrevPage.Enabled = false;
            this.bbiShowPrevPage.Hint = "Previous Page";
            this.bbiShowPrevPage.Id = 24;
            this.bbiShowPrevPage.Name = "bbiShowPrevPage";
            // 
            // bbiShowNextPage
            // 
            this.bbiShowNextPage.Caption = "Next Page";
            this.bbiShowNextPage.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ShowNextPage;
            this.bbiShowNextPage.Enabled = false;
            this.bbiShowNextPage.Hint = "Next Page";
            this.bbiShowNextPage.Id = 25;
            this.bbiShowNextPage.Name = "bbiShowNextPage";
            // 
            // bbiShowLastPage
            // 
            this.bbiShowLastPage.Caption = "Last Page";
            this.bbiShowLastPage.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ShowLastPage;
            this.bbiShowLastPage.Enabled = false;
            this.bbiShowLastPage.Hint = "Last Page";
            this.bbiShowLastPage.Id = 26;
            this.bbiShowLastPage.Name = "bbiShowLastPage";
            // 
            // bbiMultiplePages
            // 
            this.bbiMultiplePages.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.bbiMultiplePages.Caption = "Multiple Pages";
            this.bbiMultiplePages.Command = DevExpress.XtraPrinting.PrintingSystemCommand.MultiplePages;
            this.bbiMultiplePages.Enabled = false;
            this.bbiMultiplePages.Hint = "Multiple Pages";
            this.bbiMultiplePages.Id = 27;
            this.bbiMultiplePages.Name = "bbiMultiplePages";
            // 
            // bbiFillBackground
            // 
            this.bbiFillBackground.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.bbiFillBackground.Caption = "&Color...";
            this.bbiFillBackground.Command = DevExpress.XtraPrinting.PrintingSystemCommand.FillBackground;
            this.bbiFillBackground.Enabled = false;
            this.bbiFillBackground.Hint = "Background";
            this.bbiFillBackground.Id = 28;
            this.bbiFillBackground.Name = "bbiFillBackground";
            // 
            // bbiWatermark
            // 
            this.bbiWatermark.Caption = "&Watermark...";
            this.bbiWatermark.Command = DevExpress.XtraPrinting.PrintingSystemCommand.Watermark;
            this.bbiWatermark.Enabled = false;
            this.bbiWatermark.Hint = "Watermark";
            this.bbiWatermark.Id = 29;
            this.bbiWatermark.Name = "bbiWatermark";
            // 
            // bbiExportFile
            // 
            this.bbiExportFile.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.bbiExportFile.Caption = "Export Document...";
            this.bbiExportFile.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ExportFile;
            this.bbiExportFile.Enabled = false;
            this.bbiExportFile.Hint = "Export Document...";
            this.bbiExportFile.Id = 30;
            this.bbiExportFile.Name = "bbiExportFile";
            // 
            // bbiSendFile
            // 
            this.bbiSendFile.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.bbiSendFile.Caption = "Send via E-Mail...";
            this.bbiSendFile.Command = DevExpress.XtraPrinting.PrintingSystemCommand.SendFile;
            this.bbiSendFile.Enabled = false;
            this.bbiSendFile.Hint = "Send via E-Mail...";
            this.bbiSendFile.Id = 31;
            this.bbiSendFile.Name = "bbiSendFile";
            // 
            // bbiClosePreview
            // 
            this.bbiClosePreview.Caption = "E&xit";
            this.bbiClosePreview.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ClosePreview;
            this.bbiClosePreview.Enabled = false;
            this.bbiClosePreview.Hint = "Close Preview";
            this.bbiClosePreview.Id = 32;
            this.bbiClosePreview.Name = "bbiClosePreview";
            // 
            // previewBar2
            // 
            this.previewBar2.BarName = "Status Bar";
            this.previewBar2.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.previewBar2.DockCol = 0;
            this.previewBar2.DockRow = 0;
            this.previewBar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.previewBar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.printPreviewStaticItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.progressBarEditItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.printPreviewBarItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.printPreviewStaticItem2, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.zoomTrackBarEditItem1)});
            this.previewBar2.OptionsBar.AllowQuickCustomization = false;
            this.previewBar2.OptionsBar.DrawDragBorder = false;
            this.previewBar2.OptionsBar.UseWholeRow = true;
            this.previewBar2.Text = "Status Bar";
            // 
            // printPreviewStaticItem1
            // 
            this.printPreviewStaticItem1.Border = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.printPreviewStaticItem1.Caption = "Nothing";
            this.printPreviewStaticItem1.Id = 0;
            this.printPreviewStaticItem1.LeftIndent = 1;
            this.printPreviewStaticItem1.Name = "printPreviewStaticItem1";
            this.printPreviewStaticItem1.RightIndent = 1;
            this.printPreviewStaticItem1.Type = "PageOfPages";
            // 
            // progressBarEditItem1
            // 
            this.progressBarEditItem1.Edit = this.repositoryItemProgressBar1;
            this.progressBarEditItem1.EditHeight = 12;
            this.progressBarEditItem1.EditWidth = 150;
            this.progressBarEditItem1.Id = 1;
            this.progressBarEditItem1.Name = "progressBarEditItem1";
            this.progressBarEditItem1.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // repositoryItemProgressBar1
            // 
            this.repositoryItemProgressBar1.Name = "repositoryItemProgressBar1";
            // 
            // printPreviewBarItem1
            // 
            this.printPreviewBarItem1.Caption = "Stop";
            this.printPreviewBarItem1.Command = DevExpress.XtraPrinting.PrintingSystemCommand.StopPageBuilding;
            this.printPreviewBarItem1.Enabled = false;
            this.printPreviewBarItem1.Hint = "Stop";
            this.printPreviewBarItem1.Id = 2;
            this.printPreviewBarItem1.Name = "printPreviewBarItem1";
            this.printPreviewBarItem1.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // printPreviewStaticItem2
            // 
            this.printPreviewStaticItem2.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.printPreviewStaticItem2.Border = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.printPreviewStaticItem2.Caption = "100%";
            this.printPreviewStaticItem2.Id = 3;
            this.printPreviewStaticItem2.Name = "printPreviewStaticItem2";
            this.printPreviewStaticItem2.TextAlignment = System.Drawing.StringAlignment.Far;
            this.printPreviewStaticItem2.Type = "ZoomFactor";
            // 
            // zoomTrackBarEditItem1
            // 
            this.zoomTrackBarEditItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.zoomTrackBarEditItem1.Edit = this.repositoryItemZoomTrackBar1;
            this.zoomTrackBarEditItem1.EditValue = 90;
            this.zoomTrackBarEditItem1.EditWidth = 140;
            this.zoomTrackBarEditItem1.Enabled = false;
            this.zoomTrackBarEditItem1.Id = 4;
            this.zoomTrackBarEditItem1.Name = "zoomTrackBarEditItem1";
            this.zoomTrackBarEditItem1.Range = new int[] {
        10,
        500};
            // 
            // repositoryItemZoomTrackBar1
            // 
            this.repositoryItemZoomTrackBar1.Alignment = DevExpress.Utils.VertAlignment.Center;
            this.repositoryItemZoomTrackBar1.AllowFocused = false;
            this.repositoryItemZoomTrackBar1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.repositoryItemZoomTrackBar1.Maximum = 180;
            this.repositoryItemZoomTrackBar1.Name = "repositoryItemZoomTrackBar1";
            // 
            // previewBar3
            // 
            this.previewBar3.BarName = "Main Menu";
            this.previewBar3.DockCol = 0;
            this.previewBar3.DockRow = 0;
            this.previewBar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.previewBar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.miFile),
            new DevExpress.XtraBars.LinkPersistInfo(this.miView),
            new DevExpress.XtraBars.LinkPersistInfo(this.miBackground)});
            this.previewBar3.OptionsBar.MultiLine = true;
            this.previewBar3.OptionsBar.UseWholeRow = true;
            this.previewBar3.Text = "Main Menu";
            // 
            // miFile
            // 
            this.miFile.Caption = "&File";
            this.miFile.Command = DevExpress.XtraPrinting.PrintingSystemCommand.File;
            this.miFile.Id = 33;
            this.miFile.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiPageSetup),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiPrint),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiPrintDirect),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiExportFile, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiSendFile),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiClosePreview, true)});
            this.miFile.Name = "miFile";
            // 
            // miView
            // 
            this.miView.Caption = "&View";
            this.miView.Command = DevExpress.XtraPrinting.PrintingSystemCommand.View;
            this.miView.Id = 34;
            this.miView.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.miPageLayout, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.miToolbars, true)});
            this.miView.Name = "miView";
            // 
            // miPageLayout
            // 
            this.miPageLayout.Caption = "&Page Layout";
            this.miPageLayout.Command = DevExpress.XtraPrinting.PrintingSystemCommand.PageLayout;
            this.miPageLayout.Id = 36;
            this.miPageLayout.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.miPageLayoutFacing),
            new DevExpress.XtraBars.LinkPersistInfo(this.miPageLayoutContinuous)});
            this.miPageLayout.Name = "miPageLayout";
            // 
            // miPageLayoutFacing
            // 
            this.miPageLayoutFacing.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check;
            this.miPageLayoutFacing.Caption = "&Facing";
            this.miPageLayoutFacing.Command = DevExpress.XtraPrinting.PrintingSystemCommand.PageLayoutFacing;
            this.miPageLayoutFacing.Enabled = false;
            this.miPageLayoutFacing.GroupIndex = 100;
            this.miPageLayoutFacing.Id = 37;
            this.miPageLayoutFacing.Name = "miPageLayoutFacing";
            // 
            // miPageLayoutContinuous
            // 
            this.miPageLayoutContinuous.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check;
            this.miPageLayoutContinuous.Caption = "&Continuous";
            this.miPageLayoutContinuous.Command = DevExpress.XtraPrinting.PrintingSystemCommand.PageLayoutContinuous;
            this.miPageLayoutContinuous.Enabled = false;
            this.miPageLayoutContinuous.GroupIndex = 100;
            this.miPageLayoutContinuous.Id = 38;
            this.miPageLayoutContinuous.Name = "miPageLayoutContinuous";
            // 
            // miToolbars
            // 
            this.miToolbars.Caption = "Bars";
            this.miToolbars.Id = 39;
            this.miToolbars.Name = "miToolbars";
            // 
            // miBackground
            // 
            this.miBackground.Caption = "&Background";
            this.miBackground.Command = DevExpress.XtraPrinting.PrintingSystemCommand.Background;
            this.miBackground.Id = 35;
            this.miBackground.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiFillBackground),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiWatermark)});
            this.miBackground.Name = "miBackground";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.documentViewerBarManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(2196, 139);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 1469);
            this.barDockControlBottom.Manager = this.documentViewerBarManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(2196, 67);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(2196, 139);
            this.barDockControlRight.Manager = this.documentViewerBarManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 1330);
            // 
            // printPreviewBarCheckItem1
            // 
            this.printPreviewBarCheckItem1.BindableChecked = true;
            this.printPreviewBarCheckItem1.Caption = "PDF File";
            this.printPreviewBarCheckItem1.Checked = true;
            this.printPreviewBarCheckItem1.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ExportPdf;
            this.printPreviewBarCheckItem1.Enabled = false;
            this.printPreviewBarCheckItem1.GroupIndex = 2;
            this.printPreviewBarCheckItem1.Hint = "PDF File";
            this.printPreviewBarCheckItem1.Id = 40;
            this.printPreviewBarCheckItem1.Name = "printPreviewBarCheckItem1";
            // 
            // printPreviewBarCheckItem2
            // 
            this.printPreviewBarCheckItem2.Caption = "HTML File";
            this.printPreviewBarCheckItem2.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ExportHtm;
            this.printPreviewBarCheckItem2.Enabled = false;
            this.printPreviewBarCheckItem2.GroupIndex = 2;
            this.printPreviewBarCheckItem2.Hint = "HTML File";
            this.printPreviewBarCheckItem2.Id = 41;
            this.printPreviewBarCheckItem2.Name = "printPreviewBarCheckItem2";
            // 
            // printPreviewBarCheckItem3
            // 
            this.printPreviewBarCheckItem3.Caption = "MHT File";
            this.printPreviewBarCheckItem3.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ExportMht;
            this.printPreviewBarCheckItem3.Enabled = false;
            this.printPreviewBarCheckItem3.GroupIndex = 2;
            this.printPreviewBarCheckItem3.Hint = "MHT File";
            this.printPreviewBarCheckItem3.Id = 42;
            this.printPreviewBarCheckItem3.Name = "printPreviewBarCheckItem3";
            // 
            // printPreviewBarCheckItem4
            // 
            this.printPreviewBarCheckItem4.Caption = "RTF File";
            this.printPreviewBarCheckItem4.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ExportRtf;
            this.printPreviewBarCheckItem4.Enabled = false;
            this.printPreviewBarCheckItem4.GroupIndex = 2;
            this.printPreviewBarCheckItem4.Hint = "RTF File";
            this.printPreviewBarCheckItem4.Id = 43;
            this.printPreviewBarCheckItem4.Name = "printPreviewBarCheckItem4";
            // 
            // printPreviewBarCheckItem5
            // 
            this.printPreviewBarCheckItem5.Caption = "DOCX File";
            this.printPreviewBarCheckItem5.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ExportDocx;
            this.printPreviewBarCheckItem5.Enabled = false;
            this.printPreviewBarCheckItem5.GroupIndex = 2;
            this.printPreviewBarCheckItem5.Hint = "DOCX File";
            this.printPreviewBarCheckItem5.Id = 44;
            this.printPreviewBarCheckItem5.Name = "printPreviewBarCheckItem5";
            // 
            // printPreviewBarCheckItem6
            // 
            this.printPreviewBarCheckItem6.Caption = "XLS File";
            this.printPreviewBarCheckItem6.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ExportXls;
            this.printPreviewBarCheckItem6.Enabled = false;
            this.printPreviewBarCheckItem6.GroupIndex = 2;
            this.printPreviewBarCheckItem6.Hint = "XLS File";
            this.printPreviewBarCheckItem6.Id = 45;
            this.printPreviewBarCheckItem6.Name = "printPreviewBarCheckItem6";
            // 
            // printPreviewBarCheckItem7
            // 
            this.printPreviewBarCheckItem7.Caption = "XLSX File";
            this.printPreviewBarCheckItem7.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ExportXlsx;
            this.printPreviewBarCheckItem7.Enabled = false;
            this.printPreviewBarCheckItem7.GroupIndex = 2;
            this.printPreviewBarCheckItem7.Hint = "XLSX File";
            this.printPreviewBarCheckItem7.Id = 46;
            this.printPreviewBarCheckItem7.Name = "printPreviewBarCheckItem7";
            // 
            // printPreviewBarCheckItem8
            // 
            this.printPreviewBarCheckItem8.Caption = "CSV File";
            this.printPreviewBarCheckItem8.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ExportCsv;
            this.printPreviewBarCheckItem8.Enabled = false;
            this.printPreviewBarCheckItem8.GroupIndex = 2;
            this.printPreviewBarCheckItem8.Hint = "CSV File";
            this.printPreviewBarCheckItem8.Id = 47;
            this.printPreviewBarCheckItem8.Name = "printPreviewBarCheckItem8";
            // 
            // printPreviewBarCheckItem9
            // 
            this.printPreviewBarCheckItem9.Caption = "Text File";
            this.printPreviewBarCheckItem9.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ExportTxt;
            this.printPreviewBarCheckItem9.Enabled = false;
            this.printPreviewBarCheckItem9.GroupIndex = 2;
            this.printPreviewBarCheckItem9.Hint = "Text File";
            this.printPreviewBarCheckItem9.Id = 48;
            this.printPreviewBarCheckItem9.Name = "printPreviewBarCheckItem9";
            // 
            // printPreviewBarCheckItem10
            // 
            this.printPreviewBarCheckItem10.Caption = "Image File";
            this.printPreviewBarCheckItem10.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ExportGraphic;
            this.printPreviewBarCheckItem10.Enabled = false;
            this.printPreviewBarCheckItem10.GroupIndex = 2;
            this.printPreviewBarCheckItem10.Hint = "Image File";
            this.printPreviewBarCheckItem10.Id = 49;
            this.printPreviewBarCheckItem10.Name = "printPreviewBarCheckItem10";
            // 
            // printPreviewBarCheckItem11
            // 
            this.printPreviewBarCheckItem11.BindableChecked = true;
            this.printPreviewBarCheckItem11.Caption = "PDF File";
            this.printPreviewBarCheckItem11.Checked = true;
            this.printPreviewBarCheckItem11.Command = DevExpress.XtraPrinting.PrintingSystemCommand.SendPdf;
            this.printPreviewBarCheckItem11.Enabled = false;
            this.printPreviewBarCheckItem11.GroupIndex = 1;
            this.printPreviewBarCheckItem11.Hint = "PDF File";
            this.printPreviewBarCheckItem11.Id = 50;
            this.printPreviewBarCheckItem11.Name = "printPreviewBarCheckItem11";
            // 
            // printPreviewBarCheckItem12
            // 
            this.printPreviewBarCheckItem12.Caption = "MHT File";
            this.printPreviewBarCheckItem12.Command = DevExpress.XtraPrinting.PrintingSystemCommand.SendMht;
            this.printPreviewBarCheckItem12.Enabled = false;
            this.printPreviewBarCheckItem12.GroupIndex = 1;
            this.printPreviewBarCheckItem12.Hint = "MHT File";
            this.printPreviewBarCheckItem12.Id = 51;
            this.printPreviewBarCheckItem12.Name = "printPreviewBarCheckItem12";
            // 
            // printPreviewBarCheckItem13
            // 
            this.printPreviewBarCheckItem13.Caption = "RTF File";
            this.printPreviewBarCheckItem13.Command = DevExpress.XtraPrinting.PrintingSystemCommand.SendRtf;
            this.printPreviewBarCheckItem13.Enabled = false;
            this.printPreviewBarCheckItem13.GroupIndex = 1;
            this.printPreviewBarCheckItem13.Hint = "RTF File";
            this.printPreviewBarCheckItem13.Id = 52;
            this.printPreviewBarCheckItem13.Name = "printPreviewBarCheckItem13";
            // 
            // printPreviewBarCheckItem14
            // 
            this.printPreviewBarCheckItem14.Caption = "DOCX File";
            this.printPreviewBarCheckItem14.Command = DevExpress.XtraPrinting.PrintingSystemCommand.SendDocx;
            this.printPreviewBarCheckItem14.Enabled = false;
            this.printPreviewBarCheckItem14.GroupIndex = 1;
            this.printPreviewBarCheckItem14.Hint = "DOCX File";
            this.printPreviewBarCheckItem14.Id = 53;
            this.printPreviewBarCheckItem14.Name = "printPreviewBarCheckItem14";
            // 
            // printPreviewBarCheckItem15
            // 
            this.printPreviewBarCheckItem15.Caption = "XLS File";
            this.printPreviewBarCheckItem15.Command = DevExpress.XtraPrinting.PrintingSystemCommand.SendXls;
            this.printPreviewBarCheckItem15.Enabled = false;
            this.printPreviewBarCheckItem15.GroupIndex = 1;
            this.printPreviewBarCheckItem15.Hint = "XLS File";
            this.printPreviewBarCheckItem15.Id = 54;
            this.printPreviewBarCheckItem15.Name = "printPreviewBarCheckItem15";
            // 
            // printPreviewBarCheckItem16
            // 
            this.printPreviewBarCheckItem16.Caption = "XLSX File";
            this.printPreviewBarCheckItem16.Command = DevExpress.XtraPrinting.PrintingSystemCommand.SendXlsx;
            this.printPreviewBarCheckItem16.Enabled = false;
            this.printPreviewBarCheckItem16.GroupIndex = 1;
            this.printPreviewBarCheckItem16.Hint = "XLSX File";
            this.printPreviewBarCheckItem16.Id = 55;
            this.printPreviewBarCheckItem16.Name = "printPreviewBarCheckItem16";
            // 
            // printPreviewBarCheckItem17
            // 
            this.printPreviewBarCheckItem17.Caption = "CSV File";
            this.printPreviewBarCheckItem17.Command = DevExpress.XtraPrinting.PrintingSystemCommand.SendCsv;
            this.printPreviewBarCheckItem17.Enabled = false;
            this.printPreviewBarCheckItem17.GroupIndex = 1;
            this.printPreviewBarCheckItem17.Hint = "CSV File";
            this.printPreviewBarCheckItem17.Id = 56;
            this.printPreviewBarCheckItem17.Name = "printPreviewBarCheckItem17";
            // 
            // printPreviewBarCheckItem18
            // 
            this.printPreviewBarCheckItem18.Caption = "Text File";
            this.printPreviewBarCheckItem18.Command = DevExpress.XtraPrinting.PrintingSystemCommand.SendTxt;
            this.printPreviewBarCheckItem18.Enabled = false;
            this.printPreviewBarCheckItem18.GroupIndex = 1;
            this.printPreviewBarCheckItem18.Hint = "Text File";
            this.printPreviewBarCheckItem18.Id = 57;
            this.printPreviewBarCheckItem18.Name = "printPreviewBarCheckItem18";
            // 
            // printPreviewBarCheckItem19
            // 
            this.printPreviewBarCheckItem19.Caption = "Image File";
            this.printPreviewBarCheckItem19.Command = DevExpress.XtraPrinting.PrintingSystemCommand.SendGraphic;
            this.printPreviewBarCheckItem19.Enabled = false;
            this.printPreviewBarCheckItem19.GroupIndex = 1;
            this.printPreviewBarCheckItem19.Hint = "Image File";
            this.printPreviewBarCheckItem19.Id = 58;
            this.printPreviewBarCheckItem19.Name = "printPreviewBarCheckItem19";
            // 
            // xtraOpenFileDialog1
            // 
            this.xtraOpenFileDialog1.FileName = "xtraOpenFileDialog1";
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
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.tabNavigationPage3.ResumeLayout(false);
            this.pageReport.ResumeLayout(false);
            this.pageReport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.documentViewerBarManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printPreviewRepositoryItemComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemProgressBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemZoomTrackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
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
        private DevExpress.XtraEditors.SimpleButton btReport;
        private DevExpress.XtraBars.Navigation.TabNavigationPage pageReport;
        private DevExpress.XtraPrinting.Preview.DocumentViewer documentViewer1;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraPrinting.Preview.DocumentViewerBarManager documentViewerBarManager1;
        private DevExpress.XtraPrinting.Preview.PreviewBar previewBar1;
        private DevExpress.XtraPrinting.Preview.PrintPreviewBarItem bbiDocumentMap;
        private DevExpress.XtraPrinting.Preview.PrintPreviewBarItem bbiParameters;
        private DevExpress.XtraPrinting.Preview.PrintPreviewBarItem bbiThumbnails;
        private DevExpress.XtraPrinting.Preview.PrintPreviewBarItem bbiFind;
        private DevExpress.XtraPrinting.Preview.PrintPreviewBarItem bbiHighlightEditingFields;
        private DevExpress.XtraPrinting.Preview.PrintPreviewBarItem bbiCustomize;
        private DevExpress.XtraPrinting.Preview.PrintPreviewBarItem bbiOpen;
        private DevExpress.XtraPrinting.Preview.PrintPreviewBarItem bbiSave;
        private DevExpress.XtraPrinting.Preview.PrintPreviewBarItem bbiPrint;
        private DevExpress.XtraPrinting.Preview.PrintPreviewBarItem bbiPrintDirect;
        private DevExpress.XtraPrinting.Preview.PrintPreviewBarItem bbiPageSetup;
        private DevExpress.XtraPrinting.Preview.PrintPreviewBarItem bbiEditPageHF;
        private DevExpress.XtraPrinting.Preview.PrintPreviewBarItem bbiScale;
        private DevExpress.XtraPrinting.Preview.PrintPreviewBarItem bbiHandTool;
        private DevExpress.XtraPrinting.Preview.PrintPreviewBarItem bbiMagnifier;
        private DevExpress.XtraPrinting.Preview.PrintPreviewBarItem bbiZoomOut;
        private DevExpress.XtraPrinting.Preview.ZoomBarEditItem bbiZoom;
        private DevExpress.XtraPrinting.Preview.PrintPreviewRepositoryItemComboBox printPreviewRepositoryItemComboBox1;
        private DevExpress.XtraPrinting.Preview.PrintPreviewBarItem bbiZoomIn;
        private DevExpress.XtraPrinting.Preview.PrintPreviewBarItem bbiShowFirstPage;
        private DevExpress.XtraPrinting.Preview.PrintPreviewBarItem bbiShowPrevPage;
        private DevExpress.XtraPrinting.Preview.PrintPreviewBarItem bbiShowNextPage;
        private DevExpress.XtraPrinting.Preview.PrintPreviewBarItem bbiShowLastPage;
        private DevExpress.XtraPrinting.Preview.PrintPreviewBarItem bbiMultiplePages;
        private DevExpress.XtraPrinting.Preview.PrintPreviewBarItem bbiFillBackground;
        private DevExpress.XtraPrinting.Preview.PrintPreviewBarItem bbiWatermark;
        private DevExpress.XtraPrinting.Preview.PrintPreviewBarItem bbiExportFile;
        private DevExpress.XtraPrinting.Preview.PrintPreviewBarItem bbiSendFile;
        private DevExpress.XtraPrinting.Preview.PrintPreviewBarItem bbiClosePreview;
        private DevExpress.XtraPrinting.Preview.PreviewBar previewBar2;
        private DevExpress.XtraPrinting.Preview.PrintPreviewStaticItem printPreviewStaticItem1;
        private DevExpress.XtraPrinting.Preview.ProgressBarEditItem progressBarEditItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemProgressBar repositoryItemProgressBar1;
        private DevExpress.XtraPrinting.Preview.PrintPreviewBarItem printPreviewBarItem1;
        private DevExpress.XtraPrinting.Preview.PrintPreviewStaticItem printPreviewStaticItem2;
        private DevExpress.XtraPrinting.Preview.ZoomTrackBarEditItem zoomTrackBarEditItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemZoomTrackBar repositoryItemZoomTrackBar1;
        private DevExpress.XtraPrinting.Preview.PreviewBar previewBar3;
        private DevExpress.XtraPrinting.Preview.PrintPreviewSubItem miFile;
        private DevExpress.XtraPrinting.Preview.PrintPreviewSubItem miView;
        private DevExpress.XtraPrinting.Preview.PrintPreviewSubItem miPageLayout;
        private DevExpress.XtraPrinting.Preview.PrintPreviewBarItem miPageLayoutFacing;
        private DevExpress.XtraPrinting.Preview.PrintPreviewBarItem miPageLayoutContinuous;
        private DevExpress.XtraBars.BarToolbarsListItem miToolbars;
        private DevExpress.XtraPrinting.Preview.PrintPreviewSubItem miBackground;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem printPreviewBarCheckItem1;
        private DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem printPreviewBarCheckItem2;
        private DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem printPreviewBarCheckItem3;
        private DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem printPreviewBarCheckItem4;
        private DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem printPreviewBarCheckItem5;
        private DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem printPreviewBarCheckItem6;
        private DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem printPreviewBarCheckItem7;
        private DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem printPreviewBarCheckItem8;
        private DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem printPreviewBarCheckItem9;
        private DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem printPreviewBarCheckItem10;
        private DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem printPreviewBarCheckItem11;
        private DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem printPreviewBarCheckItem12;
        private DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem printPreviewBarCheckItem13;
        private DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem printPreviewBarCheckItem14;
        private DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem printPreviewBarCheckItem15;
        private DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem printPreviewBarCheckItem16;
        private DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem printPreviewBarCheckItem17;
        private DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem printPreviewBarCheckItem18;
        private DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem printPreviewBarCheckItem19;
    }
}
