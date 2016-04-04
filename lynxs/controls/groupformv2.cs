using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraEditors;
using lynxs.classes;

namespace lynxs.controls
{
    public partial class groupformv2 : DevExpress.XtraEditors.XtraUserControl
    {
        public groupformv2()
        {
            InitializeComponent();
            groupNoCalc();
            lvl.Select();
        }

        private void groupNoCalc()
        {
            var i = dbActions.groupNo();
            var newno = i + 1;
            num.Text = newno.ToString();
        }
        private void parentResize()
        {
            var parentForm = ParentForm;
            if (parentForm == null) return;
            layoutControl1.BeginUpdate();
            parentForm.ClientSize = new Size(layoutControl1.Root.MinSize.Width, layoutControl1.Root.MinSize.Height);
            layoutControl1.EndUpdate();
        }

        private void layoutControl1_GroupExpandChanged(object sender, DevExpress.XtraLayout.Utils.LayoutGroupEventArgs e)
        {
            parentResize();
        }
    }
}
