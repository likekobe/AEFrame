using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Geodatabase;

namespace AEDemo
{
    /// <summary>
    /// 属性查询窗体
    /// </summary>
    public partial class frmPropertyQuery : Form
    {
        /// <summary>
        /// 字段名称
        /// </summary>
        private string m_sFieldName = string.Empty;

        /// <summary>
        /// memoEdit是否被点击
        /// </summary>
        private bool m_bIsClicked = false;

        /// <summary>
        /// 构造函数
        /// </summary>
        public frmPropertyQuery()
        {
            InitializeComponent();
            CboLoadLayer();
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
                    cboLayer.Properties.Items.Add(pLayer.Name);
                }
            }
            catch (Exception ex)
            {
                LogOperation.WriteLog("属性查询时，ComboBox中加载图层名称失败", ex.ToString());
            }
        }

        /// <summary>
        /// 所选图层变换时触发该事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboLayer_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int iLayerIndex = cboLayer.SelectedIndex;
                ILayer pLayer = Parameters.g_pMapControl.get_Layer(iLayerIndex);
                //m_pLayer = pLayer;
                labelLayerName.Text = pLayer.Name;
                listFields.Items.Clear();
                IFeatureLayer pFeaLayer = pLayer as IFeatureLayer;
                IFeatureClass pFeaClass = pFeaLayer.FeatureClass;

                for (int i = 0; i < pFeaClass.Fields.FieldCount; i++)
                {
                    listFields.Items.Add(pFeaClass.Fields.get_Field(i).Name);
                }
            }
            catch (Exception ex)
            {
                LogOperation.WriteLog("图层字段添加到List列表失败", ex.ToString());
            }
        }

        /// <summary>
        /// 获取字段值
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGetFieldValue_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(m_sFieldName))
                {
                    listFieldValue.Items.Clear();
                    int iLayerIndex = cboLayer.SelectedIndex;
                    ILayer pLayer = Parameters.g_pMapControl.get_Layer(iLayerIndex);
                    listFieldValue.DataSource = LayerOperation.GetFieldValue(pLayer, m_sFieldName);
                }
            }
            catch(Exception ex)
            {
            
            }
        }

        /// <summary>
        /// 字段列表选中值变化事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listFields_SelectedValueChanged(object sender, EventArgs e)
        {
            if (listFields.Items.Count > 0)
            {
                m_sFieldName = listFields.SelectedValue.ToString();
            }
        }

        /// <summary>
        /// 插入字符串
        /// </summary>
        /// <param name="sText"></param>
        private void InsertText(string sText)
        {
            if (!string.IsNullOrEmpty(memoEditWhereExpress.Text.ToString()))
            {
                if (m_bIsClicked)
                {
                    int iStart = memoEditWhereExpress.SelectionStart;

                    int iEnd = memoEditWhereExpress.Text.Length;
                    string sStart = memoEditWhereExpress.Text.Substring(0, iStart);
                    string sEnd = memoEditWhereExpress.Text.Substring(iStart);

                    memoEditWhereExpress.Text = sStart + sText + sEnd;
                }
                else
                {
                    memoEditWhereExpress.Text = memoEditWhereExpress.Text + sText;
                }

            }
            else
            {
                memoEditWhereExpress.Text = sText;
            }
        }

        private void listFields_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string sField = listFields.SelectedValue.ToString();
            InsertText(sField);
        }

        private void listFieldValue_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string sFieldValue = listFieldValue.SelectedValue.ToString();

            InsertText(sFieldValue);

        }

        #region 查询条件能用到的符号
        private void btnEqual_Click(object sender, EventArgs e)
        {
            string sSymbol = "=";
            InsertText(sSymbol);

        }

        private void btnNotEqual_Click(object sender, EventArgs e)
        {
            string sSymbol = "<>";
            InsertText(sSymbol);
        }

        private void btnLike_Click(object sender, EventArgs e)
        {
            string sSymbol = "Like";
            InsertText(sSymbol);
        }

        private void btnIs_Click(object sender, EventArgs e)
        {
            string sSymbol = "Is";
            InsertText(sSymbol);
        }

        private void btnQuestion_Click(object sender, EventArgs e)
        {
            string sSymbol = "?";
            InsertText(sSymbol);
        }

        private void btnMorethan_Click(object sender, EventArgs e)
        {
            string sSymbol = ">";
            InsertText(sSymbol);
        }

        private void btnMorethanOrEqual_Click(object sender, EventArgs e)
        {
            string sSymbol = ">=";
            InsertText(sSymbol);
        }

        private void btnAnd_Click(object sender, EventArgs e)
        {
            string sSymbol = "And";
            InsertText(sSymbol);
        }

        private void btnBrackets_Click(object sender, EventArgs e)
        {
            string sSymbol = "()";
            InsertText(sSymbol);
        }

        private void btnStar_Click(object sender, EventArgs e)
        {
            string sSymbol = "*";
            InsertText(sSymbol);
        }

        private void btnLessthan_Click(object sender, EventArgs e)
        {
            string sSymbol = "<";
            InsertText(sSymbol);
        }

        private void btnLessthanOrEqual_Click(object sender, EventArgs e)
        {
            string sSymbol = "<=";
            InsertText(sSymbol);
        }

        private void btnOr_Click(object sender, EventArgs e)
        {
            string sSymbol = "Or";
            InsertText(sSymbol);
        }

        private void btnNot_Click(object sender, EventArgs e)
        {
            string sSymbol = "Not";
            InsertText(sSymbol);
        }
        #endregion

        private void btnClear_Click(object sender, EventArgs e)
        {
            memoEditWhereExpress.Text = string.Empty;
        }

        #region  判断memoEdit是否被选中
        private void memoEditWhereExpress_MouseClick(object sender, MouseEventArgs e)
        {
            m_bIsClicked = true;
        }

        private void memoEditWhereExpress_Leave(object sender, EventArgs e)
        {
            m_bIsClicked = false;
        }
        #endregion

        private void btnQuery_Click(object sender, EventArgs e)
        {
            try
            {
                gcQuery.DataSource = null;
                int iLayerIndex = cboLayer.SelectedIndex;
                ILayer pLayer = Parameters.g_pMapControl.get_Layer(iLayerIndex);
                string sWhereExpress = memoEditWhereExpress.Text;
                if (string.IsNullOrEmpty(sWhereExpress))
                {
                    sWhereExpress = null;
                }
                DataTable dt = LayerOperation.FeatureQuery(pLayer, sWhereExpress);

                if (dt != null && dt.Rows.Count > 0)
                {
                    gcQuery.DataSource = dt;
                    gvQuery.PopulateColumns();
                    gvQuery.BestFitColumns();
                }
                else
                {
                    GtMap.GxDlgHelper.DevMessageBox.ShowInformation("未查找到要素，请修改SQL语句。");
                }
            }
            catch(Exception ex)
            {
            
            }
        }

    }
}
