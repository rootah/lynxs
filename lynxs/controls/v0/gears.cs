using System;

namespace lynxs.controls.v0
{
    public partial class gears : DevExpress.XtraEditors.XtraUserControl
    {
        public gears()
        {
            InitializeComponent();
        }

        private void fakeCheck_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.fakegen = fakeCheck.Checked;
            Properties.Settings.Default.Save();}
    }
}
