using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 終極密碼GUI
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sec = 30;
        int ans;
        int max = 100;
        int min = 1;
        int count = 1;
        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "請輸入1-100的數字";
            label4.Text = string.Format("倒數 {0:00 秒}", sec);
            Random x = new Random();
            ans = x.Next(1, 101);
            label5.Text = "使用次數";
            

            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (sec >= 0.1)
            {
                label4.Text = string.Format("倒數 {0:00 秒}", sec -= 1);
                if (sec < 10)
                {
                    label4.ForeColor = Color.Red;
                    Console.Beep();
                }
            }
            else
            {
                timer1.Stop();
                MessageBox.Show("很遺憾,未能時間內達成!");
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            label5.Text = count.ToString();
            
            

            if (int.Parse(textBox1.Text) < min || int.Parse(textBox1.Text) > max)
            {
                MessageBox.Show($"請輸入 {min}-{max} 之間的'數字'!!");
            }
            else if (int.Parse(textBox1.Text) > ans)
            {
                max = int.Parse(textBox1.Text);
                label1.Text = $"請輸入{min} 到 {max}之間的數字";
                count++;
            }
            else if (int.Parse(textBox1.Text) < ans)
            {
                min = int.Parse(textBox1.Text);
                label1.Text= $"請輸入{min} 到 {max}之間的數字";
                count++;
            }
            else
            {
                label1.Text = "恭喜猜對了";
                timer1.Stop();
            }
        }
    }
}
