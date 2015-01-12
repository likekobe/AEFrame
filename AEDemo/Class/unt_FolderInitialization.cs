using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace AEDemo
{
    /// <summary>
    /// 初始化创建文件夹
    /// </summary>
    class FolderInitialization
    {
        /// <summary>
        /// 判断文件夹是否存在
        /// </summary>
        public static void CreateFolder()
        {
            try
            {
                ////    创建背景音乐文件夹
                if (!Directory.Exists(Parameters.g_sBgmPath))
                {
                    Directory.CreateDirectory(Parameters.g_sBgmPath);
                }

                ////    创建报表文件夹
                if (!Directory.Exists(Parameters.g_sCellPath))
                {
                    Directory.CreateDirectory(Parameters.g_sCellPath);
                }

                ////    创建日志文件夹
                if (!Directory.Exists(Parameters.g_sLogPath))
                {
                    Directory.CreateDirectory(Parameters.g_sLogPath);
                }
            }
            catch (Exception ex)
            {
                LogOperation.WriteLog("文件夹创建失败", ex.ToString());   
            }
        }
    }
}
