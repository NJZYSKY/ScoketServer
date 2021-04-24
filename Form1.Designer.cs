namespace ScoketServer
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonConn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxIP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelInfo = new System.Windows.Forms.Label();
            this.groupBox_S = new System.Windows.Forms.GroupBox();
            this.textBoxCmd = new System.Windows.Forms.TextBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.groupBox_R = new System.Windows.Forms.GroupBox();
            this.radioButton_R_ASCII = new System.Windows.Forms.RadioButton();
            this.radioButton_R_HEX = new System.Windows.Forms.RadioButton();
            this.checkBox_LineFeed = new System.Windows.Forms.CheckBox();
            this.checkBox_ShowSend = new System.Windows.Forms.CheckBox();
            this.checkBox_ShowTime = new System.Windows.Forms.CheckBox();
            this.radioButton_S_HEX = new System.Windows.Forms.RadioButton();
            this.radioButton_S_ASCII = new System.Windows.Forms.RadioButton();
            this.checkBox_ReSend = new System.Windows.Forms.CheckBox();
            this.numericUpDown_ReSend = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.checkBoxShowType = new System.Windows.Forms.CheckBox();
            this.checkBox_FromTo = new System.Windows.Forms.CheckBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label发送状态 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.label服务器连接状态 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.label发送 = new System.Windows.Forms.ToolStripStatusLabel();
            this.label接收 = new System.Windows.Forms.ToolStripStatusLabel();
            this.label数据记录 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBox_DataSavePath = new System.Windows.Forms.TextBox();
            this.textBox_DataSaveName = new System.Windows.Forms.TextBox();
            this.button_Path = new System.Windows.Forms.Button();
            this.button_Name = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.checkBox_Path = new System.Windows.Forms.CheckBox();
            this.checkBox_Name = new System.Windows.Forms.CheckBox();
            this.process1 = new System.Diagnostics.Process();
            this.comboBoxIP = new System.Windows.Forms.ListBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.buttonHisClear = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.编辑ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.视图ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新建ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开配置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新建配置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.配置另存为ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存消息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开消息日志ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开消息日志文件夹ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.开始ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.暂停ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.停止ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.清除消息显示ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.清除历史记录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.更新记录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox_S.SuspendLayout();
            this.groupBox_R.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ReSend)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonConn
            // 
            this.buttonConn.Location = new System.Drawing.Point(13, 197);
            this.buttonConn.Name = "buttonConn";
            this.buttonConn.Size = new System.Drawing.Size(75, 23);
            this.buttonConn.TabIndex = 0;
            this.buttonConn.Text = "连接服务器";
            this.buttonConn.UseVisualStyleBackColor = true;
            this.buttonConn.Click += new System.EventHandler(this.buttonConn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(3, 17);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(426, 249);
            this.textBox1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.textBoxPort);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxIP);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(220, 179);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "通讯设置";
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox2.Font = new System.Drawing.Font("宋体", 12F);
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Client",
            "Server"});
            this.comboBox2.Location = new System.Drawing.Point(75, 57);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(135, 24);
            this.comboBox2.TabIndex = 4;
            this.comboBox2.Text = "Client";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.comboBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.Font = new System.Drawing.Font("宋体", 12F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "TCP/UDP",
            "串口(不可用)"});
            this.comboBox1.Location = new System.Drawing.Point(75, 20);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(135, 24);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.Text = "TCP/UDP";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBoxPort
            // 
            this.textBoxPort.Font = new System.Drawing.Font("宋体", 12F);
            this.textBoxPort.Location = new System.Drawing.Point(75, 139);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(135, 26);
            this.textBoxPort.TabIndex = 3;
            this.textBoxPort.Text = "2000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(32, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "端口：";
            // 
            // textBoxIP
            // 
            this.textBoxIP.Font = new System.Drawing.Font("宋体", 12F);
            this.textBoxIP.Location = new System.Drawing.Point(75, 98);
            this.textBoxIP.Name = "textBoxIP";
            this.textBoxIP.Size = new System.Drawing.Size(135, 26);
            this.textBoxIP.TabIndex = 1;
            this.textBoxIP.Text = "127.0.0.1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(32, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "模式：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(6, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "通讯类型：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(5, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "服务器IP：";
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Location = new System.Drawing.Point(130, -16);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(0, 12);
            this.labelInfo.TabIndex = 6;
            // 
            // groupBox_S
            // 
            this.groupBox_S.Controls.Add(this.textBoxCmd);
            this.groupBox_S.Location = new System.Drawing.Point(244, 299);
            this.groupBox_S.Name = "groupBox_S";
            this.groupBox_S.Size = new System.Drawing.Size(262, 97);
            this.groupBox_S.TabIndex = 9;
            this.groupBox_S.TabStop = false;
            this.groupBox_S.Text = "发送ASCII指令";
            // 
            // textBoxCmd
            // 
            this.textBoxCmd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxCmd.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxCmd.Location = new System.Drawing.Point(3, 17);
            this.textBoxCmd.Multiline = true;
            this.textBoxCmd.Name = "textBoxCmd";
            this.textBoxCmd.Size = new System.Drawing.Size(256, 77);
            this.textBoxCmd.TabIndex = 1;
            // 
            // buttonSend
            // 
            this.buttonSend.Enabled = false;
            this.buttonSend.Location = new System.Drawing.Point(150, 197);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(75, 23);
            this.buttonSend.TabIndex = 0;
            this.buttonSend.Text = "发送数据";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // groupBox_R
            // 
            this.groupBox_R.Controls.Add(this.textBox1);
            this.groupBox_R.Location = new System.Drawing.Point(244, 12);
            this.groupBox_R.Name = "groupBox_R";
            this.groupBox_R.Size = new System.Drawing.Size(432, 269);
            this.groupBox_R.TabIndex = 8;
            this.groupBox_R.TabStop = false;
            this.groupBox_R.Text = "接收ASCII数据";
            // 
            // radioButton_R_ASCII
            // 
            this.radioButton_R_ASCII.AutoSize = true;
            this.radioButton_R_ASCII.Checked = true;
            this.radioButton_R_ASCII.Location = new System.Drawing.Point(16, 23);
            this.radioButton_R_ASCII.Name = "radioButton_R_ASCII";
            this.radioButton_R_ASCII.Size = new System.Drawing.Size(53, 16);
            this.radioButton_R_ASCII.TabIndex = 10;
            this.radioButton_R_ASCII.TabStop = true;
            this.radioButton_R_ASCII.Text = "ASCII";
            this.radioButton_R_ASCII.UseVisualStyleBackColor = true;
            this.radioButton_R_ASCII.CheckedChanged += new System.EventHandler(this.radioButton_R_ASCII_CheckedChanged);
            // 
            // radioButton_R_HEX
            // 
            this.radioButton_R_HEX.AutoSize = true;
            this.radioButton_R_HEX.Location = new System.Drawing.Point(116, 23);
            this.radioButton_R_HEX.Name = "radioButton_R_HEX";
            this.radioButton_R_HEX.Size = new System.Drawing.Size(41, 16);
            this.radioButton_R_HEX.TabIndex = 10;
            this.radioButton_R_HEX.TabStop = true;
            this.radioButton_R_HEX.Text = "HEX";
            this.radioButton_R_HEX.UseVisualStyleBackColor = true;
            this.radioButton_R_HEX.CheckedChanged += new System.EventHandler(this.radioButton_R_HEX_CheckedChanged);
            // 
            // checkBox_LineFeed
            // 
            this.checkBox_LineFeed.AutoSize = true;
            this.checkBox_LineFeed.Checked = true;
            this.checkBox_LineFeed.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_LineFeed.Location = new System.Drawing.Point(16, 45);
            this.checkBox_LineFeed.Name = "checkBox_LineFeed";
            this.checkBox_LineFeed.Size = new System.Drawing.Size(72, 16);
            this.checkBox_LineFeed.TabIndex = 11;
            this.checkBox_LineFeed.Text = "自动换行";
            this.checkBox_LineFeed.UseVisualStyleBackColor = true;
            // 
            // checkBox_ShowSend
            // 
            this.checkBox_ShowSend.AutoSize = true;
            this.checkBox_ShowSend.Checked = true;
            this.checkBox_ShowSend.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_ShowSend.Location = new System.Drawing.Point(16, 67);
            this.checkBox_ShowSend.Name = "checkBox_ShowSend";
            this.checkBox_ShowSend.Size = new System.Drawing.Size(72, 16);
            this.checkBox_ShowSend.TabIndex = 11;
            this.checkBox_ShowSend.Text = "显示发送";
            this.checkBox_ShowSend.UseVisualStyleBackColor = true;
            // 
            // checkBox_ShowTime
            // 
            this.checkBox_ShowTime.AutoSize = true;
            this.checkBox_ShowTime.Checked = true;
            this.checkBox_ShowTime.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_ShowTime.Location = new System.Drawing.Point(16, 89);
            this.checkBox_ShowTime.Name = "checkBox_ShowTime";
            this.checkBox_ShowTime.Size = new System.Drawing.Size(72, 16);
            this.checkBox_ShowTime.TabIndex = 11;
            this.checkBox_ShowTime.Text = "显示时间";
            this.checkBox_ShowTime.UseVisualStyleBackColor = true;
            // 
            // radioButton_S_HEX
            // 
            this.radioButton_S_HEX.AutoSize = true;
            this.radioButton_S_HEX.Location = new System.Drawing.Point(116, 28);
            this.radioButton_S_HEX.Name = "radioButton_S_HEX";
            this.radioButton_S_HEX.Size = new System.Drawing.Size(41, 16);
            this.radioButton_S_HEX.TabIndex = 12;
            this.radioButton_S_HEX.TabStop = true;
            this.radioButton_S_HEX.Text = "HEX";
            this.radioButton_S_HEX.UseVisualStyleBackColor = true;
            this.radioButton_S_HEX.CheckedChanged += new System.EventHandler(this.radioButton_S_HEX_CheckedChanged);
            // 
            // radioButton_S_ASCII
            // 
            this.radioButton_S_ASCII.AutoSize = true;
            this.radioButton_S_ASCII.Checked = true;
            this.radioButton_S_ASCII.Location = new System.Drawing.Point(16, 28);
            this.radioButton_S_ASCII.Name = "radioButton_S_ASCII";
            this.radioButton_S_ASCII.Size = new System.Drawing.Size(53, 16);
            this.radioButton_S_ASCII.TabIndex = 13;
            this.radioButton_S_ASCII.TabStop = true;
            this.radioButton_S_ASCII.Text = "ASCII";
            this.radioButton_S_ASCII.UseVisualStyleBackColor = true;
            this.radioButton_S_ASCII.CheckedChanged += new System.EventHandler(this.radioButton_S_ASCII_CheckedChanged);
            // 
            // checkBox_ReSend
            // 
            this.checkBox_ReSend.AutoSize = true;
            this.checkBox_ReSend.Location = new System.Drawing.Point(16, 54);
            this.checkBox_ReSend.Name = "checkBox_ReSend";
            this.checkBox_ReSend.Size = new System.Drawing.Size(72, 16);
            this.checkBox_ReSend.TabIndex = 14;
            this.checkBox_ReSend.Text = "自动重发";
            this.checkBox_ReSend.UseVisualStyleBackColor = true;
            this.checkBox_ReSend.CheckedChanged += new System.EventHandler(this.checkBox_ReSend_CheckedChanged);
            // 
            // numericUpDown_ReSend
            // 
            this.numericUpDown_ReSend.Location = new System.Drawing.Point(116, 52);
            this.numericUpDown_ReSend.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericUpDown_ReSend.Name = "numericUpDown_ReSend";
            this.numericUpDown_ReSend.Size = new System.Drawing.Size(74, 21);
            this.numericUpDown_ReSend.TabIndex = 15;
            this.numericUpDown_ReSend.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown_ReSend.ValueChanged += new System.EventHandler(this.numericUpDown_ReSend_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(196, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 12);
            this.label5.TabIndex = 16;
            this.label5.Text = "ms";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.numericUpDown_ReSend);
            this.groupBox4.Controls.Add(this.checkBox_ReSend);
            this.groupBox4.Controls.Add(this.radioButton_S_HEX);
            this.groupBox4.Controls.Add(this.radioButton_S_ASCII);
            this.groupBox4.Location = new System.Drawing.Point(13, 352);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(220, 84);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "发送设置";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.checkBoxShowType);
            this.groupBox5.Controls.Add(this.checkBox_FromTo);
            this.groupBox5.Controls.Add(this.checkBox_ShowTime);
            this.groupBox5.Controls.Add(this.checkBox_ShowSend);
            this.groupBox5.Controls.Add(this.checkBox_LineFeed);
            this.groupBox5.Controls.Add(this.radioButton_R_HEX);
            this.groupBox5.Controls.Add(this.radioButton_R_ASCII);
            this.groupBox5.Location = new System.Drawing.Point(12, 232);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(220, 114);
            this.groupBox5.TabIndex = 18;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "接收设置";
            // 
            // checkBoxShowType
            // 
            this.checkBoxShowType.AutoSize = true;
            this.checkBoxShowType.Checked = true;
            this.checkBoxShowType.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxShowType.Location = new System.Drawing.Point(116, 67);
            this.checkBoxShowType.Name = "checkBoxShowType";
            this.checkBoxShowType.Size = new System.Drawing.Size(72, 16);
            this.checkBoxShowType.TabIndex = 13;
            this.checkBoxShowType.Text = "显示类型";
            this.checkBoxShowType.UseVisualStyleBackColor = true;
            // 
            // checkBox_FromTo
            // 
            this.checkBox_FromTo.AutoSize = true;
            this.checkBox_FromTo.Checked = true;
            this.checkBox_FromTo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_FromTo.Location = new System.Drawing.Point(116, 45);
            this.checkBox_FromTo.Name = "checkBox_FromTo";
            this.checkBox_FromTo.Size = new System.Drawing.Size(72, 16);
            this.checkBox_FromTo.TabIndex = 12;
            this.checkBox_FromTo.Text = "显示来源";
            this.checkBox_FromTo.UseVisualStyleBackColor = true;
            // 
            // comboBox3
            // 
            this.comboBox3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.comboBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox3.Font = new System.Drawing.Font("宋体", 12F);
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(247, 412);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(276, 24);
            this.comboBox3.TabIndex = 5;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // label发送状态
            // 
            this.label发送状态.AutoSize = true;
            this.label发送状态.Location = new System.Drawing.Point(357, 284);
            this.label发送状态.Name = "label发送状态";
            this.label发送状态.Size = new System.Drawing.Size(53, 12);
            this.label发送状态.TabIndex = 20;
            this.label发送状态.Text = "发送状态";
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.Info;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.label服务器连接状态,
            this.toolStripProgressBar1,
            this.label发送,
            this.label接收,
            this.label数据记录});
            this.statusStrip1.Location = new System.Drawing.Point(0, 527);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.Size = new System.Drawing.Size(685, 22);
            this.statusStrip1.TabIndex = 25;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // label服务器连接状态
            // 
            this.label服务器连接状态.Name = "label服务器连接状态";
            this.label服务器连接状态.Size = new System.Drawing.Size(92, 17);
            this.label服务器连接状态.Text = "服务器连接状态";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripProgressBar1.CausesValidation = false;
            this.toolStripProgressBar1.ForeColor = System.Drawing.Color.GreenYellow;
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // label发送
            // 
            this.label发送.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.label发送.Name = "label发送";
            this.label发送.Size = new System.Drawing.Size(158, 17);
            this.label发送.Spring = true;
            this.label发送.Text = "发送：";
            // 
            // label接收
            // 
            this.label接收.Name = "label接收";
            this.label接收.Size = new System.Drawing.Size(158, 17);
            this.label接收.Spring = true;
            this.label接收.Text = "接收：";
            // 
            // label数据记录
            // 
            this.label数据记录.Name = "label数据记录";
            this.label数据记录.Size = new System.Drawing.Size(158, 17);
            this.label数据记录.Spring = true;
            this.label数据记录.Text = "数据记录：";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // textBox_DataSavePath
            // 
            this.textBox_DataSavePath.Location = new System.Drawing.Point(288, 10);
            this.textBox_DataSavePath.Multiline = true;
            this.textBox_DataSavePath.Name = "textBox_DataSavePath";
            this.textBox_DataSavePath.ReadOnly = true;
            this.textBox_DataSavePath.Size = new System.Drawing.Size(367, 51);
            this.textBox_DataSavePath.TabIndex = 26;
            // 
            // textBox_DataSaveName
            // 
            this.textBox_DataSaveName.Location = new System.Drawing.Point(61, 40);
            this.textBox_DataSaveName.Name = "textBox_DataSaveName";
            this.textBox_DataSaveName.ReadOnly = true;
            this.textBox_DataSaveName.Size = new System.Drawing.Size(159, 21);
            this.textBox_DataSaveName.TabIndex = 28;
            // 
            // button_Path
            // 
            this.button_Path.Enabled = false;
            this.button_Path.Location = new System.Drawing.Point(137, 11);
            this.button_Path.Name = "button_Path";
            this.button_Path.Size = new System.Drawing.Size(73, 23);
            this.button_Path.TabIndex = 30;
            this.button_Path.Text = "默认Path";
            this.button_Path.UseVisualStyleBackColor = true;
            this.button_Path.Click += new System.EventHandler(this.button_Path_Click);
            // 
            // button_Name
            // 
            this.button_Name.Enabled = false;
            this.button_Name.Location = new System.Drawing.Point(61, 11);
            this.button_Name.Name = "button_Name";
            this.button_Name.Size = new System.Drawing.Size(73, 23);
            this.button_Name.TabIndex = 31;
            this.button_Name.Text = "默认Name";
            this.button_Name.UseVisualStyleBackColor = true;
            this.button_Name.Click += new System.EventHandler(this.button_Name_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonOpen);
            this.groupBox2.Controls.Add(this.textBox_DataSaveName);
            this.groupBox2.Controls.Add(this.checkBox_Path);
            this.groupBox2.Controls.Add(this.checkBox_Name);
            this.groupBox2.Controls.Add(this.button_Name);
            this.groupBox2.Controls.Add(this.textBox_DataSavePath);
            this.groupBox2.Controls.Add(this.button_Path);
            this.groupBox2.Location = new System.Drawing.Point(13, 442);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(663, 70);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "数据记录";
            // 
            // buttonOpen
            // 
            this.buttonOpen.Location = new System.Drawing.Point(216, 11);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(56, 23);
            this.buttonOpen.TabIndex = 32;
            this.buttonOpen.Text = "Open";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // checkBox_Path
            // 
            this.checkBox_Path.AutoSize = true;
            this.checkBox_Path.Location = new System.Drawing.Point(234, 45);
            this.checkBox_Path.Name = "checkBox_Path";
            this.checkBox_Path.Size = new System.Drawing.Size(48, 16);
            this.checkBox_Path.TabIndex = 12;
            this.checkBox_Path.Text = "Path";
            this.checkBox_Path.UseVisualStyleBackColor = true;
            this.checkBox_Path.CheckedChanged += new System.EventHandler(this.checkBox_Path_CheckedChanged);
            // 
            // checkBox_Name
            // 
            this.checkBox_Name.AutoSize = true;
            this.checkBox_Name.Location = new System.Drawing.Point(7, 45);
            this.checkBox_Name.Name = "checkBox_Name";
            this.checkBox_Name.Size = new System.Drawing.Size(48, 16);
            this.checkBox_Name.TabIndex = 13;
            this.checkBox_Name.Text = "Name";
            this.checkBox_Name.UseVisualStyleBackColor = true;
            this.checkBox_Name.CheckedChanged += new System.EventHandler(this.checkBox_Name_CheckedChanged);
            // 
            // process1
            // 
            this.process1.StartInfo.Domain = "";
            this.process1.StartInfo.LoadUserProfile = false;
            this.process1.StartInfo.Password = null;
            this.process1.StartInfo.StandardErrorEncoding = null;
            this.process1.StartInfo.StandardOutputEncoding = null;
            this.process1.StartInfo.UserName = "";
            this.process1.SynchronizingObject = this;
            // 
            // comboBoxIP
            // 
            this.comboBoxIP.FormattingEnabled = true;
            this.comboBoxIP.ItemHeight = 12;
            this.comboBoxIP.Location = new System.Drawing.Point(512, 317);
            this.comboBoxIP.Name = "comboBoxIP";
            this.comboBoxIP.Size = new System.Drawing.Size(156, 76);
            this.comboBoxIP.TabIndex = 33;
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // buttonHisClear
            // 
            this.buttonHisClear.Location = new System.Drawing.Point(529, 414);
            this.buttonHisClear.Name = "buttonHisClear";
            this.buttonHisClear.Size = new System.Drawing.Size(139, 23);
            this.buttonHisClear.TabIndex = 34;
            this.buttonHisClear.Text = "Clear";
            this.buttonHisClear.UseVisualStyleBackColor = true;
            this.buttonHisClear.Click += new System.EventHandler(this.buttonHisClear_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.编辑ToolStripMenuItem,
            this.视图ToolStripMenuItem,
            this.设置ToolStripMenuItem,
            this.关于ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(685, 25);
            this.menuStrip1.TabIndex = 35;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新建ToolStripMenuItem,
            this.打开配置ToolStripMenuItem,
            this.新建配置ToolStripMenuItem,
            this.配置另存为ToolStripMenuItem,
            this.保存消息ToolStripMenuItem,
            this.打开消息日志ToolStripMenuItem,
            this.打开消息日志文件夹ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // 编辑ToolStripMenuItem
            // 
            this.编辑ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.开始ToolStripMenuItem,
            this.暂停ToolStripMenuItem,
            this.停止ToolStripMenuItem,
            this.清除消息显示ToolStripMenuItem,
            this.清除历史记录ToolStripMenuItem});
            this.编辑ToolStripMenuItem.Name = "编辑ToolStripMenuItem";
            this.编辑ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.编辑ToolStripMenuItem.Text = "编辑";
            // 
            // 视图ToolStripMenuItem
            // 
            this.视图ToolStripMenuItem.Name = "视图ToolStripMenuItem";
            this.视图ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.视图ToolStripMenuItem.Text = "视图";
            // 
            // 设置ToolStripMenuItem
            // 
            this.设置ToolStripMenuItem.Name = "设置ToolStripMenuItem";
            this.设置ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.设置ToolStripMenuItem.Text = "设置";
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.更新记录ToolStripMenuItem});
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.关于ToolStripMenuItem.Text = "帮助";
            // 
            // 新建ToolStripMenuItem
            // 
            this.新建ToolStripMenuItem.Name = "新建ToolStripMenuItem";
            this.新建ToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.新建ToolStripMenuItem.Text = "新建";
            // 
            // 打开配置ToolStripMenuItem
            // 
            this.打开配置ToolStripMenuItem.Name = "打开配置ToolStripMenuItem";
            this.打开配置ToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.打开配置ToolStripMenuItem.Text = "打开配置";
            // 
            // 新建配置ToolStripMenuItem
            // 
            this.新建配置ToolStripMenuItem.Name = "新建配置ToolStripMenuItem";
            this.新建配置ToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.新建配置ToolStripMenuItem.Text = "新建配置";
            // 
            // 配置另存为ToolStripMenuItem
            // 
            this.配置另存为ToolStripMenuItem.Name = "配置另存为ToolStripMenuItem";
            this.配置另存为ToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.配置另存为ToolStripMenuItem.Text = "配置另存为";
            // 
            // 保存消息ToolStripMenuItem
            // 
            this.保存消息ToolStripMenuItem.Name = "保存消息ToolStripMenuItem";
            this.保存消息ToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.保存消息ToolStripMenuItem.Text = "保存消息";
            // 
            // 打开消息日志ToolStripMenuItem
            // 
            this.打开消息日志ToolStripMenuItem.Name = "打开消息日志ToolStripMenuItem";
            this.打开消息日志ToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.打开消息日志ToolStripMenuItem.Text = "打开消息日志";
            // 
            // 打开消息日志文件夹ToolStripMenuItem
            // 
            this.打开消息日志文件夹ToolStripMenuItem.Name = "打开消息日志文件夹ToolStripMenuItem";
            this.打开消息日志文件夹ToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.打开消息日志文件夹ToolStripMenuItem.Text = "打开消息日志文件夹";
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            // 
            // 开始ToolStripMenuItem
            // 
            this.开始ToolStripMenuItem.Name = "开始ToolStripMenuItem";
            this.开始ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.开始ToolStripMenuItem.Text = "开始";
            // 
            // 暂停ToolStripMenuItem
            // 
            this.暂停ToolStripMenuItem.Name = "暂停ToolStripMenuItem";
            this.暂停ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.暂停ToolStripMenuItem.Text = "暂停";
            // 
            // 停止ToolStripMenuItem
            // 
            this.停止ToolStripMenuItem.Name = "停止ToolStripMenuItem";
            this.停止ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.停止ToolStripMenuItem.Text = "停止";
            // 
            // 清除消息显示ToolStripMenuItem
            // 
            this.清除消息显示ToolStripMenuItem.Name = "清除消息显示ToolStripMenuItem";
            this.清除消息显示ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.清除消息显示ToolStripMenuItem.Text = "清除消息显示";
            // 
            // 清除历史记录ToolStripMenuItem
            // 
            this.清除历史记录ToolStripMenuItem.Name = "清除历史记录ToolStripMenuItem";
            this.清除历史记录ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.清除历史记录ToolStripMenuItem.Text = "清除历史记录";
            // 
            // 更新记录ToolStripMenuItem
            // 
            this.更新记录ToolStripMenuItem.Name = "更新记录ToolStripMenuItem";
            this.更新记录ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.更新记录ToolStripMenuItem.Text = "更新记录";
            this.更新记录ToolStripMenuItem.Click += new System.EventHandler(this.更新记录ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 549);
            this.Controls.Add(this.buttonHisClear);
            this.Controls.Add(this.label发送状态);
            this.Controls.Add(this.comboBoxIP);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox_S);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.buttonConn);
            this.Controls.Add(this.groupBox_R);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Socket客户端";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox_S.ResumeLayout(false);
            this.groupBox_S.PerformLayout();
            this.groupBox_R.ResumeLayout(false);
            this.groupBox_R.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ReSend)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonConn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxIP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.GroupBox groupBox_S;
        private System.Windows.Forms.TextBox textBoxCmd;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.GroupBox groupBox_R;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButton_R_ASCII;
        private System.Windows.Forms.RadioButton radioButton_R_HEX;
        private System.Windows.Forms.CheckBox checkBox_LineFeed;
        private System.Windows.Forms.CheckBox checkBox_ShowSend;
        private System.Windows.Forms.CheckBox checkBox_ShowTime;
        private System.Windows.Forms.RadioButton radioButton_S_HEX;
        private System.Windows.Forms.RadioButton radioButton_S_ASCII;
        private System.Windows.Forms.CheckBox checkBox_ReSend;
        private System.Windows.Forms.NumericUpDown numericUpDown_ReSend;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label发送状态;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripStatusLabel label数据记录;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripStatusLabel label服务器连接状态;
        private System.Windows.Forms.ToolStripStatusLabel label发送;
        private System.Windows.Forms.ToolStripStatusLabel label接收;
        private System.Windows.Forms.TextBox textBox_DataSavePath;
        private System.Windows.Forms.TextBox textBox_DataSaveName;
        private System.Windows.Forms.Button button_Path;
        private System.Windows.Forms.Button button_Name;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBox_Path;
        private System.Windows.Forms.CheckBox checkBox_Name;
        private System.Windows.Forms.CheckBox checkBox_FromTo;
        private System.Windows.Forms.Button buttonOpen;
        private System.Diagnostics.Process process1;
        private System.Windows.Forms.CheckBox checkBoxShowType;
        private System.Windows.Forms.ListBox comboBoxIP;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button buttonHisClear;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新建ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开配置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新建配置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 配置另存为ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保存消息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开消息日志ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开消息日志文件夹ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 编辑ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 开始ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 暂停ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 停止ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 清除消息显示ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 清除历史记录ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 视图ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 更新记录ToolStripMenuItem;
    }
}