using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml;
using System.Net;

namespace Ehl.Atms.Tgs.lifebelt_check
{
    public class Common
    {
        private static string path = AppDomain.CurrentDomain.BaseDirectory;
        /// <summary>
        /// 删除日志文件
        /// </summary>
        public static void DeleteLogFile()
        {
            string logPath = path + @"\Log";
            if (Directory.Exists(logPath))
                Directory.Delete(logPath, true);
        }

        /// <summary>
        /// 保存违法信息配置
        /// </summary>
        /// <param name="model"></param>
        /*public static void SaveConfig(Config config)
        {
            string strFileName = Path.Combine(path, "Config/Config.xml"); //日志文件名称
            XmlDocument xmldoc = new XmlDocument();
            xmldoc.Load(strFileName);
            //先通过Wfxwms 来定位配置信息的位置，然后修改
            XmlNodeList xmlNodeList = xmldoc.SelectNodes("Config/Wfxws/Wfxw");
            foreach (XmlNode item in xmlNodeList)
            {
                string wfxwms = item.SelectSingleNode("Wfxwms").InnerText;
                if (wfxwms == config.Wfxwms)
                {
                    item.SelectSingleNode("Code").InnerText = config.Code;
                    item.SelectSingleNode("Wfxwms").InnerText = config.Wfxwms;
                }
            }
            xmldoc.Save(strFileName);

            //config.Code = model.OneAlarmMusic;
            //config.WriterLog = model.WriterLog;
        }*/

        /// <summary>
        /// 保存执勤民警配置
        /// </summary>
        /// <param name="name"></param>
        public static void SaveZqmj(string name)
        {
            string strFileName = Path.Combine(path, "Config/Config.xml"); //日志文件名称
            XmlDocument xmldoc = new XmlDocument();
            xmldoc.Load(strFileName);
            xmldoc.SelectSingleNode("Config/Zqmj").InnerText = name;
            xmldoc.Save(strFileName);

        }

        public static string get_start_datetime()
        {
            string strFileName = Path.Combine(path, "Config/Config.xml"); //日志文件名称
            XmlDocument xmldoc = new XmlDocument();
            xmldoc.Load(strFileName);
            return xmldoc.SelectSingleNode("Config/start_datetime").InnerText;
        }

        public static void save_start_datetime(string start_datetime)
        {
            string strFileName = Path.Combine(path, "Config/Config.xml"); //日志文件名称
            XmlDocument xmldoc = new XmlDocument();
            xmldoc.Load(strFileName);
            xmldoc.SelectSingleNode("Config/start_datetime").InnerText = start_datetime;
            xmldoc.Save(strFileName);
        }
        /// <summary>
        /// 保存图片到路径下
        /// </summary>
        /// <param name="url"></param>
        /// <param name="path"></param>
        public static void SavePic(string url, string path)
        {
            WebClient webClient = new WebClient();
            try
            {
                webClient.DownloadFile(url, path);
            }
            catch (Exception ex)
            {
                Log.WriteLog("下载数据：" + url + " error:" + path);
               // Log.WriteLog(ex.ToString());
            }
        }

        /// <summary>
        /// 通过违法行为得到对应的违法编号
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static string GetWfType(string name)
        {
            switch (name)
            {
                case "越黄线":
                    return "001";
                case "超速":
                    return "002";
                case "闯红灯":
                    return "003";
                case "牌照比对":
                    return "009";
                case "大货车禁行":
                    return "010";
                case "黄标车":
                    return "011";
                case "违法停车":
                    return "012";
                case "走专用道":
                    return "013";
                default :
                    return "001";
            }
        }

        /// <summary>
        /// 保存违法信息到指定位置
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="filename"></param>
        /// <param name="path"></param>
        public static void WritePeccancy(string msg, string filename, string path)
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            string strFileName = Path.Combine(path, filename); //日志文件名称
            FileInfo file = new FileInfo(strFileName);
            StreamWriter sw = null;
            try
            {
                if (!file.Exists)
                    sw = file.CreateText();
                else
                    sw = file.AppendText();
                sw.WriteLine("{0}", msg);
            }
            catch
            { }
            finally
            {
                if (sw != null)
                    sw.Close();
            }
        }

        public static void CreateConfigXML()
        {
            string configPath = path + "Config";
            if (!Directory.Exists(configPath))
            {
                Directory.CreateDirectory(configPath);
            }
            string strFileName = Path.Combine(configPath, "Config.xml");
            if (File.Exists(strFileName))
            {
                return;
            }
            string xmlContent = "<?xml version=\"1.0\" encoding=\"utf-8\" ?>";
            xmlContent += @"<Config>
                              <Wfxws>
                                <Wfxw>
                                  <Wfxwms>越黄线</Wfxwms>
                                  <Code></Code>
                                </Wfxw>
                                <Wfxw>
                                  <Wfxwms>超速</Wfxwms>
                                  <Code></Code>
                                </Wfxw>
                                <Wfxw>
                                  <Wfxwms>闯红灯</Wfxwms>
                                  <Code></Code>
                                </Wfxw>
                                <Wfxw>
                                  <Wfxwms>牌照比对</Wfxwms>
                                  <Code></Code>
                                </Wfxw>
                                <Wfxw>
                                  <Wfxwms>大货车禁行</Wfxwms>
                                  <Code></Code>
                                </Wfxw>
                                <Wfxw>
                                  <Wfxwms>黄标车</Wfxwms>
                                  <Code></Code>
                                </Wfxw>
                                <Wfxw>
                                  <Wfxwms>违法停车</Wfxwms>
                                  <Code></Code>
                                </Wfxw>
                                <Wfxw>
                                  <Wfxwms>走专用道</Wfxwms>
                                  <Code></Code>
                                </Wfxw>
                              </Wfxws>
                              <Zqmj></Zqmj>
                            </Config>";
            FileInfo file = new FileInfo(strFileName);
            StreamWriter sw = null;
            try
            {
                if (!file.Exists)
                    sw = file.CreateText();
                else
                    sw = file.AppendText();
                sw.WriteLine("{0}", xmlContent);
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
