﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.IO;
using DevExpress.XtraTreeList.Nodes;
using System.Runtime.InteropServices;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Controls;
using ESRI.ArcGIS.Geodatabase;
using System.Data;
using System.Windows.Forms;
using ESRI.ArcGIS.Geometry;

namespace AEDemo
{
    /// <summary>
    /// 图层、要素操作
    /// </summary>
    class LayerOperation
    {
        /// <summary>
        /// 储存要素属性信息
        /// </summary>
        public static DataTable m_dtFeature = null;

        /// <summary>
        /// 储存图层名称
        /// </summary>
        private static string m_sLayerName = string.Empty;

        #region 要素是否选中、 根据字段名获取所有属性值
        /// <summary>
        /// 判断当前是否选中要素
        /// </summary>
        /// <returns></returns>
        public static bool IsSelectFeature()
        {
            bool bResult = false;

            try
            {
                ISelection pSelection = Parameters.g_pMapControl.Map.FeatureSelection;
                IEnumFeatureSetup pEnumFeatureSetup = pSelection as IEnumFeatureSetup;
                pEnumFeatureSetup.AllFields = true;

                IEnumFeature pEnumFeature = pEnumFeatureSetup as IEnumFeature;
                pEnumFeature.Reset();
                IFeature pFea = pEnumFeature.Next();

                if (pFea == null)
                {
                    bResult = false;
                }
                else
                {
                    bResult = true;
                }
            }
            catch (Exception ex)
            {
                LogOperation.WriteLog("判断当前是否选中要素失败", ex.ToString());
                bResult = false;
            }

            return bResult;
        }

        /// <summary>
        /// 根据字段名获取所有属性值
        /// </summary>
        /// <param name="Layer"></param>
        /// <param name="FieldName"></param>
        /// <returns></returns>
        public static List<string> GetFieldValue(ILayer Layer, string FieldName)
        {
            List<string> listValue = new List<string> { };
            IFeatureLayer pFeaLayer = null;
            IFeatureClass pFeaClass = null;
            IFeature pFea = null;
            IFeatureCursor pFeaCursor = null;
            //// 字段索引号
            int iFieldIndex = 0;
            bool bIsContained = false;

            try
            {
                pFeaLayer = Layer as IFeatureLayer;
                pFeaClass = pFeaLayer.FeatureClass;
                pFeaCursor = pFeaClass.Search(null, true);
                pFea = pFeaCursor.NextFeature();
                iFieldIndex = pFeaClass.FindField(FieldName);

                ////遍历要素
                while (pFea != null)
                {
                    string sFieldValue = pFea.get_Value(iFieldIndex).ToString();

                    //// 判断当前List是否已经包含待添加的字段值，未包含则添加
                    for (int i = 0; i < listValue.Count; i++)
                    {
                        string sListValue = listValue[i].ToString();

                        if (sListValue.Equals(sFieldValue))
                        {
                            bIsContained = true;
                            break;
                        }
                    }

                    if (!bIsContained)
                    {
                        listValue.Add(sFieldValue);
                    }

                    pFea = pFeaCursor.NextFeature();
                }
            }
            catch (Exception ex)
            {
                LogOperation.WriteLog("根据字段名获取字段属性值失败", ex.ToString());
            }
            return listValue;
        }

        public static DataTable FeatureQuery(ILayer Layer, string WhereExpress)
        {
            DataTable dt = new DataTable();
            IFeatureLayer pFeaLayer = null;
            IFeatureClass pFeaClass = null;
            IFeature pFea = null;
            IFeatureCursor pFeaCursor = null;
            IQueryFilter pQueryFilter = new QueryFilterClass();

            try
            {
                pFeaLayer = Layer as IFeatureLayer;
                pFeaClass = pFeaLayer.FeatureClass;
                pQueryFilter.WhereClause = WhereExpress;
                pFeaCursor = pFeaClass.Search(pQueryFilter, false);
                pFea = pFeaCursor.NextFeature();

                for (int i = 0; i < pFeaClass.Fields.FieldCount; i++)
                {
                    string sFieldName = pFeaClass.Fields.get_Field(i).Name;
                    dt.Columns.Add(sFieldName);
                }

                while (pFea != null)
                {
                    DataRow dr = dt.NewRow();
                    for (int i = 0; i < pFeaClass.Fields.FieldCount; i++)
                    {
                        if (pFeaClass.Fields.get_Field(i).Type == esriFieldType.esriFieldTypeGeometry)
                        {
                            if (pFea.Shape.GeometryType.ToString().ToLower().Equals("esrigeometrypolygon"))
                            {
                                dr[i] = "面";
                            }
                            else if (pFea.Shape.GeometryType.ToString().ToLower().Equals("esrigeometrypolyline"))
                            {
                                dr[i] = "线";
                            }
                            else if (pFea.Shape.GeometryType.ToString().ToLower().Equals("esrigeometrypoint"))
                            {
                                dr[i] = "点";
                            }
                        }
                        else if (pFeaClass.Fields.get_Field(i).Type == esriFieldType.esriFieldTypeBlob)
                        {
                            dr[i] = "BLOB";
                        }
                        else
                        {
                            dr[i] = pFea.get_Value(i) != null ? pFea.get_Value(i) : string.Empty;
                        }
                    }
                    //dr["Index"] = Convert.ToInt32(dr[sOIDName]) + 1;
                    dt.Rows.Add(dr);
                    pFea = pFeaCursor.NextFeature();
                }

            }
            catch (Exception ex)
            {
                LogOperation.WriteLog("属性查询失败", ex.ToString());
                dt = null;
            }
            finally
            {
                ESRI.ArcGIS.ADF.ComReleaser.ReleaseCOMObject(pFeaLayer);
                ESRI.ArcGIS.ADF.ComReleaser.ReleaseCOMObject(pFeaClass);
                ESRI.ArcGIS.ADF.ComReleaser.ReleaseCOMObject(pFeaCursor);
                ESRI.ArcGIS.ADF.ComReleaser.ReleaseCOMObject(pFea);
                ESRI.ArcGIS.ADF.ComReleaser.ReleaseCOMObject(pQueryFilter);
            }
            return dt;

        }


        #endregion

        #region 获得图层属性、要素属性
        /// <summary>
        /// 显示图层属性
        /// </summary>
        /// <param name="frm"></param>
        /// <returns></returns>
        public static bool ShowLayerProperty(frmLayerProperty frm, ILayer Layer)
        {
            bool bResult = false;
            IFeatureLayer pFeaLayer = null;
            IFeatureClass pFeaClass = null;
            IGeoDataset pGeoDataset;
            ISpatialReference pSpatialReference;

            try
            {
                pFeaLayer = Layer as IFeatureLayer;
                pFeaClass = pFeaLayer.FeatureClass;
                pGeoDataset = pFeaLayer as IGeoDataset;
                pSpatialReference = pGeoDataset.SpatialReference;

                //// 获取字段个数
                int iFieldCount = pFeaClass.Fields.FieldCount;

                frm.listData.Items.Clear();
                frm.listData.Items.Add("图层别名：    " + pFeaClass.AliasName);
                frm.listData.Items.Add(" ");
                frm.listData.Items.Add("空间参考：    " + pSpatialReference.Name);
                frm.listData.Items.Add(" ");
                frm.listData.Items.Add("几何类型：    " + pFeaClass.ShapeType);
                frm.listData.Items.Add(" ");
                frm.listData.Items.Add("要素类型：    " + pFeaClass.FeatureType);
                frm.listData.Items.Add(" ");
                frm.listData.Items.Add("要素个数：    " + pFeaClass.FeatureCount(null));
                frm.listData.Items.Add(" ");
                frm.listData.Items.Add("字段个数：    " + pFeaClass.Fields.FieldCount);
                frm.listData.Items.Add(" ");
                frm.listData.Items.Add("OID字段名：   " + pFeaClass.OIDFieldName.ToString());
                frm.listData.Items.Add(" ");

                DataTable dt = new DataTable();
                dt.Columns.Add("名称：");
                dt.Columns.Add("别名：");
                dt.Columns.Add("类型：");
                dt.Columns.Add("长度：");
                dt.Columns.Add("精度：");

                for (int i = 0; i < iFieldCount; i++)
                {
                    DataRow dr = dt.NewRow();
                    dr["名称："] = pFeaClass.Fields.get_Field(i).Name;
                    dr["别名："] = pFeaClass.Fields.get_Field(i).AliasName;
                    dr["类型："] = pFeaClass.Fields.get_Field(i).Type;
                    dr["长度："] = pFeaClass.Fields.get_Field(i).Length;
                    dr["精度："] = pFeaClass.Fields.get_Field(i).Precision;
                    dt.Rows.Add(dr);
                }
                frm.gcField.DataSource = dt;
                frm.gvField.PopulateColumns();
                frm.gvField.BestFitColumns();

                bResult = true;
            }
            catch (Exception ex)
            {
                LogOperation.WriteLog("显示图层属性失败", ex.ToString());
                bResult = false;
            }
            finally
            {
                ESRI.ArcGIS.ADF.ComReleaser.ReleaseCOMObject(pFeaLayer);
                ESRI.ArcGIS.ADF.ComReleaser.ReleaseCOMObject(pFeaClass);
            }
            return bResult;
        }

        /// <summary>
        /// 显示图层下要素的详细信息
        /// </summary>
        /// <param name="frm"></param>
        /// <returns></returns>
        public static bool ShowPropertyDetails(frmPropertyDetails frm, ILayer Layer)
        {
            frm.gcFieldInfo.DataSource = null;
            bool bResult = false;
            IFeatureLayer pFeaLayer = null;
            IFeatureClass pFeaClass = null;
            IFeatureCursor pFeaCursor = null;
            IFeature pFea = null;
            int iFieldCount = 0;
            DataTable dt = new DataTable();
            string sOIDName = string.Empty;

            try
            {
                pFeaLayer = Layer as IFeatureLayer;
                pFeaClass = pFeaLayer.FeatureClass;
                sOIDName = pFeaClass.OIDFieldName.ToString();
                Parameters.g_sOIDName = sOIDName;
                pFeaCursor = pFeaClass.Search(null, false);
                pFea = pFeaCursor.NextFeature();
                iFieldCount = pFeaClass.Fields.FieldCount;

                for (int i = 0; i < iFieldCount; i++)
                {
                    string sFieldName = pFeaClass.Fields.get_Field(i).Name;
                    dt.Columns.Add(sFieldName);
                }

                dt.Columns.Add("Index", typeof(Int32));

                while (pFea != null)
                {
                    DataRow dr = dt.NewRow();
                    for (int i = 0; i < iFieldCount; i++)
                    {
                        if (pFeaClass.Fields.get_Field(i).Type == esriFieldType.esriFieldTypeGeometry)
                        {
                            if (pFea.Shape.GeometryType.ToString().ToLower().Equals("esrigeometrypolygon"))
                            {
                                dr[i] = "面";
                            }
                            else if (pFea.Shape.GeometryType.ToString().ToLower().Equals("esrigeometrypolyline"))
                            {
                                dr[i] = "线";
                            }
                            else if (pFea.Shape.GeometryType.ToString().ToLower().Equals("esrigeometrypoint"))
                            {
                                dr[i] = "点";
                            }
                        }
                        else if (pFeaClass.Fields.get_Field(i).Type == esriFieldType.esriFieldTypeBlob)
                        {
                            dr[i] = "BLOB";
                        }
                        else
                        {
                            dr[i] = pFea.get_Value(i) != null ? pFea.get_Value(i) : string.Empty;
                        }
                    }
                    dr["Index"] = Convert.ToInt32(dr[sOIDName]) + 1;
                    dt.Rows.Add(dr);
                    pFea = pFeaCursor.NextFeature();
                }

                Parameters.g_iSumRecords = dt.Rows.Count;
                Parameters.g_iCurrentPage = 1;
                double dSumRows = dt.Rows.Count;
                double dPages = Math.Ceiling(dSumRows / Parameters.g_iMaxRows);
                Parameters.g_iSumPages = Convert.ToInt32(dPages);

                m_dtFeature = dt;
                m_sLayerName = Layer.Name;

                if (dt != null && dt.Rows.Count > 0)
                {
                    string sWhereExpress = string.Format("Index<={0}", Parameters.g_iMaxRows);
                    DataRow[] drArray = dt.Select(sWhereExpress);

                    dt = drArray.CopyToDataTable();
                    frm.gcFieldInfo.DataSource = dt;
                    frm.gvFieldInfo.PopulateColumns();
                    frm.gvFieldInfo.BestFitColumns();
                    frm.labelRecords.Text = string.Format("第1/{0}条", Parameters.g_iSumRecords);
                    frm.labelPages.Text = string.Format("页数：第1/{0}页", Parameters.g_iSumPages);
                    frm.txtPage.Text = "1";
                }

                bResult = true;
            }
            catch (Exception ex)
            {
                LogOperation.WriteLog("显示要素详情失败：", ex.ToString());
                bResult = false;
            }
            finally
            {
                ESRI.ArcGIS.ADF.ComReleaser.ReleaseCOMObject(pFeaLayer);
                ESRI.ArcGIS.ADF.ComReleaser.ReleaseCOMObject(pFeaClass);
                ESRI.ArcGIS.ADF.ComReleaser.ReleaseCOMObject(pFeaCursor);
                ESRI.ArcGIS.ADF.ComReleaser.ReleaseCOMObject(pFea);
            }

            return bResult;
        }
        #endregion

        #region 要素属性导出
        /// <summary>
        /// 要素属性信息导出
        /// </summary>
        /// <returns></returns>
        public static bool ExportToExcel(frmPropertyDetails frm)
        {
            bool bResult = false;
            GtMap.GxDlgHelper.ProgressDialog2 pDg = null;
            string sFileName = string.Empty;

            try
            {
                if (m_dtFeature != null && m_dtFeature.Rows.Count > 0)
                {
                    pDg = new GtMap.GxDlgHelper.ProgressDialog2(frm);
                    string sTime = System.DateTime.Now.ToString("yyyyMMddHHmmss");
                    SaveFileDialog SaveDlg = new SaveFileDialog();
                    SaveDlg.Filter = "Excel(*.xlsx)|*.xlsx";
                    SaveDlg.FileName = m_sLayerName + "图层的要素属性信息(" + sTime + ")";


                    if (SaveDlg.ShowDialog() == DialogResult.OK)
                    {
                        sFileName = SaveDlg.FileName;
                        object missing = System.Reflection.Missing.Value;
                        Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
                        Microsoft.Office.Interop.Excel._Workbook workbook;
                        Microsoft.Office.Interop.Excel._Worksheet worksheet;
                        Microsoft.Office.Interop.Excel.Range range;
                        ExcelApp.Application.Workbooks.Add(true);
                        workbook = ExcelApp.ActiveWorkbook;
                        worksheet = (Microsoft.Office.Interop.Excel._Worksheet)workbook.ActiveSheet;

                        pDg.Title = "导出要素信息";
                        pDg.Message = "导出图层要素信息";
                        pDg.Min = 0;
                        pDg.Max = m_dtFeature.Rows.Count;
                        pDg.CancelEnabled = false;
                        frm.Cursor = System.Windows.Forms.Cursors.WaitCursor;

                        //// Excel中添加列名称
                        for (int k = 0; k < m_dtFeature.Columns.Count; k++)
                        {
                            worksheet.Cells[1, k + 1] = m_dtFeature.Columns[k].ColumnName;
                        }

                        pDg.Position = 0;
                        pDg.Show();

                        //// Excel中添加要素信息
                        for (int i = 0; i < m_dtFeature.Rows.Count; i++)
                        {
                            pDg.Message = "导出选中图层的要素信息";
                            pDg.Description = "正在导出第(" + i + "/" + m_dtFeature.Rows.Count + "条)记录……";
                            pDg.Step(1);

                            for (int j = 0; j < m_dtFeature.Columns.Count; j++)
                            {
                                worksheet.Cells[i + 2, j + 1] = m_dtFeature.Rows[i][j];
                            }
                        }

                        //// 自适应列宽
                        range = worksheet.Columns;
                        range.AutoFit();

                        workbook.SaveCopyAs(SaveDlg.FileName);
                        workbook.Close(false, missing, missing);
                        ExcelApp.Quit();
                        bResult = true;

                    }
                }
            }
            catch (Exception ex)
            {
                LogOperation.WriteLog("要素属性信息导出成Excel失败", ex.ToString());
                bResult = false;
            }
            finally
            {
                frm.Cursor = System.Windows.Forms.Cursors.Default;
                pDg.Hide();
                pDg = null;
                if (bResult)
                {
                    if (GtMap.GxDlgHelper.DevMessageBox.ShowConfirmation("要素信息导出成功，是否打开所在文件？") == DialogResult.Yes)
                    {
                        System.Diagnostics.Process.Start(sFileName);
                    }
                }
            }

            return bResult;
        }
        #endregion

        /// <summary>
        /// 选中属性表的要素时，闪烁并放大
        /// </summary>
        /// <param name="frm"></param>
        /// <param name="frmMain"></param>
        /// <returns></returns>
        public static bool FlashShape(frmPropertyDetails frm, frmFrame frmMain, bool IsDoubleClick)
        {
            bool bResult = false;
            ILayer pLayer = null;
            IFeatureLayer pFeaLayer = null; ;
            IFeatureClass pFeaClass = null; ;
            IFeatureCursor pFeaCursor = null;
            IFeature pFea = null;
            IQueryFilter pQueryFilter = new QueryFilterClass();

            try
            {
                //// 获取当前在树节点中选中的图层
                TreeListNode node = frm.tlLayer.FocusedNode;
                string sLayerName = node.GetDisplayText(0).Trim();

                //// 根据图层名来获取图层
                for (int i = 0; i < Parameters.g_iLayerCount; i++)
                {
                    pLayer = Parameters.g_pMapControl.get_Layer(i);
                    if (pLayer.Name.Equals(sLayerName))
                    {
                        break;
                    }
                }

                pFeaLayer = pLayer as IFeatureLayer;
                pFeaClass = pFeaLayer.FeatureClass;

                //// 获得选中的行记录
                DataRow dr = frm.gvFieldInfo.GetFocusedDataRow();
                //// 获得OID字段在该数据集中的名称，是叫FID 还是 OBJECTID
                string sOIDName = pFeaClass.OIDFieldName.ToString();
                //// 获得OID字段的值
                string sOIDValue = dr[sOIDName].ToString();

                string sQuery = "" + sOIDName + " = " + sOIDValue + "";

                pQueryFilter.WhereClause = sQuery;

                //// 根据唯一编号的ObjectID 或者 FID，查询出来的要素也是唯一的
                pFeaCursor = pFeaClass.Search(pQueryFilter, false);
                pFea = pFeaCursor.NextFeature();

                //// 清空上次选择
                frmMain.axMapControl1.Map.ClearSelection();

                if (IsDoubleClick)
                {
                    //// 要素闪烁
                    frmMain.axMapControl1.FlashShape(pFea.Shape);

                    //// 选择要素
                    frmMain.axMapControl1.Map.SelectFeature(pFeaLayer, pFea);

                    //// 放大图形
                    IEnvelope pEnvlope = pFea.Shape.Envelope;
                    //pEnvlope.Height = pEnvlope.Height * 6;
                    //pEnvlope.Width = pEnvlope.Width * 6;

                    //// 获得要素中心点
                    //IPoint pPoint = (pEnvlope as IArea).Centroid;
                    //IPoint pPoint = new PointClass();
                    //pPoint.X = (pEnvlope.LowerLeft.X+pEnvlope.UpperRight.X) / 2;
                    //pPoint.Y = (pEnvlope.LowerLeft.Y + pEnvlope.UpperRight.Y) / 2;

                    frmMain.axMapControl1.Extent = pEnvlope;
                }
                else
                {
                    //// 选择要素
                    frmMain.axMapControl1.Map.SelectFeature(pFeaLayer, pFea);
                }
                //frmMain.axMapControl1.CenterAt(pPoint);

                // IGeometry pGeo = IGeometry(pFea);

                bResult = true;
            }
            catch (Exception ex)
            {
                LogOperation.WriteLog("闪烁显示要素失败：", ex.ToString());
                bResult = false;
            }
            finally
            {
                ESRI.ArcGIS.ADF.ComReleaser.ReleaseCOMObject(pFeaLayer);
                ESRI.ArcGIS.ADF.ComReleaser.ReleaseCOMObject(pFeaClass);
                ESRI.ArcGIS.ADF.ComReleaser.ReleaseCOMObject(pFeaCursor);
                ESRI.ArcGIS.ADF.ComReleaser.ReleaseCOMObject(pFea);
                ESRI.ArcGIS.ADF.ComReleaser.ReleaseCOMObject(pQueryFilter);
            }

            return bResult;
        }

    }
}
