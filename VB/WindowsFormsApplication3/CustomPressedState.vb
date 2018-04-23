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
	Public Class CustomPressedState
		Inherits DevExpress.XtraTreeList.Handler.TreeListHandler.NodePressedState
		Public Sub New(ByVal handler As TreeListHandler)
			MyBase.New(handler)
		End Sub
		Protected Overrides Sub DoStartNodeDragging(ByVal ri As RowInfo, ByVal drgevent As DragEventArgs)
			If ri IsNot Nothing AndAlso ri.Node IsNot Nothing Then
				'custom bitmap here
				Dim img As New Bitmap(1, 1)
				ViewInfo.GetType().GetField("dragInfo", BindingFlags.NonPublic Or BindingFlags.Instance).SetValue(ViewInfo, Data.DragInfo)
				Data.RefreshDragArrow(ri, drgevent)
				Data.DragMaster.StartDrag(img, New Point(drgevent.X + img.Size.Width / 2 + 10, drgevent.Y), drgevent.Effect)
				Data.DragInfo.LastEffect = drgevent.Effect
			End If
		End Sub

	End Class
End Namespace
