using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Controls;

namespace AEDemo
{
    public partial class frmLayerProperty : DevExpress.XtraEditors.XtraForm
    {
        public frmLayerProperty()
        {
            InitializeComponent();
            CboLoadLayer();
            cboLayer.SelectedIndex = 0;
            CommFunction.ShowLayerProperty(this,Parameters.g_pMapControl.get_Layer(0));
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// ComboBox中加载图层名称
        /// </summary>
        private void CboLoadLayer()
        {

            int iLayerCount = Parameters.g_pMapControl.LayerCount;
            for (int i = 0; i < iLayerCount; i++)
            {
                ILayer pLayer = Parameters.g_pMapControl.get_Layer(i);
                cboLayer.Properties.Items.Add(pLayer.Name);
            }
        }

        /// <summary>
        /// 所选图层变换时触发该事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboLayer_SelectedIndexChanged(object sender, EventArgs e)
        {
            int iLayerIndex = cboLayer.SelectedIndex;
            ILayer pLayer = Parameters.g_pMapControl.get_Layer(iLayerIndex);
            CommFunction.ShowLayerProperty(this, pLayer);
        }

    }
}