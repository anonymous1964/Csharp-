using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 字母与ASCII码的转换
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text!=string.Empty)
            {
                try
                {
                    textBox2.Text = getCode(textBox1.Text);
                }
                catch(IndexOutOfRangeException ex)
                {
                    MessageBox.Show(ex.Message+"请输入正确的汉字","出错");
                }
            }
        }
        public string getCode(string chinese)
        {
            string P_str_Code = "";
            byte[] P_bt_array = new byte[2];
            P_bt_array = Encoding.Default.GetBytes(chinese);
            int front = (short)(P_bt_array[0] - '\0');
            int back = (short)(P_bt_array[1] - '\0');
            P_str_Code = (front - 160).ToString() + (back - 160).ToString();
            return P_str_Code;

            
        }
    }
}
