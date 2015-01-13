using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;


namespace AEDemo
{
    public partial class XtraForm1 : DevExpress.XtraEditors.XtraForm
    {
        public XtraForm1()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog SaveFileDlg = new SaveFileDialog();
                SaveFileDlg.Filter = "Excel(*.xlsx)|*.xlsx";
                //string  sTime = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                SaveFileDlg.FileName = "日志记录";
                object missing = System.Reflection.Missing.Value;

                if (SaveFileDlg.ShowDialog() == DialogResult.OK)
                {
                    //if (!SaveFileDlg.FileName.Substring(SaveFileDlg.FileName.Length - 4, 4).Equals(".xls"))
                    //{
                    //    SaveFileDlg.FileName = SaveFileDlg.FileName + ".xls";
                    //}

                    Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
                    Microsoft.Office.Interop.Excel._Workbook myWorkbook;
                    Microsoft.Office.Interop.Excel._Worksheet myWorksheet;
                    excel.Application.Workbooks.Add(true);
                    myWorkbook = excel.ActiveWorkbook;
                    myWorksheet = (Microsoft.Office.Interop.Excel._Worksheet)myWorkbook.ActiveSheet;
                    myWorksheet.Cells[1, 1] = "11";
                    //if (m_dt != null && m_dt.Rows.Count > 0)
                    //{
                    //    //GtMap.GxOAHelper.Office2003.Excel.WriteDataTableToExcel(m_dt, worksheet, 0, m_dt.Rows.Count + 1);

                    //    for (int i = 1; i <= m_dt.Columns.Count; i++)
                    //    {
                    //        myWorksheet.Cells[1, i] = m_dt.Columns[i].ColumnName;
                    //    }

                    //    for (int j = 0; j < m_dt.Rows.Count; j++)
                    //    {
                    //        for (int k = 0; k < m_dt.Columns.Count; k++)
                    //        {
                    //            myWorksheet.Cells[j + 2, k + 1] = m_dt.Rows[j][k];
                    //        }
                    //    }

                    //    myWorkbook.SaveCopyAs(SaveFileDlg.FileName);
                    //    myWorkbook.Close(false, missing, missing);
                    //    excel.Quit();
                    //}

                    myWorkbook.SaveCopyAs(SaveFileDlg.FileName);
                    myWorkbook.Close(false, missing, missing);
                    excel.Quit();

                }


            }
            catch (Exception ex)
            {
                //GtMap.GxComHelper.LogWriter.WriteLog("日志导出Excel失败", ex);
            }
        }
    }
}