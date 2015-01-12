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
    /// <summary>
    /// 显示图层属性信息
    /// </summary>
    public partial class frmLayerProperty : DevExpress.XtraEditors.XtraForm
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public frmLayerProperty()
        {
            InitializeComponent();
            CboLoadLayer();
            cboLayer.SelectedIndex = 0;
            LayerOperation.ShowLayerProperty(this, Parameters.g_pMapControl.get_Layer(0));
        }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="Layer"></param>
        public frmLayerProperty(ILayer Layer)
        {
            InitializeComponent();
            cboLayer.Text = Layer.Name;
            cboLayer.Properties.ReadOnly = true;
            LayerOperation.ShowLayerProperty(this, Layer);
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
            try
            {
                int iLayerCount = Parameters.g_pMapControl.LayerCount;

                for (int i = 0; i < iLayerCount; i++)
                {
                    ILayer pLayer = Parameters.g_pMapControl.get_Layer(i);
                    cboLayer.Properties.Items.Add(pLayer.Name);
                }
            }
            catch(Exception ex)
            {
                LogOperation.WriteLog("显示图层属性信息时，ComboBox中加载图层名称失败", ex.ToString());
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
            LayerOperation.ShowLayerProperty(this, pLayer);
        }

    }
}