using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraTab;
using System.Windows.Forms;
using DevExpress.XtraNavBar;
using System.IO;

namespace AEDemo
{
    class LogicLoadReport
    {
        /// <summary>
        /// 打开选中的报表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="tabControlReport">tab控件</param>
        public static void OpenSelectedCell(Object sender, XtraTabControl tabControlReport)
        {
            try
            {
                NavBarItem item = sender as NavBarItem;
                string sFormName = item.Name.Substring(2);
                frmCellBase frmCell = new frmCellBase();

                ////    点击的Item名称 若在现有已打开窗体中存在，则跳转到已打开Tabpage；不再打开新窗体
                for (int i = 0; i < tabControlReport.TabPages.Count; i++)
                {
                    XtraTabPage tab = tabControlReport.TabPages[i];
                    if (tab.Name == sFormName)
                    {
                        tabControlReport.SelectedTabPage = tab;
                        return;
                    }
                }

                string sCellName = string.Empty;
                string sCellPath = string.Empty;

                ////    NavBarItem的Tag存储报表模板名称
                sCellName = item.Tag.ToString();
                sCellPath = Parameters.g_sCellPath + sCellName + ".cll";

                ////    判断当前点击的报表 是否存在，不存在则给出提示
                if (!File.Exists(sCellPath))
                {
                    MessageBox.Show("报表模板 " + sCellName + "不存在。");
                }
                else
                {
                    frmCell.m_sCellPath = sCellPath;

                    XtraTabPage tabNew = new XtraTabPage();
                    tabNew.Name = sFormName;
                    tabNew.Text = sFormName.Replace("frmLoad", "") + "      ";

                    frmCell.TopLevel = false;
                    frmCell.FormBorderStyle = FormBorderStyle.None;

                    frmCell.Dock = DockStyle.Fill;
                    tabNew.Controls.Add(frmCell);

                    tabControlReport.TabPages.Add(tabNew);
                    tabControlReport.SelectedTabPage = tabNew;
                    frmCell.Show();

                    frmCell.LoadForm();
                }
            }
            catch (Exception ex)
            {

            }

        }

        /// <summary>
        /// 关闭选中的TabPage
        /// </summary>
        /// <param name="tabControl">tab控件</param>
        public static void CloseSelectedTabPage(XtraTabControl tabControlReport)
        {
            try
            {
                ////    当前选中页面
                XtraTabPage tabCurrent = tabControlReport.SelectedTabPage;

                if (tabCurrent != null)
                {
                    Form frm = null;

                    if (tabCurrent.Controls[0] is Panel)
                    {
                        frm = tabCurrent.Controls[0].Controls[0] as Form;
                    }
                    else
                    {
                        frm = tabCurrent.Controls[0] as Form;
                    }

                    if (frm != null)
                    {
                        frm.Close();
                    }

                    tabControlReport.TabPages.Remove(tabCurrent);
                }
            }
            catch (Exception ex)
            {

            }
        }

    }
}
