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
    public partial class frmShowLog : DevExpress.XtraEditors.XtraForm
    {
        public frmShowLog()
        {
            InitializeComponent();
            CommFunction.ShowLog(this);
        }
    }
}