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
            this.statusLabel = new DevExpress.XtraBars.BarStaticItem();
            this.startEditBtn = new DevExpress.XtraBars.BarButtonItem();
            this.startDelBtn = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonStart = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonStartGroupOne = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonMoneys = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonStatus = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.defaultLook = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.backstageMain = new DevExpress.XtraBars.Ribbon.BackstageViewControl();
            this.navGroupsClient = new DevExpress.XtraBars.Ribbon.BackstageViewClientControl();
            this.peoples1 = new lynxs.controls.peoples();
            this.navPaymentsClient = new DevExpress.XtraBars.Ribbon.BackstageViewClientControl();
            this.payments1 = new lynxs.controls.payments();
            this.navGroups = new DevExpress.XtraBars.Ribbon.BackstageViewTabItem();
            this.navPayments = new DevExpress.XtraBars.Ribbon.BackstageViewTabItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customBackstage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newPop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backstageMain)).BeginInit();
            this.backstageMain.SuspendLayout();
            this.navGroupsClient.SuspendLayout();
            this.navPaymentsClient.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ApplicationButtonDropDownControl = this.customBackstage;
            this.ribbon.ApplicationButtonText = "=";
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.startNewPop,
            this.startNewGroup,
            this.startNewStd,
            this.startNewIncome,
            this.statusLabel,
            this.startEditBtn,
            this.startDelBtn,
            this.barButtonItem1});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 10;
            this.ribbon.Name = "ribbon";
            this.ribbon.PageAnimationLength = 0;
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonStart,
            this.ribbonMoneys});
            this.ribbon.PopupShowMode = DevExpress.XtraBars.PopupShowMode.Inplace;
            this.ribbon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.OfficeUniversal;
            this.ribbon.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowFullScreenButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.Size = new System.Drawing.Size(1274, 83);
            this.ribbon.StatusBar = this.ribbonStatus;
            // 
            // customBackstage
            // 
            this.customBackstage.CaptionHorizontalAlignment = DevExpress.Utils.Drawing.ItemHorizontalAlignment.Right;
            this.customBackstage.ColorScheme = DevExpress.XtraBars.Ribbon.RibbonControlColorScheme.Yellow;
            this.customBackstage.Items.Add(this.backstageStop);
            this.customBackstage.Location = new System.Drawing.Point(1160, 28);
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
            this.startNewGroup.Name = "startNewGroup";
            this.startNewGroup.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.startNewGroup_ItemClick);
            // 
            // startNewStd
            // 
            this.startNewStd.Caption = "std";
            this.startNewStd.Id = 3;
            this.startNewStd.Name = "startNewStd";
            this.startNewStd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.startNewStd_ItemClick);
            // 
            // startNewIncome
            // 
            this.startNewIncome.Caption = "income";
            this.startNewIncome.Id = 4;
            this.startNewIncome.Name = "startNewIncome";
            // 
            // statusLabel
            // 
            this.statusLabel.Caption = "...";
            this.statusLabel.Id = 5;
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // startEditBtn
            // 
            this.startEditBtn.Caption = "edit";
            this.startEditBtn.Id = 7;
            this.startEditBtn.Name = "startEditBtn";
            // 
            // startDelBtn
            // 
            this.startDelBtn.Caption = "trash it";
            this.startDelBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("startDelBtn.Glyph")));
            this.startDelBtn.Id = 8;
            this.startDelBtn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("startDelBtn.LargeGlyph")));
            this.startDelBtn.Name = "startDelBtn";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "fill";
            this.barButtonItem1.Id = 9;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // ribbonStart
            // 
            this.ribbonStart.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonStartGroupOne});
            this.ribbonStart.Name = "ribbonStart";
            this.ribbonStart.Text = "start";
            // 
            // ribbonStartGroupOne
            // 
            this.ribbonStartGroupOne.ItemLinks.Add(this.startNewPop);
            this.ribbonStartGroupOne.ItemLinks.Add(this.startEditBtn, true);
            this.ribbonStartGroupOne.ItemLinks.Add(this.startDelBtn);
            this.ribbonStartGroupOne.ItemLinks.Add(this.barButtonItem1);
            this.ribbonStartGroupOne.Name = "ribbonStartGroupOne";
            this.ribbonStartGroupOne.Text = "ribbonPageGroup1";
            // 
            // ribbonMoneys
            // 
            this.ribbonMoneys.Name = "ribbonMoneys";
            this.ribbonMoneys.Text = "moneys";
            // 
            // ribbonStatus
            // 
            this.ribbonStatus.ItemLinks.Add(this.statusLabel);
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
            this.backstageMain.SelectedTab = this.navGroups;
            this.backstageMain.SelectedTabIndex = 0;
            this.backstageMain.Size = new System.Drawing.Size(1274, 398);
            this.backstageMain.TabIndex = 10;
            this.backstageMain.Text = "backstageViewControl1";
            // 
            // navGroupsClient
            // 
            this.navGroupsClient.Controls.Add(this.peoples1);
            this.navGroupsClient.Location = new System.Drawing.Point(158, 0);
            this.navGroupsClient.Name = "navGroupsClient";
            this.navGroupsClient.Size = new System.Drawing.Size(1116, 398);
            this.navGroupsClient.TabIndex = 1;
            // 
            // peoples1
            // 
            this.peoples1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.peoples1.Location = new System.Drawing.Point(0, 0);
            this.peoples1.Name = "peoples1";
            this.peoples1.Size = new System.Drawing.Size(1116, 398);
            this.peoples1.TabIndex = 0;
            // 
            // navPaymentsClient
            // 
            this.navPaymentsClient.Controls.Add(this.payments1);
            this.navPaymentsClient.Location = new System.Drawing.Point(158, 0);
            this.navPaymentsClient.Name = "navPaymentsClient";
            this.navPaymentsClient.Size = new System.Drawing.Size(1116, 398);
            this.navPaymentsClient.TabIndex = 2;
            // 
            // payments1
            // 
            this.payments1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.payments1.Location = new System.Drawing.Point(0, 0);
            this.payments1.Name = "payments1";
            this.payments1.Size = new System.Drawing.Size(1116, 398);
            this.payments1.TabIndex = 0;
            // 
            // navGroups
            // 
            this.navGroups.Caption = "groups / peoples";
            this.navGroups.ContentControl = this.navGroupsClient;
            this.navGroups.Name = "navGroups";
            this.navGroups.Selected = true;
            // 
            // navPayments
            // 
            this.navPayments.Caption = "payments";
            this.navPayments.ContentControl = this.navPaymentsClient;
            this.navPayments.Name = "navPayments";
            this.navPayments.Selected = false;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 502);
            this.Controls.Add(this.backstageMain);
            this.Controls.Add(this.customBackstage);
            this.Controls.Add(this.ribbonStatus);
            this.Controls.Add(this.ribbon);
            this.Name = "main";
            this.Ribbon = this.ribbon;
            this.ShowIcon = false;
            this.StatusBar = this.ribbonStatus;
            this.Text = "lynx.s 0x1";
            this.Load += new System.EventHandler(this.main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customBackstage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newPop)).EndInit();
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
        private payments payments1;
        private peoples peoples1;
        private DevExpress.XtraBars.BarStaticItem statusLabel;
        private DevExpress.XtraBars.BarButtonItem startEditBtn;
        private DevExpress.XtraBars.BarButtonItem startDelBtn;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
    }
}

