using System;
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
    /// 公共方法的类
    /// </summary>
    class CommFunction
    {
        //private static uint SND_ASYNC = 0x0001;
        //private static uint SND_FILENAME = 0x00020000;
        /// <summary>
        /// mciSendString用于播放音乐
        /// </summary>
        /// <param name="lpstrCommand">要发送的命令字符串。字符串结构是:[命令][设备别名][命令参数]</param>
        /// <param name="lpstrReturnString">返回信息的缓冲区,为一指定了大小的字符串变量.</param>
        /// <param name="uReturnLength">缓冲区的大小,就是字符变量的长度.</param>
        /// <param name="hWndCallback">回调方式，一般设为零</param>
        /// <returns></returns>
        [DllImport("winmm.dll")]
        private static extern uint mciSendString(string lpstrCommand, string lpstrReturnString, uint uReturnLength, uint hWndCallback);


        /// <summary>
        /// 判断当前是否选中要素
        /// </summary>
        /// <returns></returns>
        public static bool IsSelectFeature()
        {
            bool bResult=false;

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
            catch(Exception ex)
            {
                bResult = false;
            }

            return bResult;
        }



        /// <summary>
        /// 写入日志文件
        /// </summary>
        /// <param name="LogName">日志名</param>
        /// <param name="LogContent">日志内容</param>
        /// <returns></returns>
        public static bool WriteLog(string LogName, string LogContent)
        {
            bool bResult = false;
            try
            {
                //DateTime dateTime = System.DateTime.Now;
                string sTime = Parameters.g_DateTime.GetDateTimeFormats('s')[0].ToString();
                sTime = sTime.Replace(":", "").ToString();
                LogName = LogName + "(" + sTime + ").log";
                string sPath = Parameters.g_sLogPath + LogName;

                StreamWriter streamWrite = null;
                streamWrite = new StreamWriter(sPath, false);
                streamWrite.WriteLine(LogContent);
                streamWrite.Close();        ////    一定要写这一行，不然写入不了
                bResult = true;
            }
            catch (Exception ex)
            {
                WriteLog("写入日志失败", ex.ToString());
                bResult = false;
            }

            return bResult;

        }

        /// <summary>
        /// 显示日志
        /// </summary>
        /// <param name="Path">日志文件夹路径</param>
        /// <returns></returns>
        public static bool ShowLog(frmShowLog frm)
        {
            bool bResult = false;
            try
            {
                DirectoryInfo dir = new DirectoryInfo(Parameters.g_sLogPath);
                FileInfo[] files = dir.GetFiles();
                FileAttributes fileAttributes;

                //// 遍历所有文件
                foreach (FileInfo file in files)
                {
                    if (file.Extension == ".log")
                    {
                        //// 忽略隐藏文件
                        fileAttributes = file.Attributes & FileAttributes.Hidden;
                        if (fileAttributes != FileAttributes.Hidden)
                        {
                            FileStream fs = new FileStream(file.FullName, FileMode.Open);
                            StreamReader reader = new StreamReader(fs, Encoding.UTF8);

                            //// 循环读取文件
                            string sSum = string.Empty;
                            while (true)
                            {
                                string str = reader.ReadLine();
                                if (str == null)
                                {
                                    break;
                                }
                                else if (str.Trim() == "")
                                {
                                    continue;
                                }
                                else
                                {
                                    //// 这里就是每行数据了  你可以进行处理 取出符合要求的行
                                    sSum = sSum + str;
                                }
                            }

                            frm.treeListShowLog.AppendNode(new object[] { file, sSum }, null);
                        }
                    }
                }

                bResult = true;
            }
            catch (Exception ex)
            {
                WriteLog("显示日志失败", ex.ToString());
                bResult = false;
            }
            return bResult;

        }

        /// <summary>
        /// 播放音乐
        /// </summary>
        /// <param name="Play">是否正在播放的标识</param>
        public static void PlayMusic()
        {


            //string sCmd = @"open ""E:\LIKE\AEDemo\AEDemo\bin\x86\bgm\安妮的仙境(annie's w'onderland).mp3"" alias temp_alias";

            //// ？？？？？怎么设置相对路径啊，格式总写不对
            //// ！！！！！格式问题搞定啦，sCmd就是命令
            //mciSendString(@"open ""E:\LIKE\AEDemo\AEDemo\bin\x86\bgm\安妮的仙境(annie's w'onderland).mp3"" alias temp_alias", null, 0, 0);

            try
            {
                string sCmd = "open " + '"' + Parameters.g_sBgmPath + "安妮的仙境(annie's w'onderland).mp3" + '"' + " alias temp_alias";
                mciSendString("close temp_alias", null, 0, 0);
                mciSendString(sCmd, null, 0, 0);
                if (Parameters.g_bPlayMusic == false)
                {
                    mciSendString("play temp_alias repeat", null, 0, 0);
                    Parameters.g_bPlayMusic = true;
                }
                else if (Parameters.g_bPlayMusic == true)
                {
                    mciSendString("close temp_alias ", null, 0, 0);
                    Parameters.g_bPlayMusic = false;
                }
            }
            catch (Exception ex)
            {

            }
        }

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
                CommFunction.WriteLog("显示图层属性失败", ex.ToString());
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
        /// 显示属性的详细信息
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

            try
            {
                pFeaLayer = Layer as IFeatureLayer;
                pFeaClass = pFeaLayer.FeatureClass;
                pFeaCursor = pFeaClass.Search(null, false);
                pFea = pFeaCursor.NextFeature();
                iFieldCount = pFeaClass.Fields.FieldCount;

                for (int i = 0; i < iFieldCount; i++)
                {
                    string sFieldName = pFeaClass.Fields.get_Field(i).Name;
                    dt.Columns.Add(sFieldName);
                }

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
                    dt.Rows.Add(dr);
                    pFea = pFeaCursor.NextFeature();
                }
                frm.gcFieldInfo.DataSource = dt;
                frm.gvFieldInfo.PopulateColumns();
                frm.gvFieldInfo.BestFitColumns();

                bResult = true;
            }
            catch (Exception ex)
            {
                WriteLog("显示字段详情失败：", ex.ToString());
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

        /// <summary>
        /// 选中属性表的要素时，闪烁并放大
        /// </summary>
        /// <param name="frm"></param>
        /// <param name="frmMain"></param>
        /// <returns></returns>
        public static bool FlashShape(frmPropertyDetails frm, frmFrame frmMain)
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
                //frmMain.axMapControl1.CenterAt(pPoint);

                // IGeometry pGeo = IGeometry(pFea);

                bResult = true;
            }
            catch (Exception ex)
            {
                WriteLog("闪烁显示要素失败：", ex.ToString());
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
