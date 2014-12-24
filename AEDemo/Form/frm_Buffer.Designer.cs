namespace AEDemo
{
    partial class frmBuffer
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
            this.cboSelectLayer = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnCreateBuffer = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtDistance = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSelectLayer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDistance.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // cboSelectLayer
            // 
            this.cboSelectLayer.Location = new System.Drawing.Point(116, 27);
            this.cboSelectLayer.Name = "cboSelectLayer";
            this.cboSelectLayer.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboSelectLayer.Size = new System.Drawing.Size(198, 21);
            this.cboSelectLayer.TabIndex = 0;
            this.cboSelectLayer.SelectedIndexChanged += new System.EventHandler(this.cboSelectLayer_SelectedIndexChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(21, 30);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(60, 14);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "选择图层：";
            // 
            // btnCreateBuffer
            // 
            this.btnCreateBuffer.Location = new System.Drawing.Point(116, 176);
            this.btnCreateBuffer.Name = "btnCreateBuffer";
            this.btnCreateBuffer.Size = new System.Drawing.Size(75, 23);
            this.btnCreateBuffer.TabIndex = 2;
            this.btnCreateBuffer.Text = "创建缓冲区";
            this.btnCreateBuffer.Click += new System.EventHandler(this.btnCreateBuffer_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(21, 75);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(84, 14);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "设置缓冲距离：";
            // 
            // txtDistance
            // 
            this.txtDistance.Location = new System.Drawing.Point(116, 72);
            this.txtDistance.Name = "txtDistance";
            this.txtDistance.Size = new System.Drawing.Size(100, 21);
            this.txtDistance.TabIndex = 4;
            // 
            // frmBuffer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 263);
            this.Controls.Add(this.txtDistance);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.btnCreateBuffer);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.cboSelectLayer);
            this.Name = "frmBuffer";
            this.Text = "缓冲区查询";
            ((System.ComponentModel.ISupportInitialize)(this.cboSelectLayer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDistance.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.ComboBoxEdit cboSelectLayer;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnCreateBuffer;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtDistance;
    }
}