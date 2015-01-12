using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace AEDemo
{
    /// <summary>
    /// 播放音乐
    /// </summary>
    class MusicOperation
    {
        /// <summary>
        /// mciSendString用于播放音乐
        /// </summary>
        /// <param name="lpstrCommand">要发送的命令字符串。字符串结构是:[命令][设备别名][命令参数]</param>
        /// <param name="lpstrReturnString">返回信息的缓冲区,为一指定了大小的字符串变量.</param>
        /// <param name="uReturnLength">缓冲区的大小,就是字符变量的长度.</param>
        /// <param name="hWndCallback">回调方式，一般设为零</param>
        /// <returns></returns>
        [DllImport("winmm.dll")]
        private static extern uint mciSendString(string lpstrCommand, string lpstrReturnString, uint uReturnLength, uint hWndCallback);

        /// <summary>
        /// 播放音乐
        /// </summary>
        /// <param name="Play">是否正在播放的标识</param>
        public static void PlayMusic()
        {


            //string sCmd = @"open ""E:\LIKE\AEDemo\AEDemo\bin\x86\bgm\安妮的仙境(annie's w'onderland).mp3"" alias temp_alias";

            //// ？？？？？怎么设置相对路径啊，格式总写不对
            //// ！！！！！格式问题搞定啦，sCmd就是命令
            //mciSendString(@"open ""E:\LIKE\AEDemo\AEDemo\bin\x86\bgm\安妮的仙境(annie's w'onderland).mp3"" alias temp_alias", null, 0, 0);

            try
            {
                string sCmd = "open " + '"' + Parameters.g_sBgmPath + "安妮的仙境(annie's w'onderland).mp3" + '"' + " alias temp_alias";
                mciSendString("close temp_alias", null, 0, 0);
                mciSendString(sCmd, null, 0, 0);

                if (Parameters.g_bPlayMusic == false)
                {
                    mciSendString("play temp_alias repeat", null, 0, 0);
                    Parameters.g_bPlayMusic = true;
                }
                else if (Parameters.g_bPlayMusic == true)
                {
                    mciSendString("close temp_alias ", null, 0, 0);
                    Parameters.g_bPlayMusic = false;
                }
            }
            catch (Exception ex)
            {
                LogOperation.WriteLog("播放音乐失败", ex.ToString());
            }
        }

    }
}
