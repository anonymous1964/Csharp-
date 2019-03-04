//使用as关键字将对象转换为指定类型.cs
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace 使用as关键字将对象转换为指定类型
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
            {
                using (FileStream P_filestream = new FileStream(@"C:\Users\Lenovo\Desktop\log.txt", System.IO.FileMode.Create))
                {
                    object P_object = P_filestream as object; 
                    if(P_object!=null)
                    {
                        MessageBox.Show("转换为object成功！","提示");
                    }
                    else
                    {
                        MessageBox.Show("转换为object失败！", "提示");
                    }
                }
            }
            if(radioButton2.Checked)
            {
                using (FileStream P_filestream = new FileStream(@"C:\Users\Lenovo\Desktop\log.txt", System.IO.FileMode.Create))
                {
                    object P_object = P_filestream as Stream;
                    if (P_object != null)
                    {
                        MessageBox.Show("转换为Stream成功！", "提示");
                    }
                    else
                    {
                        MessageBox.Show("转换为Stream失败！", "提示");
                    }
                }
            }
            if(radioButton3.Checked)
            {
                using (FileStream P_filestream = new FileStream(@"C:\Users\Lenovo\Desktop", System.IO.FileMode.Create))
                {
                    object P_object = null;
                    if (P_object != null)
                    {
                        MessageBox.Show("转换为String成功！", "提示");
                    }
                    else
                    {
                        MessageBox.Show("转换为String失败！", "提示");
                    }
                }
            }
        }
    }
}
