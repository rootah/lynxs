﻿using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using lynxs.classes;
using lynxs.controls;

namespace lynxs.forms
{
    public partial class main : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public main()
        {
            InitializeComponent();
        }

        private void backstageHalt_ItemClick(object sender, DevExpress.XtraBars.Ribbon.BackstageViewItemEventArgs e)
        {
            Close();
        }

        private void main_Load(object sender, System.EventArgs e)
        {
            peoples1.groupFullFill();
        }

        private void startNewStd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frm = new stdform();
            var newstd = new XtraForm
            {
                FormBorderStyle = FormBorderStyle.FixedDialog,
                MaximizeBox = false,
                MinimizeBox = false,

            };
            newstd.Controls.Add(frm);
            newstd.Controls[0].Dock = DockStyle.Fill;
            newstd.ClientSize = new Size(frm.mainlayout.Root.MinSize.Width, frm.mainlayout.Root.MinSize.Height);
            newstd.StartPosition = FormStartPosition.CenterParent;
            newstd.ShowDialog(this);
        }

        private void startNewGroup_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var grp = new groupform();
            var newgroup = new XtraForm
            {
                FormBorderStyle = FormBorderStyle.FixedDialog,
                MaximizeBox = false,
                MinimizeBox = false,

            };
            newgroup.Controls.Add(grp);
            newgroup.Controls[0].Dock = DockStyle.Fill;
            newgroup.ClientSize = new Size(grp.layoutControl1.Root.MinSize.Width, grp.layoutControl1.Root.MinSize.Height);
            newgroup.StartPosition = FormStartPosition.CenterParent;
            newgroup.ShowDialog(this);
        }

        private void startEditBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // todo edit form fill
            if (peoples1.studentView.IsFocusedView)
                    MessageBox.Show("stds");
                else if (peoples1.groupView.IsFocusedView)
                    MessageBox.Show("grps");
                else MessageBox.Show("none");
        }
    }
}
