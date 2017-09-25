using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace 定时关机
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start("shutdown", " -a");
            MessageBox.Show("关机计划已取消！", "提示", MessageBoxButtons.OK);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="")
            {
                MessageBox.Show("请输入关机的延时时间！", "提示", MessageBoxButtons.OK);
            }
            else
            {
                int time = 60*int.Parse(textBox1.Text);
                string para = " -s -t " + time.ToString();
                Process.Start("shutdown",para);
                MessageBox.Show("计算机将于" + textBox1.Text + "分钟后关闭！", "提示", MessageBoxButtons.OK);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
