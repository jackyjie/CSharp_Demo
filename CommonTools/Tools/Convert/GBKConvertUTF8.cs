using CommonTools.Tools.Convert.GBK;
using CommonTools.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommonTools.Tools.Convert
{
    public partial class GBKConvertUTF8 : Form
    {

        public GBKConvertUTF8()
        {
            InitializeComponent();
        }

        private void GBKConvertUTF8_Load(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl.GetType().Name.Equals("Button"))
                {
                    ctrl.Click += btnClick;
                }
            }
        }

        private void btnClick(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            switch (btn.Name)
            {
                case "btnSelect":
                    selectBtn();
                    break;
                case "btnSelect2":
                    selectBtn2();
                    break;
                case "btnExport":
                    hideButton();
                    export();
                    showButton();
                    break;
                case "btnOpenFile":
                    openFile();
                    break;
                case "btnReadByte":
                    readByte();
                    break; 
                case "btnSaveUTF8":
                    saveUTF8();
                    break; 
            }
        }

        void saveUTF8()
        {
            string path = this.richTextBox2.Text;
            EncodingUtils.ConvertFileToUTF8(path);
        }

        void readByte()
        {
            string path = this.richTextBox2.Text;
            string bytes = File.ReadAllText(path, Encoding.Default);
            Console.WriteLine(bytes);
        }

        void openFile()
        {
            string path = this.richTextBox2.Text;
            StreamReader reader = new StreamReader(path);
            StringBuilder builder = new StringBuilder();
            string line = "";
            while ((line = reader.ReadLine()) != null)
            {
                builder.Append(line);
            }
            Console.WriteLine(builder.ToString());
        }

        void selectBtn()
        {
            DialogResult status = folderBrowserDialog1.ShowDialog();
            if (status == DialogResult.OK)
            {
                this.richTextBox1.Text = folderBrowserDialog1.SelectedPath + "\\";
            }

        }

        void selectBtn2()
        {
            DialogResult status = openFileDialog2.ShowDialog();
            if (status == DialogResult.OK)
            {
                this.richTextBox2.Text = openFileDialog2.FileName;
            }

        }

        void hideButton()
        {
            this.btnExport.Enabled = false;
        }

        void showButton()
        {
            this.btnExport.Enabled = true;
        }

        void export()
        {
            string fileName = this.richTextBox1.Text;
            GBKConvert convert = new GBKConvert();
            convert.IteratorDictory(fileName);
        }
    }
}
