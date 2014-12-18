namespace AEDemo
{
    partial class frmCellBase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCellBase));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.axCell = new AxCELL50Lib.AxCell();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axCell)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.axCell);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(331, 280);
            this.panelControl1.TabIndex = 0;
            // 
            // axCell
            // 
            this.axCell.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axCell.Enabled = true;
            this.axCell.Location = new System.Drawing.Point(2, 2);
            this.axCell.Name = "axCell";
            this.axCell.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axCell.OcxState")));
            this.axCell.Size = new System.Drawing.Size(327, 276);
            this.axCell.TabIndex = 0;
            // 
            // frmCellBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 280);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmCellBase";
            this.Text = "frm_CellBase";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axCell)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private AxCELL50Lib.AxCell axCell;
    }
}