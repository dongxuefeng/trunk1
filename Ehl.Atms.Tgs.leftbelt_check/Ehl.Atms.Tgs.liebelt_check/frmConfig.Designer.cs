namespace Ehl.Atms.Tgs.ExportPeccancy
{
    partial class frmConfig
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.cbb_wflx = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Close_Zqmj = new System.Windows.Forms.Button();
            this.btn_Save_Zqmj = new System.Windows.Forms.Button();
            this.txt_Zqmj = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(455, 347);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.btn_Close);
            this.tabPage2.Controls.Add(this.btn_Save);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.cbb_wflx);
            this.tabPage2.Controls.Add(this.checkedListBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(447, 321);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "违法行为配置";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(243, 17);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(184, 244);
            this.checkedListBox1.TabIndex = 0;
            // 
            // cbb_wflx
            // 
            this.cbb_wflx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_wflx.Font = new System.Drawing.Font("宋体", 10.5F);
            this.cbb_wflx.FormattingEnabled = true;
            this.cbb_wflx.Items.AddRange(new object[] {
            "越黄线",
            "超速",
            "闯红灯",
            "牌照比对",
            "大货车禁行",
            "黄标车",
            "走专用道"});
            this.cbb_wflx.Location = new System.Drawing.Point(98, 18);
            this.cbb_wflx.Name = "cbb_wflx";
            this.cbb_wflx.Size = new System.Drawing.Size(126, 22);
            this.cbb_wflx.TabIndex = 48;
            this.cbb_wflx.SelectedIndexChanged += new System.EventHandler(this.cbb_wflx_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(15, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 14);
            this.label6.TabIndex = 49;
            this.label6.Text = "违法类型：";
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(243, 280);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 23);
            this.btn_Save.TabIndex = 50;
            this.btn_Save.Text = "保存(&S)";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(352, 280);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(75, 23);
            this.btn_Close.TabIndex = 51;
            this.btn_Close.Text = "关闭(&C)";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(15, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 177);
            this.label1.TabIndex = 52;
            this.label1.Text = "违法类型：";
            this.label1.Visible = false;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txt_Zqmj);
            this.tabPage1.Controls.Add(this.btn_Close_Zqmj);
            this.tabPage1.Controls.Add(this.btn_Save_Zqmj);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(447, 321);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "执勤民警";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(19, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 14);
            this.label2.TabIndex = 50;
            this.label2.Text = "执勤民警：";
            // 
            // btn_Close_Zqmj
            // 
            this.btn_Close_Zqmj.Location = new System.Drawing.Point(352, 280);
            this.btn_Close_Zqmj.Name = "btn_Close_Zqmj";
            this.btn_Close_Zqmj.Size = new System.Drawing.Size(75, 23);
            this.btn_Close_Zqmj.TabIndex = 53;
            this.btn_Close_Zqmj.Text = "关闭(&C)";
            this.btn_Close_Zqmj.UseVisualStyleBackColor = true;
            this.btn_Close_Zqmj.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btn_Save_Zqmj
            // 
            this.btn_Save_Zqmj.Location = new System.Drawing.Point(243, 280);
            this.btn_Save_Zqmj.Name = "btn_Save_Zqmj";
            this.btn_Save_Zqmj.Size = new System.Drawing.Size(75, 23);
            this.btn_Save_Zqmj.TabIndex = 52;
            this.btn_Save_Zqmj.Text = "保存(&S)";
            this.btn_Save_Zqmj.UseVisualStyleBackColor = true;
            this.btn_Save_Zqmj.Click += new System.EventHandler(this.btn_Save_Zqmj_Click);
            // 
            // txt_Zqmj
            // 
            this.txt_Zqmj.Location = new System.Drawing.Point(102, 27);
            this.txt_Zqmj.Name = "txt_Zqmj";
            this.txt_Zqmj.Size = new System.Drawing.Size(100, 21);
            this.txt_Zqmj.TabIndex = 54;
            // 
            // frmConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 347);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "配置";
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbb_wflx;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txt_Zqmj;
        private System.Windows.Forms.Button btn_Close_Zqmj;
        private System.Windows.Forms.Button btn_Save_Zqmj;
        private System.Windows.Forms.Label label2;
    }
}