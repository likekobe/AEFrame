using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ESRI.ArcGIS.Controls;
using ESRI.ArcGIS.Carto;
using System.Reflection;
using ESRI.ArcGIS.Geometry;

namespace AEDemo
{
    /// <summary>
    /// 系统参数
    /// </summary>
    class Parameters
    {

        /// <summary>
        /// 每页最大显示记录数
        /// </summary>
        public  const int g_iMaxRows = 30;

        /// <summary>
        /// OID字段的名字
        /// </summary>
        public static string g_sOIDName
        {
            get;
            set;
        }

        /// <summary>
        /// 当前显示第几页
        /// </summary>
        public static int g_iCurrentPage
        {
            get;
            set;
        }

        /// <summary>
        /// 总页数
        /// </summary>
        public static int g_iSumPages
        {
            get;
            set;
        }

        /// <summary>
        /// 记录总条数
        /// </summary>
        public static int g_iSumRecords
        {
            get;
            set;
        }

        /// <summary>
        /// 音乐播放状态标识符
        /// </summary>
        public static bool g_bPlayMusic = false;

        /// <summary>
        /// 地图控件
        /// </summary>
        public static IMapControl2 g_pMapControl
        {
            get;
            set;
        }

        /// <summary>
        /// 地图文档
        /// </summary>
        public static IMapDocument g_pMapDoc
        {
            get;
            set;
        }
        /// <summary>
        /// 图层树
        /// </summary>
        public static ITOCControl g_pTOCControl
        {
            get;
            set;
        }

        /// <summary>
        /// 拖动的图层
        /// </summary>
        public static ILayer g_pMoveLayer
        {
            get;
            set;
        }

        /// <summary>
        /// 鼠标点坐标下的图层
        /// </summary>
        public static ILayer g_pSelectedLayer
        {
            get;
            set;
        }

        /// <summary>
        /// 目标图层索引
        /// </summary>
        public static int g_iToIndex
        {
            get;
            set;
        }
   
        /// <summary>
        /// 地图文档的路径
        /// </summary>
        public static string g_sDocPath
        {
            get;
            set;
        }
    

        /// <summary>
        /// 图层个数
        /// </summary>
        public static int g_iLayerCount
        {
            get;
            set;
        }
 
        /// <summary>
        /// exe可执行文件路径
        /// </summary>
        public static string g_sProjectPath
        {
            get
            {
                return Assembly.GetExecutingAssembly().Location;
            }
        }

        /// <summary>
        /// 日志文件夹路径
        /// </summary>
        public static string g_sLogPath
        {
            get
            {
                return Assembly.GetExecutingAssembly().Location + "\\..\\..\\log\\";
            }
        }

        /// <summary>
        /// Config文件路径
        /// </summary>
        public static string g_sConfigPath
        {
            get
            {
                return Assembly.GetExecutingAssembly().Location + "\\..\\..\\config.ini";
            }
        }

        /// <summary>
        /// 背景音乐文件夹路径
        /// </summary>
        public static string g_sBgmPath
        {
            get
            {
                return Assembly.GetExecutingAssembly().Location + "\\..\\..\\bgm\\";
            }
        }

        /// <summary>
        /// 报表文件夹路径
        /// </summary>
        public static string g_sCellPath
        {
            get
            {
                return Assembly.GetExecutingAssembly().Location + "\\..\\..\\rep\\";
            }
        }

        /// <summary>
        /// 系统时间
        /// </summary>
        public static DateTime g_DateTime
        {
            get
            {
                return DateTime.Now;
            }
        }

    }
}
