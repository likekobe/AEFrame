namespace AEDemo
{
    partial class frmPropertyQuery
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cboLayer = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.listFields = new DevExpress.XtraEditors.ListBoxControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.listFieldValue = new DevExpress.XtraEditors.ListBoxControl();
            this.btnGetFieldValue = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnStar = new DevExpress.XtraEditors.SimpleButton();
            this.btnQuestion = new DevExpress.XtraEditors.SimpleButton();
            this.btnNot = new DevExpress.XtraEditors.SimpleButton();
            this.btnBrackets = new DevExpress.XtraEditors.SimpleButton();
            this.btnIs = new DevExpress.XtraEditors.SimpleButton();
            this.btnOr = new DevExpress.XtraEditors.SimpleButton();
            this.btnLessthanOrEqual = new DevExpress.XtraEditors.SimpleButton();
            this.btnLessthan = new DevExpress.XtraEditors.SimpleButton();
            this.btnAnd = new DevExpress.XtraEditors.SimpleButton();
            this.btnMorethanOrEqual = new DevExpress.XtraEditors.SimpleButton();
            this.btnMorethan = new DevExpress.XtraEditors.SimpleButton();
            this.btnLike = new DevExpress.XtraEditors.SimpleButton();
            this.btnNotEqual = new DevExpress.XtraEditors.SimpleButton();
            this.btnEqual = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.btnQuery = new DevExpress.XtraEditors.SimpleButton();
            this.labelLayerName = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.gcQuery = new DevExpress.XtraGrid.GridControl();
            this.gvQuery = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.memoEditWhereExpress = new DevExpress.XtraEditors.MemoEdit();
            this.btnClear = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboLayer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listFields)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listFieldValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcQuery)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvQuery)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEditWhereExpress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
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
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Location = new System.Drawing.Point(1, 1);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(497, 64);
            this.panelControl1.TabIndex = 0;
            // 
            // cboLayer
            // 
            this.cboLayer.Location = new System.Drawing.Point(292, 33);
            this.cboLayer.Name = "cboLayer";
            this.cboLayer.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboLayer.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboLayer.Size = new System.Drawing.Size(170, 21);
            this.cboLayer.TabIndex = 5;
            this.cboLayer.SelectedIndexChanged += new System.EventHandler(this.cboLayer_SelectedIndexChanged);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(223, 36);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(60, 14);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "图层名称：";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(46, 36);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(144, 14);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "设置查询条件得到所需要素";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(22, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(52, 14);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "属性查询";
            // 
            // listFields
            // 
            this.listFields.Location = new System.Drawing.Point(5, 34);
            this.listFields.Name = "listFields";
            this.listFields.Size = new System.Drawing.Size(146, 239);
            this.listFields.TabIndex = 1;
            this.listFields.SelectedValueChanged += new System.EventHandler(this.listFields_SelectedValueChanged);
            this.listFields.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listFields_MouseDoubleClick);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(27, 11);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(60, 14);
            this.labelControl4.TabIndex = 2;
            this.labelControl4.Text = "图层字段：";
            // 
            // listFieldValue
            // 
            this.listFieldValue.Location = new System.Drawing.Point(155, 34);
            this.listFieldValue.Name = "listFieldValue";
            this.listFieldValue.Size = new System.Drawing.Size(142, 113);
            this.listFieldValue.TabIndex = 4;
            this.listFieldValue.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listFieldValue_MouseDoubleClick);
            // 
            // btnGetFieldValue
            // 
            this.btnGetFieldValue.Location = new System.Drawing.Point(221, 7);
            this.btnGetFieldValue.Name = "btnGetFieldValue";
            this.btnGetFieldValue.Size = new System.Drawing.Size(75, 23);
            this.btnGetFieldValue.TabIndex = 5;
            this.btnGetFieldValue.Text = "获取字段值";
            this.btnGetFieldValue.Click += new System.EventHandler(this.btnGetFieldValue_Click);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btnStar);
            this.panelControl2.Controls.Add(this.btnQuestion);
            this.panelControl2.Controls.Add(this.btnNot);
            this.panelControl2.Controls.Add(this.btnBrackets);
            this.panelControl2.Controls.Add(this.btnIs);
            this.panelControl2.Controls.Add(this.btnOr);
            this.panelControl2.Controls.Add(this.btnLessthanOrEqual);
            this.panelControl2.Controls.Add(this.btnLessthan);
            this.panelControl2.Controls.Add(this.btnAnd);
            this.panelControl2.Controls.Add(this.btnMorethanOrEqual);
            this.panelControl2.Controls.Add(this.btnMorethan);
            this.panelControl2.Controls.Add(this.btnLike);
            this.panelControl2.Controls.Add(this.btnNotEqual);
            this.panelControl2.Controls.Add(this.btnEqual);
            this.panelControl2.Location = new System.Drawing.Point(303, 34);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(188, 113);
            this.panelControl2.TabIndex = 6;
            // 
            // btnStar
            // 
            this.btnStar.Location = new System.Drawing.Point(151, 41);
            this.btnStar.Name = "btnStar";
            this.btnStar.Size = new System.Drawing.Size(30, 30);
            this.btnStar.TabIndex = 13;
            this.btnStar.Text = "*";
            this.btnStar.Click += new System.EventHandler(this.btnStar_Click);
            // 
            // btnQuestion
            // 
            this.btnQuestion.Location = new System.Drawing.Point(151, 5);
            this.btnQuestion.Name = "btnQuestion";
            this.btnQuestion.Size = new System.Drawing.Size(30, 30);
            this.btnQuestion.TabIndex = 12;
            this.btnQuestion.Text = "?";
            this.btnQuestion.Click += new System.EventHandler(this.btnQuestion_Click);
            // 
            // btnNot
            // 
            this.btnNot.Location = new System.Drawing.Point(115, 77);
            this.btnNot.Name = "btnNot";
            this.btnNot.Size = new System.Drawing.Size(30, 30);
            this.btnNot.TabIndex = 11;
            this.btnNot.Text = "Not";
            this.btnNot.Click += new System.EventHandler(this.btnNot_Click);
            // 
            // btnBrackets
            // 
            this.btnBrackets.Location = new System.Drawing.Point(115, 41);
            this.btnBrackets.Name = "btnBrackets";
            this.btnBrackets.Size = new System.Drawing.Size(30, 30);
            this.btnBrackets.TabIndex = 10;
            this.btnBrackets.Text = "()";
            this.btnBrackets.Click += new System.EventHandler(this.btnBrackets_Click);
            // 
            // btnIs
            // 
            this.btnIs.Location = new System.Drawing.Point(115, 5);
            this.btnIs.Name = "btnIs";
            this.btnIs.Size = new System.Drawing.Size(30, 30);
            this.btnIs.TabIndex = 9;
            this.btnIs.Text = "Is";
            this.btnIs.Click += new System.EventHandler(this.btnIs_Click);
            // 
            // btnOr
            // 
            this.btnOr.Location = new System.Drawing.Point(79, 77);
            this.btnOr.Name = "btnOr";
            this.btnOr.Size = new System.Drawing.Size(30, 30);
            this.btnOr.TabIndex = 8;
            this.btnOr.Text = "Or";
            this.btnOr.Click += new System.EventHandler(this.btnOr_Click);
            // 
            // btnLessthanOrEqual
            // 
            this.btnLessthanOrEqual.Location = new System.Drawing.Point(43, 77);
            this.btnLessthanOrEqual.Name = "btnLessthanOrEqual";
            this.btnLessthanOrEqual.Size = new System.Drawing.Size(30, 30);
            this.btnLessthanOrEqual.TabIndex = 7;
            this.btnLessthanOrEqual.Text = "<=";
            this.btnLessthanOrEqual.Click += new System.EventHandler(this.btnLessthanOrEqual_Click);
            // 
            // btnLessthan
            // 
            this.btnLessthan.Location = new System.Drawing.Point(7, 77);
            this.btnLessthan.Name = "btnLessthan";
            this.btnLessthan.Size = new System.Drawing.Size(30, 30);
            this.btnLessthan.TabIndex = 6;
            this.btnLessthan.Text = "<";
            this.btnLessthan.Click += new System.EventHandler(this.btnLessthan_Click);
            // 
            // btnAnd
            // 
            this.btnAnd.Location = new System.Drawing.Point(79, 41);
            this.btnAnd.Name = "btnAnd";
            this.btnAnd.Size = new System.Drawing.Size(30, 30);
            this.btnAnd.TabIndex = 5;
            this.btnAnd.Text = "And";
            this.btnAnd.Click += new System.EventHandler(this.btnAnd_Click);
            // 
            // btnMorethanOrEqual
            // 
            this.btnMorethanOrEqual.Location = new System.Drawing.Point(43, 41);
            this.btnMorethanOrEqual.Name = "btnMorethanOrEqual";
            this.btnMorethanOrEqual.Size = new System.Drawing.Size(30, 30);
            this.btnMorethanOrEqual.TabIndex = 4;
            this.btnMorethanOrEqual.Text = ">=";
            this.btnMorethanOrEqual.Click += new System.EventHandler(this.btnMorethanOrEqual_Click);
            // 
            // btnMorethan
            // 
            this.btnMorethan.Location = new System.Drawing.Point(7, 41);
            this.btnMorethan.Name = "btnMorethan";
            this.btnMorethan.Size = new System.Drawing.Size(30, 30);
            this.btnMorethan.TabIndex = 3;
            this.btnMorethan.Text = ">";
            this.btnMorethan.Click += new System.EventHandler(this.btnMorethan_Click);
            // 
            // btnLike
            // 
            this.btnLike.Location = new System.Drawing.Point(79, 5);
            this.btnLike.Name = "btnLike";
            this.btnLike.Size = new System.Drawing.Size(30, 30);
            this.btnLike.TabIndex = 2;
            this.btnLike.Text = "Like";
            this.btnLike.Click += new System.EventHandler(this.btnLike_Click);
            // 
            // btnNotEqual
            // 
            this.btnNotEqual.Location = new System.Drawing.Point(43, 5);
            this.btnNotEqual.Name = "btnNotEqual";
            this.btnNotEqual.Size = new System.Drawing.Size(30, 30);
            this.btnNotEqual.TabIndex = 1;
            this.btnNotEqual.Text = "<>";
            this.btnNotEqual.Click += new System.EventHandler(this.btnNotEqual_Click);
            // 
            // btnEqual
            // 
            this.btnEqual.Location = new System.Drawing.Point(7, 5);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(30, 30);
            this.btnEqual.TabIndex = 0;
            this.btnEqual.Text = "=";
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(157, 152);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(76, 14);
            this.labelControl5.TabIndex = 8;
            this.labelControl5.Text = "Select * From";
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(416, 171);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 23);
            this.btnQuery.TabIndex = 9;
            this.btnQuery.Text = "查询(&Q)";
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // labelLayerName
            // 
            this.labelLayerName.Location = new System.Drawing.Point(157, 167);
            this.labelLayerName.Name = "labelLayerName";
            this.labelLayerName.Size = new System.Drawing.Size(48, 14);
            this.labelLayerName.TabIndex = 10;
            this.labelLayerName.Text = "图层名称";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(157, 183);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(37, 14);
            this.labelControl6.TabIndex = 11;
            this.labelControl6.Text = "Where";
            // 
            // gcQuery
            // 
            this.gcQuery.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gcQuery.Location = new System.Drawing.Point(1, 352);
            this.gcQuery.MainView = this.gvQuery;
            this.gcQuery.Name = "gcQuery";
            this.gcQuery.Size = new System.Drawing.Size(497, 160);
            this.gcQuery.TabIndex = 12;
            this.gcQuery.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvQuery});
            // 
            // gvQuery
            // 
            this.gvQuery.GridControl = this.gcQuery;
            this.gvQuery.Name = "gvQuery";
            this.gvQuery.OptionsView.ColumnAutoWidth = false;
            this.gvQuery.OptionsView.EnableAppearanceEvenRow = true;
            this.gvQuery.OptionsView.ShowGroupPanel = false;
            // 
            // memoEditWhereExpress
            // 
            this.memoEditWhereExpress.Location = new System.Drawing.Point(155, 203);
            this.memoEditWhereExpress.Name = "memoEditWhereExpress";
            this.memoEditWhereExpress.Size = new System.Drawing.Size(336, 70);
            this.memoEditWhereExpress.TabIndex = 13;
            this.memoEditWhereExpress.MouseClick += new System.Windows.Forms.MouseEventHandler(this.memoEditWhereExpress_MouseClick);
            this.memoEditWhereExpress.Leave += new System.EventHandler(this.memoEditWhereExpress_Leave);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(337, 171);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "清空(&C)";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // panelControl3
            // 
            this.panelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl3.Controls.Add(this.listFields);
            this.panelControl3.Controls.Add(this.btnClear);
            this.panelControl3.Controls.Add(this.labelControl4);
            this.panelControl3.Controls.Add(this.memoEditWhereExpress);
            this.panelControl3.Controls.Add(this.listFieldValue);
            this.panelControl3.Controls.Add(this.btnGetFieldValue);
            this.panelControl3.Controls.Add(this.labelControl6);
            this.panelControl3.Controls.Add(this.panelControl2);
            this.panelControl3.Controls.Add(this.labelLayerName);
            this.panelControl3.Controls.Add(this.labelControl5);
            this.panelControl3.Controls.Add(this.btnQuery);
            this.panelControl3.Location = new System.Drawing.Point(1, 68);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(498, 279);
            this.panelControl3.TabIndex = 15;
            // 
            // frmPropertyQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 515);
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.gcQuery);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmPropertyQuery";
            this.Text = "属性查询";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboLayer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listFields)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listFieldValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcQuery)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvQuery)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEditWhereExpress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.panelControl3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.ComboBoxEdit cboLayer;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.ListBoxControl listFields;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.ListBoxControl listFieldValue;
        private DevExpress.XtraEditors.SimpleButton btnGetFieldValue;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton btnEqual;
        private DevExpress.XtraEditors.SimpleButton btnLike;
        private DevExpress.XtraEditors.SimpleButton btnNotEqual;
        private DevExpress.XtraEditors.SimpleButton btnNot;
        private DevExpress.XtraEditors.SimpleButton btnBrackets;
        private DevExpress.XtraEditors.SimpleButton btnIs;
        private DevExpress.XtraEditors.SimpleButton btnOr;
        private DevExpress.XtraEditors.SimpleButton btnLessthanOrEqual;
        private DevExpress.XtraEditors.SimpleButton btnLessthan;
        private DevExpress.XtraEditors.SimpleButton btnAnd;
        private DevExpress.XtraEditors.SimpleButton btnMorethanOrEqual;
        private DevExpress.XtraEditors.SimpleButton btnMorethan;
        private DevExpress.XtraEditors.SimpleButton btnStar;
        private DevExpress.XtraEditors.SimpleButton btnQuestion;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.SimpleButton btnQuery;
        private DevExpress.XtraEditors.LabelControl labelLayerName;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraGrid.GridControl gcQuery;
        private DevExpress.XtraGrid.Views.Grid.GridView gvQuery;
        private DevExpress.XtraEditors.MemoEdit memoEditWhereExpress;
        private DevExpress.XtraEditors.SimpleButton btnClear;
        private DevExpress.XtraEditors.PanelControl panelControl3;
    }
}