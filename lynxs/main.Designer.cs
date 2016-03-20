namespace lynxs
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
            this.formAss = new DevExpress.XtraBars.FormAssistant();
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.customBackstage = new lynxs.CustomBackstageViewControl();
            this.backstageStop = new DevExpress.XtraBars.Ribbon.BackstageViewButtonItem();
            this.startNewPop = new DevExpress.XtraBars.BarButtonItem();
            this.newPop = new DevExpress.XtraBars.PopupMenu();
            this.startNewGroup = new DevExpress.XtraBars.BarButtonItem();
            this.startNewStd = new DevExpress.XtraBars.BarButtonItem();
            this.startNewIncome = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonStart = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonStartGroupOne = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonMoneys = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonStatus = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.defaultLook = new DevExpress.LookAndFeel.DefaultLookAndFeel();
            this.backstageViewControl1 = new DevExpress.XtraBars.Ribbon.BackstageViewControl();
            this.navGroupsClient = new DevExpress.XtraBars.Ribbon.BackstageViewClientControl();
            this.navPaymentsClient = new DevExpress.XtraBars.Ribbon.BackstageViewClientControl();
            this.navGroups = new DevExpress.XtraBars.Ribbon.BackstageViewTabItem();
            this.navPayments = new DevExpress.XtraBars.Ribbon.BackstageViewTabItem();
            this.payments1 = new lynxs.payments();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customBackstage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newPop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backstageViewControl1)).BeginInit();
            this.backstageViewControl1.SuspendLayout();
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
            this.startNewIncome});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 5;
            this.ribbon.Name = "ribbon";
            this.ribbon.PageAnimationLength = 0;
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonStart,
            this.ribbonMoneys});
            this.ribbon.PopupShowMode = DevExpress.XtraBars.PopupShowMode.Inplace;
            this.ribbon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.OfficeUniversal;
            this.ribbon.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowFullScreenButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.Size = new System.Drawing.Size(1385, 83);
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
            // 
            // startNewStd
            // 
            this.startNewStd.Caption = "std";
            this.startNewStd.Id = 3;
            this.startNewStd.Name = "startNewStd";
            // 
            // startNewIncome
            // 
            this.startNewIncome.Caption = "income";
            this.startNewIncome.Id = 4;
            this.startNewIncome.Name = "startNewIncome";
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
            this.ribbonStatus.Location = new System.Drawing.Point(0, 505);
            this.ribbonStatus.Name = "ribbonStatus";
            this.ribbonStatus.Ribbon = this.ribbon;
            this.ribbonStatus.Size = new System.Drawing.Size(1385, 21);
            // 
            // defaultLook
            // 
            this.defaultLook.LookAndFeel.SkinName = "Office 2016 Dark";
            // 
            // backstageViewControl1
            // 
            this.backstageViewControl1.ColorScheme = DevExpress.XtraBars.Ribbon.RibbonControlColorScheme.Yellow;
            this.backstageViewControl1.Controls.Add(this.navGroupsClient);
            this.backstageViewControl1.Controls.Add(this.navPaymentsClient);
            this.backstageViewControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backstageViewControl1.Items.Add(this.navGroups);
            this.backstageViewControl1.Items.Add(this.navPayments);
            this.backstageViewControl1.Location = new System.Drawing.Point(0, 83);
            this.backstageViewControl1.Name = "backstageViewControl1";
            this.backstageViewControl1.SelectedTab = this.navPayments;
            this.backstageViewControl1.SelectedTabIndex = 1;
            this.backstageViewControl1.Size = new System.Drawing.Size(1385, 422);
            this.backstageViewControl1.TabIndex = 10;
            this.backstageViewControl1.Text = "backstageViewControl1";
            // 
            // navGroupsClient
            // 
            this.navGroupsClient.Location = new System.Drawing.Point(158, 0);
            this.navGroupsClient.Name = "navGroupsClient";
            this.navGroupsClient.Size = new System.Drawing.Size(1227, 422);
            this.navGroupsClient.TabIndex = 1;
            // 
            // navPaymentsClient
            // 
            this.navPaymentsClient.Controls.Add(this.payments1);
            this.navPaymentsClient.Location = new System.Drawing.Point(158, 0);
            this.navPaymentsClient.Name = "navPaymentsClient";
            this.navPaymentsClient.Size = new System.Drawing.Size(1227, 422);
            this.navPaymentsClient.TabIndex = 2;
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
            // payments1
            // 
            this.payments1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.payments1.Location = new System.Drawing.Point(0, 0);
            this.payments1.Name = "payments1";
            this.payments1.Size = new System.Drawing.Size(1227, 422);
            this.payments1.TabIndex = 0;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1385, 526);
            this.Controls.Add(this.backstageViewControl1);
            this.Controls.Add(this.customBackstage);
            this.Controls.Add(this.ribbonStatus);
            this.Controls.Add(this.ribbon);
            this.Name = "main";
            this.Ribbon = this.ribbon;
            this.ShowIcon = false;
            this.StatusBar = this.ribbonStatus;
            this.Text = "lynx.s 0x1";
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customBackstage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newPop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backstageViewControl1)).EndInit();
            this.backstageViewControl1.ResumeLayout(false);
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
        private DevExpress.XtraBars.Ribbon.BackstageViewControl backstageViewControl1;
        private DevExpress.XtraBars.Ribbon.BackstageViewClientControl navGroupsClient;
        private DevExpress.XtraBars.Ribbon.BackstageViewClientControl navPaymentsClient;
        private DevExpress.XtraBars.Ribbon.BackstageViewTabItem navGroups;
        private DevExpress.XtraBars.Ribbon.BackstageViewTabItem navPayments;
        private payments payments1;
    }
}

