using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace lynxs
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
    }
}
