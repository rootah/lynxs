using lynxs.controls;
using lynxs.customcontrols;

namespace lynxs.forms
{
    partial class main
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.formAss = new DevExpress.XtraBars.FormAssistant();
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.customBackstage = new lynxs.customcontrols.CustomBackstageViewControl();
            this.backstageStop = new DevExpress.XtraBars.Ribbon.BackstageViewButtonItem();
            this.startNewPop = new DevExpress.XtraBars.BarButtonItem();
            this.newPop = new DevExpress.XtraBars.PopupMenu(this.components);
            this.startNewGroup = new DevExpress.XtraBars.BarButtonItem();
            this.startNewStd = new DevExpress.XtraBars.BarButtonItem();
            this.startNewIncome = new DevExpress.XtraBars.BarButtonItem();
            this.startEditBtn = new DevExpress.XtraBars.BarButtonItem();
            this.startDelBtn = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonGroup1 = new DevExpress.XtraBars.BarButtonGroup();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.popupControlContainer1 = new DevExpress.XtraBars.PopupControlContainer(this.components);
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPaymentsCat = new DevExpress.XtraBars.Ribbon.RibbonPageCategory();
            this.ribbonMoneys = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStart = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonStartGroupOne = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatus = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.defaultLook = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.backstageMain = new DevExpress.XtraBars.Ribbon.BackstageViewControl();
            this.navGroupsClient = new DevExpress.XtraBars.Ribbon.BackstageViewClientControl();
            this.peoplesCtrl = new lynxs.controls.peoples();
            this.navPaymentsClient = new DevExpress.XtraBars.Ribbon.BackstageViewClientControl();
            this.paymentsCtrl = new lynxs.controls.payments();
            this.navGroups = new DevExpress.XtraBars.Ribbon.BackstageViewTabItem();
            this.navPayments = new DevExpress.XtraBars.Ribbon.BackstageViewTabItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customBackstage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newPop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupControlContainer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backstageMain)).BeginInit();
            this.backstageMain.SuspendLayout();
            this.navGroupsClient.SuspendLayout();
            this.navPaymentsClient.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ApplicationButtonDropDownControl = this.customBackstage;
            this.ribbon.ApplicationButtonText = "-";
            this.ribbon.DrawGroupCaptions = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.startNewPop,
            this.startNewGroup,
            this.startNewStd,
            this.startNewIncome,
            this.startEditBtn,
            this.startDelBtn,
            this.barButtonGroup1,
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3,
            this.barButtonItem4,
            this.barButtonItem5,
            this.barButtonItem6,
            this.barButtonItem7});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 23;
            this.ribbon.Name = "ribbon";
            this.ribbon.PageAnimationLength = 0;
            this.ribbon.PageCategories.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageCategory[] {
            this.ribbonPaymentsCat});
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonStart});
            this.ribbon.PopupShowMode = DevExpress.XtraBars.PopupShowMode.Inplace;
            this.ribbon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.OfficeUniversal;
            this.ribbon.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowFullScreenButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowItemCaptionsInQAT = true;
            this.ribbon.ShowQatLocationSelector = false;
            this.ribbon.ShowToolbarCustomizeItem = false;
            this.ribbon.Size = new System.Drawing.Size(1274, 83);
            this.ribbon.StatusBar = this.ribbonStatus;
            this.ribbon.Toolbar.ShowCustomizeItem = false;
            // 
            // customBackstage
            // 
            this.customBackstage.CaptionHorizontalAlignment = DevExpress.Utils.Drawing.ItemHorizontalAlignment.Right;
            this.customBackstage.ColorScheme = DevExpress.XtraBars.Ribbon.RibbonControlColorScheme.Yellow;
            this.customBackstage.Items.Add(this.backstageStop);
            this.customBackstage.Location = new System.Drawing.Point(940, 28);
            this.customBackstage.Name = "customBackstage";
            this.customBackstage.Ribbon = this.ribbon;
            this.customBackstage.SelectedTab = null;
            this.customBackstage.Size = new System.Drawing.Size(165, 46);
            this.customBackstage.Style = DevExpress.XtraBars.Ribbon.BackstageViewStyle.Office2013;
            this.customBackstage.TabIndex = 4;
            this.customBackstage.Text = "customBackstageViewControl1";
            // 
            // backstageStop
            // 
            this.backstageStop.Caption = "stop";
            this.backstageStop.Name = "backstageStop";
            this.backstageStop.ItemClick += new DevExpress.XtraBars.Ribbon.BackstageViewItemEventHandler(this.backstageHalt_ItemClick);
            // 
            // startNewPop
            // 
            this.startNewPop.ActAsDropDown = true;
            this.startNewPop.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.startNewPop.Caption = "new ..";
            this.startNewPop.DropDownControl = this.newPop;
            this.startNewPop.Id = 1;
            this.startNewPop.Name = "startNewPop";
            // 
            // newPop
            // 
            this.newPop.ItemLinks.Add(this.startNewGroup);
            this.newPop.ItemLinks.Add(this.startNewStd);
            this.newPop.ItemLinks.Add(this.startNewIncome);
            this.newPop.Name = "newPop";
            this.newPop.Ribbon = this.ribbon;
            // 
            // startNewGroup
            // 
            this.startNewGroup.Caption = "group";
            this.startNewGroup.Id = 2;
            this.startNewGroup.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G));
            this.startNewGroup.Name = "startNewGroup";
            this.startNewGroup.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.startNewGroup_ItemClick);
            // 
            // startNewStd
            // 
            this.startNewStd.Caption = "std";
            this.startNewStd.Id = 3;
            this.startNewStd.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S));
            this.startNewStd.Name = "startNewStd";
            this.startNewStd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.startNewStd_ItemClick);
            // 
            // startNewIncome
            // 
            this.startNewIncome.Caption = "income";
            this.startNewIncome.Id = 4;
            this.startNewIncome.Name = "startNewIncome";
            // 
            // startEditBtn
            // 
            this.startEditBtn.Caption = "edit";
            this.startEditBtn.Id = 7;
            this.startEditBtn.Name = "startEditBtn";
            this.startEditBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.startEditBtn_ItemClick);
            // 
            // startDelBtn
            // 
            this.startDelBtn.Caption = "drop";
            this.startDelBtn.Id = 8;
            this.startDelBtn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("startDelBtn.LargeGlyph")));
            this.startDelBtn.Name = "startDelBtn";
            // 
            // barButtonGroup1
            // 
            this.barButtonGroup1.Caption = "barButtonGroup1";
            this.barButtonGroup1.Id = 15;
            this.barButtonGroup1.Name = "barButtonGroup1";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check;
            this.barButtonItem1.Caption = "today";
            this.barButtonItem1.Id = 16;
            this.barButtonItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.LargeGlyph")));
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check;
            this.barButtonItem2.Caption = "week";
            this.barButtonItem2.Id = 17;
            this.barButtonItem2.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.LargeGlyph")));
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check;
            this.barButtonItem3.Caption = "month";
            this.barButtonItem3.Id = 18;
            this.barButtonItem3.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.LargeGlyph")));
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.ActAsDropDown = true;
            this.barButtonItem4.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.barButtonItem4.Caption = "custom";
            this.barButtonItem4.DropDownControl = this.popupControlContainer1;
            this.barButtonItem4.Id = 19;
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // popupControlContainer1
            // 
            this.popupControlContainer1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.popupControlContainer1.Location = new System.Drawing.Point(701, 28);
            this.popupControlContainer1.Name = "popupControlContainer1";
            this.popupControlContainer1.Ribbon = this.ribbon;
            this.popupControlContainer1.ShowCloseButton = true;
            this.popupControlContainer1.Size = new System.Drawing.Size(248, 96);
            this.popupControlContainer1.TabIndex = 13;
            this.popupControlContainer1.Visible = false;
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "pause";
            this.barButtonItem5.Id = 20;
            this.barButtonItem5.Name = "barButtonItem5";
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Caption = "stop";
            this.barButtonItem6.Id = 21;
            this.barButtonItem6.Name = "barButtonItem6";
            // 
            // barButtonItem7
            // 
            this.barButtonItem7.Caption = "start";
            this.barButtonItem7.Id = 22;
            this.barButtonItem7.Name = "barButtonItem7";
            // 
            // ribbonPaymentsCat
            // 
            this.ribbonPaymentsCat.AutoStretchPageHeaders = true;
            this.ribbonPaymentsCat.Color = System.Drawing.SystemColors.Control;
            this.ribbonPaymentsCat.Name = "ribbonPaymentsCat";
            this.ribbonPaymentsCat.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonMoneys});
            this.ribbonPaymentsCat.Text = "Payments";
            // 
            // ribbonMoneys
            // 
            this.ribbonMoneys.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonMoneys.Name = "ribbonMoneys";
            this.ribbonMoneys.Text = "fees";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonGroup1);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem1, false, "", "", true);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem2, false, "", "", true);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem3, false, "", "", true);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem4, true);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            this.ribbonPageGroup1.Text = "display";
            // 
            // ribbonStart
            // 
            this.ribbonStart.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonStartGroupOne,
            this.ribbonPageGroup2});
            this.ribbonStart.Name = "ribbonStart";
            this.ribbonStart.Text = "start";
            // 
            // ribbonStartGroupOne
            // 
            this.ribbonStartGroupOne.AllowTextClipping = false;
            this.ribbonStartGroupOne.ItemLinks.Add(this.startNewPop);
            this.ribbonStartGroupOne.ItemLinks.Add(this.startEditBtn, true);
            this.ribbonStartGroupOne.ItemLinks.Add(this.startDelBtn);
            this.ribbonStartGroupOne.Name = "ribbonStartGroupOne";
            this.ribbonStartGroupOne.ShowCaptionButton = false;
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem5);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem6);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem7);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.ShowCaptionButton = false;
            // 
            // ribbonStatus
            // 
            this.ribbonStatus.AutoHeight = true;
            this.ribbonStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ribbonStatus.Location = new System.Drawing.Point(0, 481);
            this.ribbonStatus.Name = "ribbonStatus";
            this.ribbonStatus.Ribbon = this.ribbon;
            this.ribbonStatus.Size = new System.Drawing.Size(1274, 21);
            // 
            // defaultLook
            // 
            this.defaultLook.LookAndFeel.SkinName = "Office 2016 Colorful";
            // 
            // backstageMain
            // 
            this.backstageMain.ColorScheme = DevExpress.XtraBars.Ribbon.RibbonControlColorScheme.Yellow;
            this.backstageMain.Controls.Add(this.navGroupsClient);
            this.backstageMain.Controls.Add(this.navPaymentsClient);
            this.backstageMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backstageMain.Items.Add(this.navGroups);
            this.backstageMain.Items.Add(this.navPayments);
            this.backstageMain.Location = new System.Drawing.Point(0, 83);
            this.backstageMain.Name = "backstageMain";
            this.backstageMain.SelectedTab = this.navPayments;
            this.backstageMain.SelectedTabIndex = 1;
            this.backstageMain.Size = new System.Drawing.Size(1274, 398);
            this.backstageMain.TabIndex = 10;
            this.backstageMain.Text = "backstageViewControl1";
            this.backstageMain.SelectedTabChanged += new DevExpress.XtraBars.Ribbon.BackstageViewItemEventHandler(this.backstageMain_SelectedTabChanged);
            // 
            // navGroupsClient
            // 
            this.navGroupsClient.Controls.Add(this.peoplesCtrl);
            this.navGroupsClient.Location = new System.Drawing.Point(158, 0);
            this.navGroupsClient.Name = "navGroupsClient";
            this.navGroupsClient.Size = new System.Drawing.Size(1116, 398);
            this.navGroupsClient.TabIndex = 1;
            // 
            // peoplesCtrl
            // 
            this.peoplesCtrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.peoplesCtrl.Location = new System.Drawing.Point(0, 0);
            this.peoplesCtrl.Name = "peoplesCtrl";
            this.peoplesCtrl.Size = new System.Drawing.Size(1116, 398);
            this.peoplesCtrl.TabIndex = 0;
            // 
            // navPaymentsClient
            // 
            this.navPaymentsClient.Controls.Add(this.paymentsCtrl);
            this.navPaymentsClient.Location = new System.Drawing.Point(158, 0);
            this.navPaymentsClient.Name = "navPaymentsClient";
            this.navPaymentsClient.Size = new System.Drawing.Size(1116, 398);
            this.navPaymentsClient.TabIndex = 2;
            // 
            // paymentsCtrl
            // 
            this.paymentsCtrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paymentsCtrl.Location = new System.Drawing.Point(0, 0);
            this.paymentsCtrl.Name = "paymentsCtrl";
            this.paymentsCtrl.Size = new System.Drawing.Size(1116, 398);
            this.paymentsCtrl.TabIndex = 0;
            // 
            // navGroups
            // 
            this.navGroups.Caption = "groups / peoples";
            this.navGroups.ContentControl = this.navGroupsClient;
            this.navGroups.Name = "navGroups";
            this.navGroups.Selected = false;
            // 
            // navPayments
            // 
            this.navPayments.Caption = "payments";
            this.navPayments.ContentControl = this.navPaymentsClient;
            this.navPayments.Name = "navPayments";
            this.navPayments.Selected = true;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 502);
            this.Controls.Add(this.backstageMain);
            this.Controls.Add(this.popupControlContainer1);
            this.Controls.Add(this.customBackstage);
            this.Controls.Add(this.ribbonStatus);
            this.Controls.Add(this.ribbon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "main";
            this.Ribbon = this.ribbon;
            this.ShowIcon = false;
            this.StatusBar = this.ribbonStatus;
            this.Text = "lynx.s 0x1";
            this.Load += new System.EventHandler(this.main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customBackstage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newPop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupControlContainer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backstageMain)).EndInit();
            this.backstageMain.ResumeLayout(false);
            this.navGroupsClient.ResumeLayout(false);
            this.navPaymentsClient.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.FormAssistant formAss;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonStart;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonStartGroupOne;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatus;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLook;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonMoneys;
        private CustomBackstageViewControl customBackstage;
        private DevExpress.XtraBars.Ribbon.BackstageViewButtonItem backstageStop;
        private DevExpress.XtraBars.BarButtonItem startNewPop;
        private DevExpress.XtraBars.PopupMenu newPop;
        private DevExpress.XtraBars.BarButtonItem startNewGroup;
        private DevExpress.XtraBars.BarButtonItem startNewStd;
        private DevExpress.XtraBars.BarButtonItem startNewIncome;
        private DevExpress.XtraBars.Ribbon.BackstageViewControl backstageMain;
        private DevExpress.XtraBars.Ribbon.BackstageViewClientControl navGroupsClient;
        private DevExpress.XtraBars.Ribbon.BackstageViewClientControl navPaymentsClient;
        private DevExpress.XtraBars.Ribbon.BackstageViewTabItem navGroups;
        private DevExpress.XtraBars.Ribbon.BackstageViewTabItem navPayments;
        private payments paymentsCtrl;
        private DevExpress.XtraBars.BarButtonItem startDelBtn;
        public DevExpress.XtraBars.BarButtonItem startEditBtn;
        public peoples peoplesCtrl;
        private DevExpress.XtraBars.Ribbon.RibbonPageCategory ribbonPaymentsCat;
        private DevExpress.XtraBars.BarButtonGroup barButtonGroup1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.PopupControlContainer popupControlContainer1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraBars.BarButtonItem barButtonItem7;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
    }
}

