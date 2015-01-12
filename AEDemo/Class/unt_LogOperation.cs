using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace AEDemo
{
    /// <summary>
    /// 日志的写入、读取
    /// </summary>
    class LogOperation
    {
        /// <summary>
        /// 写入日志文件
        /// </summary>
        /// <param name="LogName">日志名</param>
        /// <param name="LogContent">日志内容</param>
        /// <returns></returns>
        public static bool WriteLog(string LogName, string LogContent)
        {
            bool bResult = false;
            try
            {
                //DateTime dateTime = System.DateTime.Now;
                string sTime = Parameters.g_DateTime.GetDateTimeFormats('s')[0].ToString();
                sTime = sTime.Replace(":", "").ToString();
                LogName = LogName + "(" + sTime + ").log";
                string sPath = Parameters.g_sLogPath + LogName;

                StreamWriter streamWrite = null;
                streamWrite = new StreamWriter(sPath, false);
                streamWrite.WriteLine(LogContent);
                streamWrite.Close();        ////    一定要写这一行，不然写入不了
                bResult = true;
            }
            catch (Exception ex)
            {
                WriteLog("写入日志失败", ex.ToString());
                bResult = false;
            }

            return bResult;
        }

        /// <summary>
        /// 显示日志
        /// </summary>
        /// <param name="Path">日志文件夹路径</param>
        /// <returns></returns>
        public static bool ShowLog(frmShowLog frm)
        {
            bool bResult = false;
            try
            {
                DirectoryInfo dir = new DirectoryInfo(Parameters.g_sLogPath);
                FileInfo[] files = dir.GetFiles();
                FileAttributes fileAttributes;

                //// 遍历所有文件
                foreach (FileInfo file in files)
                {
                    if (file.Extension == ".log")
                    {
                        //// 忽略隐藏文件
                        fileAttributes = file.Attributes & FileAttributes.Hidden;
                        if (fileAttributes != FileAttributes.Hidden)
                        {
                            FileStream fs = new FileStream(file.FullName, FileMode.Open);
                            StreamReader reader = new StreamReader(fs, Encoding.UTF8);

                            //// 循环读取文件
                            string sSum = string.Empty;
                            while (true)
                            {
                                string str = reader.ReadLine();
                                if (str == null)
                                {
                                    break;
                                }
                                else if (str.Trim() == "")
                                {
                                    continue;
                                }
                                else
                                {
                                    //// 这里就是每行数据了  你可以进行处理 取出符合要求的行
                                    sSum = sSum + str;
                                }
                            }

                            frm.treeListShowLog.AppendNode(new object[] { file, sSum }, null);
                        }
                    }
                }

                bResult = true;
            }
            catch (Exception ex)
            {
                WriteLog("显示日志失败", ex.ToString());
                bResult = false;
            }
            return bResult;

        }
    }
}
