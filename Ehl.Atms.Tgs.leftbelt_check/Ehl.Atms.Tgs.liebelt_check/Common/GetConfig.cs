using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace Ehl.Atms.Tgs.lifebelt_check
{
    public class GetConfig
    {
        private List<Config> configs = new List<Config>();
        /// <summary>
        /// 服务配置
        /// </summary>
        public List<Config> Configs
        {
            get { return configs; }
            set { configs = value; }
        }

        private string zqmj;
        /// <summary>
        /// 执勤民警
        /// </summary>
        public string Zqmj
        {
            get { return zqmj; }
            set { zqmj = value; }
        }

        /// <summary>
        /// 获取配置信息
        /// </summary>
        public void GetConfigModel()
        {
            try
            {
                string root = System.Reflection.Assembly.GetExecutingAssembly().Location;
                //从配置文件中读取配置项
                XmlDocument xmldoc = new XmlDocument();
                string xmlPath = root.Remove(root.LastIndexOf('\\') + 1) + "Config\\Config.xml";
                //Log.WriteLog(xmlPath);
                xmldoc.Load(xmlPath);
                XmlNodeList xmlNodeList = xmldoc.SelectNodes("Config/Wfxws/Wfxw");
                configs = new List<Config>();
                foreach (XmlNode item in xmlNodeList)
                {
                    Config config = new Config();
                    config.Wfxwms = item.SelectSingleNode("Wfxwms").InnerText;
                    config.Code = item.SelectSingleNode("Code").InnerText;
                    configs.Add(config);
                }
                zqmj = xmldoc.SelectSingleNode("Config/Zqmj").InnerText;
                xmldoc = null;
            }
            catch (Exception ex)
            {
                Log.WriteLog(string.Format("读取系统配置时出现异常：{0}", ex.Message));
            }
        }
    }

    public class Config
    {
        private string wfxwms;
        /// <summary>
        /// 违法描述
        /// </summary>
        public string Wfxwms
        {
            get { return wfxwms; }
            set { wfxwms = value; }
        }

        private string code;
        /// <summary>
        /// 违法代码串
        /// </summary>
        public string Code
        {
            get { return code; }
            set { code = value; }
        }
    }
}
