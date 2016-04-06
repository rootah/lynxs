using System;
using System.Drawing;
using DevExpress.XtraLayout.Utils;

namespace lynxs.controls.v2
{
    public partial class stdformv2 : DevExpress.XtraEditors.XtraUserControl
    {
        public stdformv2()
        {
            InitializeComponent();
            parentResize();
        }

        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {
            layoutControlGroup3.Visibility = checkEdit1.Checked ? LayoutVisibility.Always : LayoutVisibility.Never;
        }

        private void parentResize()
        {
            var parentForm = ParentForm;
            if (parentForm == null) return;
            mainlayoutcontrol.BeginUpdate();
            parentForm.ClientSize = new Size(mainlayoutcontrol.Root.MinSize.Width, mainlayoutcontrol.Root.MinSize.Height);
            mainlayoutcontrol.EndUpdate();
        }
    }
}
