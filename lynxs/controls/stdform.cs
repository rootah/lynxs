using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraLayout;

namespace lynxs.controls
{
    public partial class stdform : DevExpress.XtraEditors.XtraUserControl
    {
        public stdform()
        {
            InitializeComponent();
        }

        private void parentResize()

        {
            var parentForm = this.ParentForm;
            if (parentForm != null)
            {
                parentForm.ClientSize = new Size(layoutControl1.Root.MinSize.Width, layoutControl1.Root.MinSize.Height);
            }
        }

        private void addPhone_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            contactsGroup.BeginUpdate();
            var phonebox = new TextEdit();

            var phone = contactsGroup.AddItem();
            phone.TextLocation = Locations.Top;
            phone.Text = @"phone";
            phone.Control = phonebox;

            contactsGroup.EndUpdate();
            parentResize();
        }
    }
}
