Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraTreeList
Imports DevExpress.XtraTreeList.Handler
Imports DevExpress.XtraTreeList.Nodes
Imports DevExpress.XtraTreeList.ViewInfo
Imports DevExpress.Utils.Drawing
Imports DevExpress.XtraTreeList.Painter
Imports System.Reflection

Namespace WindowsFormsApplication3
	Public Class CustomTreeList
		Inherits TreeList
		Public Sub New()
			MyBase.New()
		End Sub

		Protected Overrides Function CreateHandler() As DevExpress.XtraTreeList.Handler.TreeListHandler
			Return New CustomTreeListHandler(Me)
		End Function
	End Class
End Namespace
