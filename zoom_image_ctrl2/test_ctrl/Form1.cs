using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace test_ctrl
{
    public partial class Form1 : Form
    {
        private zoom_image_ctrl.myZoomImageCtrl myctrl;
        private Button button1;
    
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdPic = new OpenFileDialog();
            ofdPic.Filter = "JPG(*.JPG;*.JPEG);gif文件(*.GIF);PNG(*.PNG)|*.png;*.jpg;*.jpeg;*.gif";
            ofdPic.FilterIndex = 1;
            ofdPic.RestoreDirectory = true;
            ofdPic.FileName = "";
            if (ofdPic.ShowDialog() == DialogResult.OK)
            {
                string sPicPaht = ofdPic.FileName.ToString();
                myctrl.filenamepath = sPicPaht;
            }
        }

        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.myctrl = new zoom_image_ctrl.myZoomImageCtrl();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(258, 237);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(189, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "openfile";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // myctrl
            // 
            this.myctrl.BackColor = System.Drawing.Color.Black;
            this.myctrl.Cursor = System.Windows.Forms.Cursors.Cross;
            this.myctrl.ForeColor = System.Drawing.Color.Black;
            this.myctrl.Location = new System.Drawing.Point(137, 1);
            this.myctrl.Name = "myctrl";
            this.myctrl.Size = new System.Drawing.Size(422, 230);
            this.myctrl.TabIndex = 1;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(680, 262);
            this.Controls.Add(this.myctrl);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.ResumeLayout(false);

        }
    }
}
