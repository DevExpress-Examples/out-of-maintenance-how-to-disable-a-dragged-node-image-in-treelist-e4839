using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Handler;
using DevExpress.XtraTreeList.Nodes;
using DevExpress.XtraTreeList.ViewInfo;
using DevExpress.Utils.Drawing;
using DevExpress.XtraTreeList.Painter;
using System.Reflection;

namespace WindowsFormsApplication3 {
    public class CustomPressedState : DevExpress.XtraTreeList.Handler.TreeListHandler.NodePressedState {
        public CustomPressedState(TreeListHandler handler) : base(handler) { }
        protected override void DoStartNodeDragging(RowInfo ri, DragEventArgs drgevent) {
            if (ri != null && ri.Node != null) {
                //custom bitmap here
                Bitmap img = new Bitmap(1, 1);
                ViewInfo.GetType().GetField("dragInfo", BindingFlags.NonPublic | BindingFlags.Instance).SetValue(ViewInfo, Data.DragInfo);
                Data.RefreshDragArrow(ri, drgevent);
                Data.DragMaster.StartDrag(img, new Point(drgevent.X + img.Size.Width / 2 + 10, drgevent.Y), drgevent.Effect);
                Data.DragInfo.LastEffect = drgevent.Effect;
            }
        }
        
    }
}
