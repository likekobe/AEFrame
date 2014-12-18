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
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.tlLayer = new DevExpress.XtraTreeList.TreeList();
            this.LayerName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.LayerIndex = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.gcFieldInfo = new DevExpress.XtraGrid.GridControl();
            this.gvFieldInfo = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tlLayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcFieldInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvFieldInfo)).BeginInit();
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
            this.panelControl1.Size = new System.Drawing.Size(563, 64);
            this.panelControl1.TabIndex = 0;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(521, 12);
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
            // panelControl2
            // 
            this.panelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl2.Location = new System.Drawing.Point(1, 69);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(563, 2);
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
            this.tlLayer.Size = new System.Drawing.Size(157, 319);
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
            this.gcFieldInfo.Size = new System.Drawing.Size(404, 319);
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
            this.gvFieldInfo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gvFieldInfo_MouseDown);
            // 
            // frmPropertyDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 394);
            this.Controls.Add(this.gcFieldInfo);
            this.Controls.Add(this.tlLayer);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
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
    }
}