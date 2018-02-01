using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Ehl.Atms.Tgs.lifebelt_check
{
    public partial class animateImage : Form
    {
        private Image animatedImage;// = new Bitmap("SampleAnimation.gif");
        private bool currentlyAnimating = false;
        public animateImage(Form mainfm)
        {
            
            InitializeComponent();
            try
            {
                animatedImage = Properties.Resources.mygif;

            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }
        //    TopMost = true;
            if (mainfm != null)
            {
                int w = mainfm.Width;
                int h = mainfm.Height;
                Point main_src_p = PointToScreen(mainfm.Location);
                this.Top = mainfm.Location.Y + h / 2 - this.Height / 2;
                this.Left = mainfm.Location.X + w / 2 - Width / 2;
            }
        }
   
        private void play()
        {
            if (!currentlyAnimating)
            {
                ImageAnimator.Animate(animatedImage, new EventHandler(this.OnFrameChanged));
                currentlyAnimating = true;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            System.Windows.Forms.Application.DoEvents();
            //Begin the animation.
            play();
            //Get the next frame ready for rendering.
            ImageAnimator.UpdateFrames();
            //Draw the next frame in the animation.
            e.Graphics.DrawImage(this.animatedImage, 0,0,ClientSize.Width,ClientSize.Height);       
        }
        private void OnFrameChanged(object o, EventArgs e)
        {
            this.Invalidate();
        }

        
    }
}
