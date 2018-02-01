namespace Ehl.Atms.Tgs.lifebelt_check
{
    partial class Form1
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Export = new System.Windows.Forms.Button();
            this.dtp_Start = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_Config = new System.Windows.Forms.Button();
            this.lbl_type = new System.Windows.Forms.Label();
            this.hphm_tb = new System.Windows.Forms.TextBox();
            this.buttonPrev = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.btn_serach = new System.Windows.Forms.Button();
            this.btn_Brower = new System.Windows.Forms.Button();
            this.txt_path = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_gwsj = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_kkmc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.interval_time = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.myCtrl = new zoom_image_ctrl.myZoomImageCtrl();
            this.myCtrl2 = new zoom_image_ctrl.myZoomImageCtrl();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.first_image_index_lb = new System.Windows.Forms.Label();
            this.screen_show_checkbox = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.qu_dd_lb = new System.Windows.Forms.Label();
            this.qu_dd_cb = new System.Windows.Forms.ComboBox();
            this.cllx_cb = new System.Windows.Forms.ComboBox();
            this.stop_dtp = new System.Windows.Forms.DateTimePicker();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.sec_xinxi_lb = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.sec_dd_lb = new System.Windows.Forms.Label();
            this.sec_gc_time_lb = new System.Windows.Forms.Label();
            this.sec_hp_lb = new System.Windows.Forms.Label();
            this.sec_dd_tb = new System.Windows.Forms.TextBox();
            this.sec_time_tb = new System.Windows.Forms.TextBox();
            this.sec_hp_tb = new System.Windows.Forms.TextBox();
            this.sec_pre_bt = new System.Windows.Forms.Button();
            this.sec_next_bt = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Export
            // 
            this.btn_Export.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_Export.Enabled = false;
            this.btn_Export.Location = new System.Drawing.Point(683, 5);
            this.btn_Export.Name = "btn_Export";
            this.btn_Export.Size = new System.Drawing.Size(75, 23);
            this.btn_Export.TabIndex = 0;
            this.btn_Export.Text = "导出(&E)";
            this.btn_Export.UseVisualStyleBackColor = true;
            this.btn_Export.Click += new System.EventHandler(this.btn_Export_Click);
            // 
            // dtp_Start
            // 
            this.dtp_Start.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp_Start.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtp_Start.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_Start.Location = new System.Drawing.Point(3, 7);
            this.dtp_Start.MaxDate = new System.DateTime(2115, 12, 31, 0, 0, 0, 0);
            this.dtp_Start.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtp_Start.Name = "dtp_Start";
            this.dtp_Start.Size = new System.Drawing.Size(154, 21);
            this.dtp_Start.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(33, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "号牌:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Close
            // 
            this.btn_Close.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_Close.Location = new System.Drawing.Point(889, 5);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(47, 23);
            this.btn_Close.TabIndex = 7;
            this.btn_Close.Text = "关闭(&C)";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btn_Config
            // 
            this.btn_Config.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_Config.Location = new System.Drawing.Point(793, 3);
            this.btn_Config.Name = "btn_Config";
            this.btn_Config.Size = new System.Drawing.Size(143, 30);
            this.btn_Config.TabIndex = 31;
            this.btn_Config.Text = "查找";
            this.btn_Config.UseVisualStyleBackColor = true;
            this.btn_Config.Click += new System.EventHandler(this.btn_Config_Click);
            // 
            // lbl_type
            // 
            this.lbl_type.AutoSize = true;
            this.lbl_type.Location = new System.Drawing.Point(500, 231);
            this.lbl_type.Name = "lbl_type";
            this.lbl_type.Size = new System.Drawing.Size(0, 12);
            this.lbl_type.TabIndex = 32;
            // 
            // hphm_tb
            // 
            this.hphm_tb.BackColor = System.Drawing.Color.White;
            this.hphm_tb.Location = new System.Drawing.Point(72, 95);
            this.hphm_tb.Name = "hphm_tb";
            this.hphm_tb.Size = new System.Drawing.Size(191, 21);
            this.hphm_tb.TabIndex = 1;
            // 
            // buttonPrev
            // 
            this.buttonPrev.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonPrev.Enabled = false;
            this.buttonPrev.Location = new System.Drawing.Point(56, 133);
            this.buttonPrev.Name = "buttonPrev";
            this.buttonPrev.Size = new System.Drawing.Size(178, 52);
            this.buttonPrev.TabIndex = 35;
            this.buttonPrev.Text = "上一张";
            this.buttonPrev.UseVisualStyleBackColor = true;
            this.buttonPrev.Click += new System.EventHandler(this.buttonPrev_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonNext.Enabled = false;
            this.buttonNext.Location = new System.Drawing.Point(320, 133);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(178, 52);
            this.buttonNext.TabIndex = 36;
            this.buttonNext.Text = "下一张";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // btn_serach
            // 
            this.btn_serach.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_serach.Enabled = false;
            this.btn_serach.Location = new System.Drawing.Point(19, 53);
            this.btn_serach.Name = "btn_serach";
            this.btn_serach.Size = new System.Drawing.Size(164, 35);
            this.btn_serach.TabIndex = 45;
            this.btn_serach.Text = "查找相关图片";
            this.btn_serach.UseVisualStyleBackColor = true;
            this.btn_serach.Click += new System.EventHandler(this.btn_serach_Click);
            // 
            // btn_Brower
            // 
            this.btn_Brower.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_Brower.Location = new System.Drawing.Point(598, 5);
            this.btn_Brower.Name = "btn_Brower";
            this.btn_Brower.Size = new System.Drawing.Size(75, 23);
            this.btn_Brower.TabIndex = 49;
            this.btn_Brower.Text = "浏览(&B)";
            this.btn_Brower.UseVisualStyleBackColor = true;
            this.btn_Brower.Click += new System.EventHandler(this.btn_Brower_Click);
            // 
            // txt_path
            // 
            this.txt_path.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_path.BackColor = System.Drawing.Color.White;
            this.txt_path.Location = new System.Drawing.Point(75, 6);
            this.txt_path.Name = "txt_path";
            this.txt_path.ReadOnly = true;
            this.txt_path.Size = new System.Drawing.Size(483, 21);
            this.txt_path.TabIndex = 48;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 47;
            this.label3.Text = "导出路径：";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_gwsj);
            this.groupBox1.Controls.Add(this.hphm_tb);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBox_kkmc);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 124);
            this.groupBox1.TabIndex = 59;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "车辆信息";
            // 
            // textBox_gwsj
            // 
            this.textBox_gwsj.BackColor = System.Drawing.Color.White;
            this.textBox_gwsj.Location = new System.Drawing.Point(70, 67);
            this.textBox_gwsj.Name = "textBox_gwsj";
            this.textBox_gwsj.ReadOnly = true;
            this.textBox_gwsj.Size = new System.Drawing.Size(193, 21);
            this.textBox_gwsj.TabIndex = 56;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 12);
            this.label7.TabIndex = 55;
            this.label7.Text = "过车时间:";
            // 
            // textBox_kkmc
            // 
            this.textBox_kkmc.BackColor = System.Drawing.Color.White;
            this.textBox_kkmc.Location = new System.Drawing.Point(70, 33);
            this.textBox_kkmc.Name = "textBox_kkmc";
            this.textBox_kkmc.ReadOnly = true;
            this.textBox_kkmc.Size = new System.Drawing.Size(193, 21);
            this.textBox_kkmc.TabIndex = 54;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 12);
            this.label6.TabIndex = 53;
            this.label6.Text = "地点:";
            // 
            // interval_time
            // 
            this.interval_time.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.interval_time.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.interval_time.FormattingEnabled = true;
            this.interval_time.Location = new System.Drawing.Point(19, 27);
            this.interval_time.Name = "interval_time";
            this.interval_time.Size = new System.Drawing.Size(164, 20);
            this.interval_time.TabIndex = 60;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.interval_time);
            this.groupBox2.Controls.Add(this.btn_serach);
            this.groupBox2.Location = new System.Drawing.Point(309, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(215, 108);
            this.groupBox2.TabIndex = 61;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "相关查询选项";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.myCtrl, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.myCtrl2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(400, 436);
            this.tableLayoutPanel1.TabIndex = 62;
            // 
            // myCtrl
            // 
            this.myCtrl.BackColor = System.Drawing.Color.Black;
            this.myCtrl.Cursor = System.Windows.Forms.Cursors.Cross;
            this.myCtrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myCtrl.filenamepath = null;
            this.myCtrl.ForeColor = System.Drawing.Color.Black;
            this.myCtrl.Location = new System.Drawing.Point(3, 3);
            this.myCtrl.Name = "myCtrl";
            this.myCtrl.Size = new System.Drawing.Size(394, 212);
            this.myCtrl.TabIndex = 0;
            // 
            // myCtrl2
            // 
            this.myCtrl2.BackColor = System.Drawing.Color.Black;
            this.myCtrl2.Cursor = System.Windows.Forms.Cursors.Cross;
            this.myCtrl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myCtrl2.filenamepath = null;
            this.myCtrl2.ForeColor = System.Drawing.Color.Black;
            this.myCtrl2.Location = new System.Drawing.Point(3, 221);
            this.myCtrl2.Name = "myCtrl2";
            this.myCtrl2.Size = new System.Drawing.Size(394, 212);
            this.myCtrl2.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 115F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txt_path, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_Brower, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_Close, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_Export, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.button1, 4, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 476);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(939, 33);
            this.tableLayoutPanel2.TabIndex = 63;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.21822F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.78178F));
            this.tableLayoutPanel3.Controls.Add(this.buttonPrev, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.groupBox2, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.buttonNext, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.first_image_index_lb, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.screen_show_checkbox, 1, 2);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(527, 218);
            this.tableLayoutPanel3.TabIndex = 64;
            // 
            // first_image_index_lb
            // 
            this.first_image_index_lb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.first_image_index_lb.AutoSize = true;
            this.first_image_index_lb.Location = new System.Drawing.Point(3, 197);
            this.first_image_index_lb.Name = "first_image_index_lb";
            this.first_image_index_lb.Size = new System.Drawing.Size(285, 12);
            this.first_image_index_lb.TabIndex = 62;
            this.first_image_index_lb.Text = "  ";
            this.first_image_index_lb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // screen_show_checkbox
            // 
            this.screen_show_checkbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.screen_show_checkbox.AutoSize = true;
            this.screen_show_checkbox.Location = new System.Drawing.Point(294, 195);
            this.screen_show_checkbox.Name = "screen_show_checkbox";
            this.screen_show_checkbox.Size = new System.Drawing.Size(230, 16);
            this.screen_show_checkbox.TabIndex = 63;
            this.screen_show_checkbox.Text = "全屏显示";
            this.screen_show_checkbox.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 6;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.Controls.Add(this.qu_dd_lb, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.qu_dd_cb, 3, 0);
            this.tableLayoutPanel4.Controls.Add(this.btn_Config, 5, 0);
            this.tableLayoutPanel4.Controls.Add(this.cllx_cb, 4, 0);
            this.tableLayoutPanel4.Controls.Add(this.dtp_Start, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.stop_dtp, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(939, 36);
            this.tableLayoutPanel4.TabIndex = 65;
            // 
            // qu_dd_lb
            // 
            this.qu_dd_lb.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.qu_dd_lb.AutoSize = true;
            this.qu_dd_lb.Font = new System.Drawing.Font("宋体", 10.5F);
            this.qu_dd_lb.Location = new System.Drawing.Point(345, 11);
            this.qu_dd_lb.Name = "qu_dd_lb";
            this.qu_dd_lb.Size = new System.Drawing.Size(77, 14);
            this.qu_dd_lb.TabIndex = 32;
            this.qu_dd_lb.Text = "违法地点：";
            // 
            // qu_dd_cb
            // 
            this.qu_dd_cb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.qu_dd_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.qu_dd_cb.FormattingEnabled = true;
            this.qu_dd_cb.Location = new System.Drawing.Point(428, 8);
            this.qu_dd_cb.Name = "qu_dd_cb";
            this.qu_dd_cb.Size = new System.Drawing.Size(194, 20);
            this.qu_dd_cb.TabIndex = 33;
            // 
            // cllx_cb
            // 
            this.cllx_cb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cllx_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cllx_cb.FormattingEnabled = true;
            this.cllx_cb.Items.AddRange(new object[] {
            "全部车辆",
            "小车",
            "大车"});
            this.cllx_cb.Location = new System.Drawing.Point(628, 8);
            this.cllx_cb.Name = "cllx_cb";
            this.cllx_cb.Size = new System.Drawing.Size(144, 20);
            this.cllx_cb.TabIndex = 34;
            // 
            // stop_dtp
            // 
            this.stop_dtp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.stop_dtp.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.stop_dtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.stop_dtp.Location = new System.Drawing.Point(163, 7);
            this.stop_dtp.Name = "stop_dtp";
            this.stop_dtp.Size = new System.Drawing.Size(154, 21);
            this.stop_dtp.TabIndex = 35;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(0, 36);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(939, 440);
            this.splitContainer1.SplitterDistance = 404;
            this.splitContainer1.TabIndex = 66;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.tableLayoutPanel3);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.groupBox3);
            this.splitContainer2.Size = new System.Drawing.Size(527, 436);
            this.splitContainer2.SplitterDistance = 218;
            this.splitContainer2.TabIndex = 66;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.sec_xinxi_lb);
            this.groupBox3.Controls.Add(this.tableLayoutPanel5);
            this.groupBox3.Controls.Add(this.sec_pre_bt);
            this.groupBox3.Controls.Add(this.sec_next_bt);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(527, 214);
            this.groupBox3.TabIndex = 65;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "车辆信息";
            // 
            // sec_xinxi_lb
            // 
            this.sec_xinxi_lb.AutoSize = true;
            this.sec_xinxi_lb.Location = new System.Drawing.Point(219, 190);
            this.sec_xinxi_lb.Name = "sec_xinxi_lb";
            this.sec_xinxi_lb.Size = new System.Drawing.Size(17, 12);
            this.sec_xinxi_lb.TabIndex = 5;
            this.sec_xinxi_lb.Text = "  ";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.Controls.Add(this.sec_dd_lb, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.sec_gc_time_lb, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.sec_hp_lb, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.sec_dd_tb, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.sec_time_tb, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.sec_hp_tb, 1, 2);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(32, 20);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 3;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(430, 104);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // sec_dd_lb
            // 
            this.sec_dd_lb.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.sec_dd_lb.AutoSize = true;
            this.sec_dd_lb.Location = new System.Drawing.Point(46, 11);
            this.sec_dd_lb.Name = "sec_dd_lb";
            this.sec_dd_lb.Size = new System.Drawing.Size(41, 12);
            this.sec_dd_lb.TabIndex = 0;
            this.sec_dd_lb.Text = "地点：";
            // 
            // sec_gc_time_lb
            // 
            this.sec_gc_time_lb.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.sec_gc_time_lb.AutoSize = true;
            this.sec_gc_time_lb.Location = new System.Drawing.Point(22, 45);
            this.sec_gc_time_lb.Name = "sec_gc_time_lb";
            this.sec_gc_time_lb.Size = new System.Drawing.Size(65, 12);
            this.sec_gc_time_lb.TabIndex = 1;
            this.sec_gc_time_lb.Text = "过车时间：";
            // 
            // sec_hp_lb
            // 
            this.sec_hp_lb.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.sec_hp_lb.AutoSize = true;
            this.sec_hp_lb.Location = new System.Drawing.Point(46, 80);
            this.sec_hp_lb.Name = "sec_hp_lb";
            this.sec_hp_lb.Size = new System.Drawing.Size(41, 12);
            this.sec_hp_lb.TabIndex = 2;
            this.sec_hp_lb.Text = "号牌：";
            // 
            // sec_dd_tb
            // 
            this.sec_dd_tb.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.sec_dd_tb.BackColor = System.Drawing.Color.White;
            this.sec_dd_tb.Location = new System.Drawing.Point(93, 6);
            this.sec_dd_tb.Name = "sec_dd_tb";
            this.sec_dd_tb.ReadOnly = true;
            this.sec_dd_tb.Size = new System.Drawing.Size(326, 21);
            this.sec_dd_tb.TabIndex = 5;
            // 
            // sec_time_tb
            // 
            this.sec_time_tb.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.sec_time_tb.BackColor = System.Drawing.Color.White;
            this.sec_time_tb.Location = new System.Drawing.Point(93, 40);
            this.sec_time_tb.Name = "sec_time_tb";
            this.sec_time_tb.ReadOnly = true;
            this.sec_time_tb.Size = new System.Drawing.Size(326, 21);
            this.sec_time_tb.TabIndex = 6;
            // 
            // sec_hp_tb
            // 
            this.sec_hp_tb.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.sec_hp_tb.BackColor = System.Drawing.Color.White;
            this.sec_hp_tb.Location = new System.Drawing.Point(93, 75);
            this.sec_hp_tb.Name = "sec_hp_tb";
            this.sec_hp_tb.Size = new System.Drawing.Size(326, 21);
            this.sec_hp_tb.TabIndex = 7;
            // 
            // sec_pre_bt
            // 
            this.sec_pre_bt.Enabled = false;
            this.sec_pre_bt.Location = new System.Drawing.Point(62, 136);
            this.sec_pre_bt.Name = "sec_pre_bt";
            this.sec_pre_bt.Size = new System.Drawing.Size(135, 34);
            this.sec_pre_bt.TabIndex = 3;
            this.sec_pre_bt.Text = "上一张";
            this.sec_pre_bt.UseVisualStyleBackColor = true;
            this.sec_pre_bt.Click += new System.EventHandler(this.sec_pre_bt_Click);
            // 
            // sec_next_bt
            // 
            this.sec_next_bt.Enabled = false;
            this.sec_next_bt.Location = new System.Drawing.Point(317, 136);
            this.sec_next_bt.Name = "sec_next_bt";
            this.sec_next_bt.Size = new System.Drawing.Size(135, 34);
            this.sec_next_bt.TabIndex = 4;
            this.sec_next_bt.Text = "下 一张";
            this.sec_next_bt.UseVisualStyleBackColor = true;
            this.sec_next_bt.Click += new System.EventHandler(this.sec_next_bt_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(764, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 27);
            this.button1.TabIndex = 50;
            this.button1.Text = "设置";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 509);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.lbl_type);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "安全带查询";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Export;
        private System.Windows.Forms.DateTimePicker dtp_Start;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btn_Config;
        private System.Windows.Forms.Label lbl_type;
        private System.Windows.Forms.TextBox hphm_tb;
        private System.Windows.Forms.Button buttonPrev;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button btn_serach;
        private System.Windows.Forms.Button btn_Brower;
        private System.Windows.Forms.TextBox txt_path;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_gwsj;
        private System.Windows.Forms.TextBox textBox_kkmc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox interval_time;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private zoom_image_ctrl.myZoomImageCtrl myCtrl;
        private zoom_image_ctrl.myZoomImageCtrl myCtrl2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label sec_dd_lb;
        private System.Windows.Forms.Label sec_gc_time_lb;
        private System.Windows.Forms.Label sec_hp_lb;
        private System.Windows.Forms.Button sec_pre_bt;
        private System.Windows.Forms.Button sec_next_bt;
        private System.Windows.Forms.TextBox sec_dd_tb;
        private System.Windows.Forms.TextBox sec_time_tb;
        private System.Windows.Forms.TextBox sec_hp_tb;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label sec_xinxi_lb;
        private System.Windows.Forms.Label qu_dd_lb;
        private System.Windows.Forms.ComboBox qu_dd_cb;
        private System.Windows.Forms.ComboBox cllx_cb;
        private System.Windows.Forms.Label first_image_index_lb;
        private System.Windows.Forms.DateTimePicker stop_dtp;
        private System.Windows.Forms.CheckBox screen_show_checkbox;
        private System.Windows.Forms.Button button1;
    }
}

