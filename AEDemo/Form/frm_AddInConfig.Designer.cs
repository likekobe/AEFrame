namespace AEDemo
{
    partial class frmAddInConfig
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.cboLayer = new DevExpress.XtraEditors.ComboBoxEdit();
            this.listBoxUnSelected = new DevExpress.XtraEditors.ListBoxControl();
            this.listBoxSelected = new DevExpress.XtraEditors.ListBoxControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnRead = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.cboLayer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxUnSelected)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxSelected)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 17);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(72, 14);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "请选择图层：";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(188, 17);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(108, 14);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "待选择的配置图层：";
            // 
            // cboLayer
            // 
            this.cboLayer.Location = new System.Drawing.Point(12, 44);
            this.cboLayer.Name = "cboLayer";
            this.cboLayer.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboLayer.Size = new System.Drawing.Size(155, 21);
            this.cboLayer.TabIndex = 2;
            // 
            // listBoxUnSelected
            // 
            this.listBoxUnSelected.Location = new System.Drawing.Point(188, 47);
            this.listBoxUnSelected.Name = "listBoxUnSelected";
            this.listBoxUnSelected.Size = new System.Drawing.Size(174, 190);
            this.listBoxUnSelected.TabIndex = 3;
            this.listBoxUnSelected.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxUnSelected_MouseDoubleClick);
            // 
            // listBoxSelected
            // 
            this.listBoxSelected.Location = new System.Drawing.Point(12, 112);
            this.listBoxSelected.Name = "listBoxSelected";
            this.listBoxSelected.Size = new System.Drawing.Size(155, 125);
            this.listBoxSelected.TabIndex = 4;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(12, 83);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(108, 14);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "已选择的配置图层：";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(287, 247);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "添加(&A)";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(206, 247);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(75, 23);
            this.btnRead.TabIndex = 7;
            this.btnRead.Text = "读取(&R)";
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // frmAddInConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 282);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.listBoxSelected);
            this.Controls.Add(this.listBoxUnSelected);
            this.Controls.Add(this.cboLayer);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Name = "frmAddInConfig";
            this.Text = "frm_AddInConfig";
            ((System.ComponentModel.ISupportInitialize)(this.cboLayer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxUnSelected)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxSelected)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.ComboBoxEdit cboLayer;
        private DevExpress.XtraEditors.ListBoxControl listBoxUnSelected;
        private DevExpress.XtraEditors.ListBoxControl listBoxSelected;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.SimpleButton btnRead;
    }
}