using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Geodatabase;

namespace AEDemo
{
    public partial class frmSQLQuery : DevExpress.XtraEditors.XtraForm
    {
        public frmSQLQuery()
        {
            InitializeComponent();
        }

        private DataTable Query(string sQueryKeyWords)
        {
            ILayer pLayer = null;
            IFeatureLayer pFeaLayer = null;
            IFeatureClass pFeaClass = null;
            IFields pFields = null;
            IField pField = null;
            IQueryFilter pQueryFilter = null;
            IFeatureCursor pFeaCursor = null;
            IFeature pFea = null;

            string sFieldValue = string.Empty;
            DataTable dt = new DataTable();
            DataRow dr = null;
            dt.Columns.Add("图层名");
            dt.Columns.Add("OID");
            dt.Columns.Add("字段值");

            try
            {
                //// 遍历图层
                for (int i = 0; i < Parameters.g_iLayerCount; i++)
                {
                    pLayer = Parameters.g_pMapControl.Map.get_Layer(i);
                    pFeaLayer = pLayer as IFeatureLayer;
                    pFeaClass = pFeaLayer.FeatureClass;
                    pFields = pFeaClass.Fields;
                    pQueryFilter = new QueryFilterClass();
                    string sWhereCause = string.Empty;

                    //// 设置模糊查询条件
                    for (int j = 0; j < pFields.FieldCount; j++)
                    {
                        pField = pFields.get_Field(j);
                        if (pField.Type != esriFieldType.esriFieldTypeString)
                        {
                            continue;
                        }

                        sWhereCause += string.Format("{0} LIKE '%{1}%' OR ", pField.Name, sQueryKeyWords);
                    }

                    sWhereCause = sWhereCause.TrimEnd();
                    sWhereCause = sWhereCause.Substring(0, sWhereCause.LastIndexOf("OR") - 1);
                    pQueryFilter.WhereClause = sWhereCause;
                    pFeaCursor = pFeaClass.Search(pQueryFilter, false);
                    pFea = pFeaCursor.NextFeature();

                    while (pFea != null)
                    {
                        dr = dt.NewRow();
                        dr["图层名"] = pLayer.Name;
                        dr["OID"] = pFea.OID;

                        //// 获得字段值
                        for (int k = 0; k < pFields.FieldCount; k++)
                        {
                            pField = pFields.get_Field(k);
                            if (pField.Type != esriFieldType.esriFieldTypeString)
                            {
                                continue;
                            }

                            sFieldValue = pFea.get_Value(k).ToString();

                            if (sFieldValue.Contains(memoEditFieldValue.Text))
                            {
                                dr["字段值"] = sFieldValue;
                                break;
                            }
                        }

                        dt.Rows.Add(dr);
                        pFea = pFeaCursor.NextFeature();
                    }
                }

                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }


        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            using (DevExpress.Utils.WaitDialogForm frm = new DevExpress.Utils.WaitDialogForm("正在查询……", "查询"))
            {
                gcResult.DataSource = Query(memoEditFieldValue.Text);
            }
        }


        private void cboQuery_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void cboQuery_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                string sQueryKeyWords = cboQuery.Text.ToString();

                //// 清空原来的值
                cboQuery.Properties.Items.Clear();

                if (!string.IsNullOrEmpty(sQueryKeyWords))
                {
                    DataTable dt = Query(sQueryKeyWords);

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        cboQuery.Properties.Items.Add(dt.Rows[i]["字段值"]);
                        
                    }

                    cboQuery.ShowPopup();
                }
            }
            catch (Exception ex)
            {

            }
        }



    }
}