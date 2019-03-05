using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 根据标点符号对字符串进行分行
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder stringBuilder = new StringBuilder(textBox1.Text);
            for (int i = 0; i < stringBuilder.Length; i++)
            {
                if (stringBuilder[i] == '，')
                {
                    stringBuilder.Insert(++i, Environment.NewLine);
                }
            }

            textBox2.Text = stringBuilder.ToString();
        }
    }
}
