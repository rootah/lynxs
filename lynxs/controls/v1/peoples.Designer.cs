namespace lynxs.controls.v1
{
    partial class peoples
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.phoneadd = new DevExpress.XtraEditors.LabelControl();
            this.phonemain = new DevExpress.XtraEditors.LabelControl();
            this.studentGrid = new DevExpress.XtraGrid.GridControl();
            this.realTimeStudents = new DevExpress.Data.RealTimeSource();
            this.studentView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupGrid = new DevExpress.XtraGrid.GridControl();
            this.realTimeGroup = new DevExpress.Data.RealTimeSource();
            this.groupView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.splitterItem1 = new DevExpress.XtraLayout.SplitterItem();
            this.splitterItem2 = new DevExpress.XtraLayout.SplitterItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.tabbedControlGroup1 = new DevExpress.XtraLayout.TabbedControlGroup();
            this.paymentsgroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.contactsgroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.phonemainlabel = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.simpleLabelItem1 = new DevExpress.XtraLayout.SimpleLabelItem();
            this.stdHeadLabel = new DevExpress.XtraLayout.SimpleLabelItem();
            this.infoHeader = new DevExpress.XtraLayout.SimpleLabelItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentsgroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactsgroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phonemainlabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stdHeadLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoHeader)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.phoneadd);
            this.layoutControl1.Controls.Add(this.phonemain);
            this.layoutControl1.Controls.Add(this.studentGrid);
            this.layoutControl1.Controls.Add(this.groupGrid);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(895, 223, 514, 488);
            this.layoutControl1.OptionsFocus.AllowFocusGroups = false;
            this.layoutControl1.OptionsFocus.AllowFocusTabbedGroups = false;
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(793, 398);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // phoneadd
            // 
            this.phoneadd.Location = new System.Drawing.Point(492, 111);
            this.phoneadd.Name = "phoneadd";
            this.phoneadd.Size = new System.Drawing.Size(178, 36);
            this.phoneadd.StyleController = this.layoutControl1;
            this.phoneadd.TabIndex = 13;
            this.phoneadd.Text = "...";
            this.phoneadd.Visible = false;
            // 
            // phonemain
            // 
            this.phonemain.Location = new System.Drawing.Point(492, 70);
            this.phonemain.Name = "phonemain";
            this.phonemain.Size = new System.Drawing.Size(178, 37);
            this.phonemain.StyleController = this.layoutControl1;
            this.phonemain.TabIndex = 12;
            this.phonemain.Text = "...";
            this.phonemain.Visible = false;
            // 
            // studentGrid
            // 
            this.studentGrid.DataSource = this.realTimeStudents;
            this.studentGrid.Location = new System.Drawing.Point(167, 35);
            this.studentGrid.MainView = this.studentView;
            this.studentGrid.Name = "studentGrid";
            this.studentGrid.Size = new System.Drawing.Size(240, 356);
            this.studentGrid.TabIndex = 5;
            this.studentGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.studentView});
            // 
            // realTimeStudents
            // 
            this.realTimeStudents.DisplayableProperties = null;
            this.realTimeStudents.UseWeakEventHandler = true;
            // 
            // studentView
            // 
            this.studentView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.studentView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None;
            this.studentView.GridControl = this.studentGrid;
            this.studentView.Name = "studentView";
            this.studentView.OptionsBehavior.Editable = false;
            this.studentView.OptionsFind.AlwaysVisible = true;
            this.studentView.OptionsFind.FindDelay = 500;
            this.studentView.OptionsFind.FindMode = DevExpress.XtraEditors.FindMode.Always;
            this.studentView.OptionsFind.FindNullPrompt = "search em all...";
            this.studentView.OptionsFind.ShowCloseButton = false;
            this.studentView.OptionsFind.ShowFindButton = false;
            this.studentView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.studentView.OptionsView.ShowColumnHeaders = false;
            this.studentView.OptionsView.ShowGroupPanel = false;
            this.studentView.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.False;
            this.studentView.OptionsView.ShowIndicator = false;
            this.studentView.RowHeight = 25;
            this.studentView.ViewCaption = "students";
            this.studentView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.studentView_FocusedRowChanged);
            // 
            // groupGrid
            // 
            this.groupGrid.DataSource = this.realTimeGroup;
            this.groupGrid.Location = new System.Drawing.Point(7, 35);
            this.groupGrid.MainView = this.groupView;
            this.groupGrid.Name = "groupGrid";
            this.groupGrid.Size = new System.Drawing.Size(144, 356);
            this.groupGrid.TabIndex = 4;
            this.groupGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.groupView});
            // 
            // realTimeGroup
            // 
            this.realTimeGroup.DisplayableProperties = null;
            this.realTimeGroup.UseWeakEventHandler = true;
            // 
            // groupView
            // 
            this.groupView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.groupView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None;
            this.groupView.GridControl = this.groupGrid;
            this.groupView.Name = "groupView";
            this.groupView.OptionsBehavior.Editable = false;
            this.groupView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.groupView.OptionsView.ShowColumnHeaders = false;
            this.groupView.OptionsView.ShowGroupPanel = false;
            this.groupView.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.False;
            this.groupView.OptionsView.ShowIndicator = false;
            this.groupView.RowHeight = 25;
            this.groupView.ViewCaption = "groups";
            this.groupView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.groupView_FocusedRowChanged);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.splitterItem1,
            this.splitterItem2,
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.tabbedControlGroup1,
            this.emptySpaceItem1,
            this.simpleLabelItem1,
            this.stdHeadLabel,
            this.infoHeader});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutControlGroup1.Size = new System.Drawing.Size(793, 398);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // splitterItem1
            // 
            this.splitterItem1.AllowHotTrack = true;
            this.splitterItem1.Location = new System.Drawing.Point(148, 0);
            this.splitterItem1.Name = "splitterItem1";
            this.splitterItem1.Size = new System.Drawing.Size(12, 388);
            // 
            // splitterItem2
            // 
            this.splitterItem2.AllowHotTrack = true;
            this.splitterItem2.Location = new System.Drawing.Point(404, 0);
            this.splitterItem2.Name = "splitterItem2";
            this.splitterItem2.Size = new System.Drawing.Size(12, 388);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.groupGrid;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 28);
            this.layoutControlItem1.MaxSize = new System.Drawing.Size(170, 0);
            this.layoutControlItem1.MinSize = new System.Drawing.Size(104, 24);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(148, 360);
            this.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.studentGrid;
            this.layoutControlItem2.Location = new System.Drawing.Point(160, 28);
            this.layoutControlItem2.MaxSize = new System.Drawing.Size(290, 0);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(100, 1);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(244, 360);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // tabbedControlGroup1
            // 
            this.tabbedControlGroup1.Location = new System.Drawing.Point(416, 28);
            this.tabbedControlGroup1.Name = "tabbedControlGroup1";
            this.tabbedControlGroup1.SelectedTabPage = this.paymentsgroup;
            this.tabbedControlGroup1.SelectedTabPageIndex = 1;
            this.tabbedControlGroup1.Size = new System.Drawing.Size(263, 360);
            this.tabbedControlGroup1.TabPages.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.contactsgroup,
            this.paymentsgroup});
            // 
            // paymentsgroup
            // 
            this.paymentsgroup.Location = new System.Drawing.Point(0, 0);
            this.paymentsgroup.Name = "paymentsgroup";
            this.paymentsgroup.Size = new System.Drawing.Size(239, 313);
            this.paymentsgroup.Text = "payments";
            // 
            // contactsgroup
            // 
            this.contactsgroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem3,
            this.phonemainlabel,
            this.emptySpaceItem2});
            this.contactsgroup.Location = new System.Drawing.Point(0, 0);
            this.contactsgroup.Name = "contactsgroup";
            this.contactsgroup.Size = new System.Drawing.Size(239, 313);
            this.contactsgroup.Text = "contacts";
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.AppearanceItemCaption.ForeColor = System.Drawing.SystemColors.GrayText;
            this.layoutControlItem3.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem3.Control = this.phoneadd;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 41);
            this.layoutControlItem3.MinSize = new System.Drawing.Size(73, 17);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(239, 40);
            this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem3.Text = "phone #2";
            this.layoutControlItem3.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(47, 13);
            this.layoutControlItem3.TextToControlDistance = 10;
            // 
            // phonemainlabel
            // 
            this.phonemainlabel.AppearanceItemCaption.ForeColor = System.Drawing.SystemColors.GrayText;
            this.phonemainlabel.AppearanceItemCaption.Options.UseForeColor = true;
            this.phonemainlabel.Control = this.phonemain;
            this.phonemainlabel.Location = new System.Drawing.Point(0, 0);
            this.phonemainlabel.MinSize = new System.Drawing.Size(73, 17);
            this.phonemainlabel.Name = "phonemainlabel";
            this.phonemainlabel.Size = new System.Drawing.Size(239, 41);
            this.phonemainlabel.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.phonemainlabel.Text = "phone #1";
            this.phonemainlabel.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.phonemainlabel.TextSize = new System.Drawing.Size(47, 13);
            this.phonemainlabel.TextToControlDistance = 10;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 81);
            this.emptySpaceItem2.MinSize = new System.Drawing.Size(104, 24);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(239, 232);
            this.emptySpaceItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(679, 0);
            this.emptySpaceItem1.MinSize = new System.Drawing.Size(104, 24);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(104, 388);
            this.emptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem1.Spacing = new DevExpress.XtraLayout.Utils.Padding(10, 0, 0, 0);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // simpleLabelItem1
            // 
            this.simpleLabelItem1.AllowHotTrack = false;
            this.simpleLabelItem1.AppearanceItemCaption.FontSizeDelta = 1;
            this.simpleLabelItem1.AppearanceItemCaption.ForeColor = System.Drawing.SystemColors.GrayText;
            this.simpleLabelItem1.AppearanceItemCaption.Options.UseFont = true;
            this.simpleLabelItem1.AppearanceItemCaption.Options.UseForeColor = true;
            this.simpleLabelItem1.Location = new System.Drawing.Point(0, 0);
            this.simpleLabelItem1.Name = "simpleLabelItem1";
            this.simpleLabelItem1.Size = new System.Drawing.Size(148, 28);
            this.simpleLabelItem1.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 0, 5, 5);
            this.simpleLabelItem1.Text = "groups";
            this.simpleLabelItem1.TextSize = new System.Drawing.Size(48, 14);
            // 
            // stdHeadLabel
            // 
            this.stdHeadLabel.AllowHotTrack = false;
            this.stdHeadLabel.AppearanceItemCaption.FontSizeDelta = 1;
            this.stdHeadLabel.AppearanceItemCaption.ForeColor = System.Drawing.SystemColors.GrayText;
            this.stdHeadLabel.AppearanceItemCaption.Options.UseFont = true;
            this.stdHeadLabel.AppearanceItemCaption.Options.UseForeColor = true;
            this.stdHeadLabel.Location = new System.Drawing.Point(160, 0);
            this.stdHeadLabel.Name = "stdHeadLabel";
            this.stdHeadLabel.Size = new System.Drawing.Size(244, 28);
            this.stdHeadLabel.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 0, 5, 5);
            this.stdHeadLabel.Text = "students";
            this.stdHeadLabel.TextSize = new System.Drawing.Size(48, 14);
            // 
            // infoHeader
            // 
            this.infoHeader.AllowHotTrack = false;
            this.infoHeader.AppearanceItemCaption.FontSizeDelta = 1;
            this.infoHeader.AppearanceItemCaption.ForeColor = System.Drawing.SystemColors.GrayText;
            this.infoHeader.AppearanceItemCaption.Options.UseFont = true;
            this.infoHeader.AppearanceItemCaption.Options.UseForeColor = true;
            this.infoHeader.Location = new System.Drawing.Point(416, 0);
            this.infoHeader.Name = "infoHeader";
            this.infoHeader.Size = new System.Drawing.Size(263, 28);
            this.infoHeader.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 0, 5, 5);
            this.infoHeader.Text = "info";
            this.infoHeader.TextSize = new System.Drawing.Size(48, 14);
            // 
            // peoples
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Name = "peoples";
            this.Size = new System.Drawing.Size(793, 398);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.studentGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentsgroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactsgroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phonemainlabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stdHeadLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoHeader)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraGrid.GridControl studentGrid;
        private DevExpress.XtraLayout.SplitterItem splitterItem1;
        private DevExpress.XtraLayout.SplitterItem splitterItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        public DevExpress.Data.RealTimeSource realTimeGroup;
        public DevExpress.Data.RealTimeSource realTimeStudents;
        public DevExpress.XtraGrid.Views.Grid.GridView studentView;
        public DevExpress.XtraGrid.Views.Grid.GridView groupView;
        public DevExpress.XtraGrid.GridControl groupGrid;
        private DevExpress.XtraEditors.LabelControl phoneadd;
        private DevExpress.XtraEditors.LabelControl phonemain;
        private DevExpress.XtraLayout.TabbedControlGroup tabbedControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup contactsgroup;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem phonemainlabel;
        private DevExpress.XtraLayout.LayoutControlGroup paymentsgroup;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.SimpleLabelItem simpleLabelItem1;
        private DevExpress.XtraLayout.SimpleLabelItem stdHeadLabel;
        private DevExpress.XtraLayout.SimpleLabelItem infoHeader;
    }
}
