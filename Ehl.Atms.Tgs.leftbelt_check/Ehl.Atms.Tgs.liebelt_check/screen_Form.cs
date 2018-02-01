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
    public partial class screen_Form : Form
    {

        private string _img_filepath;
        Image jpg_img;
        public string img_filepath
        {
            set
            {
                _img_filepath = value;
                if (jpg_img != null)
                {
                    jpg_img.Dispose();
                    jpg_img = null;
                }
                jpg_img = Image.FromFile(_img_filepath);
                this.Invalidate();
            }
        }
        public screen_Form()
        {
            InitializeComponent();
        }
        private object pform;
        public screen_Form(object parent_form)
            : this()
        {
            pform = parent_form;
        }

        private void screen_Form_Shown(object sender, EventArgs e)
        {
            Top = 0;
            Left = 0;
            Width = Screen.PrimaryScreen.Bounds.Width;
            Height = Screen.PrimaryScreen.Bounds.Height;
        }

        private void screen_Form_DoubleClick(object sender, EventArgs e)
        {
            this.Hide();
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Space) || keyData == Keys.Down)
            {
                if (pform != null)
                {
                    ((Form1)pform).buttonNext_Click(null, null);
                }
                return true;
            }
            else if (keyData == Keys.Up)
            {
                    if (pform != null)
                    {
                        ((Form1)pform).buttonPrev_Click(null, null);
                    }
                    return true;
            }
            else if (keyData == Keys.Escape)
            {
                this.Hide();
                return true;
            }
            else
                return base.ProcessCmdKey(ref msg, keyData);
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics dc = e.Graphics;
            if (jpg_img != null)
            {
                dc.DrawImage(jpg_img,0,0,this.Width,this.Height);
            }
        }
    }
}
