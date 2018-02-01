using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace zoom_image_ctrl
{
    public partial class myZoomImageCtrl : UserControl
    {
        private String jpg_filenamepath;    //图像文件路径
        public String filenamepath
        {
            get
            {
                return jpg_filenamepath;
            }
            set
            {
                jpg_filenamepath = value;
                start_p.X = 0;
                start_p.Y = 0;
                end_p.X = this.Width;
                end_p.Y = this.Height;
                if (jpeg_img != null)
                    jpeg_img.Dispose();
                jpeg_img = null;
                try
                {
                    if (File.Exists(jpg_filenamepath))
                    {
                        jpeg_img = Image.FromFile(jpg_filenamepath);
                        already_scale = false;
                        compute_scale();
                        Invalidate();
                    }
                }
                catch ( Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine(ex.Message);
                    jpeg_img = null;
                    Invalidate();
                }

            }
        }

        public Stream jpeg_stream
        {
            set
            {
                start_p.X = 0;
                start_p.Y = 0;
                end_p.X = this.Width;
                end_p.Y = this.Height;
                if (jpeg_img != null)
                    jpeg_img.Dispose();
                jpeg_img = null;
                try
                {
                    jpeg_img = Image.FromStream(value);
                    already_scale = false;
                    compute_scale();
                    Invalidate();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine(ex.Message);
                    jpeg_img = null;
                    Invalidate();

                }
            }
        }
        private int scale_top;     //图像中心位置
        private int scale_left;     //图像中心位置
        private int scale_bottom;
        private int scale_right;
        private Point start_p;
        private Point end_p;
        private bool mouse_down = false;    //鼠标左键按下
        Image jpeg_img;
        bool already_scale = false;
        Rectangle old_rect = new Rectangle(0,0,0,0);
        public myZoomImageCtrl()
        {
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true); // 禁止擦除背景.
            SetStyle(ControlStyles.DoubleBuffer, true); // 双缓冲
            InitializeComponent();
        }

        private void UserControl1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && !already_scale)
            {
                mouse_down = true;
                start_p.X = e.X;
                start_p.Y = e.Y;
                old_rect.Width = 0;
                old_rect.Height = 0;
            }
        }

        private void UserControl1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && !already_scale )
            {
                if (mouse_down)
                {
                    mouse_down = false;
                    end_p.X = e.X;
                    end_p.Y = e.Y;
                    already_scale = true;
                    compute_scale();
                    Invalidate();
                }
            }
            else if (e.Button == MouseButtons.Right && already_scale )
            {
                start_p.X = 0;
                start_p.Y = 0;
                end_p.X = this.Width;
                end_p.Y = this.Height;
                already_scale = false;
                compute_scale();
                Invalidate();
            }
   
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics dc = e.Graphics;

            if (jpeg_img != null)
            {

                if (mouse_down)
                {
                    Rectangle rect = new Rectangle();
                    rect.Location = start_p;
                    rect.Width = (end_p.X - start_p.X);
                    rect.Height = ( end_p.Y-start_p.Y );
                    rect = adjust_rect(rect);

                    Image tmp_img = (Image)jpeg_img.Clone();
                    Graphics g = Graphics.FromImage(tmp_img);
              
                    Rectangle srcrect = new Rectangle();
                    double xsc = (Convert.ToDouble( jpeg_img.Width) / this.Width );
                    double ysc =  ( Convert.ToDouble(jpeg_img.Height) / this.Height);
                    srcrect.X = Convert.ToInt32(rect.X * xsc);
                    srcrect.Y = Convert.ToInt32(rect.Y * ysc);
                    srcrect.Width = Convert.ToInt32(rect.Width * xsc);
                    srcrect.Height = Convert.ToInt32(rect.Height * ysc);
                    srcrect = adjust_rect(srcrect);

                    Pen redpen = new Pen(Color.Red,5);
                    g.DrawRectangle(redpen, srcrect);
                    redpen.Dispose();

                    dc.DrawImage(tmp_img, 0, 0,this.Width,this.Height);
                    g.Dispose();
                    tmp_img.Dispose();
                    old_rect = rect;

                    System.Diagnostics.Debug.WriteLine(@"---划框---");
                }
                else
                {
                    Rectangle dstrect = new Rectangle(scale_left, scale_top, scale_right, scale_bottom);
                    dc.DrawImage(jpeg_img, dstrect);
                    System.Diagnostics.Debug.WriteLine(@"---画图---");
             
                }

            }
            else
            {
                dc.FillRectangle(new SolidBrush(Color.Black), 0, 0, this.Width, this.Height);
            }
        }

        private void myZoomImageCtrl_MouseLeave(object sender, EventArgs e)
        {
            //mouse_down = false;
        }
        private void compute_scale()
        {
            if (start_p.X == end_p.X || start_p.Y == end_p.Y) return;
            int cent_x = (start_p.X + end_p.X) / 2;
            int cent_y = (start_p.Y + end_p.Y) / 2;
            double scale1 = this.Width/Math.Abs(Convert.ToDouble(end_p.X - start_p.X))  ;
            double scale2 = this.Height/Math.Abs(Convert.ToDouble(end_p.Y - start_p.Y));
            double jpgscale = scale1 > scale2 ? scale2 : scale1;

            int max_w = Convert.ToInt32(this.Width * jpgscale);
            int max_h = Convert.ToInt32(this.Height * jpgscale);

            scale_top = this.Height / 2-Convert.ToInt32(cent_y * jpgscale);
            scale_left = this.Width / 2- Convert.ToInt32(cent_x * jpgscale);
            if (scale_top > 0) scale_top = 0;
            if (scale_left > 0) scale_left = 0;
  
            scale_bottom = max_h;
            scale_right = max_w;
            if (scale_top + max_h < this.Height) scale_top =  this.Height - max_h;
            if (scale_left + max_w < this.Width) scale_left = this.Width - max_w;
        }

        private void myZoomImageCtrl_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && !already_scale)
            {
                end_p.X = e.X;
                end_p.Y = e.Y;
                Rectangle rect = new Rectangle();
                rect.Location = start_p;
                rect.Width = (end_p.X - start_p.X);
                rect.Height = (end_p.Y- start_p.Y);
                rect = adjust_rect(rect);

                if (old_rect.Width > 0 && old_rect.Height > 0)
                {
                    Rectangle new_rect = union_rect(rect, old_rect);
                    new_rect.Inflate(new Size(10,10));
                    Invalidate(new_rect, false);
                    System.Diagnostics.Debug.WriteLine(@"--rect {0},{1},{2},{3}---", rect.X, rect.Y, rect.Width + rect.X,rect.Height+rect.Y);
                    System.Diagnostics.Debug.WriteLine(@"---old_rect {0},{1},{2},{3}--", old_rect.X, old_rect.Y, old_rect.Width + rect.X, old_rect.Height + old_rect.Y);
                    System.Diagnostics.Debug.WriteLine(@"---new_rect {0},{1},{2},{3}--", new_rect.X, new_rect.Y, rect.Width + new_rect.X, new_rect.Height + new_rect.Y);
                }
                else
                {
                    Invalidate(rect, false);
                }
            }
           
        }

        public Rectangle adjust_rect(Rectangle src_rect)
        {
            if (src_rect.Width < 0)
            {
                src_rect.X = src_rect.X + src_rect.Width;
                src_rect.Width = Math.Abs(src_rect.Width);
            }
            if (src_rect.Height < 0)
            {
                src_rect.Y = src_rect.Y + src_rect.Height;
                src_rect.Height = Math.Abs(src_rect.Height);
            }
            return src_rect;
        }

        public Rectangle union_rect(Rectangle rect1, Rectangle rect2)
        {
            rect1 = adjust_rect(rect1);
            rect2 = adjust_rect(rect2);
            int x1 = rect1.X;
            int y1 = rect1.Y;
            int x11 = rect1.X+rect1.Width;
            int y11 = rect1.Y+rect1.Height;

            int x2 = rect2.X;
            int y2 = rect2.Y;
            int x21 = rect2.X+rect2.Width;
            int y21 = rect2.Y+rect2.Height;
            Rectangle tmp_rect = new Rectangle();
            tmp_rect.X = x1 > x2 ? x2 : x1;
            tmp_rect.Y = y1 > y2 ? y2 : y1;
            x11 = x11 > x21 ? x11 : x21;
            y11 = y11 > y21 ? y11 : y21;

            tmp_rect.Width = x11 - x1;
            tmp_rect.Height = y11 - y1;

            return tmp_rect;
           


        }

        private void myZoomImageCtrl_Resize(object sender, EventArgs e)
        {
            start_p.X = 0;
            start_p.Y = 0;
            end_p.X = this.Width;
            end_p.Y = this.Height;
            Invalidate();
        }

    }

}
