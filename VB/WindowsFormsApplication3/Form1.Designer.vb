Imports Microsoft.VisualBasic
Imports System
Namespace WindowsFormsApplication3
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.treeList1 = New WindowsFormsApplication3.CustomTreeList()
			Me.colCategoryID = New DevExpress.XtraTreeList.Columns.TreeListColumn()
			Me.colCategoryName = New DevExpress.XtraTreeList.Columns.TreeListColumn()
			Me.colDescription = New DevExpress.XtraTreeList.Columns.TreeListColumn()
			Me.colPicture = New DevExpress.XtraTreeList.Columns.TreeListColumn()
			Me.colIcon_17 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
			Me.colIcon_25 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
			Me.categoriesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.nwindDataSet = New WindowsFormsApplication3.nwindDataSet()
			Me.categoriesTableAdapter = New WindowsFormsApplication3.nwindDataSetTableAdapters.CategoriesTableAdapter()
			Me.userControl11 = New WindowsFormsApplication3.UserControl1()
			CType(Me.treeList1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.categoriesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' treeList1
			' 
			Me.treeList1.AllowDrop = True
			Me.treeList1.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() { Me.colCategoryID, Me.colCategoryName, Me.colDescription, Me.colPicture, Me.colIcon_17, Me.colIcon_25})
			Me.treeList1.DataSource = Me.categoriesBindingSource
			Me.treeList1.Location = New System.Drawing.Point(0, 0)
			Me.treeList1.Name = "treeList1"
			Me.treeList1.OptionsBehavior.DragNodes = True
			Me.treeList1.Size = New System.Drawing.Size(270, 419)
			Me.treeList1.TabIndex = 0
			' 
			' colCategoryID
			' 
			Me.colCategoryID.FieldName = "CategoryID"
			Me.colCategoryID.Name = "colCategoryID"
			Me.colCategoryID.Visible = True
			Me.colCategoryID.VisibleIndex = 0
			Me.colCategoryID.Width = 63
			' 
			' colCategoryName
			' 
			Me.colCategoryName.FieldName = "CategoryName"
			Me.colCategoryName.Name = "colCategoryName"
			Me.colCategoryName.Visible = True
			Me.colCategoryName.VisibleIndex = 1
			Me.colCategoryName.Width = 63
			' 
			' colDescription
			' 
			Me.colDescription.FieldName = "Description"
			Me.colDescription.Name = "colDescription"
			Me.colDescription.Visible = True
			Me.colDescription.VisibleIndex = 2
			Me.colDescription.Width = 64
			' 
			' colPicture
			' 
			Me.colPicture.FieldName = "Picture"
			Me.colPicture.Name = "colPicture"
			Me.colPicture.Visible = True
			Me.colPicture.VisibleIndex = 3
			Me.colPicture.Width = 64
			' 
			' colIcon_17
			' 
			Me.colIcon_17.FieldName = "Icon_17"
			Me.colIcon_17.Name = "colIcon_17"
			Me.colIcon_17.Visible = True
			Me.colIcon_17.VisibleIndex = 4
			Me.colIcon_17.Width = 64
			' 
			' colIcon_25
			' 
			Me.colIcon_25.FieldName = "Icon_25"
			Me.colIcon_25.Name = "colIcon_25"
			Me.colIcon_25.Visible = True
			Me.colIcon_25.VisibleIndex = 5
			Me.colIcon_25.Width = 64
			' 
			' categoriesBindingSource
			' 
			Me.categoriesBindingSource.DataMember = "Categories"
			Me.categoriesBindingSource.DataSource = Me.nwindDataSet
			' 
			' nwindDataSet
			' 
			Me.nwindDataSet.DataSetName = "nwindDataSet"
			Me.nwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' categoriesTableAdapter
			' 
			Me.categoriesTableAdapter.ClearBeforeFill = True
			' 
			' userControl11
			' 
			Me.userControl11.Location = New System.Drawing.Point(276, 0)
			Me.userControl11.Name = "userControl11"
			Me.userControl11.Size = New System.Drawing.Size(282, 419)
			Me.userControl11.TabIndex = 1
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(8F, 16F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(667, 490)
			Me.Controls.Add(Me.userControl11)
			Me.Controls.Add(Me.treeList1)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.treeList1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.categoriesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private treeList1 As CustomTreeList
		Private nwindDataSet As nwindDataSet
		Private categoriesBindingSource As System.Windows.Forms.BindingSource
		Private categoriesTableAdapter As nwindDataSetTableAdapters.CategoriesTableAdapter
		Private colCategoryID As DevExpress.XtraTreeList.Columns.TreeListColumn
		Private colCategoryName As DevExpress.XtraTreeList.Columns.TreeListColumn
		Private colDescription As DevExpress.XtraTreeList.Columns.TreeListColumn
		Private colPicture As DevExpress.XtraTreeList.Columns.TreeListColumn
		Private colIcon_17 As DevExpress.XtraTreeList.Columns.TreeListColumn
		Private colIcon_25 As DevExpress.XtraTreeList.Columns.TreeListColumn
		Private userControl11 As UserControl1
	End Class
End Namespace

