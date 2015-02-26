using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ESRI.ArcGIS.Geometry;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Geodatabase;
using System.Runtime.InteropServices;

namespace AEDemo
{
    /// <summary>
    /// 在图层中增加要素
    /// </summary>
    class Edit
    {
        public static void Add(string LayerName,frmFrame frm)
        {
            IGeometryCollection pGeoCollection = new MultipointClass();
            object oMissing = Type.Missing;
            IPoint pPoint;

            for (int i = 0; i < 10;i++ )
            {
                pPoint = new PointClass();
                pPoint.PutCoords(100 * i, 100 * i);
                pGeoCollection.AddGeometry(pPoint as IGeometry, ref oMissing, ref oMissing);
            }

            IMultipoint pMultipoint = pGeoCollection as IMultipoint;
            AddFeature(LayerName, pMultipoint as IGeometry);
            frm.axMapControl1.Extent = pMultipoint.Envelope;
            frm.axMapControl1.Refresh();
        }

        /// <summary>
        /// 在图层中增加要素
        /// </summary>
        /// <param name="LayerName"></param>
        /// <param name="Geometry"></param>
        public static void AddFeature(string LayerName,IGeometry Geometry)
        {
            try
            {
                ILayer pLayer = null;

                ////    获得选中的图层
                for (int i = 0; i < Parameters.g_iLayerCount; i++)
                {
                    pLayer = Parameters.g_pMapControl.get_Layer(i);

                    if (pLayer.Name.Equals(LayerName))
                    {
                        break;
                    }
                }

                IFeatureLayer pFeaLayer = pLayer as IFeatureLayer;
                IFeatureClass pFeaClass = pFeaLayer.FeatureClass;
                IDataset pDataset = (IDataset)pFeaClass;
                IWorkspace pWorkSpc = pDataset.Workspace;

                ////    开始编辑
                IWorkspaceEdit pWorkSpcEdit = (IWorkspaceEdit)pWorkSpc;
                pWorkSpcEdit.StartEditing(true);
                pWorkSpcEdit.StartEditOperation();

                ////    清除图层原有实体对象
                IFeatureBuffer pFeaBuffer = pFeaClass.CreateFeatureBuffer();
                IFeatureCursor pFeaCursor = pFeaClass.Search(null, true);
                IFeature pFea = pFeaCursor.NextFeature();

                while (pFea != null)
                {
                    pFea.Delete();
                    pFea = pFeaCursor.NextFeature();
                }

                ////    插入新的实体对象
                pFeaCursor = pFeaClass.Insert(true);
                pFeaBuffer.Shape = Geometry;
                object oFeaOID = pFeaCursor.InsertFeature(pFeaBuffer);

                ////    保存实体
                pFeaCursor.Flush();

                ////    结束编辑
                pWorkSpcEdit.StopEditOperation();
                pWorkSpcEdit.StopEditing(true);
                Marshal.ReleaseComObject(pFeaCursor);
            }
            catch
            { 
            
            }
        }
    }
}
