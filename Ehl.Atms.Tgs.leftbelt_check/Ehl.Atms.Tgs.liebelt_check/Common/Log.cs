using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Ehl.Atms.Tgs.lifebelt_check
{
    public class Log
    {
        public static object objLock = new object();
        /// <summary>
        /// 写日志
        /// </summary>
        /// <param name="msg"></param>
        public static void WriteLog(string msg)
        {
            string strRootPath = AppDomain.CurrentDomain.BaseDirectory; //应用程序目录
            string strLogPath = Path.Combine(strRootPath, "Log"); //日志目录
            if (!Directory.Exists(strLogPath))
            {
                Directory.CreateDirectory(strLogPath);
            }
            string strLogFileName = Path.Combine(strLogPath, "日志_" + DateTime.Now.ToString("yyyyMMdd") + ".log"); //日志文件名称
            lock (objLock)
            {

                FileInfo file = new FileInfo(strLogFileName);
                StreamWriter sw = null;
                try
                {
                    if (!file.Exists)
                        sw = file.CreateText();
                    else
                        sw = file.AppendText();
                    sw.WriteLine("{0} {1}", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss fff"), msg);
                }
                catch
                { }
                finally
                {
                    if (sw != null)
                        sw.Close();
                }
            }
        }
    }
}
