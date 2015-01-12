using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Geometry;
using ESRI.ArcGIS.Geodatabase;
using ESRI.ArcGIS.Display;
using DevExpress.XtraTreeList.Nodes;

namespace AEDemo
{
    /// <summary>
    /// 缓冲区查询
    /// </summary>
    public partial class frmBufferQuery : Form
    {
        public frmBufferQuery()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBufferDistance.Text))
            {
                MessageBox.Show("请输入缓冲距离。");
            }
            else
            {
                QueryBuffer();
                tlBufferResult.ExpandAll();
            }
        }

        /// <summary>
        /// 缓冲区查询
        /// </summary>
        private void QueryBuffer()
        {
            ITopologicalOperator pTopo = null;
            IElement pElement = null;
            IGeometry pBuffer = null;
            IGeometry pGeo = null;
            ISelection pSelection = null;
            IEnumFeatureSetup pEnumFeatureSetup = null;
            IEnumFeature pEnumFeature = null;
            IFillSymbol pFillSymbol = null;
            IRgbColor pRgbColor = null;

            IFeature pFea = null;
            IFeature pFeature = null;
            IFeatureLayer pFeaLayer = null;
            IFeatureClass pFeaClass = null;
            IFeatureCursor pFeaCursor = null;

            ISpatialFilter pSpatialfilter = null;
            double dDistance = 0;
            double.TryParse(txtBufferDistance.Text, out dDistance);

            try
            {
                if (Parameters.g_pMapControl.Map != null)
                {
                    (Parameters.g_pMapControl.Map as IGraphicsContainer).DeleteAllElements();
                }

                //// 获得选中要素
                pSelection = Parameters.g_pMapControl.Map.FeatureSelection;
                pEnumFeatureSetup = pSelection as IEnumFeatureSetup;
                pEnumFeatureSetup.AllFields = true;

                pEnumFeature = pEnumFeatureSetup as IEnumFeature;
                pEnumFeature.Reset();
                pFea = pEnumFeature.Next();

                //// 遍历选中要素
                while (pFea != null)
                {
                    pGeo = pFea.ShapeCopy;
                    pTopo = pGeo as ITopologicalOperator;
                    pBuffer = pTopo.Buffer(dDistance);

                    pElement = new PolygonElementClass();
                    pElement.Geometry = pBuffer;

                    //// 设置缓冲区颜色
                    pFillSymbol = new SimpleFillSymbolClass();
                    pRgbColor = new RgbColorClass();
                    pRgbColor.Red = 255;
                    pRgbColor.Green = 255;
                    pRgbColor.Blue = 153;
                    pRgbColor.Transparency = 1;
                    pFillSymbol.Color = pRgbColor;
                    (pElement as IFillShapeElement).Symbol = pFillSymbol;
                    (Parameters.g_pMapControl.Map as IGraphicsContainer).AddElement(pElement, 0);

                    //// 设置空间过滤器
                    pSpatialfilter = new SpatialFilterClass();
                    pSpatialfilter.Geometry = pBuffer;

                    //// 遍历图层
                    for (int i = 0; i < Parameters.g_iLayerCount; i++)
                    {
                        pFeaLayer = Parameters.g_pMapControl.Map.get_Layer(i) as IFeatureLayer;
                        pFeaClass = pFeaLayer.FeatureClass;

                        switch (pFeaClass.ShapeType)
                        {
                            case esriGeometryType.esriGeometryPoint:
                                {
                                    pSpatialfilter.SpatialRel = esriSpatialRelEnum.esriSpatialRelContains;
                                    break;
                                }
                            case esriGeometryType.esriGeometryPolyline:
                                {
                                    pSpatialfilter.SpatialRel = esriSpatialRelEnum.esriSpatialRelContains;
                                    break;
                                }
                            case esriGeometryType.esriGeometryPolygon:
                                {
                                    pSpatialfilter.SpatialRel = esriSpatialRelEnum.esriSpatialRelContains;
                                    break;
                                }
                        }

                        pSpatialfilter.GeometryField = pFeaClass.ShapeFieldName;
                        pFeaCursor = pFeaClass.Search(pSpatialfilter, false);
                        pFeature = pFeaCursor.NextFeature();

                        TreeListNode tlNode = null;

                        //// 查询到的要素添加到TreeList
                        while (pFeature != null)
                        {
                            //// 添加图层节点到TreeList
                            bool bIsContainLayer = false;
                            foreach (TreeListNode node in tlBufferResult.Nodes)
                            {
                                tlNode = node;
                                bIsContainLayer = true;
                                break;
                            }
                            if (!bIsContainLayer)
                            {
                                tlNode = tlBufferResult.AppendNode(new object[] { pFeaLayer.Name }, null);
                            }

                            //// 添加要素到图层节点下
                            bool bIsAdd = false;
                            foreach (TreeListNode childnode in tlNode.Nodes)
                            {
                                if (childnode.GetDisplayText(0).Equals(pFeature.OID.ToString()))
                                {
                                    bIsAdd = true;
                                    break;
                                }
                            }
                            if (!bIsAdd)
                            {
                                tlBufferResult.AppendNode(new object[] { pFeature.OID }, tlNode);
                            }

                            pFeature = pFeaCursor.NextFeature();
                        }
                    }


                    pFea = pEnumFeature.Next();
                }

                IActiveView pActiveView = Parameters.g_pMapControl.Map as IActiveView;
                pActiveView.Refresh();
            }
            catch (Exception ex)
            {
                LogOperation.WriteLog("缓冲区查询失败", ex.ToString());
            }
        }

        private void frmBufferQuery_FormClosing(object sender, FormClosingEventArgs e)
        {
            //// 清空缓冲区图形
            if (Parameters.g_pMapControl.Map != null)
            {
                (Parameters.g_pMapControl.Map as IGraphicsContainer).DeleteAllElements();
                IActiveView pActiveView = Parameters.g_pMapControl.Map as IActiveView;
                pActiveView.Refresh();
            }
        }

        private void tlBufferResult_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                ILayer pLayer = null;
                IFeatureLayer pFeaLayer = null;
                IFeatureClass pFeaClass = null;
                IFeatureCursor pFeaCursor = null;
                IFeature pFea = null;
                IQueryFilter pQueryFilter = new QueryFilterClass();

                TreeListNode node = tlBufferResult.FocusedNode;
                if (!node.HasChildren)
                {
                    string sLayerName = node.ParentNode.GetDisplayText(0).Trim();

                    //// 根据图层名来获取图层
                    for (int i = 0; i < Parameters.g_pMapControl.Map.LayerCount; i++)
                    {
                        if (Parameters.g_pMapControl.Map.get_Layer(i).Name.Equals(sLayerName))
                        {
                            pLayer = Parameters.g_pMapControl.Map.get_Layer(i);
                            break;
                        }
                    }

                    pFeaLayer = pLayer as IFeatureLayer;
                    pFeaClass = pFeaLayer.FeatureClass;
                    string sOIDName = pFeaClass.OIDFieldName.ToString();
                    string sOID = node.GetDisplayText(0);
                    string sQuery = "" + sOIDName + " = " + sOID + "";
                    pQueryFilter.WhereClause = sQuery;

                    //// 根据唯一编号的ObjectID 或者 FID，查询出来的要素也是唯一的
                    pFeaCursor = pFeaClass.Search(pQueryFilter, false);
                    pFea = pFeaCursor.NextFeature();

                    //// 设置缓冲区颜色
                    ISimpleFillSymbol pFillSymbol = new SimpleFillSymbolClass();
                    ISymbol pSymbol;
                    IRgbColor pRgbColor = new RgbColorClass();
                    pRgbColor.Red = 255;
                    pRgbColor.Green = 255;
                    pRgbColor.Blue = 153;
                    pRgbColor.Transparency = 1;
                    pFillSymbol.Color = pRgbColor;
                    pSymbol = (ISymbol)pFillSymbol; 

                    //// 清空上次选择
                    Parameters.g_pMapControl.Map.ClearSelection();

                    //// 要素闪烁
                    Parameters.g_pMapControl.FlashShape(pFea.Shape,2,100,pSymbol);

                    //// 选择要素
                    Parameters.g_pMapControl.Map.SelectFeature(pFeaLayer, pFea);

                    //// 放大图形
                    IEnvelope pEnvlope = pFea.Shape.Envelope;
                    Parameters.g_pMapControl.Extent = pEnvlope;
                }
            }
            catch (Exception ex)
            {
                LogOperation.WriteLog("缓冲区查询时，要素定位闪烁失败", ex.ToString());
            }
        }

    }
}
