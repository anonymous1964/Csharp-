using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 使用using关键字有效回收资源
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (new test())
            {
   
            }
            
        }
        class test : IDisposable
        {
            public void Dispose()
            {
                MessageBox.Show("已经执行test的对象的Dispose方法","提示");
            }
        }
    }
}
