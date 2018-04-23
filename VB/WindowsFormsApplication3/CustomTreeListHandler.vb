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
	Public Class CustomTreeListHandler
		Inherits TreeListHandler
		Public Sub New(ByVal treeList As TreeList)
			MyBase.New(treeList)
		End Sub

		Protected Overrides Function CreateState(ByVal state As TreeListState) As TreeListHandler.TreeListControlState
            If state = TreeListState.NodePressed Then
                Return New CustomPressedState(Me)
            End If
            If state = TreeListState.NodeDragging Then
                Return New CustomNodeDraggingState(Me)
            End If
			Return MyBase.CreateState(state)
		End Function


	End Class
	Public Class CustomNodeDraggingState
		Inherits DevExpress.XtraTreeList.Handler.TreeListHandler.NodeDraggingState
		Public Sub New(ByVal handler As TreeListHandler)
			MyBase.New(handler)
		End Sub
		Protected Overrides Sub DoStartNodeDragging(ByVal ri As RowInfo, ByVal drgevent As DragEventArgs)
			'base.DoStartNodeDragging(rin, drgevent);
		End Sub
	End Class
End Namespace
