namespace AEDemo
{
    partial class frmSQLQuery
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
            this.memoEditFieldValue = new DevExpress.XtraEditors.MemoEdit();
            this.gcResult = new DevExpress.XtraGrid.GridControl();
            this.gvResult = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnQuery = new DevExpress.XtraEditors.SimpleButton();
            this.cboQuery = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEditFieldValue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboQuery.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // memoEditFieldValue
            // 
            this.memoEditFieldValue.Location = new System.Drawing.Point(1, 81);
            this.memoEditFieldValue.Name = "memoEditFieldValue";
            this.memoEditFieldValue.Size = new System.Drawing.Size(182, 45);
            this.memoEditFieldValue.TabIndex = 0;
            // 
            // gcResult
            // 
            this.gcResult.Location = new System.Drawing.Point(1, 161);
            this.gcResult.MainView = this.gvResult;
            this.gcResult.Name = "gcResult";
            this.gcResult.Size = new System.Drawing.Size(453, 239);
            this.gcResult.TabIndex = 1;
            this.gcResult.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvResult});
            // 
            // gvResult
            // 
            this.gvResult.GridControl = this.gcResult;
            this.gvResult.Name = "gvResult";
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(12, 132);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 23);
            this.btnQuery.TabIndex = 2;
            this.btnQuery.Text = "查询(&Q)";
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // cboQuery
            // 
            this.cboQuery.Location = new System.Drawing.Point(263, 12);
            this.cboQuery.Name = "cboQuery";
            this.cboQuery.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboQuery.Size = new System.Drawing.Size(191, 21);
            this.cboQuery.TabIndex = 3;
            this.cboQuery.EditValueChanged += new System.EventHandler(this.cboQuery_EditValueChanged);
            this.cboQuery.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cboQuery_KeyUp);
            // 
            // frmSQLQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 415);
            this.Controls.Add(this.cboQuery);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.gcResult);
            this.Controls.Add(this.memoEditFieldValue);
            this.Name = "frmSQLQuery";
            this.Text = "SQL查询";
            ((System.ComponentModel.ISupportInitialize)(this.memoEditFieldValue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboQuery.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.MemoEdit memoEditFieldValue;
        private DevExpress.XtraGrid.GridControl gcResult;
        private DevExpress.XtraGrid.Views.Grid.GridView gvResult;
        private DevExpress.XtraEditors.SimpleButton btnQuery;
        private DevExpress.XtraEditors.ComboBoxEdit cboQuery;
    }
}