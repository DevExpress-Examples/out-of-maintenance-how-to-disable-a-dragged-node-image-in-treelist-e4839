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
    public class CustomTreeList : TreeList {
        public CustomTreeList() : base() { }

        protected override DevExpress.XtraTreeList.Handler.TreeListHandler CreateHandler() {
            return new CustomTreeListHandler(this);
        }
    }
}
