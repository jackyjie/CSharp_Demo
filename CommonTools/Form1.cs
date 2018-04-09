using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommonTools
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            foreach(Control ctrl in this.Controls)
            {
                if (ctrl.GetType().Name.Equals("Button"))
                {
                    Button btn = ctrl as Button;
                    btn.Click += btn_Click;
                }
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            switch (btn.Name)
            {
                case "btnPing":
                    using(Form frmPing = new Tools.PingIPs.frmPing())
                    {
                        frmPing.ShowDialog(); 
                    }
                    break;
            }
        }
    }
}
