using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;



namespace zoom_image_ctrl
{
    public partial class myZoomImageCtrl : UserControl
    {

        [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
        private static extern bool ShowWindow(HandleRef hWnd, int nCmdShow);

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
                if (jpeg_img != null)
                    jpeg_img.Dispose();
                jpeg_img = null;
                try
                {
                    if (!string.IsNullOrEmpty(jpg_filenamepath))
                    {
                        jpeg_img = Image.FromFile(jpg_filenamepath);
                    }
                }
                catch (Exception ex)
                {

                }
                
                Invalidate();
            }
        }
        Image jpeg_img;
        ImageForm img_form;
        double img_scale = 1.0f;
        public myZoomImageCtrl()
        {
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true); // 禁止擦除背景.
            SetStyle(ControlStyles.DoubleBuffer, true); // 双缓冲
            InitializeComponent();
            this.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.myZoomImageCtrl_MouseWheel);

        }
        ~myZoomImageCtrl()
        {
            if (jpeg_img != null)
            {
                jpeg_img.Dispose();
                jpeg_img = null;
            }
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics dc = e.Graphics;
            if (jpeg_img!=null)
            {
                dc.DrawImage(jpeg_img, new Rectangle(0, 0, this.Width, this.Height));
            }

        }

        private void myZoomImageCtrl_MouseLeave(object sender, EventArgs e)
        {
            try
            {
                if (img_form != null)
                {
                    img_form.Hide();
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }

        }
        private Point compute_img_point(Point mouse_p)
        {
            try
            {
                mouse_p.X = Convert.ToInt32(Convert.ToDouble(jpeg_img.Width) / this.ClientSize.Width * mouse_p.X);
                mouse_p.Y = Convert.ToInt32(Convert.ToDouble(jpeg_img.Height) / this.ClientSize.Height * mouse_p.Y);
                return mouse_p;
            }
            catch (Exception ex)
            {
                
            }
            return new Point(0, 0);

        }

        private Rectangle get_empty_rect()
        {
            int SH = Screen.PrimaryScreen.Bounds.Height;
            int SW = Screen.PrimaryScreen.Bounds.Width;
            int w = this.Width;
            int h = this.Height;
            Point screentopp = PointToScreen(new Point(0,0));
            screentopp.X = screentopp.X;
            screentopp.Y = screentopp.Y;
            int screen_right = screentopp.X + w;
            int screen_bottom = screentopp.Y + h;


            //X方向的的空余位置
            int w_i = SW;
            int h_i = SH;
            int img_form_w = screentopp.X > (SW - screen_right) ? screentopp.X  : (SW - screen_right);
            //Y方向的空余位置
            int img_form_h = screentopp.Y > (SH - screen_bottom)?screentopp.Y : (SH - screen_bottom);

            if (img_form_w > Convert.ToInt32(Convert.ToDouble(img_form_h) * w_i / h_i))        //w/h=3:2 //取x方向
            {
                img_form_h = Convert.ToInt32(Convert.ToDouble(img_form_w) * h_i / w_i);
                int x = 0;
                if (screentopp.X > (SW - screen_right))     //左边
                {
                    x = 0;
                }
                else                                        //右边
                {
                    x = screen_right;
                }
                int y = screentopp.Y + h / 2 - img_form_h / 2;
                if (y < 0) y = 0;
                if (y + img_form_h > SH) y = SH - img_form_h;

                return new Rectangle(x, y, img_form_w, img_form_h);
      
             }
            else                                                //取Y方向
            {
                img_form_w = Convert.ToInt32(Convert.ToDouble(img_form_h) * w_i /h_i);
                if (img_form_w > SW) img_form_w = SW;
                int x = 0;
                int y = 0;
                if (screentopp.Y > (SH - screen_bottom))        //上边
                {
                    y = 0;
                }
                else                                              //下边
                {
                    y = screen_bottom;
                }

                x = screentopp.X + w  / 2 - img_form_w / 2;
                if (x < 0) x = 0;
                if (x + img_form_w > SW) x = SW - img_form_w;
                return new Rectangle(x, y, img_form_w, img_form_h);
            }
        }

        private void myZoomImageCtrl_MouseMove(object sender, MouseEventArgs e)
        {
            if (img_form!=null)
                img_form.show_imge(img_scale, compute_img_point(new Point(e.X, e.Y)));
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
        
        private void myZoomImageCtrl_MouseEnter(object sender, EventArgs e)
        {
            if(jpeg_img!=null)
            {
                if (img_form == null)
                {
                    img_form = new ImageForm();
                    img_form.TopMost = true;

                }
                img_form.jpegfilepath = jpg_filenamepath;
                img_form.Show();
        //        ShowWindow(new HandleRef(img_form, img_form.Handle), 4);

                Rectangle img_posion = get_empty_rect();
                img_form.Top = img_posion.Y;
                img_form.Left = img_posion.X;
                img_form.Width = img_posion.Width;
                img_form.Height = img_posion.Height;
                img_scale = 1.0f;

         //       System.Diagnostics.Debug.WriteLine(@"-------{0},{1},{2},{3}----------", img_posion.X, img_posion.Y, img_posion.Width, img_posion.Height);
         //       System.Diagnostics.Debug.WriteLine(@"-------{0},{1}----------", img_form.Left, img_form.Top, img_form.Width, img_form.Height);

            }
            
        }
        private const double MAX_SCALE = 15.0f;
        private const double MIN_SCALE = 0.1f;
        private const double PRE_SCALE = 0.001f;

        private void myZoomImageCtrl_MouseWheel(object sender, MouseEventArgs e)
        {
            if (jpeg_img != null)
            {
                img_scale += PRE_SCALE * e.Delta;

                if (img_scale > MAX_SCALE)
                {
                    img_scale = MAX_SCALE;
                }
                if (img_scale < MIN_SCALE)
                {
                    img_scale = MIN_SCALE;
                }
                img_form.show_imge(img_scale, compute_img_point(new Point(e.X, e.Y)));

            }

        }
    }

}
