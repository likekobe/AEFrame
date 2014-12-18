using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraNavBar;
using DevExpress.XtraTab;
using System.IO;

namespace AEDemo
{
    public partial class frmLoadReport : DevExpress.XtraEditors.XtraForm
    {
        public frmLoadReport()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 打开选中报表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void navBarControl1_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            LogicLoadReport.OpenSelectedCell(sender, tabControlReport);
        }

        /// <summary>
        /// 关闭选中页面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabControlReport_CloseButtonClick(object sender, EventArgs e)
        {
            LogicLoadReport.CloseSelectedTabPage(tabControlReport);
        }
    }
}