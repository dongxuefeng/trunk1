using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace zoom_image_ctrl
{
    public partial class ImageForm : Form
    {
        public ImageForm()
        {
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true); // 禁止擦除背景.
            SetStyle(ControlStyles.DoubleBuffer, true); // 双缓冲
            InitializeComponent();
    //        SetTopLevel(true);
         }
        public ImageForm(String filename)
            : this()
        {
            jpegfilepath = filename;
        }
        ~ImageForm()
        {

        }
        private String jpeg_filepath;
        public String jpegfilepath
        {
            set
            {
                try
                {
                    jpeg_filepath = value;
                    if (jpeg_image != null)
                        jpeg_image.Dispose();
                    jpeg_image = Image.FromFile(jpeg_filepath);

                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine(ex.Message);
                }

            }
        }
        private Image jpeg_image;
        private int src_top;
        private int src_left;
        private int src_w;
        private int src_h;
        public void show_imge(double jpgscale, Point cent_p)
        {
            try
            {
                src_w = Convert.ToInt32(this.ClientSize.Width / jpgscale);
                src_h = Convert.ToInt32(this.ClientSize.Height / jpgscale);

                src_top = cent_p.Y - src_h / 2;
                src_left = cent_p.X - src_w / 2;

                if (src_top < 0) src_top = 0;
                if (src_left < 0) src_left = 0;

                if (src_top + src_h > jpeg_image.Height) src_top = jpeg_image.Height - src_h;
                if (src_left + src_w > jpeg_image.Width) src_left = jpeg_image.Width - src_w;

                if (src_top < 0) src_top = src_top/2;
                if (src_left < 0) src_left = src_left/2;


                Invalidate();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }


        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            try
            {
                if (jpeg_image != null)
                {
                    Graphics dc = e.Graphics;
                    dc.DrawImage(jpeg_image, new Rectangle(0, 0, ClientSize.Width, ClientSize.Height), new Rectangle(src_left, src_top, src_w, src_h), GraphicsUnit.Pixel);

                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }

        }
    }
}
