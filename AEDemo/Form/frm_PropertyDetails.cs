using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraTreeList.Nodes;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Geodatabase;

namespace AEDemo
{
    public partial class frmPropertyDetails : DevExpress.XtraEditors.XtraForm
    {

        public frmPropertyDetails()
        {
            InitializeComponent();
            TreeListLoadLayer();
            CommFunction.ShowPropertyDetails(this, Parameters.g_pMapControl.get_Layer(0));
        }

        public frmPropertyDetails(ILayer Layer)
        {
            InitializeComponent();
            tlLayer.AppendNode(new object[] { Layer.Name, 0 }, null);
            CommFunction.ShowPropertyDetails(this, Layer);
        }

        /// <summary>
        /// 在TreeList中加载图层名称
        /// </summary>
        private void TreeListLoadLayer()
        {
            try
            {
                int iLayerCount = Parameters.g_pMapControl.LayerCount;
                for (int i = 0; i < iLayerCount; i++)
                {
                    string sLayerName = Parameters.g_pMapControl.get_Layer(i).Name;
                    tlLayer.AppendNode(new object[] { sLayerName, i }, null);
                }
            }
            catch(Exception ex)
            {
            
            }
        }

        /// <summary>
        /// 所选树节点变化时，触发该事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tlLayer_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {
            try
            {
                TreeListNode node = tlLayer.FocusedNode;
                int iLayerIndex = Convert.ToInt32(node.GetDisplayText(1));
                string sLayerName = node.GetDisplayText(0);
                ILayer pLayer = Parameters.g_pMapControl.get_Layer(iLayerIndex);
                labelLayerName.Text = "图层 【" + sLayerName + "】 属性表";
                CommFunction.ShowPropertyDetails(this, pLayer);
            }
            catch(Exception ex)
            {
            
            }
        }

        /// <summary>
        /// MouseDown事件，双击选中行，放大并闪烁要素
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gvFieldInfo_MouseDown(object sender, MouseEventArgs e)
        {
            //// 判断是否是用鼠标双击    
            if (e.Button == MouseButtons.Left && e.Clicks == 2) 
            {
                DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitInfo gridHitInfo = gvFieldInfo.CalcHitInfo(new Point(e.X, e.Y));

                //// 判断光标是否在行内  
                if (gridHitInfo.InRow)
                {
                    CommFunction.FlashShape(this, (frmFrame)this.Owner);
                }
            }
        }


    }
}