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
    /// <summary>
    /// 显示图层下要素的详细属性
    /// </summary>
    public partial class frmPropertyDetails : DevExpress.XtraEditors.XtraForm
    {


        /// <summary>
        /// 构造函数
        /// </summary>
        public frmPropertyDetails()
        {
            InitializeComponent();
            TreeListLoadLayer();
            LayerOperation.ShowPropertyDetails(this, Parameters.g_pMapControl.get_Layer(0));
        }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="Layer">图层</param>
        public frmPropertyDetails(ILayer Layer)
        {
            InitializeComponent();
            tlLayer.AppendNode(new object[] { Layer.Name, 0 }, null);
            LayerOperation.ShowPropertyDetails(this, Layer);
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
            catch (Exception ex)
            {
                LogOperation.WriteLog("显示图层下要素的详细属性时，TreeList中加载图层名称失败", ex.ToString());
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
                LayerOperation.ShowPropertyDetails(this, pLayer);
            }
            catch (Exception ex)
            {
                LogOperation.WriteLog("显示图层下要素的详细属性时，TreeList中切换选中节点，显示要素详情失败", ex.ToString());
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
                    LayerOperation.FlashShape(this, (frmFrame)this.Owner);
                }
            }
        }

        /// <summary>
        /// 要素属性信息导出成Excel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExport_Click(object sender, EventArgs e)
        {
            if (!LayerOperation.ExportToExcel(this))
            {
                GtMap.GxDlgHelper.DevMessageBox.ShowInformation("要素信息导出失败。");
            }
        }

        #region 分页功能

        /// <summary>
        /// 上一页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPrevPage_Click(object sender, EventArgs e)
        {
            if (Parameters.g_iCurrentPage > 1)
            {
                Parameters.g_iCurrentPage--;
                PageToSelection();
            }
        }

        /// <summary>
        /// 下一页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNextPage_Click(object sender, EventArgs e)
        {
            if (Parameters.g_iCurrentPage < Parameters.g_iSumPages)
            {
                Parameters.g_iCurrentPage++;
                PageToSelection();
            }
        }

        /// <summary>
        /// 首页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFirstPage_Click(object sender, EventArgs e)
        {
            Parameters.g_iCurrentPage = 1;
            PageToSelection();
        }

        /// <summary>
        /// 末页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLastPage_Click(object sender, EventArgs e)
        {
            Parameters.g_iCurrentPage = Parameters.g_iSumPages;
            PageToSelection();
        }

        /// <summary>
        /// 跳转
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPageTo_Click(object sender, EventArgs e)
        {
            int iPage = 1;
            int.TryParse(txtPage.Text, out iPage);

            if (iPage > 0 && iPage <= Parameters.g_iSumPages)
            {
                Parameters.g_iCurrentPage = iPage;
                PageToSelection();
            }
        }

        /// <summary>
        /// 选中行切换事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gvFieldInfo_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gvFieldInfo.GetFocusedDataRow();
            if (dr != null)
            {
                labelRecords.Text = string.Format("第{0}/{1}条", dr["Index"], Parameters.g_iSumRecords);
            }
        }

        #endregion

        /// <summary>
        /// 跳转到选中页
        /// </summary>
        private void PageToSelection()
        {
            string sWhereExpress = string.Format("Index>{0} AND Index<{1}", (Parameters.g_iCurrentPage - 1) * Parameters.g_iMaxRows, Parameters.g_iCurrentPage * Parameters.g_iMaxRows + 1);
            DataRow[] drArray = LayerOperation.m_dtFeature.Select(sWhereExpress);
            DataTable dtTemp = drArray.CopyToDataTable();
            gcFieldInfo.DataSource = dtTemp;
            //gvRZXX.BestFitColumns();

            string sRecordText = string.Format("第{0}/{1}条", (Parameters.g_iCurrentPage - 1) * Parameters.g_iMaxRows + 1, Parameters.g_iSumRecords);
            labelRecords.Text = sRecordText;
            string sText = string.Format("页数：第{0}/{1}页", Parameters.g_iCurrentPage, Parameters.g_iSumPages);
            labelPages.Text = sText;
        }

        /// <summary>
        /// 限制只准输入数字
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtPage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar > 47 && (int)e.KeyChar < 58) || (int)e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }




    }
}