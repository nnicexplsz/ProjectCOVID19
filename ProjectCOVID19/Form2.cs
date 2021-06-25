using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectCOVID19
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e) //เกี่ยวกับ
        {
            this.Hide();
            Form6 f = new Form6();
            f.Show();
        }

        private void button6_Click(object sender, EventArgs e) //วิเคราะห์อาการ
        {
            this.Hide();
            Form3 f = new Form3();
            f.Show();
        }

        private void button5_Click(object sender, EventArgs e) //กรอกข้อมูลส่วนตัวของท่าน
        {
            this.Hide();
            Form4 f = new Form4();
            f.Show();
        }

        private void button8_Click(object sender, EventArgs e) //ผู้พัฒนา
        {
            this.Hide();
            Form5 f = new Form5();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e) //ออกจากระบบ
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e) //แสดงข้อมูลทั้งหมด
        {
            this.Hide();
            Form7 f = new Form7();
            f.Show();
        }
    }
}
