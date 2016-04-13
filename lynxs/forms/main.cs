using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using lynxs.classes;
using lynxs.controls;
using lynxs.controls.v2;

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

        public void groupGridFill()
        {
            peoplesCtrl.groupFullFill();
        }

        private void main_Load(object sender, System.EventArgs e)
        {
            peoplesCtrl.groupFullFill();
            gears1.fakeCheck.Checked = Properties.Settings.Default.fakegen;
        }

        private void startNewStd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frm = new stdformv2();
            var newstd = new XtraForm
            {
                FormBorderStyle = FormBorderStyle.FixedDialog,
                MaximizeBox = false,
                MinimizeBox = false

            };
            newstd.Controls.Add(frm);
            newstd.Controls[0].Dock = DockStyle.Fill;
            newstd.ClientSize = new Size(frm.mainlayoutcontrol.Root.MinSize.Width, frm.mainlayoutcontrol.Root.MinSize.Height);
            newstd.StartPosition = FormStartPosition.CenterParent;
            newstd.Text = @"+ creating";

            frm.controlInit();
            newstd.ShowDialog(this);
        }

        private void startNewGroup_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var grp = new groupformv2(this);
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

        private void stdEdit(string stdid)
        {
            // creating form
            var frm = new stdformv2();
            var newstd = new XtraForm
            {
                FormBorderStyle = FormBorderStyle.FixedDialog,
                MaximizeBox = false,
                MinimizeBox = false

            };
            newstd.Controls.Add(frm);
            newstd.Controls[0].Dock = DockStyle.Fill;
            newstd.ClientSize = new Size(frm.mainlayoutcontrol.Root.MinSize.Width, frm.mainlayoutcontrol.Root.MinSize.Height);
            newstd.StartPosition = FormStartPosition.CenterParent;
            newstd.Text = @"* editing";

            frm.stdEditFormFill(stdid);
            newstd.ShowDialog(this);
            // ***
        }
        private void startEditBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // todo edit form fill
            if (peoplesCtrl.studentView.IsFocusedView)
            {
                var id = peoplesCtrl.studentView.GetRowCellValue(peoplesCtrl.studentView.FocusedRowHandle, "_id").ToString();
                stdEdit(id);
            }
                else if (peoplesCtrl.groupView.IsFocusedView)
                    MessageBox.Show("grps");
                else MessageBox.Show("none");
        }


        private void backstageMain_SelectedTabChanged(object sender, DevExpress.XtraBars.Ribbon.BackstageViewItemEventArgs e)
        {
            if (backstageMain.SelectedTabIndex == 1)
            {
                ribbonPaymentsCat.Visible = true;}
            else ribbonPaymentsCat.Visible = false;
        }
    }
}
