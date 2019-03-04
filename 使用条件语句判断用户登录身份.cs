using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 使用条件语句判断用户登录身份
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedItem.ToString()=="admin")
            {
                MessageBox.Show("管理员登陆");
            }
            else
            {
                if(comboBox1.SelectedItem.ToString() == "黄晓伟")
                {
                    MessageBox.Show("黄晓伟登陆");
                }
                else
                {
                    if(comboBox1.SelectedItem.ToString() == "宋围娜")
                    {
                        MessageBox.Show("宋围娜登陆");
                    }
                    else
                    {
                        MessageBox.Show("anonmymous登陆");
                    }
                }
            }
        }
    }
}
