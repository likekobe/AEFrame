using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GtMap.GxAEHelper;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Geodatabase;
using ESRI.ArcGIS.Geometry;
using ESRI.ArcGIS.Display;

namespace AEDemo
{
    public partial class frmBuffer : Form
    {
        ILayer m_pLayer = null;

        public frmBuffer()
        {
            InitializeComponent();
            CboLoadLayer();
            cboSelectLayer.SelectedIndex = 0;
            m_pLayer = Parameters.g_pMapControl.get_Layer(0);
        }

        private void btnCreateBuffer_Click(object sender, EventArgs e)
        {
            try
            {
                IFeatureLayer pFeaLayer = m_pLayer as IFeatureLayer;
                IFeatureClass pFeaClass = pFeaLayer.FeatureClass;
                IFeature pFea = null;
                ITopologicalOperator pTopo = null;

                IFeatureCursor pFeaCursor = null;


                IGeometry pGeo = null;

                IGeometry pBuffer = null;
                IElement pElement = null;

                double dDistance = 0;
                double.TryParse(txtDistance.Text, out dDistance);

                ISpatialFilter pSpatialFilter = new SpatialFilterClass();

                if (Parameters.g_StartPoint.X == Parameters.g_EndPoint.X && Parameters.g_StartPoint.Y == Parameters.g_EndPoint.Y && Parameters.g_StartPoint != null)
                {
                    pSpatialFilter.Geometry = Parameters.g_StartPoint;
                    pSpatialFilter.SpatialRel = esriSpatialRelEnum.esriSpatialRelIntersects;
                    pSpatialFilter.GeometryField = pFeaLayer.FeatureClass.ShapeFieldName;
                    pFeaCursor = pFeaLayer.Search(pSpatialFilter, false);
                    pFeaCursor = pFeaClass.Search(pSpatialFilter, false);
                    pFea = pFeaCursor.NextFeature();
                }
                else if (Parameters.g_StartPoint != Parameters.g_EndPoint)
                {
                    IPolygon pPolygon = GtMap.GxAEHelper.Geometry.CreatePolygon(Parameters.g_StartPoint.X, Parameters.g_EndPoint.X, Parameters.g_StartPoint.Y, Parameters.g_EndPoint.Y);
                    pSpatialFilter.Geometry = pPolygon;
                    pSpatialFilter.SpatialRel = esriSpatialRelEnum.esriSpatialRelIntersects;
                    pSpatialFilter.GeometryField = pFeaLayer.FeatureClass.ShapeFieldName;

                    pFeaCursor = pFeaClass.Search(pSpatialFilter, false);
                    pFea = pFeaCursor.NextFeature();
                }

                while (pFea != null)
                {
                    //pFea = pFeaClass.GetFeature(k);
                    pTopo = pFea as ITopologicalOperator;

                    if (pFea.ShapeCopy == null)
                    {
                        continue;
                    }

                    pGeo = pFea.ShapeCopy;
                    IGeometryCollection pGeoCollection = pGeo as IGeometryCollection;
                    IGeometry pGeonext;

                    for (int j = 0; j < pGeoCollection.GeometryCount; j++)
                    {
                        pGeonext = GtMap.GxAEHelper.Geometry.CloneGeometry(pGeoCollection.get_Geometry(j));
                        IGeometryCollection pGEOcol = new PolygonClass();
                        object mising1 = Type.Missing;
                        object mising2 = Type.Missing;
                        pGEOcol.AddGeometry(pGeonext, ref mising1, ref mising2);

                        pTopo = (pGEOcol as IPolygon) as ITopologicalOperator;
                        pBuffer = pTopo.Buffer(dDistance);

                        pElement = new PolygonElementClass();
                        pElement.Geometry = pBuffer;

                        IFillSymbol pFillSymbol = new SimpleFillSymbolClass();
                        (pFillSymbol as ISimpleFillSymbol).Style = esriSimpleFillStyle.esriSFSNull;
                        IRgbColor pRgbColor = new RgbColorClass();
                        pRgbColor.Red = 255;

                        //ILineSymbol pLineSymbol = new SimpleLineSymbolClass();
                        //pLineSymbol.Color = pRgbColor;
                        //pLineSymbol.Width = 1.5;

                        //(pFillSymbol as IFillSymbol).Outline = pLineSymbol;
                        (pElement as IFillShapeElement).Symbol = pFillSymbol;

                        (Parameters.g_pMapControl.Map as IGraphicsContainer).AddElement(pElement, 0);
                    }
                    pFea = pFeaCursor.NextFeature();

                }
                IActiveView pAct = Parameters.g_pMapControl.Map as IActiveView;
                pAct.Refresh();

            }
            catch
            {

            }




            //IGeometry pGeo = null;

            //IGeometry pBuffer = null;
            //IElement pElement = null;

            //double dDistance = 0;
            //double.TryParse(txtDistance.ToString(), out dDistance);

            //IMap pMap = Parameters.g_pMapControl.Map;
            //IFeatureSelection pFeaSelection = pMap.FeatureSelection as IFeatureSelection;
            ////ISelection pSelection = pMap.FeatureSelection;
            //ISelectionSet pSelectionSet = pFeaSelection.SelectionSet;
            //ISpatialFilter pfilte;
            ////pFeaClass.ShapeFieldName



            ////IEnumFeatureSetup iEnumFeatureSetup = new IEnumFeatureSetupProxy(pSelection);
            ////iEnumFeatureSetup.setAllFields(true);
            ////IEnumFeature enumFeature = new IEnumFeatureProxy(iEnumFeatureSetup);
            ////enumFeature.reset();
            ////IFeature feature = enumFeature.next();  

            //for (int i = 0; i < pFeaClass.FeatureCount(null); i++)
            //{
            //    pFea = pFeaClass.GetFeature(i);
            //    int o = pFea.OID;

            //    if (pFea.ShapeCopy == null)
            //    {
            //        continue;
            //    }

            //    pGeo = pFea.ShapeCopy;
            //    IGeometryCollection pGeoCollection = pGeo as IGeometryCollection;
            //    IGeometry pGeonext;

            //    for (int j = 0; j < pGeoCollection.GeometryCount; j++)
            //    {
            //        pGeonext = GtMap.GxAEHelper.Geometry.CloneGeometry(pGeoCollection.get_Geometry(j));
            //        IGeometryCollection pGEOcol = new PolygonClass();
            //        object mising1 = Type.Missing;
            //        object mising2 = Type.Missing;
            //        pGEOcol.AddGeometry(pGeonext, ref mising1, ref mising2);

            //        pTopo = (pGEOcol as IPolygon) as ITopologicalOperator;
            //        pBuffer = pTopo.Buffer(dDistance);

            //        pElement = new PolygonElementClass();
            //        pElement.Geometry = pBuffer;

            //        IFillSymbol pFillSymbol = new SimpleFillSymbolClass();
            //        (pFillSymbol as ISimpleFillSymbol).Style = esriSimpleFillStyle.esriSFSNull;
            //        IRgbColor pRgbColor = new RgbColorClass();
            //        pRgbColor.Red = 255;

            //        //ILineSymbol pLineSymbol = new SimpleLineSymbolClass();
            //        //pLineSymbol.Color = pRgbColor;
            //        //pLineSymbol.Width = 1.5;

            //        //(pFillSymbol as IFillSymbol).Outline = pLineSymbol;
            //        (pElement as IFillShapeElement).Symbol = pFillSymbol;

            //        (Parameters.g_pMapControl.Map as IGraphicsContainer).AddElement(pElement, 0);
            //    }

            //}
            //IActiveView pAct = Parameters.g_pMapControl.Map as IActiveView;
            //pAct.Refresh();

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
                    cboSelectLayer.Properties.Items.Add(pLayer.Name);
                }
            }
            catch (Exception ex)
            {

            }
        }

        /// <summary>
        /// 所选图层变换时触发该事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboSelectLayer_SelectedIndexChanged(object sender, EventArgs e)
        {
            int iLayerIndex = cboSelectLayer.SelectedIndex;
            ILayer pLayer = Parameters.g_pMapControl.get_Layer(iLayerIndex);
            m_pLayer = pLayer;

            for (int i = 0; i < Parameters.g_pMapControl.LayerCount; i++)
            {
                Parameters.g_pMapControl.get_Layer(i).Visible = false;
            }
            pLayer.Visible = true;

            IActiveView pActiveView = Parameters.g_pMapControl.Map as IActiveView;
            pActiveView.Refresh();

            //CommFunction.ShowLayerProperty(this, pLayer);
        }
    }
}
