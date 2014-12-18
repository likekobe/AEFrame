namespace AEDemo
{
    partial class frmLoadReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoadReport));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnEsc = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
            this.nbfrmLoad1 = new DevExpress.XtraNavBar.NavBarItem();
            this.nbfrmLoad2 = new DevExpress.XtraNavBar.NavBarItem();
            this.nbfrmLoad3 = new DevExpress.XtraNavBar.NavBarItem();
            this.nbfrmLoad4 = new DevExpress.XtraNavBar.NavBarItem();
            this.nbfrmLoad5 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup2 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarGroup3 = new DevExpress.XtraNavBar.NavBarGroup();
            this.tabControlReport = new DevExpress.XtraTab.XtraTabControl();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabControlReport)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ribbonControl1.ApplicationButtonText = null;
            this.ribbonControl1.Dock = System.Windows.Forms.DockStyle.None;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnEsc});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 1;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.SelectedPage = this.ribbonPage1;
            this.ribbonControl1.ShowCategoryInCaption = false;
            this.ribbonControl1.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl1.Size = new System.Drawing.Size(898, 98);
            this.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // btnEsc
            // 
            this.btnEsc.Caption = "退出";
            this.btnEsc.Id = 0;
            this.btnEsc.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnEsc.LargeGlyph")));
            this.btnEsc.LargeWidth = 85;
            this.btnEsc.Name = "btnEsc";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnEsc);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.navBarGroup1;
            this.navBarControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroup1,
            this.navBarGroup2,
            this.navBarGroup3});
            this.navBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.nbfrmLoad1,
            this.nbfrmLoad2,
            this.nbfrmLoad3,
            this.nbfrmLoad4,
            this.nbfrmLoad5});
            this.navBarControl1.Location = new System.Drawing.Point(0, 104);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 197;
            this.navBarControl1.Size = new System.Drawing.Size(221, 459);
            this.navBarControl1.TabIndex = 1;
            this.navBarControl1.Text = "navBarControl1";
            this.navBarControl1.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarControl1_LinkClicked);
            // 
            // navBarGroup1
            // 
            this.navBarGroup1.Caption = "调查表";
            this.navBarGroup1.Expanded = true;
            this.navBarGroup1.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbfrmLoad1),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbfrmLoad2),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbfrmLoad3),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbfrmLoad4),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbfrmLoad5)});
            this.navBarGroup1.Name = "navBarGroup1";
            // 
            // nbfrmLoad1
            // 
            this.nbfrmLoad1.Caption = "开发区基本信息调查表（Ⅰ）";
            this.nbfrmLoad1.Name = "nbfrmLoad1";
            this.nbfrmLoad1.Tag = "表F.1  开发区基本信息调查表（Ⅰ）";
            this.nbfrmLoad1.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarControl1_LinkClicked);
            // 
            // nbfrmLoad2
            // 
            this.nbfrmLoad2.Caption = "开发区基本信息调查表（Ⅱ）";
            this.nbfrmLoad2.Name = "nbfrmLoad2";
            this.nbfrmLoad2.Tag = "表F.2  开发区基本信息调查表（Ⅱ）";
            this.nbfrmLoad2.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarControl1_LinkClicked);
            // 
            // nbfrmLoad3
            // 
            this.nbfrmLoad3.Caption = "审批及调整情况调查表";
            this.nbfrmLoad3.Name = "nbfrmLoad3";
            this.nbfrmLoad3.Tag = "表F.3  开发区用地审批及调整情况调查表";
            this.nbfrmLoad3.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarControl1_LinkClicked);
            // 
            // nbfrmLoad4
            // 
            this.nbfrmLoad4.Caption = "土地利用状况统计表（Ⅰ）";
            this.nbfrmLoad4.Name = "nbfrmLoad4";
            this.nbfrmLoad4.Tag = "表F.4  开发区土地利用状况统计表（Ⅰ）——按建设状况划分";
            this.nbfrmLoad4.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarControl1_LinkClicked);
            // 
            // nbfrmLoad5
            // 
            this.nbfrmLoad5.Caption = "土地利用状况统计表（Ⅱ）";
            this.nbfrmLoad5.Name = "nbfrmLoad5";
            this.nbfrmLoad5.Tag = "表F.5  开发区土地利用状况统计表（Ⅱ）——按供应状况划分";
            this.nbfrmLoad5.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarControl1_LinkClicked);
            // 
            // navBarGroup2
            // 
            this.navBarGroup2.Caption = "评价表";
            this.navBarGroup2.Expanded = true;
            this.navBarGroup2.Name = "navBarGroup2";
            // 
            // navBarGroup3
            // 
            this.navBarGroup3.Caption = "测算表";
            this.navBarGroup3.Expanded = true;
            this.navBarGroup3.Name = "navBarGroup3";
            // 
            // tabControlReport
            // 
            this.tabControlReport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlReport.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InTabControlHeader;
            this.tabControlReport.Location = new System.Drawing.Point(227, 104);
            this.tabControlReport.Name = "tabControlReport";
            this.tabControlReport.Size = new System.Drawing.Size(671, 459);
            this.tabControlReport.TabIndex = 2;
            this.tabControlReport.CloseButtonClick += new System.EventHandler(this.tabControlReport_CloseButtonClick);
            // 
            // frmLoadReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 575);
            this.Controls.Add(this.tabControlReport);
            this.Controls.Add(this.navBarControl1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "frmLoadReport";
            this.Text = "报表输出";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabControlReport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
        private DevExpress.XtraNavBar.NavBarItem nbfrmLoad1;
        private DevExpress.XtraNavBar.NavBarItem nbfrmLoad2;
        private DevExpress.XtraNavBar.NavBarItem nbfrmLoad3;
        private DevExpress.XtraNavBar.NavBarItem nbfrmLoad4;
        private DevExpress.XtraNavBar.NavBarItem nbfrmLoad5;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup2;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup3;
        private DevExpress.XtraBars.BarButtonItem btnEsc;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        public DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        public DevExpress.XtraTab.XtraTabControl tabControlReport;
    }
}