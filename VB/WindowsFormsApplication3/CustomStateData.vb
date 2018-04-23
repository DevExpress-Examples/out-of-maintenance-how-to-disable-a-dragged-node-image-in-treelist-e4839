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
	Public Class CustomStateData
		Inherits StateData
		Public Sub New(ByVal treeList As TreeList)
			MyBase.New(treeList)
		End Sub

		Public Function GetNodeDragBitmapEx(ByVal node As TreeListNode, ByVal visibleIndex As Integer, ByVal indentWidth As Integer) As Bitmap
			Return Nothing
		End Function
	End Class
End Namespace
