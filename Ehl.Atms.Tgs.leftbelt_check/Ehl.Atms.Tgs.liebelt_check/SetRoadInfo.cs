using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ehl.Atms.Tgs.lifebelt_check
{
    public partial class SetRoadInfo : Form
    {
        private static SetRoadInfo instance = null;
        public SetRoadInfo()
        {
            InitializeComponent();
        }

        public static SetRoadInfo Instance
        {
            get { return instance; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RoadInfo roadInfo = new RoadInfo();
            roadInfo.dldm = text_dldm.Text;
            roadInfo.dlmc = text_dlmc.Text;
            roadInfo.kkid = text_kkid.Text;
            roadInfo.lddm = text_lddm.Text;
            roadInfo.ms = text_ms.Text;
            roadInfo.sbbh = text_sbid.Text;
            roadInfo.sblx = text_sblx.Text;
            roadInfo.sbmc = text_sbmc.Text;
            GetRoadInfo getRoadInfo = new GetRoadInfo();
            getRoadInfo.WriteRoadInfo(roadInfo);
            text_dldm.Text = "";
            text_dlmc.Text = "";
            text_kkid.Text = "";
            text_lddm.Text = "";
            text_ms.Text = "";
            text_sbid.Text = "";
            text_sblx.Text = "";
            text_sbmc.Text = "";
        }

        private void btn_flash_Click(object sender, EventArgs e)
        {
            listkkid.Items.Clear();
            GetRoadInfo getRoadInfo = new GetRoadInfo();
            List<RoadInfo> list;
            list = getRoadInfo.LoadRoadInfo();
            if (list == null)
                MessageBox.Show("没有参数");
            foreach (RoadInfo ri in list)
            {
                listkkid.Items.Add(ri.kkid);
            }
        }

        private void listkkid_SelectedIndexChanged(object sender, EventArgs e)
        {
            listkkinfo.Items.Clear();
            GetRoadInfo getRoadInfo = new GetRoadInfo();
            List<RoadInfo> list;
            list = getRoadInfo.LoadRoadInfo();
            if (list == null)
                MessageBox.Show("没有参数");

            listkkinfo.Items.Add(list[listkkid.SelectedIndex].dldm);
            listkkinfo.Items.Add(list[listkkid.SelectedIndex].dlmc);
            listkkinfo.Items.Add(list[listkkid.SelectedIndex].lddm);
            listkkinfo.Items.Add(list[listkkid.SelectedIndex].ms);
            listkkinfo.Items.Add(list[listkkid.SelectedIndex].sbbh);
            listkkinfo.Items.Add(list[listkkid.SelectedIndex].sblx);
            listkkinfo.Items.Add(list[listkkid.SelectedIndex].sbmc);
        }
    }
}
