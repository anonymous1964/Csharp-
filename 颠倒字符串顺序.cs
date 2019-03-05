using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 对每个字符进行颠倒输出
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            char[] car = textBox1.Text.ToCharArray();       //从字符串中得到字节数组
            Array.Reverse(car,0,textBox1.Text.Length);
            textBox2.Text = new StringBuilder().Append(car).ToString();     
        }
    }
}
