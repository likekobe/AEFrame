using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ESRI.ArcGIS.Geodatabase;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Geoprocessor;
using ESRI.ArcGIS.AnalysisTools;
using ESRI.ArcGIS.esriSystem;
using ESRI.ArcGIS.Geoprocessing;
using ESRI.ArcGIS.DataManagementTools;


namespace AEDemo
{
    //********************************************************
    //创建时间: 2014.8.13
    //作    者: 向强
    //內容说明: GP
    //********************************************************
    public class GPRunner
    {
        #region Members
        /// <summary>
        /// Geoprocessor
        /// </summary>
        private Geoprocessor GP = null;

        /// <summary>
        /// GP信息
        /// </summary>
        private string PGMessages = string.Empty;

        /// <summary>
        /// 日志
        /// </summary>
        public string Log { get; set; }

        /// <summary>
        /// 结果信息
        /// </summary>
        public string g_sResult;

        #endregion Members

        #region Constructors
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="pDg"></param>
        public GPRunner()
        {
            GP = new Geoprocessor();
        }

        #endregion Constructors

        #region PrivateMethods
        /// <summary>
        /// 输出GP信息
        /// </summary>
        private void ReturnMessages()
        {
            if (GP.MessageCount > 0)
            {
                for (int i = 0; i <= GP.MessageCount - 1; i++)
                {
                    PGMessages += GP.GetMessage(i) + "\n";
                }
            }
        }

        /// <summary>
        /// 执行工具
        /// </summary>
        /// <param name="process">GP方法</param>
        private bool RunTool(IGPProcess process)
        {
            bool bSuccess = false;
            GP.OverwriteOutput = true;
            IGeoProcessorResult result;
            try
            {
                result = (IGeoProcessorResult)GP.Execute(process, null);
                ReturnMessages();
                if (result == null)
                {
                    return false;
                }

                if (result.Status == esriJobStatus.esriJobSucceeded)
                {
                    bSuccess = true;
                }
                //ESRI.ArcGIS.ADF.ComReleaser.ReleaseCOMObject(result);
            }
            catch (Exception err)
            {
                PGMessages += err.Message + "\n";
                ReturnMessages();
            }
            finally
            {
                if (GP.MessageCount > 0)
                {
                    for (int i = 0; i < GP.MessageCount - 1; i++)
                    {
                        string sMs = GP.GetMessage(i);
                        GtMap.GxComHelper.LogWriter.WriteLog(Log, GP.GetMessage(i));
                    }
                }
            }
            
            return bSuccess;

        }

        #endregion PrivateMethods

        #region PublicMethods

        /// <summary>
        /// 用Append工具将某图层
        /// </summary>
        /// <param name="pInputFeaCls">源图层</param>
        /// <param name="pOutputFeaCls">目标图层</param>
        public bool AppendGP(IFeatureClass pInputFeaCls, IFeatureClass pTargetFeaCls)
        {
            try
            {
                Append pAppend = new Append();
                pAppend.inputs = pInputFeaCls;
                pAppend.target = pTargetFeaCls;
                pAppend.schema_type = "NO_TEST";
                return RunTool(pAppend);
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// 用Dissolve工具合并某个图层
        /// </summary>
        /// <param name="pInputFeaCls"></param>
        /// <param name="pOutFeaClsName"></param>
        /// <param name="sDissolvField"></param>
        /// <returns></returns>
        public bool DissolveGP(IFeatureClass pInputFeaCls, string pOutFeaClsName, string sDisolve_Field, object statisticsFields, bool bIsMuiti)
        {
            try
            {

                if (pInputFeaCls == null || string.IsNullOrEmpty(pOutFeaClsName))
                {
                    return false;
                }

                Dissolve pDissolve = new Dissolve();
                pDissolve.in_features = pInputFeaCls;
                pDissolve.dissolve_field = sDisolve_Field;
                pDissolve.out_feature_class = pOutFeaClsName;
                if (bIsMuiti)
                {
                    pDissolve.multi_part = "MULTI_PART";
                }
                else
                {
                    pDissolve.multi_part = "SINGLE_PART";
                }

                return RunTool(pDissolve);

            }
            catch (Exception ex)
            {
                GtMap.GxComHelper.LogWriter.WriteLog(Log, "【用Dissolve工具合并某个图层】失败，原因：" + ex.Message);
                return false;
            }
        }

        /// <summary>
        /// 多部分拆分为单一部分
        /// </summary>
        /// <param name="pInputFeaCls">输入要素</param>
        /// <param name="pOutFeaClsName">输出要素</param>
        /// <returns></returns>
        public bool MultipartToSinglepartGP(IFeatureClass pInputFeaCls, string pOutFeaClsName)
        {
            try
            {
                MultipartToSinglepart pMultipart = new MultipartToSinglepart();
                pMultipart.in_features = pInputFeaCls;
                pMultipart.out_feature_class = pOutFeaClsName;
                return RunTool(pMultipart);
            }
            catch (Exception ex)
            {
                GtMap.GxComHelper.LogWriter.WriteLog(Log, "【多部分拆分为单一部分】失败，原因：" + ex.Message);
                return false;
            }
        }

        /// <summary>
        /// Identity工具
        /// </summary>
        /// <param name="pInputFeaCls">输入要素</param>
        /// <param name="pIdentityFeaCls">Identity要素</param>
        /// <param name="sOutFeaClsName">输出要素名称</param>
        /// <returns></returns>
        public bool IdentityGP(string pInputFeaCls, string pIdentityFeaCls, string sOutFeaClsName)
        {
            try
            {
                if (pInputFeaCls == null || pIdentityFeaCls == null || string.IsNullOrEmpty(sOutFeaClsName))
                {
                    return false;
                }

                Identity pIdentity = new Identity();
                pIdentity.in_features = pInputFeaCls;
                pIdentity.identity_features = pIdentityFeaCls;
                pIdentity.out_feature_class = @"E:\数据\★中国矢量数据（Lambert投影）\中国_Identity.shp ";
                pIdentity.join_attributes = "ALL";
                pIdentity.cluster_tolerance = string.Empty;
                pIdentity.relationship = "NO_RELATIONSHIPS";
                return RunTool(pIdentity);

            }
            catch (Exception ex)
            {
                GtMap.GxComHelper.LogWriter.WriteLog(Log, "【Identity工具】失败，原因：" + ex.Message);
                return false;
            }
        }

        /// <summary>
        /// 图层对比
        /// </summary>
        /// <param name="pInputFeaCls"></param>
        /// <param name="pDifferenceFeaCls"></param>
        /// <param name="sOutFeaClsName"></param>
        /// <returns></returns>
        public bool Difference(IFeatureClass pInputFeaCls, IFeatureClass pDifferenceFeaCls, string sOutFeaClsName)
        {
            try
            {
                if (pInputFeaCls == null || pDifferenceFeaCls == null || string.IsNullOrEmpty(sOutFeaClsName))
                {
                    return false;
                }

                SymDiff Difference = new SymDiff();
                Difference.in_features = pInputFeaCls;
                Difference.update_features = pDifferenceFeaCls;
                Difference.out_feature_class = sOutFeaClsName;
                Difference.join_attributes = "ALL";
                Difference.cluster_tolerance = string.Empty;
                return RunTool(Difference);
            }
            catch (Exception ex)
            {
                GtMap.GxComHelper.LogWriter.WriteLog(Log, "【Difference工具】失败，原因：" + ex.Message);
                return false;
            }
        }

        public bool Intersect(IFeatureClass pInputFeaCls, IFeatureClass pIdentityFeaCls, string sOutFeaClsName)
        {
            try
            {
                if (pInputFeaCls == null || pIdentityFeaCls == null || string.IsNullOrEmpty(sOutFeaClsName))
                {
                    return false;
                }

                string sInFeatures = string.Empty;
                sInFeatures = GtMap.GxAEHelper.FeatureClass.GetFullName(pInputFeaCls) + ";";
                sInFeatures = sInFeatures + GtMap.GxAEHelper.FeatureClass.GetFullName(pIdentityFeaCls);
                Intersect pIntersect = new Intersect();
                pIntersect.in_features = sInFeatures;
                pIntersect.out_feature_class = sOutFeaClsName;

                return RunTool(pIntersect);
            }
            catch (Exception ex)
            {
                GtMap.GxComHelper.LogWriter.WriteLog(Log, "【Intersect工具】失败，原因：" + ex.Message);
                return false;
            }

        }

        /// <summary>
        /// 多边形转换为线
        /// </summary>
        /// <param name="pInputFeaCls">输入图层：面图层</param>
        /// <param name="sOutFeaClsName">输出文件名称</param>
        /// <returns></returns>
        public bool PolygonToline(IFeatureClass pInputFeaCls, string sOutFeaClsName)
        {
            try
            {
                if (pInputFeaCls == null || string.IsNullOrEmpty(sOutFeaClsName))
                {
                    return false;
                }

                PolygonToLine pPolToLine = new PolygonToLine();
                pPolToLine.in_features = pInputFeaCls;
                pPolToLine.out_feature_class = sOutFeaClsName;
                return RunTool(pPolToLine);
            }
            catch (Exception ex)
            {
                GtMap.GxComHelper.LogWriter.WriteLog(Log, "【PolygonToline工具】失败，原因：" + ex.Message);
                return false;
            }
        }

        /// <summary>
        /// 修复图形
        /// </summary>
        /// <param name="pFeaCls">要素类</param>
        /// <returns></returns>
        public bool RepairGeometryFromFeatureClass(IFeatureClass pFeaCls)
        {
            try
            {
                if (pFeaCls == null)
                    return false;
                RepairGeometry pRepGeo = new RepairGeometry(pFeaCls);
                return RunTool(pRepGeo);
            }
            catch (Exception ex)
            {
                GtMap.GxComHelper.LogWriter.WriteLog(Log, "【RepairGeometryFromFeatureClass工具】失败，原因：" + ex.Message);
                return false;
            }
        }


        public bool FeatureToPoint(IFeatureClass pFeaClsInput, string sOutFeaClsName)
        {
            if (pFeaClsInput == null || string.IsNullOrEmpty(sOutFeaClsName))
            {
                return false;
            }

            try
            {
                FeatureToPoint pFeaToPnt = new FeatureToPoint();
                pFeaToPnt.in_features = pFeaClsInput;
                pFeaToPnt.out_feature_class = sOutFeaClsName;
                return RunTool(pFeaToPnt);
            }
            catch (Exception ex)
            {
                GtMap.GxComHelper.LogWriter.WriteLog(Log, "【FeatureToPoint工具】失败，原因：" + ex.Message);
                return false;
            }

        }

        #endregion PublicMethods

    }
}
