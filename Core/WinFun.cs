/*!
 * Sam.Cheng Pinyin Helper
 * http://300830.com
 *
 * Copyright 2020 Sam.Cheng
 * Released under the MIT license
 *
 * Date: 2020-04-24
 */
namespace SamCheng.PinyinHelper.Core
{
    #region _Spaces
    using System;
    using System.Text;
    using System.IO;
    using System.Windows.Forms;
    #endregion

    public class WinFun
    {
        #region 文本操作
        /// <summary>
        /// 写入文本文件 (追加)
        /// </summary>
        /// <param name="txtPath"></param>
        /// <param name="txtContent"></param>
        /// <returns></returns>
        public static bool AppendWriteToFile(string txtPath, string txtContent)
        {
            try
            {
                if (File.Exists(txtPath))
                {
                    using (StreamWriter sw = File.AppendText(txtPath))
                    {
                        sw.WriteLine(txtContent);
                        sw.Flush();
                        sw.Close();
                    }
                }
                else
                {
                    using (StreamWriter sw = File.CreateText(txtPath))
                    {
                        sw.WriteLine(txtContent);
                        sw.Flush();
                        sw.Close();
                    }
                }
                return true;
            }
            catch { return false; }
        }

        /// <summary>
        /// 写入日志（文本）
        /// </summary>
        /// <param name="LogType"></param>
        /// <param name="LogTitle"></param>
        /// <param name="LogContent"></param>
        public static void WriteAppendLogs(string LogType, bool IsTime, string LogTitle, string LogContent)
        {
            var SavePath = Application.StartupPath + $@"\Logs\";
            if (!Directory.Exists(SavePath))
                Directory.CreateDirectory(SavePath);

            AppendWriteToFile(SavePath + LogType + ".txt", 
                (IsTime ? DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff") + "：" : "") + 
                (LogTitle.Length > 0 ? LogTitle + "：" : "") + 
                LogContent);
        }

        /// <summary>
        /// 读取文本文件
        /// </summary>
        /// <param name="PathFile"></param>
        /// <returns></returns>
        public static string ReadFileContent(string PathFile)
        {
            return File.Exists(PathFile) ? File.ReadAllText(PathFile, Encoding.UTF8) : "";
        }
        #endregion
    }
}
