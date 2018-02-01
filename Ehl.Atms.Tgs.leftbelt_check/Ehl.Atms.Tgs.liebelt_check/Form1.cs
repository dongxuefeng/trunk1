using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using System.Net;
using System.Threading;


namespace Ehl.Atms.Tgs.lifebelt_check
{
    public partial class Form1 : Form
    {
        // GetConfig getConfig = new GetConfig();
        DataAccess dataAccess = new DataAccess();
        //  DataTable dt;gengming
        int imgNo = 0;
        int sec_img_No = 0;
        int first_img_index = 0;
        int second_img_index = 0;
        DataTable dt;
        DataTable sec_dt;
        Dictionary<string,int> time_combo_map = new Dictionary<string,int>();
        Dictionary<string, string> kkdd_combo_map = new Dictionary<string, string>();
        string current_kkid;
        string current_kkmc;
        screen_Form scr_frm = null;
        public Form1()
        {
            InitializeComponent();
            Common.DeleteLogFile();
           
            //需要判断配置文件是否存在，如果不存在得创建空的配置文件
            Common.CreateConfigXML();
            
            string start_datetime = Common.get_start_datetime();
            if (string.IsNullOrEmpty(start_datetime))
            {
                dtp_Start.Text = DateTime.Now.ToString("yyyy-MM-dd 00:00:00");
            }
            else
            {
                dtp_Start.Text = start_datetime;
            }
            stop_dtp.Text = DateTime.Now.ToString("yyyy-MM-dd 23:59:59"); 
        }
        


        private void query()
        {
            imgNo = 0;
            //每种违法类型导出一种格式
            if (dt!=null)
                dt.Clear();
            if (kkdd_combo_map.ContainsKey(qu_dd_cb.SelectedItem.ToString()))
            {
                current_kkid = kkdd_combo_map[qu_dd_cb.SelectedItem.ToString()];
                current_kkmc = qu_dd_cb.SelectedItem.ToString();
                dt = dataAccess.GetPeccancy(dtp_Start.Text, stop_dtp.Text,current_kkid, cllx_cb.SelectedIndex);//gengming
 
            }
            if (dt == null || dt.Rows.Count == 0)
            {
                MessageBox.Show("没有查询到数据");
            }

        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Config_Click(object sender, EventArgs e)
        {
            imgNo = 0;
            btn_Config.Enabled = false;
           // query();
            query_data_wait_form(query);
            btn_Config.Enabled = true;
            if (dt == null)
                return;
            showimg(imgNo);
            
        }

        private void btn_Export_Click(object sender, EventArgs e)
        {

            btn_Export.Enabled = false;
            string jpg_filepath = myCtrl.filenamepath;
            string jpg_filepath1 = myCtrl2.filenamepath;
            if (string.IsNullOrEmpty(txt_path.Text))
            {
                MessageBox.Show("请选择输出目录。");
                btn_Export.Enabled = true;
                return;
            }

            string out_path = txt_path.Text;
            out_path += "\\";
            out_path += DateTime.Now.ToString("yyyy-MM-dd");
            if (!Directory.Exists(out_path))
            {
                Directory.CreateDirectory(out_path);
            }
            out_path += "\\";
            out_path += current_kkmc;
            if (!Directory.Exists(out_path))
            {
                Directory.CreateDirectory(out_path);
            }
            ////4位时间,车号,号牌种类,行驶车道,地址,违法行为代码，实测值，标准值，车辆类型,设备编码,NVR设备号,图片顺序.jpg
            string kksj = DateTime.ParseExact(textBox_gwsj.Text, "yyyy-MM-dd HH:mm:ss", null).ToString("yyyyMMddHHmmss");
//            string platenum = 
            string out_jpg_filepath = string.Format("{0}\\{1}000_{2}_1.jpg", out_path, kksj, hphm_tb.Text);

            if (combine_jpg(jpg_filepath, jpg_filepath1, out_jpg_filepath))
            {
                MessageBox.Show("保存文件成功");
            }
            else { MessageBox.Show("保存文件失败！"); }
            btn_Export.Enabled = true;
           
        }

        private void btn_Brower_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fiBrower = new FolderBrowserDialog();
            if (fiBrower.ShowDialog() == DialogResult.OK)
            {
                txt_path.Text = fiBrower.SelectedPath;
            }
        }

        public void buttonNext_Click(object sender, EventArgs e)
        {
            imgNo++;
            showimg(imgNo);
            
        }

        private void query2()
        {
            int min = 0;

            if (time_combo_map.ContainsKey(interval_time.SelectedItem.ToString()))
            {
                min = time_combo_map[interval_time.SelectedItem.ToString()];
            }
            else
            {
                min = 360;
            }



            if (sec_dt != null)
            {
                sec_dt.Clear();
            }
            try
            {

                DateTime nDateTime = DateTime.ParseExact(textBox_gwsj.Text, "yyyy-MM-dd HH:mm:ss", null);
                DateTime start_DT = nDateTime.AddMinutes(-min);
                DateTime end_DT = nDateTime.AddMinutes(min);

                sec_dt = dataAccess.GetPeccancy(start_DT.ToString("yyyy-MM-dd HH:mm:ss"), end_DT.ToString("yyyy-MM-dd HH:mm:ss"), hphm_tb.Text, current_kkid);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("查询失败。");
                return;
            }
        }
        private void btn_serach_Click(object sender, EventArgs e)
        {
            btn_serach.Enabled = false;
            query_data_wait_form(query2);
            btn_serach.Enabled = true;
            sec_img_No = 0;
            show_img_sec(sec_img_No);

        }

        public void buttonPrev_Click(object sender, EventArgs e)
        {
            imgNo--;
            if (imgNo < 0)
            {
                imgNo = 0;
                return;
            }
            showimg(imgNo);
        }

        private void showimg(int num)
        {
            if (dt != null && num < dt.Rows.Count && num >= 0)
            {
                string zjwj = dt.Rows[num]["zjwj"].ToString();

                WebClient webClient = new WebClient();
                string tmp_path = Environment.GetEnvironmentVariable("TEMP");
                zjwj = zjwj.Replace('\\', '/');
                int tmp_i = zjwj.LastIndexOf('/');

                string file_path = tmp_path + zjwj.Substring(tmp_i + 2);
                if (!File.Exists(file_path))
                {
                    try
                    {
                        webClient.DownloadFile(zjwj, file_path);
                    }
                    catch (Exception ex)
                    {
                        Log.WriteLog("下载数据：" + zjwj + " error:" + ex.ToString());
                        return;
                    }
                }
                //               Log.WriteLog("本地图片：");
                //                Log.WriteLog(file_path);

                this.myCtrl.filenamepath = file_path;
                this.textBox_kkmc.Text = dt.Rows[num]["kkmc"].ToString();
                this.textBox_gwsj.Text = dt.Rows[num]["gwsj"].ToString();
                dtp_Start.Text = dt.Rows[num]["gwsj"].ToString();
                hphm_tb.Text = dt.Rows[num]["hphm"].ToString();
                Common.save_start_datetime(dt.Rows[num]["gwsj"].ToString());
                first_img_index = num;
                this.buttonPrev.Enabled = num > 0;
                this.buttonNext.Enabled = num < dt.Rows.Count - 1;
                btn_serach.Enabled = true;
                btn_Export.Enabled = false;
                myCtrl2.filenamepath = "";
                if (sec_dt != null)
                    sec_dt.Clear();
                sec_pre_bt.Enabled = false;
                sec_next_bt.Enabled = false;
                sec_dd_tb.Text = "";
                sec_hp_tb.Text = "";
                sec_time_tb.Text = "";
                sec_xinxi_lb.Text = "";
                first_image_index_lb.Text = string.Format("第{0}/{1}张", num + 1, dt.Rows.Count);
                if (screen_show_checkbox.Checked)
                {
                    if (scr_frm == null)
                    {
                        scr_frm = new screen_Form(this);
          
                    }
                    if (!scr_frm.Visible)
                    {
                        scr_frm.Show();
                    }
                    scr_frm.img_filepath = file_path;
                }else
                {
                    if (scr_frm != null)
                    {
                        scr_frm.Hide();
                    }
                }
            }
            else if ((dt!=null && num == dt.Rows.Count))
            {
                btn_Config_Click(null,null);
            }

        }

        private void show_img_sec(int num)
        {
            if (sec_dt!=null && num >= 0 && num < sec_dt.Rows.Count)
            {
                string zjwj = sec_dt.Rows[num]["zjwj"].ToString();

                WebClient webClient = new WebClient();
                string tmp_path = Environment.GetEnvironmentVariable("TEMP");
                zjwj = zjwj.Replace('\\', '/');
                int tmp_i = zjwj.LastIndexOf('/');

                string file_path = tmp_path + zjwj.Substring(tmp_i+2);
                if (!File.Exists(file_path))
                {
                    try
                    {
                        webClient.DownloadFile(zjwj, file_path);
                    }
                    catch (Exception ex)
                    {
                        Log.WriteLog("下载数据：" + zjwj + " error:" + ex.ToString());
                        return;
                    }
                }

                this.myCtrl2.filenamepath = file_path;
                this.sec_dd_tb.Text = sec_dt.Rows[num]["kkmc"].ToString();
                this.sec_time_tb.Text = sec_dt.Rows[num]["gwsj"].ToString();
                sec_hp_tb.Text = sec_dt.Rows[num]["hphm"].ToString();
                second_img_index = num;
                this.sec_pre_bt.Enabled = num > 0;
                this.sec_next_bt.Enabled = num < sec_dt.Rows.Count-1;
                btn_Export.Enabled = true;

                sec_xinxi_lb.Text = string.Format("第{0}/{1}张",num+1,sec_dt.Rows.Count);
            }
            else
            {
                this.myCtrl2.filenamepath = "";
                this.sec_dd_tb.Text ="";
                this.sec_time_tb.Text = "";
                sec_hp_tb.Text = "";
                this.sec_pre_bt.Enabled = false;
                this.sec_next_bt.Enabled = false;
                btn_Export.Enabled = true;
                sec_xinxi_lb.Text = "";
            }
            
        }

        private void sec_pre_bt_Click(object sender, EventArgs e)
        {
            sec_img_No--;
            show_img_sec(sec_img_No);
        }

        private void sec_next_bt_Click(object sender, EventArgs e)
        {
            sec_img_No++;
            show_img_sec(sec_img_No);
        }
        private bool combine_jpg(string filepath1, string filepath2, string out_filepath)
        {
            try
            {
                Image img1 = Image.FromFile(filepath1);
                Image img2 = Image.FromFile(filepath2);
                int h = (img1.Height>img2.Height) ? img1.Height : img2.Height;
                Image newimg = new Bitmap(img1.Width+img2.Width,h);
                Graphics g = Graphics.FromImage( newimg );
                g.Clear(Color.White);
                g.DrawImage(img1,0,0);
                g.DrawImage(img2,img1.Width,0);
                g.Save();
                newimg.Save(out_filepath, ImageFormat.Jpeg);
                img1.Dispose();
                img1.Dispose();
                newimg.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            return true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Log.WriteLog("启动程序。");
            query_data_wait_form(init);
            
        }
        //运行时间较长的函数的委托定义
        private delegate void query_delegate();

        private void query_data_wait_form(query_delegate dl_fun)
        {
            query_delegate sd = new query_delegate(dl_fun);
            //开始调用函数,可以带参数 
            IAsyncResult ir = sd.BeginInvoke(null,null);
            //显示等待的窗口 
            animateImage fWait = new animateImage(this);
            fWait.StartPosition = FormStartPosition.CenterParent;
            fWait.Show(this);
            //刷新这个等待的窗口 
            Application.DoEvents();
            while (true) 
            {
                Application.DoEvents();
                if (ir.IsCompleted)
                {
                    //完成了操作则关闭窗口 
                    fWait.Close();
                    break;
                }
                Application.DoEvents();
                Thread.Sleep(20);
            } 

        }

        private void init()
        {
            this.cllx_cb.SelectedIndex = 0;
            //初始化相关查询的时间combobox
            time_combo_map.Add(("10分钟"), 10);
            time_combo_map.Add(("30分钟"), 30);
            time_combo_map.Add(("1小时"), 60);
            time_combo_map.Add(("6小时"), 360);
            time_combo_map.Add(("12小时"), 720);
            interval_time.Items.Clear();
            foreach (var item in time_combo_map)
            {
                interval_time.Items.Add(item.Key);
            }
            interval_time.SelectedIndex = 1;

            //初始化地点列表
            DataTable kkinfo = dataAccess.exe_sql(@"select kkid, kkmc from t_tgs_set_watch ");
            if (kkinfo != null)
            {
                int i = 0;
                for (; i < kkinfo.Rows.Count; i++)
                {
                    kkdd_combo_map.Add(kkinfo.Rows[i]["kkmc"].ToString(), kkinfo.Rows[i]["kkid"].ToString());
                }
            }
            qu_dd_cb.Items.Clear();
            foreach (var item in kkdd_combo_map)
            {
                qu_dd_cb.Items.Add(item.Key);
            }
            qu_dd_cb.SelectedIndex = 0;

        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Space))
            {
                buttonNext_Click(null, null);
                return true;
            }else

             return base.ProcessCmdKey(ref msg, keyData);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (SetRoadInfo.Instance == null || SetRoadInfo.Instance.IsDisposed)
            {
                SetRoadInfo setRoadInfo = new SetRoadInfo();
                setRoadInfo.ShowDialog();
            }
            else
            {
                SetRoadInfo.Instance.Activate();
            }
        }
    }
}
