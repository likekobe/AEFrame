using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;

namespace AEDemo
{
    public partial class frmCellBase : Form
    {
        #region 类成员变量
        /// <summary>
        /// 数据库连接
        /// </summary>
        public IDbConnection m_DbConnection;

        /// <summary>
        /// 报表模板路径
        /// </summary>
        public string m_sCellPath = string.Empty;

        /// <summary>
        /// 表名
        /// </summary>
        public string m_sTableName = string.Empty;

        /// <summary>
        /// 主键名
        /// </summary>
        public string m_sKeyName = string.Empty;

        /// <summary>
        /// 开发区代码
        /// </summary>
        public string m_sKFQDM = string.Empty;

        /// <summary>
        /// 开发区名称
        /// </summary>
        public string m_sKFQMC = string.Empty;
        #endregion

        public frmCellBase()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 加载窗体
        /// </summary>
        public void LoadForm()
        {
            axCell.OpenFile(m_sCellPath, "");
            SetCellControls(this);

            ////    设置在 Cell 组件/插件窗口的背景颜色
            axCell.WndBkColor = 16777215;

            ////    设置无边框
            axCell.Border = 0;

        }

        /// <summary>
        /// 设置Cell中控件的位置数据
        /// </summary>
        /// <param name="CellPath"></param>
        /// <param name="axCell"></param>
        /// <param name="controlcol"></param>
        public void SetCellControls(Control controlcol)
        {
            try
            {
                axCell.Login("国图报表管理系统", "11100101750", "1000-0653-0161-3005");
                axCell.LocalizeControl(2052);

                axCell.ShowGridLine(0, 0);       ////   设置不显示表格线
                axCell.ShowTopLabel(0, 0);       ////   设置不显示列标
                axCell.ShowSideLabel(0, 0);      ////   设置不显示行标

                axCell.WorkbookReadonly = true;
                axCell.ShowSheetLabel(0, 0);     ////   显示页签 
                axCell.ClearSelection();
                axCell.SetSelectMode(0, 0);

                ////    遍历控件，设置控件无边框
                foreach (Control control in controlcol.Controls)
                {
                    if (!string.IsNullOrEmpty(control.Name))
                    {
                        if (control is MemoEdit)
                        {
                            //(control as MemoEdit).BorderStyle = BorderStyles.NoBorder;
                        }
                        else if (control is TextEdit)
                        {
                            (control as TextEdit).BorderStyle = BorderStyles.NoBorder;
                            (control as TextEdit).Properties.AutoHeight = false;
                        }
                        else if (control is DateEdit)
                        {
                            (control as DateEdit).BorderStyle = BorderStyles.NoBorder;
                            (control as DateEdit).Properties.AutoHeight = false;
                        }
                        else if (control is ComboBoxEdit)
                        {
                            (control as ComboBoxEdit).BorderStyle = BorderStyles.NoBorder;
                            (control as ComboBoxEdit).Properties.AutoHeight = false;
                        }
                        else if (control is CheckedComboBoxEdit)
                        {
                            (control as CheckedComboBoxEdit).BorderStyle = BorderStyles.NoBorder;
                            (control as CheckedComboBoxEdit).Properties.AutoHeight = false;
                        }
                        else if (control is PictureEdit)
                        {
                            (control as PictureEdit).BorderStyle = BorderStyles.NoBorder;
                            (control as PictureEdit).Properties.AutoHeight = false;
                        }
                        else if (control is CheckEdit)
                        {
                            (control as CheckEdit).BorderStyle = BorderStyles.NoBorder;
                            (control as CheckEdit).Properties.AutoHeight = false;
                        }
                        else if (control is PanelControl)
                        {
                            (control as PanelControl).BorderStyle = BorderStyles.NoBorder;
                        }

                        SetControlStyle(control);
                    }
                }

            }
            catch (System.Exception ex)
            {

            }
        }

        /// <summary>
        /// 设置控件的样式，宽度、高度、位置
        /// </summary>
        /// <param name="control"></param>
        private void SetControlStyle(Control control)
        {
            int iCol = -1, iRow = -1, iSheet = -1;

            if (axCell.GetCellVar(control.Name, ref iCol, ref iRow, ref iSheet))
            {
                int iLeft = -1, iTop = -1, iRight = -1, iBottom = -1;

                axCell.GetCellRect(iCol, iRow, ref iLeft, ref iTop, ref iRight, ref iBottom, true, false);
                control.Left = axCell.Left + iLeft + 2;
                control.Top = axCell.Top + iTop + 2;
                control.Width = iRight - iLeft - 2;
                control.Height = iBottom - iTop - 2;
            }
        }
    }
}