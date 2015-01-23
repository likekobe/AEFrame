using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ESRI.ArcGIS.Carto;
using System.IO;

namespace AEDemo
{
    public partial class frmAddInConfig : DevExpress.XtraEditors.XtraForm
    {
        public frmAddInConfig()
        {
            InitializeComponent();
            LoadLayer();
        }

        /// <summary>
        /// 加载图层名称
        /// </summary>
        private void LoadLayer()
        {
            try
            {
                cboLayer.Properties.Items.Clear();
                listBoxUnSelected.Items.Clear();
                listBoxSelected.Items.Clear();

                int iLayerCount = Parameters.g_pMapControl.LayerCount;

                for (int i = 0; i < iLayerCount; i++)
                {
                    ILayer pLayer = Parameters.g_pMapControl.get_Layer(i);
                    cboLayer.Properties.Items.Add(pLayer.Name);
                    listBoxUnSelected.Items.Add(pLayer.Name);
                }

            }
            catch (Exception ex)
            {
                LogOperation.WriteLog("修改配置文件时，加载图层名称失败", ex.ToString());
            }
        }

        private void listBoxUnSelected_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            listBoxSelected.Items.Add(listBoxUnSelected.SelectedItem);
            listBoxUnSelected.Items.Remove(listBoxUnSelected.SelectedItem);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string sLayerName = cboLayer.SelectedText;
            //string sLayerName = "图层测试";
            if (string.IsNullOrEmpty(sLayerName))
            {
                GtMap.GxDlgHelper.DevMessageBox.ShowInformation("请先选择图层。");
            }
            else
            {
                sLayerName = "[" + sLayerName + "LayerInfo]";
                List<string> listLayerName = new List<string> { };

                for (int i = 0; i < listBoxSelected.Items.Count; i++)
                {
                    listLayerName.Add(listBoxSelected.Items[i].ToString());
                }

                if (!IsCover(sLayerName))
                {
                    if (AddInConfig(sLayerName, listLayerName))
                    {
                        GtMap.GxDlgHelper.DevMessageBox.ShowInformation("配置图层添加成功。");
                    }
                    else
                    {
                        GtMap.GxDlgHelper.DevMessageBox.ShowInformation("配置图层添加失败。");
                    }
                }
                else
                {
                    if (NewAddInConfig(sLayerName, listLayerName))
                    {
                        GtMap.GxDlgHelper.DevMessageBox.ShowInformation("配置图层添加成功。");
                    }
                    else
                    {
                        GtMap.GxDlgHelper.DevMessageBox.ShowInformation("配置图层添加失败。");
                    }
                }
            }
        }

        /// <summary>
        /// 是否已经存在图层名
        /// </summary>
        /// <param name="LayerName"></param>
        /// <returns></returns>
        private bool IsCover(string LayerName)
        {
            bool bResult = false;
            try
            {
                //// 读取配置文件中所有行
                string[] sAllLines = File.ReadAllLines(Parameters.g_sConfigPath);

                for (int i = 0; i < sAllLines.Length; i++)
                {
                    if (sAllLines[i].StartsWith("[") && sAllLines[i].Trim().Equals(LayerName))
                    {
                        bResult = true;
                        break;
                    }
                }

            }
            catch
            {
                bResult = false;
            }
            return bResult;

        }

        /// <summary>
        /// 添加到配置文件
        /// </summary>
        /// <param name="LayerName">图层名</param>
        /// <param name="ListLayerName">配置图层</param>
        private bool AddInConfig(string LayerName, List<string> ListLayerName)
        {
            bool bResult = false;
            try
            {
                StreamWriter streamWriter = new StreamWriter(Parameters.g_sConfigPath, true);
                streamWriter.WriteLine(LayerName);

                for (int i = 0; i < ListLayerName.Count; i++)
                {
                    string sValue = "LayerName[" + i + "]=" + ListLayerName[i];
                    streamWriter.WriteLine(sValue);
                }

                streamWriter.Close();
                bResult = true;
            }
            catch (Exception ex)
            {
                LogOperation.WriteLog("添加到配置文件失败", ex.ToString());
                bResult = false;
            }
            return bResult;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="LayerName">图层名</param>
        /// <param name="ListLayerName">所有的配置图层</param>
        private bool NewAddInConfig(string LayerName, List<string> ListLayerName)
        {
            bool bResult = false;
            try
            {
                //// 读取配置文件中所有行
                string[] sAllLines = File.ReadAllLines(Parameters.g_sConfigPath);

                List<string> listAllLines = new List<string> { };

                bool bStart = false;
                int iStart = 0;
                int iEnd = -1;

                for (int i = 0; i < sAllLines.Length; i++)
                {
                    if (bStart && sAllLines[i].StartsWith("["))
                    {
                        iEnd = i;
                        break;
                    }

                    if (sAllLines[i].StartsWith("[") && sAllLines[i].Trim().Equals(LayerName))
                    {
                        iStart = i;
                        bStart = true;
                    }

                    listAllLines.Add(sAllLines[i]);
                }

                if(iEnd==-1)
                {
                    iEnd = sAllLines.Length;
                }

                //// 移除
                listAllLines.RemoveRange(iStart + 1, iEnd - iStart-1);

                for (int i = 0; i < ListLayerName.Count; i++)
                {
                    string sValue = "LayerName[" + i + "]=" + ListLayerName[i];
                    listAllLines.Add(sValue);
                }

                for (int i = iEnd; i < sAllLines.Length; i++)
                {
                    listAllLines.Add(sAllLines[i]);
                }

                File.WriteAllLines(Parameters.g_sConfigPath, listAllLines.ToArray());
                bResult = true;
            }
            catch (Exception ex)
            {
                LogOperation.WriteLog("添加到配置文件失败", ex.ToString());
                bResult = false;
            }

            return bResult;
        }

        /// <summary>
        /// 读取图层配置信息
        /// </summary>
        /// <param name="LayerName"></param>
        /// <returns>返回图层名列表</returns>
        private List<string> ReadLayerInfo(string LayerName)
        {
            List<string> listLayerInfo = null;

            try
            {
                LayerName = "[" + LayerName + "LayerInfo]";
                //// 读取配置文件中所有行
                string[] sAllLines = File.ReadAllLines(Parameters.g_sConfigPath, UnicodeEncoding.GetEncoding("GB2312"));
                bool bStart = false;
                int iStart = 0;
                int iEnd = -1;

                //// 获得图层配置信息的起始行、终止行号
                for (int i = 0; i < sAllLines.Length; i++)
                {
                    if (bStart && sAllLines[i].StartsWith("["))
                    {
                        iEnd = i;
                        break;
                    }

                    if (sAllLines[i].StartsWith("[") && sAllLines[i].Trim().Equals(LayerName))
                    {
                        iStart = i;
                        bStart = true;
                    }
                }

                if (iEnd == -1)
                {
                    iEnd = sAllLines.Length;
                }

                //// 配置图层信息存入List
                listLayerInfo = new List<string> { };
                for (int i = iStart + 1; i < iEnd; i++)
                {
                    listLayerInfo.Add(sAllLines[i]);
                }

            }
            catch
            {
                listLayerInfo = null;
            }

            return listLayerInfo;
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            ReadLayerInfo("dlzx");
        }

    }
}