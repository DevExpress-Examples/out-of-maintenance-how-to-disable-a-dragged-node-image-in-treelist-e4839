namespace WindowsFormsApplication3 {
    partial class UserControl1 {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.customTreeList1 = new WindowsFormsApplication3.CustomTreeList();
            this.colCategoryID = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colCategoryName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colDescription = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colPicture = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colIcon_17 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colIcon_25 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.categoriesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.nwindDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nwindDataSet = new WindowsFormsApplication3.nwindDataSet();
            this.categoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoriesTableAdapter = new WindowsFormsApplication3.nwindDataSetTableAdapters.CategoriesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.customTreeList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nwindDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nwindDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // customTreeList1
            // 
            this.customTreeList1.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colCategoryID,
            this.colCategoryName,
            this.colDescription,
            this.colPicture,
            this.colIcon_17,
            this.colIcon_25});
            this.customTreeList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customTreeList1.Location = new System.Drawing.Point(0, 0);
            this.customTreeList1.Name = "customTreeList1";
            this.customTreeList1.BeginUnboundLoad();
            this.customTreeList1.AppendNode(new object[] {
            null,
            null,
            null,
            null,
            null,
            null}, -1);
            this.customTreeList1.AppendNode(new object[] {
            null,
            null,
            null,
            null,
            null,
            null}, -1);
            this.customTreeList1.AppendNode(new object[] {
            null,
            null,
            null,
            null,
            null,
            null}, -1);
            this.customTreeList1.AppendNode(new object[] {
            null,
            null,
            null,
            null,
            null,
            null}, -1);
            this.customTreeList1.AppendNode(new object[] {
            null,
            null,
            null,
            null,
            null,
            null}, -1);
            this.customTreeList1.AppendNode(new object[] {
            null,
            null,
            null,
            null,
            null,
            null}, -1);
            this.customTreeList1.EndUnboundLoad();
            this.customTreeList1.OptionsBehavior.DragNodes = true;
            this.customTreeList1.Size = new System.Drawing.Size(466, 421);
            this.customTreeList1.TabIndex = 0;
            // 
            // colCategoryID
            // 
            this.colCategoryID.FieldName = "CategoryID";
            this.colCategoryID.MinWidth = 34;
            this.colCategoryID.Name = "colCategoryID";
            this.colCategoryID.Visible = true;
            this.colCategoryID.VisibleIndex = 0;
            this.colCategoryID.Width = 74;
            // 
            // colCategoryName
            // 
            this.colCategoryName.FieldName = "CategoryName";
            this.colCategoryName.Name = "colCategoryName";
            this.colCategoryName.Visible = true;
            this.colCategoryName.VisibleIndex = 1;
            this.colCategoryName.Width = 74;
            // 
            // colDescription
            // 
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 2;
            // 
            // colPicture
            // 
            this.colPicture.FieldName = "Picture";
            this.colPicture.Name = "colPicture";
            this.colPicture.Visible = true;
            this.colPicture.VisibleIndex = 3;
            // 
            // colIcon_17
            // 
            this.colIcon_17.FieldName = "Icon_17";
            this.colIcon_17.Name = "colIcon_17";
            this.colIcon_17.Visible = true;
            this.colIcon_17.VisibleIndex = 4;
            // 
            // colIcon_25
            // 
            this.colIcon_25.FieldName = "Icon_25";
            this.colIcon_25.Name = "colIcon_25";
            this.colIcon_25.Visible = true;
            this.colIcon_25.VisibleIndex = 5;
            // 
            // categoriesBindingSource1
            // 
            this.categoriesBindingSource1.DataMember = "Categories";
            this.categoriesBindingSource1.DataSource = this.nwindDataSetBindingSource;
            // 
            // nwindDataSetBindingSource
            // 
            this.nwindDataSetBindingSource.DataSource = this.nwindDataSet;
            this.nwindDataSetBindingSource.Position = 0;
            // 
            // nwindDataSet
            // 
            this.nwindDataSet.DataSetName = "nwindDataSet";
            this.nwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoriesBindingSource
            // 
            this.categoriesBindingSource.DataMember = "Categories";
            this.categoriesBindingSource.DataSource = this.nwindDataSet;
            // 
            // categoriesTableAdapter
            // 
            this.categoriesTableAdapter.ClearBeforeFill = true;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.customTreeList1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(466, 421);
            ((System.ComponentModel.ISupportInitialize)(this.customTreeList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nwindDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nwindDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomTreeList customTreeList1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colCategoryID;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colCategoryName;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colDescription;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colPicture;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colIcon_17;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colIcon_25;
        private System.Windows.Forms.BindingSource categoriesBindingSource;
        private nwindDataSet nwindDataSet;
        private System.Windows.Forms.BindingSource nwindDataSetBindingSource;
        private nwindDataSetTableAdapters.CategoriesTableAdapter categoriesTableAdapter;
        private System.Windows.Forms.BindingSource categoriesBindingSource1;
    }
}
