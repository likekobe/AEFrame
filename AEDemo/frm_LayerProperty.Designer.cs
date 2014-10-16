namespace AEDemo
{
    partial class frmLayerProperty
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLayerProperty));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cboLayer = new DevExpress.XtraEditors.ComboBoxEdit();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.tabLayerProperty = new DevExpress.XtraTab.XtraTabControl();
            this.tabPageData = new DevExpress.XtraTab.XtraTabPage();
            this.listData = new DevExpress.XtraEditors.ListBoxControl();
            this.tabPageField = new DevExpress.XtraTab.XtraTabPage();
            this.gcField = new DevExpress.XtraGrid.GridControl();
            this.gvField = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboLayer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabLayerProperty)).BeginInit();
            this.tabLayerProperty.SuspendLayout();
            this.tabPageData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listData)).BeginInit();
            this.tabPageField.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvField)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.White;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.cboLayer);
            this.panelControl1.Controls.Add(this.pictureEdit1);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Location = new System.Drawing.Point(0, 1);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(565, 64);
            this.panelControl1.TabIndex = 0;
            // 
            // cboLayer
            // 
            this.cboLayer.Location = new System.Drawing.Point(239, 33);
            this.cboLayer.Name = "cboLayer";
            this.cboLayer.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboLayer.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboLayer.Size = new System.Drawing.Size(170, 21);
            this.cboLayer.TabIndex = 2;
            this.cboLayer.SelectedIndexChanged += new System.EventHandler(this.cboLayer_SelectedIndexChanged);
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(522, 12);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.AllowFocused = false;
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Size = new System.Drawing.Size(32, 32);
            this.pictureEdit1.TabIndex = 2;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(172, 36);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(60, 14);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "图层名称：";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(46, 36);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(96, 14);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "显示图层属性信息";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(22, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(52, 14);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "图层属性";
            // 
            // panelControl2
            // 
            this.panelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl2.Location = new System.Drawing.Point(1, 67);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(565, 2);
            this.panelControl2.TabIndex = 1;
            // 
            // tabLayerProperty
            // 
            this.tabLayerProperty.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabLayerProperty.Location = new System.Drawing.Point(1, 72);
            this.tabLayerProperty.Name = "tabLayerProperty";
            this.tabLayerProperty.SelectedTabPage = this.tabPageData;
            this.tabLayerProperty.Size = new System.Drawing.Size(564, 297);
            this.tabLayerProperty.TabIndex = 2;
            this.tabLayerProperty.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabPageData,
            this.tabPageField});
            // 
            // tabPageData
            // 
            this.tabPageData.Controls.Add(this.listData);
            this.tabPageData.Name = "tabPageData";
            this.tabPageData.Size = new System.Drawing.Size(557, 267);
            this.tabPageData.Text = "  数据源  ";
            // 
            // listData
            // 
            this.listData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.listData.Location = new System.Drawing.Point(3, 3);
            this.listData.Name = "listData";
            this.listData.Size = new System.Drawing.Size(551, 289);
            this.listData.TabIndex = 0;
            // 
            // tabPageField
            // 
            this.tabPageField.Controls.Add(this.gcField);
            this.tabPageField.Name = "tabPageField";
            this.tabPageField.Size = new System.Drawing.Size(557, 267);
            this.tabPageField.Text = "   字段   ";
            // 
            // gcField
            // 
            this.gcField.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gcField.Location = new System.Drawing.Point(3, 3);
            this.gcField.MainView = this.gvField;
            this.gcField.Name = "gcField";
            this.gcField.Size = new System.Drawing.Size(551, 261);
            this.gcField.TabIndex = 0;
            this.gcField.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvField});
            // 
            // gvField
            // 
            this.gvField.GridControl = this.gcField;
            this.gvField.Name = "gvField";
            this.gvField.OptionsBehavior.Editable = false;
            this.gvField.OptionsView.ColumnAutoWidth = false;
            this.gvField.OptionsView.ShowGroupPanel = false;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Location = new System.Drawing.Point(490, 370);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 21);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "退出(&X)";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmLayerProperty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 394);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.tabLayerProperty);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLayerProperty";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "图层属性";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboLayer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabLayerProperty)).EndInit();
            this.tabLayerProperty.ResumeLayout(false);
            this.tabPageData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listData)).EndInit();
            this.tabPageField.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvField)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraTab.XtraTabPage tabPageData;
        private DevExpress.XtraTab.XtraTabPage tabPageField;
        private DevExpress.XtraEditors.SimpleButton btnExit;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ComboBoxEdit cboLayer;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        public DevExpress.XtraTab.XtraTabControl tabLayerProperty;
        public DevExpress.XtraEditors.ListBoxControl listData;
        public DevExpress.XtraGrid.GridControl gcField;
        public DevExpress.XtraGrid.Views.Grid.GridView gvField;
    }
}