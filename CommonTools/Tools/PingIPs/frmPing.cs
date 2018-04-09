using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CommonTools.Utils;

namespace CommonTools.Tools.PingIPs
{
    public partial class frmPing : Form
    {
        public frmPing()
        {
            InitializeComponent();

            foreach(Control ctrl in this.Controls)
            {
                if(ctrl.GetType().Name == "Button"){
                    ctrl.Click += btnClick; 
                }
            }
        }

        private void btnClick(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            switch (btn.Name)
            {
                case "btnPing": // 单线程Ping类
                    ping(pingSingle);
                    break;
                case "btnPingIcmp": // 单线程PingIcmp
                    break;
                case "btnPingMultiIcmp": // 多线程PingIcmp
                    break;
                case "btnPingMulti": // 多线程Ping
                    break;
            }

        }

        private void ping(Action<string> func)
        {
            string text = this.richTextBox1.Text;
            string splitText = this.textBox1.Text;
            string[] data = text.MySplit(splitText, TextUtils.SplitOption.NOTNULL);
            if (data == null) { Console.WriteLine("出问题"); return; }

            foreach (string ip in data)
            {
                func.Invoke(ip);
            }
        }

        public void pingSingle(String IP)
        {
            bool status = FunctionUtils.Ping(IP);
            Console.WriteLine(string.Format("IP:{0} {1}|", IP, status ? "成功" : "失败"));
        }

        public void pingIcmp(String IP)
        {
            bool status = FunctionUtils.PingIcmp(IP);
            Console.WriteLine(string.Format("IP:{0} {1}|", IP, status ? "成功" : "失败"));
        }
    }
}
