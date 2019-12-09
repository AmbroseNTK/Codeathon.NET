namespace Codeathon.Desktop.Components
{
    partial class ChallengeExplore
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.layoutView1 = new DevExpress.XtraGrid.Views.Layout.LayoutView();
            this.id = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.name = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.author = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.description = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutViewCard1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewCard();
            this.layoutViewField_id = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewField_name = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewField_author = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewField_description = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_id)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_name)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_author)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_description)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.layoutView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1050, 666);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.layoutView1,
            this.gridView1});
            // 
            // layoutView1
            // 
            this.layoutView1.Appearance.Card.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.layoutView1.Appearance.Card.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.layoutView1.Appearance.Card.Options.UseBackColor = true;
            this.layoutView1.Appearance.Card.Options.UseFont = true;
            this.layoutView1.Appearance.CardCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.layoutView1.Appearance.CardCaption.Options.UseForeColor = true;
            this.layoutView1.CardHorzInterval = 8;
            this.layoutView1.CardMinSize = new System.Drawing.Size(482, 482);
            this.layoutView1.CardVertInterval = 0;
            this.layoutView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.LayoutViewColumn[] {
            this.id,
            this.name,
            this.author,
            this.description});
            this.layoutView1.GridControl = this.gridControl1;
            this.layoutView1.Name = "layoutView1";
            this.layoutView1.OptionsItemText.AlignMode = DevExpress.XtraGrid.Views.Layout.FieldTextAlignMode.AlignGlobal;
            this.layoutView1.OptionsItemText.TextToControlDistance = 2;
            this.layoutView1.OptionsView.ShowCardExpandButton = false;
            this.layoutView1.OptionsView.ViewMode = DevExpress.XtraGrid.Views.Layout.LayoutViewMode.MultiRow;
            this.layoutView1.TemplateCard = this.layoutViewCard1;
            // 
            // id
            // 
            this.id.Caption = "ID";
            this.id.FieldName = "id";
            this.id.LayoutViewField = this.layoutViewField_id;
            this.id.MinWidth = 50;
            this.id.Name = "id";
            this.id.Width = 187;
            // 
            // name
            // 
            this.name.Caption = "Name";
            this.name.FieldName = "name";
            this.name.LayoutViewField = this.layoutViewField_name;
            this.name.MinWidth = 50;
            this.name.Name = "name";
            this.name.Width = 187;
            // 
            // author
            // 
            this.author.Caption = "Author";
            this.author.FieldName = "author";
            this.author.LayoutViewField = this.layoutViewField_author;
            this.author.MinWidth = 50;
            this.author.Name = "author";
            this.author.Width = 187;
            // 
            // description
            // 
            this.description.Caption = "Description";
            this.description.FieldName = "description";
            this.description.LayoutViewField = this.layoutViewField_description;
            this.description.MinWidth = 50;
            this.description.Name = "description";
            this.description.Width = 187;
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // layoutViewCard1
            // 
            this.layoutViewCard1.CustomizationFormText = "TemplateCard";
            this.layoutViewCard1.HeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText;
            this.layoutViewCard1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutViewField_id,
            this.layoutViewField_name,
            this.layoutViewField_author,
            this.layoutViewField_description});
            this.layoutViewCard1.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table;
            this.layoutViewCard1.Name = "layoutViewCard1";
            this.layoutViewCard1.OptionsItemText.TextToControlDistance = 2;
            this.layoutViewCard1.Text = "TemplateCard";
            // 
            // layoutViewField_id
            // 
            this.layoutViewField_id.EditorPreferredWidth = 188;
            this.layoutViewField_id.Location = new System.Drawing.Point(0, 0);
            this.layoutViewField_id.Name = "layoutViewField_id";
            this.layoutViewField_id.Size = new System.Drawing.Size(339, 54);
            this.layoutViewField_id.TextSize = new System.Drawing.Size(145, 34);
            // 
            // layoutViewField_name
            // 
            this.layoutViewField_name.EditorPreferredWidth = 188;
            this.layoutViewField_name.Location = new System.Drawing.Point(0, 54);
            this.layoutViewField_name.Name = "layoutViewField_name";
            this.layoutViewField_name.Size = new System.Drawing.Size(339, 54);
            this.layoutViewField_name.TextSize = new System.Drawing.Size(145, 34);
            // 
            // layoutViewField_author
            // 
            this.layoutViewField_author.EditorPreferredWidth = 188;
            this.layoutViewField_author.Location = new System.Drawing.Point(0, 108);
            this.layoutViewField_author.Name = "layoutViewField_author";
            this.layoutViewField_author.Size = new System.Drawing.Size(339, 54);
            this.layoutViewField_author.TextSize = new System.Drawing.Size(145, 34);
            // 
            // layoutViewField_description
            // 
            this.layoutViewField_description.EditorPreferredWidth = 188;
            this.layoutViewField_description.Location = new System.Drawing.Point(0, 162);
            this.layoutViewField_description.Name = "layoutViewField_description";
            this.layoutViewField_description.Size = new System.Drawing.Size(339, 54);
            this.layoutViewField_description.TextSize = new System.Drawing.Size(145, 34);
            // 
            // ChallengeExplore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Name = "ChallengeExplore";
            this.Size = new System.Drawing.Size(1050, 666);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_id)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_name)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_author)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_description)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Layout.LayoutView layoutView1;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn id;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn name;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn author;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn description;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_id;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_name;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_author;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_description;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewCard layoutViewCard1;
    }
}
