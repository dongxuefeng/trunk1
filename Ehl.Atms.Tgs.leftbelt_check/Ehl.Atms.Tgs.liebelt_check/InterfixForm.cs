using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
namespace Ehl.Atms.Tgs.lifebelt_check
{
    public partial class InterfixForm : Form
    {
        int imgNo = 0;
        DataTable tableData;
        DataAccess dataAccess = new DataAccess();
        DataRow row;
        DataTable dt = new DataTable("Datas");//gengming
        private Image combineImages(String imgPath1,String imgPath2,String newImg)
        {
            Image bmp1 = new Bitmap(imgPath1);
            Image bmp2 = new Bitmap(imgPath2);
            Image newBmp = new Bitmap(bmp1.Width + bmp2.Width, (bmp1.Height > bmp2.Height) ? bmp1.Height : bmp2.Height);
            Graphics g = Graphics.FromImage(newBmp);
            g.DrawImage(bmp1, 0, 0);
            g.DrawImage(bmp2, 0, bmp1.Height);
            newBmp.Save(newImg);
            //save(newBmp);
            return newBmp;
        }
        public InterfixForm(DataTable table, DataRow curRow)
        {
            tableData = table;
            row = curRow;
            imgNo = 0;
//             string hphmt = tableData.Rows[imgNo][1].ToString();
//             string zjwj1 = tableData.Rows[imgNo][8].ToString();
//             System.Net.HttpWebRequest req = (System.Net.HttpWebRequest)System.Net.HttpWebRequest.Create(zjwj1);
//             System.Net.HttpWebResponse res = (System.Net.HttpWebResponse)req.GetResponse();
//             Stream stream = res.GetResponseStream();
//             myctrl.jpeg_stream = stream;
//             stream.Dispose();
                 
            this.buttonPrev.Enabled = false;
        }
        public InterfixForm(int seclect, DataRow curRow)
        {
            //tableData = dataAccess.GetSeclectPeccancy(curRow, seclect);gengming
            row = curRow;
            imgNo = 0;

            dt.Columns.Add("ID", Type.GetType("System.Int32"));
            dt.Columns[0].AutoIncrement = true;
            dt.Columns[0].AutoIncrementSeed = 1;
            dt.Columns[0].AutoIncrementStep = 1;

            dt.Columns.Add("column1", Type.GetType("System.String"));
            dt.Columns.Add("column2", Type.GetType("System.String"));
            dt.Columns.Add("column3", Type.GetType("System.String"));
            dt.Columns.Add("column4", Type.GetType("System.String"));
            dt.Columns.Add("column5", Type.GetType("System.String"));
            dt.Columns.Add("column6", Type.GetType("System.String"));
            dt.Columns.Add("column7", Type.GetType("System.String"));
            dt.Columns.Add("column8", Type.GetType("System.String"));
            dt.Columns.Add("column9", Type.GetType("System.String"));
            DataRow curRow6 = dt.NewRow();
            curRow6[8] = "http://img2.itiexue.net/2117/21176294.jpg";
            curRow6[1] = "陕A30054";
            dt.Rows.Add(curRow6);
            DataRow curRow1 = dt.NewRow();
            curRow1[8] = "http://img2.itiexue.net/2117/21176294.jpg";
            curRow1[1] = "陕A30054";
            dt.Rows.Add(curRow1);
            DataRow curRow2 = dt.NewRow();
            curRow2[8] = "http://img9.itiexue.net/2117/21176289.jpg";
            curRow2[1] = "陕A30054";
            dt.Rows.Add(curRow2);
            DataRow curRow3 = dt.NewRow();
            curRow3[8] = "http://img0.itiexue.net/2117/21176292.jpg";
            curRow3[1] = "陕A30054";
            dt.Rows.Add(curRow3);
            tableData = dt;

//             string hphmt = tableData.Rows[3][1].ToString();
//             string zjwj1 = tableData.Rows[3][8].ToString();
//             System.Net.HttpWebRequest req = (System.Net.HttpWebRequest)System.Net.HttpWebRequest.Create(zjwj1);
//             System.Net.HttpWebResponse res = (System.Net.HttpWebResponse)req.GetResponse();
//             Stream stream = res.GetResponseStream();
//             myctrl.jpeg_stream = stream;
//             stream.Dispose();

            this.buttonPrev.Enabled = false;
        }
        private void buttonPrev_Click(object sender, EventArgs e)
        {
            this.buttonPrev.Enabled = true;
            if (imgNo > 0)
            {
                imgNo--;
                this.buttonNext.Enabled = true;
            }
            if (imgNo == 0)
            {
                this.buttonNext.Enabled = true;
                this.buttonPrev.Enabled = false;
            }
//             string xh = tableData.Rows[imgNo][0].ToString();
//             string hpzl = tableData.Rows[imgNo][1].ToString().PadRight(2);
//             string hphmt = tableData.Rows[imgNo][1].ToString();
//             string zjwj1 = tableData.Rows[imgNo][8].ToString();
//             System.Net.HttpWebRequest req = (System.Net.HttpWebRequest)System.Net.HttpWebRequest.Create(zjwj1);
//             System.Net.HttpWebResponse res = (System.Net.HttpWebResponse)req.GetResponse();
//             Stream stream = res.GetResponseStream();
//             myctrl.jpeg_stream = stream;
//             stream.Dispose();
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
//             if (this.imgSelected.CheckState == CheckState.Checked)
//             {
//                 string hphm = tableData.Rows[imgNo][1].ToString();
//                 string gwsj = tableData.Rows[imgNo][4].ToString();
//                 string picName1 = string.Empty;
//                 string picName2 = string.Empty;
// 
//                 //导出
// 
//                 picName1 = row[4].ToString() + "_" + row[1].ToString() + "_" + "未系安全带" + ".jpg";
//                 Common.SavePic(row[8].ToString(), txt_path.Text + "/" + "/" + picName1);//gengming add wfdz
// 
//                 picName2 = gwsj + "_" + hphm + "_" + "未系安全带" + ".jpg";
//                 Common.SavePic(tableData.Rows[imgNo][8].ToString(), txt_path.Text + "/" + "/" + picName2);
// 
//                 String newImgPath = txt_path.Text + "/" + "/" + row[1].ToString() + "_" + row[4].ToString() + "_" + gwsj + "_" + "未系安全带" + ".jpg";
// 
//                 combineImages(txt_path.Text + "/" + "/" + picName1, txt_path.Text + "/" + "/" + picName2, newImgPath);
//                 File.Delete(txt_path.Text + "/" + "/" + picName1);//删除当前文件
//                 File.Delete(txt_path.Text + "/" + "/" + picName2);//删除当前文件
// 
//                 System.Windows.Forms.Application.DoEvents();
 //                       
 //           }
        }
          
        private void buttonNext_Click(object sender, EventArgs e)
        {
            this.buttonNext.Enabled = true;
            if (imgNo < tableData.Rows.Count)
            {
                imgNo++;
                this.buttonPrev.Enabled = true;
            }
            if (imgNo == (tableData.Rows.Count - 1))
            {
                this.buttonNext.Enabled = false;
            }
//             string xh = tableData.Rows[imgNo][0].ToString();
//             string hpzl = tableData.Rows[imgNo][1].ToString().PadRight(2);
//             string hphmt = tableData.Rows[imgNo][1].ToString();
//             string zjwj1 = tableData.Rows[imgNo][8].ToString();
//             System.Net.HttpWebRequest req = (System.Net.HttpWebRequest)System.Net.HttpWebRequest.Create(zjwj1);
//             System.Net.HttpWebResponse res = (System.Net.HttpWebResponse)req.GetResponse();
//             Stream stream = res.GetResponseStream();
//             myctrl.jpeg_stream = stream;
//             stream.Dispose();  
        }

        private void btn_Brower_Click(object sender, EventArgs e)
        {
//             FolderBrowserDialog fiBrower = new FolderBrowserDialog();
//             if (fiBrower.ShowDialog() == DialogResult.OK)
//             {
//                 txt_path.Text = fiBrower.SelectedPath;
//             }
        }
    }
}
