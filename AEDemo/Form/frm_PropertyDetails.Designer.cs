namespace AEDemo
{
    partial class frmPropertyDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPropertyDetails));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.labelLayerName = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnExport = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.tlLayer = new DevExpress.XtraTreeList.TreeList();
            this.LayerName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.LayerIndex = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.gcFieldInfo = new DevExpress.XtraGrid.GridControl();
            this.gvFieldInfo = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.txtPage = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelPages = new DevExpress.XtraEditors.LabelControl();
            this.labelRecords = new DevExpress.XtraEditors.LabelControl();
            this.btnPageTo = new DevExpress.XtraEditors.SimpleButton();
            this.btnLastPage = new DevExpress.XtraEditors.SimpleButton();
            this.btnNextPage = new DevExpress.XtraEditors.SimpleButton();
            this.btnPrevPage = new DevExpress.XtraEditors.SimpleButton();
            this.btnFirstPage = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tlLayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcFieldInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvFieldInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPage.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.White;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.pictureEdit1);
            this.panelControl1.Controls.Add(this.labelLayerName);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Location = new System.Drawing.Point(1, 2);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(700, 64);
            this.panelControl1.TabIndex = 0;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(658, 12);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.AllowFocused = false;
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Size = new System.Drawing.Size(32, 32);
            this.pictureEdit1.TabIndex = 2;
            // 
            // labelLayerName
            // 
            this.labelLayerName.Location = new System.Drawing.Point(46, 36);
            this.labelLayerName.Name = "labelLayerName";
            this.labelLayerName.Size = new System.Drawing.Size(70, 14);
            this.labelLayerName.TabIndex = 1;
            this.labelLayerName.Text = "labelControl2";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(22, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(52, 14);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "浏览属性";
            // 
            // btnExport
            // 
            this.btnExport.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btnExport.Appearance.Options.UseBackColor = true;
            this.btnExport.Location = new System.Drawing.Point(448, 1);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 23);
            this.btnExport.TabIndex = 3;
            this.btnExport.Text = "导出(&E)";
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // panelControl2
            // 
            this.panelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl2.Location = new System.Drawing.Point(1, 69);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(700, 2);
            this.panelControl2.TabIndex = 1;
            // 
            // tlLayer
            // 
            this.tlLayer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.tlLayer.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.LayerName,
            this.LayerIndex});
            this.tlLayer.Location = new System.Drawing.Point(1, 72);
            this.tlLayer.Name = "tlLayer";
            this.tlLayer.Size = new System.Drawing.Size(157, 369);
            this.tlLayer.TabIndex = 2;
            this.tlLayer.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(this.tlLayer_FocusedNodeChanged);
            // 
            // LayerName
            // 
            this.LayerName.Caption = "图层名称";
            this.LayerName.FieldName = "图层名称";
            this.LayerName.Name = "LayerName";
            this.LayerName.OptionsColumn.AllowEdit = false;
            this.LayerName.Visible = true;
            this.LayerName.VisibleIndex = 0;
            // 
            // LayerIndex
            // 
            this.LayerIndex.Caption = "图层索引：";
            this.LayerIndex.FieldName = "图层索引：";
            this.LayerIndex.Name = "LayerIndex";
            // 
            // gcFieldInfo
            // 
            this.gcFieldInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gcFieldInfo.Location = new System.Drawing.Point(160, 72);
            this.gcFieldInfo.MainView = this.gvFieldInfo;
            this.gcFieldInfo.Name = "gcFieldInfo";
            this.gcFieldInfo.Size = new System.Drawing.Size(541, 343);
            this.gcFieldInfo.TabIndex = 3;
            this.gcFieldInfo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvFieldInfo});
            // 
            // gvFieldInfo
            // 
            this.gvFieldInfo.GridControl = this.gcFieldInfo;
            this.gvFieldInfo.Name = "gvFieldInfo";
            this.gvFieldInfo.OptionsBehavior.Editable = false;
            this.gvFieldInfo.OptionsView.ColumnAutoWidth = false;
            this.gvFieldInfo.OptionsView.EnableAppearanceEvenRow = true;
            this.gvFieldInfo.OptionsView.ShowGroupPanel = false;
            this.gvFieldInfo.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvFieldInfo_FocusedRowChanged);
            this.gvFieldInfo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gvFieldInfo_MouseDown);
            // 
            // panelControl3
            // 
            this.panelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl3.Controls.Add(this.txtPage);
            this.panelControl3.Controls.Add(this.labelControl5);
            this.panelControl3.Controls.Add(this.labelControl4);
            this.panelControl3.Controls.Add(this.labelPages);
            this.panelControl3.Controls.Add(this.labelRecords);
            this.panelControl3.Controls.Add(this.btnPageTo);
            this.panelControl3.Controls.Add(this.btnExport);
            this.panelControl3.Controls.Add(this.btnLastPage);
            this.panelControl3.Controls.Add(this.btnNextPage);
            this.panelControl3.Controls.Add(this.btnPrevPage);
            this.panelControl3.Controls.Add(this.btnFirstPage);
            this.panelControl3.Location = new System.Drawing.Point(160, 416);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(541, 25);
            this.panelControl3.TabIndex = 4;
            // 
            // txtPage
            // 
            this.txtPage.Location = new System.Drawing.Point(218, 1);
            this.txtPage.Name = "txtPage";
            this.txtPage.Size = new System.Drawing.Size(28, 21);
            this.txtPage.TabIndex = 9;
            this.txtPage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPage_KeyPress);
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(250, 4);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(24, 14);
            this.labelControl5.TabIndex = 8;
            this.labelControl5.Text = "页：";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(203, 4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(12, 14);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "第";
            // 
            // labelPages
            // 
            this.labelPages.Location = new System.Drawing.Point(310, 5);
            this.labelPages.Name = "labelPages";
            this.labelPages.Size = new System.Drawing.Size(79, 14);
            this.labelPages.TabIndex = 6;
            this.labelPages.Text = "页数：第0/0页";
            // 
            // labelRecords
            // 
            this.labelRecords.Location = new System.Drawing.Point(54, 4);
            this.labelRecords.Name = "labelRecords";
            this.labelRecords.Size = new System.Drawing.Size(43, 14);
            this.labelRecords.TabIndex = 5;
            this.labelRecords.Text = "第0/0条";
            // 
            // btnPageTo
            // 
            this.btnPageTo.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnPageTo.Image = ((System.Drawing.Image)(resources.GetObject("btnPageTo.Image")));
            this.btnPageTo.Location = new System.Drawing.Point(272, 1);
            this.btnPageTo.Name = "btnPageTo";
            this.btnPageTo.Size = new System.Drawing.Size(20, 23);
            this.btnPageTo.TabIndex = 4;
            this.btnPageTo.ToolTip = "跳转";
            this.btnPageTo.Click += new System.EventHandler(this.btnPageTo_Click);
            // 
            // btnLastPage
            // 
            this.btnLastPage.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnLastPage.Image = ((System.Drawing.Image)(resources.GetObject("btnLastPage.Image")));
            this.btnLastPage.Location = new System.Drawing.Point(150, 1);
            this.btnLastPage.Name = "btnLastPage";
            this.btnLastPage.Size = new System.Drawing.Size(20, 23);
            this.btnLastPage.TabIndex = 3;
            this.btnLastPage.ToolTip = "末页";
            this.btnLastPage.Click += new System.EventHandler(this.btnLastPage_Click);
            // 
            // btnNextPage
            // 
            this.btnNextPage.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnNextPage.Image = ((System.Drawing.Image)(resources.GetObject("btnNextPage.Image")));
            this.btnNextPage.Location = new System.Drawing.Point(130, 1);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(20, 23);
            this.btnNextPage.TabIndex = 2;
            this.btnNextPage.ToolTip = "下一页";
            this.btnNextPage.Click += new System.EventHandler(this.btnNextPage_Click);
            // 
            // btnPrevPage
            // 
            this.btnPrevPage.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnPrevPage.Image = ((System.Drawing.Image)(resources.GetObject("btnPrevPage.Image")));
            this.btnPrevPage.Location = new System.Drawing.Point(25, 1);
            this.btnPrevPage.Name = "btnPrevPage";
            this.btnPrevPage.Size = new System.Drawing.Size(20, 23);
            this.btnPrevPage.TabIndex = 1;
            this.btnPrevPage.ToolTip = "上一页";
            this.btnPrevPage.Click += new System.EventHandler(this.btnPrevPage_Click);
            // 
            // btnFirstPage
            // 
            this.btnFirstPage.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnFirstPage.Image = ((System.Drawing.Image)(resources.GetObject("btnFirstPage.Image")));
            this.btnFirstPage.Location = new System.Drawing.Point(5, 1);
            this.btnFirstPage.Name = "btnFirstPage";
            this.btnFirstPage.Size = new System.Drawing.Size(20, 23);
            this.btnFirstPage.TabIndex = 0;
            this.btnFirstPage.ToolTip = "首页";
            this.btnFirstPage.Click += new System.EventHandler(this.btnFirstPage_Click);
            // 
            // frmPropertyDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 444);
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.gcFieldInfo);
            this.Controls.Add(this.tlLayer);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPropertyDetails";
            this.Text = "浏览属性";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tlLayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcFieldInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvFieldInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.panelControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPage.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.LabelControl labelLayerName;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        public DevExpress.XtraGrid.GridControl gcFieldInfo;
        private DevExpress.XtraTreeList.Columns.TreeListColumn LayerName;
        public DevExpress.XtraTreeList.TreeList tlLayer;
        public DevExpress.XtraGrid.Views.Grid.GridView gvFieldInfo;
        private DevExpress.XtraTreeList.Columns.TreeListColumn LayerIndex;
        private DevExpress.XtraEditors.SimpleButton btnExport;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.SimpleButton btnLastPage;
        private DevExpress.XtraEditors.SimpleButton btnNextPage;
        private DevExpress.XtraEditors.SimpleButton btnPrevPage;
        private DevExpress.XtraEditors.SimpleButton btnFirstPage;
        private DevExpress.XtraEditors.SimpleButton btnPageTo;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        public DevExpress.XtraEditors.LabelControl labelPages;
        public DevExpress.XtraEditors.LabelControl labelRecords;
        public DevExpress.XtraEditors.TextEdit txtPage;
    }
}