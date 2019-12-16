namespace Codeathon.Desktop.Components
{
    partial class CategoryEditor
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
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.stackPanel1 = new DevExpress.Utils.Layout.StackPanel();
            this.btCreateCat = new DevExpress.XtraEditors.SimpleButton();
            this.btUpdateCat = new DevExpress.XtraEditors.SimpleButton();
            this.btDeleteCat = new DevExpress.XtraEditors.SimpleButton();
            this.picCoverCat = new System.Windows.Forms.PictureBox();
            this.btOpenCoverCat = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.textDescriptionCat = new DevExpress.XtraEditors.TextEdit();
            this.textNameCat = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridCat = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumChallenge = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtraOpenFileDialog1 = new DevExpress.XtraEditors.XtraOpenFileDialog(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stackPanel1)).BeginInit();
            this.stackPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCoverCat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textDescriptionCat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textNameCat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tablePanel1
            // 
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 40F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 10F)});
            this.tablePanel1.Controls.Add(this.stackPanel1);
            this.tablePanel1.Controls.Add(this.picCoverCat);
            this.tablePanel1.Controls.Add(this.btOpenCoverCat);
            this.tablePanel1.Controls.Add(this.labelControl3);
            this.tablePanel1.Controls.Add(this.textDescriptionCat);
            this.tablePanel1.Controls.Add(this.textNameCat);
            this.tablePanel1.Controls.Add(this.labelControl2);
            this.tablePanel1.Controls.Add(this.labelControl1);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tablePanel1.Location = new System.Drawing.Point(0, 0);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 100F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 70F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanel1.Size = new System.Drawing.Size(1710, 631);
            this.tablePanel1.TabIndex = 2;
            // 
            // stackPanel1
            // 
            this.tablePanel1.SetColumn(this.stackPanel1, 1);
            this.stackPanel1.Controls.Add(this.btCreateCat);
            this.stackPanel1.Controls.Add(this.btUpdateCat);
            this.stackPanel1.Controls.Add(this.btDeleteCat);
            this.stackPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stackPanel1.Location = new System.Drawing.Point(84, 510);
            this.stackPanel1.Name = "stackPanel1";
            this.tablePanel1.SetRow(this.stackPanel1, 5);
            this.stackPanel1.Size = new System.Drawing.Size(645, 64);
            this.stackPanel1.TabIndex = 7;
            // 
            // btCreateCat
            // 
            this.btCreateCat.Location = new System.Drawing.Point(3, 3);
            this.btCreateCat.Name = "btCreateCat";
            this.btCreateCat.Size = new System.Drawing.Size(187, 57);
            this.btCreateCat.TabIndex = 3;
            this.btCreateCat.Text = "Create";
            this.btCreateCat.Click += new System.EventHandler(this.btCreateCat_Click);
            // 
            // btUpdateCat
            // 
            this.btUpdateCat.Location = new System.Drawing.Point(196, 3);
            this.btUpdateCat.Name = "btUpdateCat";
            this.btUpdateCat.Size = new System.Drawing.Size(187, 57);
            this.btUpdateCat.TabIndex = 2;
            this.btUpdateCat.Text = "Update";
            this.btUpdateCat.Click += new System.EventHandler(this.btUpdateCat_Click);
            // 
            // btDeleteCat
            // 
            this.btDeleteCat.Location = new System.Drawing.Point(389, 3);
            this.btDeleteCat.Name = "btDeleteCat";
            this.btDeleteCat.Size = new System.Drawing.Size(187, 57);
            this.btDeleteCat.TabIndex = 1;
            this.btDeleteCat.Text = "Delete";
            this.btDeleteCat.Click += new System.EventHandler(this.btDeleteCat_Click);
            // 
            // picCoverCat
            // 
            this.tablePanel1.SetColumn(this.picCoverCat, 2);
            this.picCoverCat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picCoverCat.Location = new System.Drawing.Point(736, 260);
            this.picCoverCat.Name = "picCoverCat";
            this.tablePanel1.SetRow(this.picCoverCat, 4);
            this.picCoverCat.Size = new System.Drawing.Size(808, 244);
            this.picCoverCat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCoverCat.TabIndex = 6;
            this.picCoverCat.TabStop = false;
            // 
            // btOpenCoverCat
            // 
            this.tablePanel1.SetColumn(this.btOpenCoverCat, 2);
            this.btOpenCoverCat.Location = new System.Drawing.Point(736, 197);
            this.btOpenCoverCat.Name = "btOpenCoverCat";
            this.tablePanel1.SetRow(this.btOpenCoverCat, 3);
            this.btOpenCoverCat.Size = new System.Drawing.Size(808, 57);
            this.btOpenCoverCat.TabIndex = 5;
            this.btOpenCoverCat.Text = "Open Cover Image";
            this.btOpenCoverCat.Click += new System.EventHandler(this.btOpenCoverCat_Click);
            // 
            // labelControl3
            // 
            this.tablePanel1.SetColumn(this.labelControl3, 1);
            this.labelControl3.Location = new System.Drawing.Point(84, 197);
            this.labelControl3.Name = "labelControl3";
            this.tablePanel1.SetRow(this.labelControl3, 3);
            this.labelControl3.Size = new System.Drawing.Size(231, 50);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Cover Image";
            // 
            // textDescriptionCat
            // 
            this.tablePanel1.SetColumn(this.textDescriptionCat, 2);
            this.textDescriptionCat.Location = new System.Drawing.Point(736, 125);
            this.textDescriptionCat.Name = "textDescriptionCat";
            this.tablePanel1.SetRow(this.textDescriptionCat, 2);
            this.textDescriptionCat.Size = new System.Drawing.Size(808, 66);
            this.textDescriptionCat.TabIndex = 3;
            // 
            // textNameCat
            // 
            this.tablePanel1.SetColumn(this.textNameCat, 2);
            this.textNameCat.Location = new System.Drawing.Point(736, 53);
            this.textNameCat.Name = "textNameCat";
            this.tablePanel1.SetRow(this.textNameCat, 1);
            this.textNameCat.Size = new System.Drawing.Size(808, 66);
            this.textNameCat.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.tablePanel1.SetColumn(this.labelControl2, 1);
            this.labelControl2.Location = new System.Drawing.Point(84, 125);
            this.labelControl2.Name = "labelControl2";
            this.tablePanel1.SetRow(this.labelControl2, 2);
            this.labelControl2.Size = new System.Drawing.Size(205, 50);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Description";
            // 
            // labelControl1
            // 
            this.tablePanel1.SetColumn(this.labelControl1, 1);
            this.labelControl1.Location = new System.Drawing.Point(84, 53);
            this.labelControl1.Name = "labelControl1";
            this.tablePanel1.SetRow(this.labelControl1, 1);
            this.labelControl1.Size = new System.Drawing.Size(106, 50);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Name";
            // 
            // gridCat
            // 
            this.gridCat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCat.Location = new System.Drawing.Point(0, 631);
            this.gridCat.MainView = this.gridView1;
            this.gridCat.Name = "gridCat";
            this.gridCat.Size = new System.Drawing.Size(1710, 720);
            this.gridCat.TabIndex = 3;
            this.gridCat.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName,
            this.colDescription,
            this.colNumChallenge});
            this.gridView1.GridControl = this.gridCat;
            this.gridView1.Name = "gridView1";
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // colName
            // 
            this.colName.Caption = "Name";
            this.colName.FieldName = "Name";
            this.colName.MinWidth = 50;
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            this.colName.Width = 187;
            // 
            // colDescription
            // 
            this.colDescription.Caption = "Description";
            this.colDescription.FieldName = "Description";
            this.colDescription.MinWidth = 50;
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 1;
            this.colDescription.Width = 187;
            // 
            // colNumChallenge
            // 
            this.colNumChallenge.Caption = "Num of Challenge";
            this.colNumChallenge.FieldName = "NumOfChallenge";
            this.colNumChallenge.MinWidth = 50;
            this.colNumChallenge.Name = "colNumChallenge";
            this.colNumChallenge.Visible = true;
            this.colNumChallenge.VisibleIndex = 2;
            this.colNumChallenge.Width = 187;
            // 
            // xtraOpenFileDialog1
            // 
            this.xtraOpenFileDialog1.FileName = "xtraOpenFileDialog1";
            // 
            // CategoryEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridCat);
            this.Controls.Add(this.tablePanel1);
            this.Name = "CategoryEditor";
            this.Size = new System.Drawing.Size(1710, 1351);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            this.tablePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stackPanel1)).EndInit();
            this.stackPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCoverCat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textDescriptionCat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textNameCat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private DevExpress.Utils.Layout.StackPanel stackPanel1;
        private DevExpress.XtraEditors.SimpleButton btCreateCat;
        private DevExpress.XtraEditors.SimpleButton btUpdateCat;
        private DevExpress.XtraEditors.SimpleButton btDeleteCat;
        private System.Windows.Forms.PictureBox picCoverCat;
        private DevExpress.XtraEditors.SimpleButton btOpenCoverCat;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit textDescriptionCat;
        private DevExpress.XtraEditors.TextEdit textNameCat;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gridCat;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colNumChallenge;
        private DevExpress.XtraEditors.XtraOpenFileDialog xtraOpenFileDialog1;
    }
}
