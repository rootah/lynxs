﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace lynxs.controls
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
