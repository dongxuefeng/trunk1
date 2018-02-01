namespace Ehl.Atms.Tgs.lifebelt_check
{
    partial class InterfixForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonPrev = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.dd_lbl = new System.Windows.Forms.Label();
            this.time_lb = new System.Windows.Forms.Label();
            this.dd_tb = new System.Windows.Forms.TextBox();
            this.time_tb = new System.Windows.Forms.TextBox();
            this.myctrl = new zoom_image_ctrl.myZoomImageCtrl();
            this.SuspendLayout();
            // 
            // buttonPrev
            // 
            this.buttonPrev.Location = new System.Drawing.Point(149, 483);
            this.buttonPrev.Name = "buttonPrev";
            this.buttonPrev.Size = new System.Drawing.Size(75, 23);
            this.buttonPrev.TabIndex = 1;
            this.buttonPrev.Text = "上一张";
            this.buttonPrev.UseVisualStyleBackColor = true;
            this.buttonPrev.Click += new System.EventHandler(this.buttonPrev_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(442, 483);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(75, 23);
            this.buttonNext.TabIndex = 2;
            this.buttonNext.Text = "下一张";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Location = new System.Drawing.Point(715, 483);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(75, 23);
            this.buttonConfirm.TabIndex = 4;
            this.buttonConfirm.Text = "确定";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // dd_lbl
            // 
            this.dd_lbl.AutoSize = true;
            this.dd_lbl.Location = new System.Drawing.Point(10, 451);
            this.dd_lbl.Name = "dd_lbl";
            this.dd_lbl.Size = new System.Drawing.Size(65, 12);
            this.dd_lbl.TabIndex = 6;
            this.dd_lbl.Text = "过车地点：";
            // 
            // time_lb
            // 
            this.time_lb.AutoSize = true;
            this.time_lb.Location = new System.Drawing.Point(398, 451);
            this.time_lb.Name = "time_lb";
            this.time_lb.Size = new System.Drawing.Size(65, 12);
            this.time_lb.TabIndex = 7;
            this.time_lb.Text = "过车时间：";
            // 
            // dd_tb
            // 
            this.dd_tb.BackColor = System.Drawing.Color.White;
            this.dd_tb.Location = new System.Drawing.Point(81, 448);
            this.dd_tb.Name = "dd_tb";
            this.dd_tb.ReadOnly = true;
            this.dd_tb.Size = new System.Drawing.Size(251, 21);
            this.dd_tb.TabIndex = 8;
            // 
            // time_tb
            // 
            this.time_tb.BackColor = System.Drawing.Color.White;
            this.time_tb.Location = new System.Drawing.Point(469, 448);
            this.time_tb.Name = "time_tb";
            this.time_tb.ReadOnly = true;
            this.time_tb.Size = new System.Drawing.Size(224, 21);
            this.time_tb.TabIndex = 9;
            // 
            // myctrl
            // 
            this.myctrl.BackColor = System.Drawing.Color.Black;
            this.myctrl.Cursor = System.Windows.Forms.Cursors.Cross;
            this.myctrl.ForeColor = System.Drawing.Color.Black;
            this.myctrl.Location = new System.Drawing.Point(12, 12);
            this.myctrl.Name = "myctrl";
            this.myctrl.Size = new System.Drawing.Size(787, 417);
            this.myctrl.TabIndex = 10;
            // 
            // InterfixForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 518);
            this.Controls.Add(this.myctrl);
            this.Controls.Add(this.time_tb);
            this.Controls.Add(this.dd_tb);
            this.Controls.Add(this.time_lb);
            this.Controls.Add(this.dd_lbl);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonPrev);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InterfixForm";
            this.Text = "相关图片";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPrev;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.Label dd_lbl;
        private System.Windows.Forms.Label time_lb;
        private System.Windows.Forms.TextBox dd_tb;
        private System.Windows.Forms.TextBox time_tb;
        private zoom_image_ctrl.myZoomImageCtrl myctrl;
    }
}