using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ESRI.ArcGIS.Controls;
using System.Runtime.InteropServices;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Geometry;
using ESRI.ArcGIS.Display;
using ESRI.ArcGIS.Geodatabase;

namespace AEDemo
{
    public partial class frmFrame : DevExpress.XtraEditors.XtraForm
    {
        public frmFrame()
        {
            InitializeComponent();
            axMapControlEagelEye.Visible = false;
            CommFunction.PlayMusic();
        }

        /// <summary>
        /// 播放背景音乐
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPlayMusic_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CommFunction.PlayMusic();
        }

        #region 文件操作
        /// <summary>
        /// 打开Mxd文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOpenMxd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OperateFile.OpenFile(this);
        }

        /// <summary>
        /// 添加Shape格式文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddData_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OperateFile.AddShapeFile(this);
        }

        /// <summary>
        /// 保存地图文档
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OperateFile.SaveDocument(this);
        }

        /// <summary>
        /// 另存为
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveAs_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OperateFile.SaveAsDocument(this);
        }
        #endregion

        #region 鹰眼
        /// <summary>
        /// 打开或关闭鹰眼界面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEagleEye_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (axMapControlEagelEye.Visible == false)
            {
                axMapControlEagelEye.Visible = true;
            }
            else
            {
                axMapControlEagelEye.Visible = false;
            }
        }

        /// <summary>
        /// 地图移动时，鹰眼地图同步移动
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void axMapControl1_OnExtentUpdated(object sender, IMapControlEvents2_OnExtentUpdatedEvent e)
        {
            //// 得到新范围
            IEnvelope pEnv = e.newEnvelope as IEnvelope;
            IGraphicsContainer pGraphicsContainer = axMapControlEagelEye.Map as IGraphicsContainer;
            IActiveView pActiveView = pGraphicsContainer as IActiveView;

            //// 绘制新的矩形框前，清除Map对象中的任何图形元素
            pGraphicsContainer.DeleteAllElements();
            IRectangleElement pRectangleEle = new RectangleElementClass();
            IElement pEle = pRectangleEle as IElement;
            pEle.Geometry = pEnv;

            IRgbColor pColor = new RgbColorClass();
            pColor.RGB = 255;
            pColor.Transparency = 255;

            //// 产生一个线符号
            ILineSymbol pOutLine = new SimpleLineSymbolClass();
            pOutLine.Width = 1;
            pOutLine.Color = pColor;

            //// 设置颜色属性
            pColor = new RgbColorClass();
            pColor.RGB = 255;
            pColor.Transparency = 0;

            //// 设置填充符号的属性
            IFillSymbol pFillSymbol = new SimpleFillSymbolClass();
            pFillSymbol.Color = pColor;
            pFillSymbol.Outline = pOutLine;
            IFillShapeElement pFillShapeEle = pEle as IFillShapeElement;
            pFillShapeEle.Symbol = pFillSymbol;
            pEle = pFillShapeEle as IElement;
            pGraphicsContainer.AddElement(pEle, 0);
            pActiveView.PartialRefresh(esriViewDrawPhase.esriViewGraphics, null, null);

        }
        #endregion

        #region 日志操作
        /// <summary>
        /// 显示日志
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnShowLog_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Parameters.g_iLayerCount > 0)
            {
                frmShowLog frm = new frmShowLog();
                frm.StartPosition = FormStartPosition.CenterParent;
                frm.ShowDialog();
            }
            else
            {
                if (MessageBox.Show("未加载地图文档，是否加载地图文档？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    btnOpenMxd_ItemClick(null, null);
                }
            }
        }

        /// <summary>
        /// 添加日志
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddLog_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
        #endregion

        #region 查看属性
        /// <summary>
        /// 图层属性
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLayerProperty_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Parameters.g_iLayerCount > 0 || this.axMapControl1.LayerCount > 0)
            {
                frmLayerProperty frm = new frmLayerProperty();
                //// ？？？？？并不显示在父窗体的中心，未设置子窗体的父窗体？？
                //// 解答：！！！！ 以ShowDialog()方式显示窗体，才会在父窗体中心显示
                frm.StartPosition = FormStartPosition.CenterParent;
                frm.ShowDialog();
            }
            else
            {
                if (MessageBox.Show("未加载地图文档，是否加载地图文档？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    btnOpenMxd_ItemClick(null, null);
                }
            }
        }

        /// <summary>
        /// 浏览属性的字段详情
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPropertyDetails_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Parameters.g_iLayerCount > 0 || this.axMapControl1.LayerCount > 0)
            {
                frmPropertyDetails frm = new frmPropertyDetails();
                frm.StartPosition = FormStartPosition.CenterParent;
                frm.Owner = this;
                frm.Show();
            }
            else
            {
                if (MessageBox.Show("未加载地图文档，是否加载地图文档？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    btnOpenMxd_ItemClick(null, null);
                }
            }
        }
        #endregion

        #region 属性查询功能
        private void btnQuery_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnSpatialQuery_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
        #endregion

        #region 按下鼠标中键实现拖动
        /// <summary>
        /// 鼠标按下事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void axMapControl1_OnMouseDown(object sender, IMapControlEvents2_OnMouseDownEvent e)
        {
            //// 鼠标中键按下，实现地图拖动
            if (e.button == 4)
            {
                axMapControl1.MousePointer = esriControlsMousePointer.esriPointerHand;
                axMapControl1.Pan();
            }
        }

        //// MapControl中，在使用其它工具后，会使鼠标滚轮缩放失效，可以通过加入MouseDown或MouseUp事件让地图获得焦点，使此功能持续有效。
        //// MapControl1在MouseUp后获得焦点，使滚轮放大缩小总是可用 
        private void axMapControl1_OnMouseUp(object sender, IMapControlEvents2_OnMouseUpEvent e)
        {
            axMapControl1.Focus();
        }
        #endregion

        #region 图层树操作,实现拖动图层
        /// <summary>
        /// 图层树的MouseDown事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void axTOCControl1_OnMouseDown(object sender, ITOCControlEvents_OnMouseDownEvent e)
        {
            if (Parameters.g_pTOCControl != null)
            {
                //// 单击了鼠标左键
                if (e.button == 1)
                {
                    esriTOCControlItem Item = esriTOCControlItem.esriTOCControlItemNone;
                    IBasicMap pBasicMap = null;
                    ILayer pLayer = null;
                    System.Object Other = null;
                    System.Object Index = null;
                    Parameters.g_pTOCControl.HitTest(e.x, e.y, ref Item, ref pBasicMap, ref pLayer, ref Other, ref Index);

                    if (Item == esriTOCControlItem.esriTOCControlItemLayer)
                    {
                        if (pLayer is IAnnotationSublayer)
                        {
                            return;
                        }
                        else
                        {
                            Parameters.g_pMoveLayer = pLayer;
                        }
                    }

                }
                else if (e.button == 2)
                {
                    try
                    {
                        if (Parameters.g_iLayerCount > 0)
                        {
                            esriTOCControlItem Item = esriTOCControlItem.esriTOCControlItemNone;
                            IBasicMap pBasicMap = null;
                            ILayer pLayer = null;
                            System.Object Other = null;
                            System.Object Index = null;
                            //// 获得鼠标点坐标下的图层
                            Parameters.g_pTOCControl.HitTest(e.x, e.y, ref Item, ref pBasicMap, ref pLayer, ref Other, ref Index);
                            //IGeoFeatureLayer pGeoFeatureLayer = (IGeoFeatureLayer)pLayer;
                            Parameters.g_pSelectedLayer = pLayer;

                            //// 弹出右键菜单
                            if (pLayer != null)
                            {
                                contextMenuStrip1.Show(axTOCControl1, e.x, e.y);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        CommFunction.WriteLog("获得鼠标点下的图层失败：", ex.ToString());
                    }


                }
            }
        }

        /// <summary>
        /// 图层树的MouseUp事件,拖动图层
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void axTOCControl1_OnMouseUp(object sender, ITOCControlEvents_OnMouseUpEvent e)
        {
            if (Parameters.g_pTOCControl != null)
            {
                if (e.button == 1)
                {
                    esriTOCControlItem Item = esriTOCControlItem.esriTOCControlItemNone;
                    IBasicMap pBasicMap = null;
                    ILayer pLayer = null;
                    System.Object Other = null;
                    System.Object Index = null;
                    //// 获得鼠标点坐标下的图层
                    Parameters.g_pTOCControl.HitTest(e.x, e.y, ref Item, ref pBasicMap, ref pLayer, ref Other, ref Index);
                    IMap pMap = axMapControl1.ActiveView.FocusMap;

                    if (Item == esriTOCControlItem.esriTOCControlItemLayer || pLayer != null)
                    {
                        if (Parameters.g_pMoveLayer != pLayer)
                        {
                            ILayer pTempLayer;

                            for (int i = 0; i < pMap.LayerCount; i++)
                            {
                                pTempLayer = pMap.get_Layer(i);

                                if (pTempLayer == pLayer)
                                {
                                    Parameters.g_iToIndex = i;
                                }
                            }

                            pMap.MoveLayer(Parameters.g_pMoveLayer, Parameters.g_iToIndex);
                            axMapControl1.ActiveView.Refresh();
                            Parameters.g_pTOCControl.Update();
                        }
                    }
                }
            }
        }
        #endregion

        #region 图层树右键操作
        private void 浏览属性ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 图层属性ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 移除图层ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.axMapControl1.Map.DeleteLayer(Parameters.g_pSelectedLayer);
        }

        private void 缩放到图层ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.axMapControl1.Extent = (IEnvelope)Parameters.g_pSelectedLayer;
        }

        private void 选择ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IFeatureLayer pFeaLayer = Parameters.g_pSelectedLayer as IFeatureLayer;
            IFeatureClass pFeaClass = pFeaLayer.FeatureClass;
            int iFeaCount = pFeaClass.FeatureCount(null);

            for (int i = 0; i < iFeaCount; i++)
            {
                IFeature pFea = pFeaClass.GetFeature(i);
                this.axMapControl1.Map.SelectFeature(pFeaLayer, pFea);
            }
            this.axMapControl1.Refresh();

        } 
        #endregion

        #region 关闭窗体事件
        /// <summary>
        /// 按下Esc退出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        //// ！！！！！！点击Esc退出窗体后，会报错： 尝试读取或写入受保护的内存。这通常指示其他内存已损坏。
        private void frmFrame_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                ShowCloseFormTips();
            }
        }

        /// <summary>
        /// 退出按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEsc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowCloseFormTips();
        }

        /// <summary>
        /// 主界面关闭事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        // ！！！！！！！！！！！有问题啊，点击否 窗体还是会关闭
        //private void frmFrame_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    ShowCloseFormTips();
        //}

        /// <summary>
        /// 关闭主界面给出提示
        /// </summary>
        private void ShowCloseFormTips()
        {
            if (MessageBox.Show("     确定要退出系统？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Dispose();
            }
        }
        #endregion

    }
}