namespace AEDemo
{
    partial class frmFrame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFrame));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnOpenMxd = new DevExpress.XtraBars.BarButtonItem();
            this.btnAddData = new DevExpress.XtraBars.BarButtonItem();
            this.btnSave = new DevExpress.XtraBars.BarButtonItem();
            this.btnSaveAs = new DevExpress.XtraBars.BarButtonItem();
            this.btnEsc = new DevExpress.XtraBars.BarButtonItem();
            this.btnShowLog = new DevExpress.XtraBars.BarButtonItem();
            this.btnAddLog = new DevExpress.XtraBars.BarButtonItem();
            this.btnEagleEye = new DevExpress.XtraBars.BarButtonItem();
            this.btnPlayMusic = new DevExpress.XtraBars.BarButtonItem();
            this.btnLayerProperty = new DevExpress.XtraBars.BarButtonItem();
            this.btnPropertyDetails = new DevExpress.XtraBars.BarButtonItem();
            this.btnQuery = new DevExpress.XtraBars.BarButtonItem();
            this.btnSpatialQuery = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.axTOCControl1 = new ESRI.ArcGIS.Controls.AxTOCControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.浏览属性ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.移除图层ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.缩放到图层ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.选择ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.图层属性ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.axMapControlEagelEye = new ESRI.ArcGIS.Controls.AxMapControl();
            this.axLicenseControl1 = new ESRI.ArcGIS.Controls.AxLicenseControl();
            this.axMapControl1 = new ESRI.ArcGIS.Controls.AxMapControl();
            this.imageCollection = new DevExpress.Utils.ImageCollection(this.components);
            this.axToolbarControl1 = new ESRI.ArcGIS.Controls.AxToolbarControl();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axTOCControl1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axMapControlEagelEye)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axLicenseControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axMapControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axToolbarControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ribbonControl1.ApplicationButtonText = null;
            this.ribbonControl1.Dock = System.Windows.Forms.DockStyle.None;
            this.ribbonControl1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnOpenMxd,
            this.btnAddData,
            this.btnSave,
            this.btnSaveAs,
            this.btnEsc,
            this.btnShowLog,
            this.btnAddLog,
            this.btnEagleEye,
            this.btnPlayMusic,
            this.btnLayerProperty,
            this.btnPropertyDetails,
            this.btnQuery,
            this.btnSpatialQuery});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 22;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.PageHeaderItemLinks.Add(this.btnPlayMusic);
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2,
            this.ribbonPage3});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2007;
            this.ribbonControl1.SelectedPage = this.ribbonPage1;
            this.ribbonControl1.ShowToolbarCustomizeItem = false;
            this.ribbonControl1.Size = new System.Drawing.Size(969, 145);
            this.ribbonControl1.Toolbar.ItemLinks.Add(this.btnOpenMxd, "打开文件");
            this.ribbonControl1.Toolbar.ItemLinks.Add(this.btnAddData, "添加数据");
            this.ribbonControl1.Toolbar.ItemLinks.Add(this.btnSave);
            this.ribbonControl1.Toolbar.ItemLinks.Add(this.btnSaveAs);
            this.ribbonControl1.Toolbar.ItemLinks.Add(this.btnEagleEye);
            this.ribbonControl1.Toolbar.ItemLinks.Add(this.btnEsc);
            this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
            // 
            // btnOpenMxd
            // 
            this.btnOpenMxd.Caption = "打开文件";
            this.btnOpenMxd.Glyph = ((System.Drawing.Image)(resources.GetObject("btnOpenMxd.Glyph")));
            this.btnOpenMxd.Id = 3;
            this.btnOpenMxd.LargeWidth = 85;
            this.btnOpenMxd.Name = "btnOpenMxd";
            this.btnOpenMxd.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnOpenMxd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnOpenMxd_ItemClick);
            // 
            // btnAddData
            // 
            this.btnAddData.Caption = "添加数据";
            this.btnAddData.Glyph = ((System.Drawing.Image)(resources.GetObject("btnAddData.Glyph")));
            this.btnAddData.Id = 4;
            this.btnAddData.LargeWidth = 85;
            this.btnAddData.Name = "btnAddData";
            this.btnAddData.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnAddData.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAddData_ItemClick);
            // 
            // btnSave
            // 
            this.btnSave.Caption = "保存";
            this.btnSave.Glyph = ((System.Drawing.Image)(resources.GetObject("btnSave.Glyph")));
            this.btnSave.Id = 5;
            this.btnSave.LargeWidth = 85;
            this.btnSave.Name = "btnSave";
            this.btnSave.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSave_ItemClick);
            // 
            // btnSaveAs
            // 
            this.btnSaveAs.Caption = "另存为";
            this.btnSaveAs.Glyph = ((System.Drawing.Image)(resources.GetObject("btnSaveAs.Glyph")));
            this.btnSaveAs.Id = 6;
            this.btnSaveAs.LargeWidth = 85;
            this.btnSaveAs.Name = "btnSaveAs";
            this.btnSaveAs.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnSaveAs.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSaveAs_ItemClick);
            // 
            // btnEsc
            // 
            this.btnEsc.Caption = "退出";
            this.btnEsc.Glyph = ((System.Drawing.Image)(resources.GetObject("btnEsc.Glyph")));
            this.btnEsc.Id = 10;
            this.btnEsc.LargeWidth = 85;
            this.btnEsc.Name = "btnEsc";
            this.btnEsc.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnEsc.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEsc_ItemClick);
            // 
            // btnShowLog
            // 
            this.btnShowLog.Caption = "显示日志";
            this.btnShowLog.Glyph = ((System.Drawing.Image)(resources.GetObject("btnShowLog.Glyph")));
            this.btnShowLog.Id = 11;
            this.btnShowLog.LargeWidth = 85;
            this.btnShowLog.Name = "btnShowLog";
            this.btnShowLog.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnShowLog.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnShowLog_ItemClick);
            // 
            // btnAddLog
            // 
            this.btnAddLog.Caption = "添加日志";
            this.btnAddLog.Glyph = ((System.Drawing.Image)(resources.GetObject("btnAddLog.Glyph")));
            this.btnAddLog.Id = 12;
            this.btnAddLog.LargeWidth = 85;
            this.btnAddLog.Name = "btnAddLog";
            this.btnAddLog.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnAddLog.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAddLog_ItemClick);
            // 
            // btnEagleEye
            // 
            this.btnEagleEye.Caption = "鹰眼";
            this.btnEagleEye.Glyph = ((System.Drawing.Image)(resources.GetObject("btnEagleEye.Glyph")));
            this.btnEagleEye.Id = 13;
            this.btnEagleEye.Name = "btnEagleEye";
            this.btnEagleEye.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEagleEye_ItemClick);
            // 
            // btnPlayMusic
            // 
            this.btnPlayMusic.Caption = "播放音乐";
            this.btnPlayMusic.Glyph = ((System.Drawing.Image)(resources.GetObject("btnPlayMusic.Glyph")));
            this.btnPlayMusic.Id = 16;
            this.btnPlayMusic.Name = "btnPlayMusic";
            this.btnPlayMusic.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPlayMusic_ItemClick);
            // 
            // btnLayerProperty
            // 
            this.btnLayerProperty.Caption = "图层属性";
            this.btnLayerProperty.Glyph = ((System.Drawing.Image)(resources.GetObject("btnLayerProperty.Glyph")));
            this.btnLayerProperty.Id = 17;
            this.btnLayerProperty.LargeWidth = 85;
            this.btnLayerProperty.Name = "btnLayerProperty";
            this.btnLayerProperty.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnLayerProperty.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLayerProperty_ItemClick);
            // 
            // btnPropertyDetails
            // 
            this.btnPropertyDetails.Caption = "浏览属性";
            this.btnPropertyDetails.Glyph = ((System.Drawing.Image)(resources.GetObject("btnPropertyDetails.Glyph")));
            this.btnPropertyDetails.Id = 18;
            this.btnPropertyDetails.LargeWidth = 85;
            this.btnPropertyDetails.Name = "btnPropertyDetails";
            this.btnPropertyDetails.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnPropertyDetails.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPropertyDetails_ItemClick);
            // 
            // btnQuery
            // 
            this.btnQuery.Caption = "属性查询";
            this.btnQuery.Glyph = ((System.Drawing.Image)(resources.GetObject("btnQuery.Glyph")));
            this.btnQuery.Id = 20;
            this.btnQuery.LargeWidth = 85;
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnQuery.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnQuery_ItemClick);
            // 
            // btnSpatialQuery
            // 
            this.btnSpatialQuery.Caption = "空间查询";
            this.btnSpatialQuery.Glyph = ((System.Drawing.Image)(resources.GetObject("btnSpatialQuery.Glyph")));
            this.btnSpatialQuery.Id = 21;
            this.btnSpatialQuery.LargeWidth = 85;
            this.btnSpatialQuery.Name = "btnSpatialQuery";
            this.btnSpatialQuery.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnSpatialQuery.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSpatialQuery_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup4});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "文件";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnOpenMxd);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnAddData);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnSave);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnSaveAs);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "文件操作";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btnShowLog);
            this.ribbonPageGroup4.ItemLinks.Add(this.btnAddLog);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "日志操作";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "属性";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnLayerProperty);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnPropertyDetails);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "图层";
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3});
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "查询";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnQuery);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnSpatialQuery);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "查询";
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 142);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.axTOCControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.axMapControlEagelEye);
            this.splitContainerControl1.Panel2.Controls.Add(this.axLicenseControl1);
            this.splitContainerControl1.Panel2.Controls.Add(this.axMapControl1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(969, 514);
            this.splitContainerControl1.SplitterPosition = 208;
            this.splitContainerControl1.TabIndex = 1;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // axTOCControl1
            // 
            this.axTOCControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.axTOCControl1.ContextMenuStrip = this.contextMenuStrip1;
            this.axTOCControl1.Location = new System.Drawing.Point(3, 0);
            this.axTOCControl1.Name = "axTOCControl1";
            this.axTOCControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axTOCControl1.OcxState")));
            this.axTOCControl1.Size = new System.Drawing.Size(204, 514);
            this.axTOCControl1.TabIndex = 0;
            this.axTOCControl1.OnMouseUp += new ESRI.ArcGIS.Controls.ITOCControlEvents_Ax_OnMouseUpEventHandler(this.axTOCControl1_OnMouseUp);
            this.axTOCControl1.OnMouseDown += new ESRI.ArcGIS.Controls.ITOCControlEvents_Ax_OnMouseDownEventHandler(this.axTOCControl1_OnMouseDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.浏览属性ToolStripMenuItem,
            this.移除图层ToolStripMenuItem,
            this.缩放到图层ToolStripMenuItem,
            this.选择ToolStripMenuItem,
            this.图层属性ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(137, 114);
            // 
            // 浏览属性ToolStripMenuItem
            // 
            this.浏览属性ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("浏览属性ToolStripMenuItem.Image")));
            this.浏览属性ToolStripMenuItem.Name = "浏览属性ToolStripMenuItem";
            this.浏览属性ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.浏览属性ToolStripMenuItem.Text = "浏览属性";
            this.浏览属性ToolStripMenuItem.Click += new System.EventHandler(this.浏览属性ToolStripMenuItem_Click);
            // 
            // 移除图层ToolStripMenuItem
            // 
            this.移除图层ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("移除图层ToolStripMenuItem.Image")));
            this.移除图层ToolStripMenuItem.Name = "移除图层ToolStripMenuItem";
            this.移除图层ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.移除图层ToolStripMenuItem.Text = "移除图层";
            this.移除图层ToolStripMenuItem.Click += new System.EventHandler(this.移除图层ToolStripMenuItem_Click);
            // 
            // 缩放到图层ToolStripMenuItem
            // 
            this.缩放到图层ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("缩放到图层ToolStripMenuItem.Image")));
            this.缩放到图层ToolStripMenuItem.Name = "缩放到图层ToolStripMenuItem";
            this.缩放到图层ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.缩放到图层ToolStripMenuItem.Text = "缩放到图层";
            this.缩放到图层ToolStripMenuItem.Click += new System.EventHandler(this.缩放到图层ToolStripMenuItem_Click);
            // 
            // 选择ToolStripMenuItem
            // 
            this.选择ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("选择ToolStripMenuItem.Image")));
            this.选择ToolStripMenuItem.Name = "选择ToolStripMenuItem";
            this.选择ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.选择ToolStripMenuItem.Text = "选择";
            this.选择ToolStripMenuItem.Click += new System.EventHandler(this.选择ToolStripMenuItem_Click);
            // 
            // 图层属性ToolStripMenuItem
            // 
            this.图层属性ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("图层属性ToolStripMenuItem.Image")));
            this.图层属性ToolStripMenuItem.Name = "图层属性ToolStripMenuItem";
            this.图层属性ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.图层属性ToolStripMenuItem.Text = "图层属性";
            this.图层属性ToolStripMenuItem.Click += new System.EventHandler(this.图层属性ToolStripMenuItem_Click);
            // 
            // axMapControlEagelEye
            // 
            this.axMapControlEagelEye.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.axMapControlEagelEye.Location = new System.Drawing.Point(477, 259);
            this.axMapControlEagelEye.Name = "axMapControlEagelEye";
            this.axMapControlEagelEye.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axMapControlEagelEye.OcxState")));
            this.axMapControlEagelEye.Size = new System.Drawing.Size(275, 252);
            this.axMapControlEagelEye.TabIndex = 2;
            // 
            // axLicenseControl1
            // 
            this.axLicenseControl1.Enabled = true;
            this.axLicenseControl1.Location = new System.Drawing.Point(297, 259);
            this.axLicenseControl1.Name = "axLicenseControl1";
            this.axLicenseControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axLicenseControl1.OcxState")));
            this.axLicenseControl1.Size = new System.Drawing.Size(32, 32);
            this.axLicenseControl1.TabIndex = 1;
            // 
            // axMapControl1
            // 
            this.axMapControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.axMapControl1.Location = new System.Drawing.Point(-1, 3);
            this.axMapControl1.Name = "axMapControl1";
            this.axMapControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axMapControl1.OcxState")));
            this.axMapControl1.Size = new System.Drawing.Size(756, 511);
            this.axMapControl1.TabIndex = 0;
            this.axMapControl1.OnExtentUpdated += new ESRI.ArcGIS.Controls.IMapControlEvents2_Ax_OnExtentUpdatedEventHandler(this.axMapControl1_OnExtentUpdated);
            this.axMapControl1.OnMouseDown += new ESRI.ArcGIS.Controls.IMapControlEvents2_Ax_OnMouseDownEventHandler(this.axMapControl1_OnMouseDown);
            this.axMapControl1.OnMouseUp += new ESRI.ArcGIS.Controls.IMapControlEvents2_Ax_OnMouseUpEventHandler(this.axMapControl1_OnMouseUp);
            // 
            // imageCollection
            // 
            this.imageCollection.ImageSize = new System.Drawing.Size(32, 32);
            this.imageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection.ImageStream")));
            this.imageCollection.Images.SetKeyName(0, "DataAdd32.png");
            this.imageCollection.Images.SetKeyName(1, "FileOpen.png");
            this.imageCollection.Images.SetKeyName(2, "Save32.png");
            this.imageCollection.Images.SetKeyName(3, "SaveAs32.png");
            this.imageCollection.Images.SetKeyName(4, "DataAdd32.png");
            this.imageCollection.Images.SetKeyName(5, "EagleEye.png");
            this.imageCollection.Images.SetKeyName(6, "EagleEye2.png");
            this.imageCollection.Images.SetKeyName(7, "FileNewBlogPost.png");
            this.imageCollection.Images.SetKeyName(8, "FileOpen.png");
            this.imageCollection.Images.SetKeyName(9, "FilePrepareMenu.png");
            this.imageCollection.Images.SetKeyName(10, "FindDialog.png");
            this.imageCollection.Images.SetKeyName(11, "GenericCalculator32.png");
            this.imageCollection.Images.SetKeyName(12, "GenericInformation_B_32.png");
            this.imageCollection.Images.SetKeyName(13, "GenericWarning32.png");
            this.imageCollection.Images.SetKeyName(14, "GenericWarningsFolder32.png");
            this.imageCollection.Images.SetKeyName(15, "GroupMacroTools.png");
            this.imageCollection.Images.SetKeyName(16, "HelpSystem_B_32.png");
            this.imageCollection.Images.SetKeyName(17, "HelpSystemBlue48.png");
            this.imageCollection.Images.SetKeyName(18, "LocationGoTo32.png");
            this.imageCollection.Images.SetKeyName(19, "MailMergeRecepientsUseOutlookContacts.png");
            this.imageCollection.Images.SetKeyName(20, "MeasureTool32.png");
            this.imageCollection.Images.SetKeyName(21, "ModelBuilderVariable32.png");
            this.imageCollection.Images.SetKeyName(22, "Save32.png");
            this.imageCollection.Images.SetKeyName(23, "SaveAs32.png");
            this.imageCollection.Images.SetKeyName(24, "SoundInsertFromFile.png");
            this.imageCollection.Images.SetKeyName(25, "Text_File32.png");
            this.imageCollection.Images.SetKeyName(26, "Tip32.png");
            this.imageCollection.Images.SetKeyName(27, "ZoomFullExtent32.png");
            this.imageCollection.Images.SetKeyName(28, "ZoomInTool_B_32.png");
            this.imageCollection.Images.SetKeyName(29, "ZoomOutTool_B_32.png");
            this.imageCollection.Images.SetKeyName(30, "退出.png");
            // 
            // axToolbarControl1
            // 
            this.axToolbarControl1.Location = new System.Drawing.Point(167, 0);
            this.axToolbarControl1.Name = "axToolbarControl1";
            this.axToolbarControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axToolbarControl1.OcxState")));
            this.axToolbarControl1.Size = new System.Drawing.Size(296, 28);
            this.axToolbarControl1.TabIndex = 3;
            // 
            // frmFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 658);
            this.Controls.Add(this.axToolbarControl1);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.ribbonControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmFrame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ArcEngine Frame";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmFrame_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axTOCControl1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axMapControlEagelEye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axLicenseControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axMapControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axToolbarControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem btnOpenMxd;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraBars.BarButtonItem btnAddData;
        private DevExpress.XtraBars.BarButtonItem btnSave;
        private DevExpress.XtraBars.BarButtonItem btnSaveAs;
        private DevExpress.Utils.ImageCollection imageCollection;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem btnEsc;
        private DevExpress.XtraBars.BarButtonItem btnShowLog;
        private DevExpress.XtraBars.BarButtonItem btnAddLog;
        private DevExpress.XtraBars.BarButtonItem btnEagleEye;
        private ESRI.ArcGIS.Controls.AxLicenseControl axLicenseControl1;
        public ESRI.ArcGIS.Controls.AxMapControl axMapControl1;
        public ESRI.ArcGIS.Controls.AxToolbarControl axToolbarControl1;
        public ESRI.ArcGIS.Controls.AxTOCControl axTOCControl1;
        public ESRI.ArcGIS.Controls.AxMapControl axMapControlEagelEye;
        private DevExpress.XtraBars.BarButtonItem btnPlayMusic;
        private DevExpress.XtraBars.BarButtonItem btnLayerProperty;
        private DevExpress.XtraBars.BarButtonItem btnPropertyDetails;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 移除图层ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 缩放到图层ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 选择ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 浏览属性ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 图层属性ToolStripMenuItem;
        private DevExpress.XtraBars.BarButtonItem btnQuery;
        private DevExpress.XtraBars.BarButtonItem btnSpatialQuery;

    }
}