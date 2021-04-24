using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using ClassLibrary1;

namespace ScoketServer
{
    public partial class Form1 : Form
    {
        int count = 0;
        Client Client = new Client();
        SocketServer server = new SocketServer();
        Int64 LenR = 0;
        Int64 lenS = 0;
        string listenIP;

        public Form1()
        {
            //仅执行一次
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;//禁用跨线程操作检测
            textBox_DataSavePath.Text = Application.StartupPath;//获取可执行文件当前目录
            textBox_DataSaveName.Text = "ScoketClient_S_R_LOG";//设置记录文件名称
            Client.onReceive += new Client.ReceiveEvent(Client_onReceive); //指定响应事件时要调用的方法
            Client.onConnect += new Client.ConnectEvent(Client_onConnect);
            server.onReceive += new SocketServer.ReceiveEvent(server_onReceive);
            server.onConnect += new SocketServer.ConnectEvent(server_onConnect);
        }

        void Client_onConnect(Dictionary<string, System.Net.Sockets.Socket> dict)
        {
            //MessageBox.Show("连接了新客户端！", "客户端连接", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        void Client_onReceive(string ip, byte[] data, int length)
        {
            listenIP = ip;
            string A_H = "ASCII";//设置默认格式
            string strMessage = "";//清空缓存
            byte[] cardData = new byte[length];
            string strCard = "";
            try
            {
                if (this.textBox1.Text.Length > 10000)//如果显示框显示字符数大于10000，则清空
                    this.textBox1.Text = "";
                if (length == 0) return;//如果长度为0，则不执行下面的代码
                count += 1;//接收数据计数
                groupBox_R.Text = "接收数据：" + count;
                for (int i = 0; i < length; i += 1)//将数组有效数据转移至指定长度的数组中
                {
                    cardData[i] = data[i];
                }
                if (radioButton_R_ASCII.Checked == true)//判断数据接收格式
                {
                    A_H = "ASCII";
                    strCard = System.Text.Encoding.ASCII.GetString(cardData);//数据类型转换为等效的ASCII
                }
                else if (radioButton_R_HEX.Checked == true)
                {
                    A_H = "HEX";
                    strCard = byteToHexStr(cardData, cardData.Length);//数据类型转换为等效的ASCII表示的HEX
                }
                strMessage = Rlayout(strCard, A_H, listenIP);//数据进行显示格式添加
                this.textBox1.Text = this.textBox1.Text + strMessage;//数据显示到文本框
                this.textBox1.Focus();//获取焦点
                this.textBox1.Select(this.textBox1.TextLength, 0);//光标定位到文本最后
                this.textBox1.ScrollToCaret();//滚动到光标处

                LenR += Client.recMsglength();//设置一接收到的字符数
                label接收.Text = "接收：" + LenR.ToString() + " 字节";
                //调用LOG写入方法，记录数据
                Log_txt_Console.Logmsg_Write(strMessage, textBox_DataSaveName.Text, textBox_DataSavePath.Text);
                Log_Excel_Console.Logmsg_Write(strMessage, textBox_DataSaveName.Text, textBox_DataSavePath.Text);
                strMessage = "";
            }
            catch (Exception erro)
            {
                this.textBox1.Text += erro.Message + "\r\n";
                label服务器连接状态.Text = "服务器连接失败";
                label服务器连接状态.ForeColor = System.Drawing.Color.Red;//变更字体颜色
            }
        }
        void server_onConnect(Dictionary<string, System.Net.Sockets.Socket> dict)
        {
            this.comboBoxIP.Items.Clear();
            foreach (string ip in dict.Keys)//将连接IP遍历一次，关联到列表文本框
            {
                this.comboBoxIP.Items.Add(ip);
            }

        }
        void server_onReceive(string ip, byte[] data, int length)
        {
            listenIP = ip;
            string A_H = "ASCII";//设置默认格式
            string strMessage = "";//清空缓存
            byte[] cardData = new byte[length];
            string strCard = "";
            try
            {
                if (this.textBox1.Text.Length > 10000)//如果显示框显示字符数大于10000，则清空
                    this.textBox1.Text = "";
                if (length == 0) return;//如果长度为0，则不执行下面的代码
                count += 1;
                groupBox_R.Text = "接收数据：" + count;
                for (int i = 0; i < length; i += 1)
                {
                    cardData[i] = data[i];
                }
                if (radioButton_R_ASCII.Checked == true)
                {
                    A_H = "ASCII";
                    strCard = System.Text.Encoding.ASCII.GetString(cardData);
                }
                else if (radioButton_R_HEX.Checked == true)
                {
                    A_H = "HEX";
                    strCard = byteToHexStr(cardData, cardData.Length);
                }
                strMessage = Rlayout(strCard, A_H, listenIP);
                this.textBox1.Text = this.textBox1.Text + strMessage;
                this.textBox1.Focus();//获取焦点
                this.textBox1.Select(this.textBox1.TextLength, 0);//光标定位到文本最后
                this.textBox1.ScrollToCaret();//滚动到光标处

                LenR += server.recMsglength();
                label接收.Text = "接收：" + LenR.ToString() + " 字节";
                Log_txt_Console.Logmsg_Write(strMessage, textBox_DataSaveName.Text, textBox_DataSavePath.Text);
                
                strMessage = "";
            }
            catch (Exception erro)
            {
                this.textBox1.Text += erro.Message + "\r\n";
                label服务器连接状态.Text = "服务器连接失败";
                label服务器连接状态.ForeColor = System.Drawing.Color.Red;//变更字体颜色
            }
        }

        //连接按钮
        private void buttonConn_Click(object sender, EventArgs e)
        {
            if (buttonConn.Text == "连接服务器")
            {
                try
                {
                    int port = int.Parse(this.textBoxPort.Text);
                    Client.Start(this.textBoxIP.Text, port);//连接
                    label服务器连接状态.Text = "服务器连接成功";
                    label服务器连接状态.ForeColor = System.Drawing.Color.Green;//变更字体颜色
                    toolStripProgressBar1.ForeColor = System.Drawing.Color.Green;
                    toolStripProgressBar1.Value = 100;
                    Client.onConnect += new Client.ConnectEvent(Client_onConnect);
                    buttonConn.Text = "断开服务器";
                    buttonSend.Enabled = true;
                    return;
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message, "启动客户端", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    label服务器连接状态.Text = "服务器:" + this.textBoxIP.Text + "连接失败";
                    label服务器连接状态.ForeColor = System.Drawing.Color.Red;//变更字体颜色
                }
            }
            else if (buttonConn.Text == "断开服务器")
            {
                Client.Close();            //断开连接
                Client.onConnect -= new Client.ConnectEvent(Client_onConnect);
                label服务器连接状态.Text = "服务器连接断开";
                label服务器连接状态.ForeColor = System.Drawing.Color.Red;//变更字体颜色
                toolStripProgressBar1.ForeColor = System.Drawing.Color.Red;
                toolStripProgressBar1.Value = 0;
                buttonConn.Text = "连接服务器";
                buttonSend.Enabled = false;
            }
            else if (buttonConn.Text == "启动服务器"&& 
                comboBox2.Text == comboBox2.Items[1].ToString())
            {
                try
                {
                    int port = int.Parse(this.textBoxPort.Text);
                    server.Start(this.textBoxIP.Text, port);
                    label服务器连接状态.Text = "服务器启动成功";
                    label服务器连接状态.ForeColor = System.Drawing.Color.Green;//变更字体颜色
                    toolStripProgressBar1.ForeColor = System.Drawing.Color.Green;
                    toolStripProgressBar1.Value = 100;
                    server.onConnect += new SocketServer.ConnectEvent(server_onConnect);
                    buttonConn.Text = "关闭服务器";
                    buttonSend.Enabled = true;

                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message, "启动服务器", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (buttonConn.Text == "关闭服务器" &&
                comboBox2.Text == comboBox2.Items[1].ToString())
            {
                server.Close();            //断开连接
                server.onConnect -= new SocketServer.ConnectEvent(server_onConnect);
                label服务器连接状态.Text = "服务器关闭";
                label服务器连接状态.ForeColor = System.Drawing.Color.Red;//变更字体颜色
                toolStripProgressBar1.ForeColor = System.Drawing.Color.Red;
                toolStripProgressBar1.Value = 0;
                buttonConn.Text = "连接服务器";
                buttonSend.Enabled = false;
            }
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            string A_H = "ASCII";
            string strMessage = "";
            byte[] cmd=null;
            try
            {
                if (label服务器连接状态.Text == "服务器连接成功"||
                    label服务器连接状态.Text == "服务器启动成功")
                {
                    if (radioButton_S_ASCII.Checked == true)//判断发送数据格式ASCII
                    {
                        A_H = "ASCII";
                        if (comboBox2.Text == comboBox2.Items[0].ToString())
                        {
                            Client.SendMessage(textBoxIP.Text, this.textBoxCmd.Text);
                        }
                        else if(comboBox2.Text == comboBox2.Items[1].ToString())
                        {
                            server.SendMessage(textBoxIP.Text, this.textBoxCmd.Text);
                        }
                            
                    }
                    else if (radioButton_S_HEX.Checked == true)//判断发送数据格式HEX
                    {
                        A_H = "HEX";
                        cmd = HexStringToByteArray(this.textBoxCmd.Text);//System.Text.Encoding.UTF8.GetBytes(this.textBoxCmd.Text + "\r\n");
                        
                        if (comboBox2.Text == comboBox2.Items[0].ToString())
                        {
                            Client.SendMessage(textBoxIP.Text, cmd);
                        }
                        else if (comboBox2.Text == comboBox2.Items[1].ToString())
                        {
                            server.SendMessage(textBoxIP.Text, cmd);
                        }
                    }
                    
                    if (checkBox_ShowSend.Checked == true)//判断显示发送数据
                    {
                        strMessage = Slayout(this.textBoxCmd.Text, A_H, listenIP);
                        this.textBox1.Text= this.textBox1.Text + strMessage ;
                        this.textBox1.Focus();//获取焦点
                        this.textBox1.Select(this.textBox1.TextLength, 0);//光标定位到文本最后
                        this.textBox1.ScrollToCaret();//滚动到光标处
                        bool A= comboBox3.Items.Contains(this.textBoxCmd.Text);
                        if (A == false)//判断发送数据历史中是否存在相同数据，没有则保存
                        {
                            comboBox3.Items.Add(this.textBoxCmd.Text);
                            comboBox3.Text= this.textBoxCmd.Text;
                        }
                    }
                    label发送状态.Text = "消息发送成功";
                    if (comboBox2.Text == comboBox2.Items[0].ToString())
                    {
                        lenS += Client.sendMessagelength();
                    }
                    else if (comboBox2.Text == comboBox2.Items[1].ToString())
                    {
                        lenS += server.sendMessagelength();
                    }
                    label发送.Text = "发送：" + lenS.ToString() + " 字节";
                    Log_txt_Console.Logmsg_Write(strMessage, textBox_DataSaveName.Text, textBox_DataSavePath.Text);
                }
            }
            catch (Exception error)
            {
                label发送状态.Text = "消息发送失败\n" + error.Message;
                //MessageBox.Show(error.Message, "发送消息", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public byte[] HexStringToByteArray(string s)
        {
            s = s.Replace(" ", "");
            if ((s.Length % 2) != 0)//判断发送的数据是否为完整字节，否则添加前导0
            {
                //StringBuilder sss;
                //sss = new StringBuilder(s);
                //sss.Insert(s.Length-1, "0");
                //s = sss.ToString();
                s = "0" + s;
            }
            byte[] buffer = new byte[s.Length / 2];
            for (int i = 0; i < s.Length; i += 2)
                buffer[i / 2] = (byte)Convert.ToByte(s.Substring(i, 2), 16);
            return buffer;
        }
        //字节数组转16进制字符串
        private static string byteToHexStr(byte[] bytes, int length)
        {
            string returnStr = "";
            if (bytes != null)
            {
                for (int i = 0; i < length; i++)
                {
                    returnStr += bytes[i].ToString("X2");
                }
            }
            return returnStr;
        }

        private void radioButton_R_ASCII_CheckedChanged(object sender, EventArgs e)
        {
            groupBox_R.Text = "接收ASCII数据";
        }

        private void radioButton_R_HEX_CheckedChanged(object sender, EventArgs e)
        {
            groupBox_R.Text = "接收HEX数据";
        }

        private void radioButton_S_ASCII_CheckedChanged(object sender, EventArgs e)
        {
            groupBox_S.Text = "发送ASCII数据";
        }

        private void radioButton_S_HEX_CheckedChanged(object sender, EventArgs e)
        {
            groupBox_S.Text = "发送HEX数据";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Int64 len;
            len = Log_txt_Console.Logmsg_Read(this.textBox_DataSaveName.Text, Application.StartupPath).Length;
            label数据记录.Text = "数据记录：" + len.ToString() + "字节";
        }
        private void TextBoxChange(string S)
        {

        }
        //恢复默认文件名
        private void button_Name_Click(object sender, EventArgs e)
        {
            textBox_DataSaveName.Text = "ScoketClient_S_R_LOG";
        }
        //恢复默认文件路径
        private void button_Path_Click(object sender, EventArgs e)
        {
            textBox_DataSavePath.Text = Application.StartupPath;
        }
        //允许更改文件名
        private void checkBox_Name_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Name.Checked == true)
            {
                textBox_DataSaveName.ReadOnly = false;
                button_Name.Enabled = true;
            }
            else
            {
                textBox_DataSaveName.ReadOnly = true;
                button_Name.Enabled = false;
            }
        }
        //允许更改文件路径
        private void checkBox_Path_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Path.Checked == true)
            {
                textBox_DataSavePath.ReadOnly = false;
                button_Path.Enabled = true;
            }
            else
            {
                if (textBox_DataSavePath.Text == "")//判断文件路径是否为空。为空则使用默认路径
                {
                    this.textBox_DataSavePath.Text = Application.StartupPath;
                }
                textBox_DataSavePath.ReadOnly = true;
                button_Path.Enabled = false;
            }

        }
        //向数据添加格式 设置
        private string Slayout(string Message, string A_H, string ip)
        {
            if (checkBoxShowType.Checked == true)//显示数据类型
            {
                Message = "[" + A_H + "_DATA:]" + Message;
            }
            if (checkBox_FromTo.Checked == true)//显示来源和去向
            {
                if (comboBox2.Text == comboBox2.Items[0].ToString())//判断通讯类型
                {
                    Message = "[To  :" + ip + "]" + Message;
                }
                if (comboBox2.Text == comboBox2.Items[1].ToString())
                {
                    Message = "[To  :" + ip + "]" + Message;
                }
            }
            if (checkBox_ShowTime.Checked == true)//显示时间
            {
                Message = "[" + DateTime.Now.ToString("HH:mm:ss.fff") + "]" + Message;
            }
            if (checkBox_LineFeed.Checked == true)//自动换行
            {
                Message = Message + "\r\n";
            }
            return Message;
        }
        private string Rlayout(string Message, string A_H, string ip)
        {
            if (checkBoxShowType.Checked == true)//显示数据类型
            {
                Message = "[" + A_H + "_DATA:]" + Message;
            }
            if (checkBox_FromTo.Checked == true)//显示来源和去向
            {
                if (comboBox2.Text== comboBox2.Items[0].ToString())//判断通讯类型
                {
                    Message = "[From:" + ip + "]" + Message;
                }
                if (comboBox2.Text == comboBox2.Items[1].ToString())
                {
                    Message = "[From:" + ip + "]" + Message;
                }
            }
            if (checkBox_ShowTime.Checked == true)//显示时间
            {
                Message = "[" + DateTime.Now.ToString("HH:mm:ss.fff") + "]" + Message;
            }
            if (checkBox_LineFeed.Checked == true)//自动换行
            {
                Message =  Message+"\r\n";
            }
            return Message;
        }
        //打开数据记录
        private void buttonOpen_Click(object sender, EventArgs e)
        {
            try
            {
                process1.StartInfo.FileName = this.textBox_DataSavePath.Text + "/" + this.textBox_DataSaveName.Text + ".TXT";
                process1.Start();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }

        }
        //选择数据发送

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox2.SelectedIndex)
            {
                case 0:
                    buttonConn.Text = "连接服务器";
                    break;
                case 1:
                    Client.Close();            //断开连接
                    Client.onConnect -= new Client.ConnectEvent(Client_onConnect);
                    label服务器连接状态.Text = "服务器:" + "连接断开";
                    label服务器连接状态.ForeColor = System.Drawing.Color.Red;//变更字体颜色
                    toolStripProgressBar1.ForeColor = System.Drawing.Color.Red;
                    toolStripProgressBar1.Value = 0;
                    buttonSend.Enabled = false;
                    buttonConn.Text = "启动服务器";
                    break;
            }
        }
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox_ReSend_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_ReSend.Checked == true)
            {
                timer2.Interval = (int)Convert.ToInt32(numericUpDown_ReSend.Value);
                timer2.Enabled = true;
            }
            else
            {
                timer2.Interval = (int)Convert.ToInt32(numericUpDown_ReSend.Value);
                timer2.Enabled = false;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Thread threadtimer2_Tick = new Thread(timer2_SET);
            threadtimer2_Tick.IsBackground = true;
            threadtimer2_Tick.Start();
        }
        void timer2_SET()
        {
            object sender=null ;
            EventArgs e = null;
            buttonSend_Click(sender, e);
        }

        private void numericUpDown_ReSend_ValueChanged(object sender, EventArgs e)
        {
            if (checkBox_ReSend.Checked == true)
            {
                timer2.Interval = (int)Convert.ToInt32(numericUpDown_ReSend.Value);
                timer2.Enabled = true;
            }
            else
            {
                timer2.Interval = (int)Convert.ToInt32(numericUpDown_ReSend.Value);
                timer2.Enabled = false;
            }
        }

        private void buttonHisClear_Click(object sender, EventArgs e)
        {
            comboBox3.Items.Clear();
        }

        private void 更新记录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdataLog LOG = new UpdataLog();
            LOG.Show();
        }
    }
}

