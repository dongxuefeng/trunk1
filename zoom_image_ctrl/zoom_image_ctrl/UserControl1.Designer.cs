﻿namespace zoom_image_ctrl
{
    partial class myZoomImageCtrl
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // myZoomImageCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "myZoomImageCtrl";
            this.Size = new System.Drawing.Size(230, 150);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UserControl1_MouseDown);
            this.MouseLeave += new System.EventHandler(this.myZoomImageCtrl_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.myZoomImageCtrl_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.UserControl1_MouseUp);
            this.Resize += new System.EventHandler(this.myZoomImageCtrl_Resize);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
