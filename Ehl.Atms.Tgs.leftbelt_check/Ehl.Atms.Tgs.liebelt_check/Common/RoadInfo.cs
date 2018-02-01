using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace Ehl.Atms.Tgs.lifebelt_check
{
    public class RoadInfo
    {
        public string kkid;     //卡口编号
        public string sbbh;     //设备编号
        public string sblx;     //设备类型
        public string sbmc;     //设备名称
        public string dldm;     //道路代码
        public string lddm;     //路段代码
        public string ms;       //米数
        public string dlmc;     //道路名称
    }

    public class GetRoadInfo
    {
        string xmlPath;
        public GetRoadInfo()
        {
            string root = System.Reflection.Assembly.GetExecutingAssembly().Location;
            xmlPath = root.Remove(root.LastIndexOf('\\') + 1) + "Config\\RoadInfo.xml";
        }
        public GetRoadInfo(string xmlpath)
        {
            xmlPath = xmlpath;
        }

        public void WriteRoadInfo(RoadInfo roadInfo)
        {
            XmlDocument xmldoc = new XmlDocument();
            try
            {
                xmldoc.Load(xmlPath);
            }
            catch (System.IO.FileNotFoundException e)
            {
                XmlDeclaration xd = xmldoc.CreateXmlDeclaration("1.0", "UTF-8", null);
                xmldoc.AppendChild(xd);
                XmlElement rot = xmldoc.CreateElement("Root");
                xmldoc.AppendChild(rot);
                XmlNode notelist = xmldoc.CreateElement("RoadInfoList");
                rot.AppendChild(notelist);
                xmldoc.Save(xmlPath);
                xmldoc.Load(xmlPath);
            }
            XmlNode root = xmldoc.SelectSingleNode("Root");
            XmlNodeList xnl = root.ChildNodes;
            foreach (XmlNode xn0 in xnl)
            {
                if (xn0.Name == "RoadInfoList")
                {
                 /*   public string kkid;     //卡口编号
        public string sbbh;     //设备编号
        public string sblx;     //设备类型
        public string sbmc;     //设备名称
        public string dldm;     //道路代码
        public string lddm;     //路段代码
        public string ms;       //米数
        public string dlmc;     //道路名称*/
                    XmlElement xml = xmldoc.CreateElement("RoadInfo");
                    xml.SetAttribute("kkid", roadInfo.kkid);
                    XmlElement sbbh = xmldoc.CreateElement("sbbh");
                    sbbh.InnerText = roadInfo.sbbh;
                    xml.AppendChild(sbbh);
                    XmlElement sblx = xmldoc.CreateElement("sblx");
                    sblx.InnerText = roadInfo.sblx;
                    xml.AppendChild(sblx);
                    XmlElement sbmc = xmldoc.CreateElement("sbmc");
                    sbmc.InnerText = roadInfo.sbmc;
                    xml.AppendChild(sbmc);
                    XmlElement dldm = xmldoc.CreateElement("dldm");
                    dldm.InnerText = roadInfo.dldm;
                    xml.AppendChild(dldm);
                    XmlElement lddm = xmldoc.CreateElement("lddm");
                    lddm.InnerText = roadInfo.lddm;
                    xml.AppendChild(lddm);
                    XmlElement ms = xmldoc.CreateElement("ms");
                    ms.InnerText = roadInfo.ms;
                    xml.AppendChild(ms);
                    XmlElement dlmc = xmldoc.CreateElement("dlmc");
                    dlmc.InnerText = roadInfo.dlmc;
                    xml.AppendChild(dlmc);
                    xn0.AppendChild(xml);
                    xmldoc.Save(xmlPath);
                }
            }
        }
        public List<RoadInfo> LoadRoadInfo()
        {
            
            //从配置文件中读取配置项
            XmlDocument xmldoc = new XmlDocument();
            
            
            //Log.WriteLog(xmlPath);
            try
            {
                xmldoc.Load(xmlPath);
            }
            catch (System.IO.FileNotFoundException e)
            {
                XmlDeclaration xd = xmldoc.CreateXmlDeclaration("1.0", "UTF-8", null);
                xmldoc.AppendChild(xd);
                XmlElement root = xmldoc.CreateElement("Root");
                xmldoc.AppendChild(root);
                XmlNode notelist = xmldoc.CreateElement("RoadInfoList");
                root.AppendChild(notelist);
                xmldoc.Save(xmlPath);
                xmldoc.Load(xmlPath);
            }
            XmlNode xn = xmldoc.SelectSingleNode("Root");
            if (xn == null)
                return null;
            XmlNodeList xnl = xn.ChildNodes;
            List<RoadInfo> RoadInfoList = new List<RoadInfo>();
            foreach (XmlNode xnf in xnl)
            {
                XmlNodeList xnll = xnf.ChildNodes;
                if (xnll == null)
                    break;
                foreach (XmlNode xnc in xnll)
                {
                    
                    XmlElement xe = (XmlElement)xnc;
                    if (xe.Name == "RoadInfo")
                    {
                        RoadInfo roadInfo = new RoadInfo();
                        roadInfo.kkid = xe.GetAttribute("kkid");
                        XmlNodeList xnf3 = xe.ChildNodes;
                        foreach (XmlNode xn2 in xnf3)
                        {
                            /*   public string kkid;     //卡口编号
public string sbbh;     //设备编号
public string sblx;     //设备类型
public string sbmc;     //设备名称
public string dldm;     //道路代码
public string lddm;     //路段代码
public string ms;       //米数
public string dlmc;     //道路名称*/
                            XmlElement xe1 = (XmlElement)xn2;
                            if (xn2.Name == "sbbh")
                                roadInfo.sbbh = xe1.InnerText;
                            if (xn2.Name == "sblx")
                                roadInfo.sblx = xe1.InnerText;
                            if (xn2.Name == "sbmc")
                                roadInfo.sbmc = xe1.InnerText;
                            if (xn2.Name == "dldm")
                                roadInfo.dldm = xe1.InnerText;
                            if (xn2.Name == "lddm")
                                roadInfo.lddm = xe1.InnerText;
                            if (xn2.Name == "ms")
                                roadInfo.ms = xe1.InnerText;
                            if (xn2.Name == "dlmc")
                                roadInfo.dlmc = xe1.InnerText;
                        }
                        RoadInfoList.Add(roadInfo);
                    }
                }
        
            }
            return RoadInfoList;
        }

    }

}
