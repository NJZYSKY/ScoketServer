using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary1;

namespace ScoketServer
{
    public partial class UpdataLog : Form
    {
        public UpdataLog()
        {
            InitializeComponent();
            LOG();
        }
        private void  LOG()
        {
            string UpdataLog1 = Log_txt_Console.Logmsg_Read("更新记录", Application.StartupPath);
            textBox1.Text= UpdataLog1;
            this.textBox1.Focus();//获取焦点
            this.textBox1.Select(0, 0);//光标定位到文本最后
            this.textBox1.ScrollToCaret();//滚动到光标处
        }
    }
}
