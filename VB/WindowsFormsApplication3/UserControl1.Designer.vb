Imports Microsoft.VisualBasic
Imports System
Namespace WindowsFormsApplication3
	Partial Public Class UserControl1
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

		#Region "Component Designer generated code"

		''' <summary> 
		''' Required method for Designer support - do not modify 
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.customTreeList1 = New WindowsFormsApplication3.CustomTreeList()
			Me.colCategoryID = New DevExpress.XtraTreeList.Columns.TreeListColumn()
			Me.colCategoryName = New DevExpress.XtraTreeList.Columns.TreeListColumn()
			Me.colDescription = New DevExpress.XtraTreeList.Columns.TreeListColumn()
			Me.colPicture = New DevExpress.XtraTreeList.Columns.TreeListColumn()
			Me.colIcon_17 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
			Me.colIcon_25 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
			Me.categoriesBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
			Me.nwindDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.nwindDataSet = New WindowsFormsApplication3.nwindDataSet()
			Me.categoriesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.categoriesTableAdapter = New WindowsFormsApplication3.nwindDataSetTableAdapters.CategoriesTableAdapter()
			CType(Me.customTreeList1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.categoriesBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.nwindDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.categoriesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' customTreeList1
			' 
			Me.customTreeList1.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() { Me.colCategoryID, Me.colCategoryName, Me.colDescription, Me.colPicture, Me.colIcon_17, Me.colIcon_25})
			Me.customTreeList1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.customTreeList1.Location = New System.Drawing.Point(0, 0)
			Me.customTreeList1.Name = "customTreeList1"
			Me.customTreeList1.BeginUnboundLoad()
			Me.customTreeList1.AppendNode(New Object() { Nothing, Nothing, Nothing, Nothing, Nothing, Nothing}, -1)
			Me.customTreeList1.AppendNode(New Object() { Nothing, Nothing, Nothing, Nothing, Nothing, Nothing}, -1)
			Me.customTreeList1.AppendNode(New Object() { Nothing, Nothing, Nothing, Nothing, Nothing, Nothing}, -1)
			Me.customTreeList1.AppendNode(New Object() { Nothing, Nothing, Nothing, Nothing, Nothing, Nothing}, -1)
			Me.customTreeList1.AppendNode(New Object() { Nothing, Nothing, Nothing, Nothing, Nothing, Nothing}, -1)
			Me.customTreeList1.AppendNode(New Object() { Nothing, Nothing, Nothing, Nothing, Nothing, Nothing}, -1)
			Me.customTreeList1.EndUnboundLoad()
			Me.customTreeList1.OptionsBehavior.DragNodes = True
			Me.customTreeList1.Size = New System.Drawing.Size(466, 421)
			Me.customTreeList1.TabIndex = 0
			' 
			' colCategoryID
			' 
			Me.colCategoryID.FieldName = "CategoryID"
			Me.colCategoryID.MinWidth = 34
			Me.colCategoryID.Name = "colCategoryID"
			Me.colCategoryID.Visible = True
			Me.colCategoryID.VisibleIndex = 0
			Me.colCategoryID.Width = 74
			' 
			' colCategoryName
			' 
			Me.colCategoryName.FieldName = "CategoryName"
			Me.colCategoryName.Name = "colCategoryName"
			Me.colCategoryName.Visible = True
			Me.colCategoryName.VisibleIndex = 1
			Me.colCategoryName.Width = 74
			' 
			' colDescription
			' 
			Me.colDescription.FieldName = "Description"
			Me.colDescription.Name = "colDescription"
			Me.colDescription.Visible = True
			Me.colDescription.VisibleIndex = 2
			' 
			' colPicture
			' 
			Me.colPicture.FieldName = "Picture"
			Me.colPicture.Name = "colPicture"
			Me.colPicture.Visible = True
			Me.colPicture.VisibleIndex = 3
			' 
			' colIcon_17
			' 
			Me.colIcon_17.FieldName = "Icon_17"
			Me.colIcon_17.Name = "colIcon_17"
			Me.colIcon_17.Visible = True
			Me.colIcon_17.VisibleIndex = 4
			' 
			' colIcon_25
			' 
			Me.colIcon_25.FieldName = "Icon_25"
			Me.colIcon_25.Name = "colIcon_25"
			Me.colIcon_25.Visible = True
			Me.colIcon_25.VisibleIndex = 5
			' 
			' categoriesBindingSource1
			' 
			Me.categoriesBindingSource1.DataMember = "Categories"
			Me.categoriesBindingSource1.DataSource = Me.nwindDataSetBindingSource
			' 
			' nwindDataSetBindingSource
			' 
			Me.nwindDataSetBindingSource.DataSource = Me.nwindDataSet
			Me.nwindDataSetBindingSource.Position = 0
			' 
			' nwindDataSet
			' 
			Me.nwindDataSet.DataSetName = "nwindDataSet"
			Me.nwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' categoriesBindingSource
			' 
			Me.categoriesBindingSource.DataMember = "Categories"
			Me.categoriesBindingSource.DataSource = Me.nwindDataSet
			' 
			' categoriesTableAdapter
			' 
			Me.categoriesTableAdapter.ClearBeforeFill = True
			' 
			' UserControl1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(8F, 16F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.customTreeList1)
			Me.Name = "UserControl1"
			Me.Size = New System.Drawing.Size(466, 421)
			CType(Me.customTreeList1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.categoriesBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.nwindDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.categoriesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private customTreeList1 As CustomTreeList
		Private colCategoryID As DevExpress.XtraTreeList.Columns.TreeListColumn
		Private colCategoryName As DevExpress.XtraTreeList.Columns.TreeListColumn
		Private colDescription As DevExpress.XtraTreeList.Columns.TreeListColumn
		Private colPicture As DevExpress.XtraTreeList.Columns.TreeListColumn
		Private colIcon_17 As DevExpress.XtraTreeList.Columns.TreeListColumn
		Private colIcon_25 As DevExpress.XtraTreeList.Columns.TreeListColumn
		Private categoriesBindingSource As System.Windows.Forms.BindingSource
		Private nwindDataSet As nwindDataSet
		Private nwindDataSetBindingSource As System.Windows.Forms.BindingSource
		Private categoriesTableAdapter As nwindDataSetTableAdapters.CategoriesTableAdapter
		Private categoriesBindingSource1 As System.Windows.Forms.BindingSource
	End Class
End Namespace
