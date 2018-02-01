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
    public partial class screen_Form2 : Form
    {
        public screen_Form2()
        {
            InitializeComponent();
        }


        private void screen_Form_Click(object sender, EventArgs e)
        {

        }

        private void screen_Form_Paint(object sender, PaintEventArgs e)
        {

        }

        private void screen_Form_Shown(object sender, EventArgs e)
        {
            this.Height = Screen.PrimaryScreen.Bounds.Height;
            this.Width = Screen.PrimaryScreen.Bounds.Width;
            this.Top = 0;
            this.Left = 0;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Space))
            {
                return true;
            }
            else

                return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
