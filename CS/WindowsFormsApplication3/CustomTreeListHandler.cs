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
    public class CustomTreeListHandler : TreeListHandler {
        public CustomTreeListHandler(TreeList treeList) : base(treeList) { }

        protected override TreeListHandler.TreeListControlState CreateState(TreeListState state) {
            if (state == TreeListState.NodePressed) {
                return new CustomPressedState(this);
            }
            if (state == TreeListState.NodeDragging) {
                return new CustomNodeDraggingState(this);
            }
            return base.CreateState(state);
        }


    }
    public class CustomNodeDraggingState : DevExpress.XtraTreeList.Handler.TreeListHandler.NodeDraggingState {
        public CustomNodeDraggingState(TreeListHandler handler) : base(handler) { }
        protected override void DoStartNodeDragging(RowInfo ri, DragEventArgs drgevent) {
            //base.DoStartNodeDragging(rin, drgevent);
        }
    }
}
