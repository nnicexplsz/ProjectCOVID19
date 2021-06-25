using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProjectCOVID19
{

    public partial class Form7 : Form
    {
        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=projectcovid;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }


        private void showdataUser1()
        {
            MySqlConnection conn = databaseConnection();
            DataSet ds = new DataSet();
            conn.Open();

            MySqlCommand cmd;

            cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT id AS ลำดับ,name AS ชื่อ,surname AS นามสกุล,sex AS เพศ,age AS อายุ,pass AS เลขบัตรประจำตัวประชาชน,number AS เบอร์โทรศัพท์,address AS ที่อยู่,province AS จังหวัด FROM `user`";

            MySqlDataAdapter adpter = new MySqlDataAdapter(cmd);
            adpter.Fill(ds);

            conn.Close();

            dataUser1.DataSource = ds.Tables[0].DefaultView;
        }
        private void showdataUser22()
        {
            MySqlConnection conn = databaseConnection();
            DataSet ds = new DataSet();
            conn.Open();

            MySqlCommand cmd;

            cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT id AS ลำดับ , name AS ชื่อ , surname AS นามสกุล ,age AS อายุ , s1 AS อุณหภูมิ , s2 AS ไข้ , s3 AS ไอแห้ง , s4 AS ไอมีเสมหะ , s5 AS เจ็บคอ , s6 AS มีน้ำมูก ,province AS จังหวัด FROM `user`";

            MySqlDataAdapter adpter = new MySqlDataAdapter(cmd);
            adpter.Fill(ds);

            conn.Close();

            dataUser22.DataSource = ds.Tables[0].DefaultView;
        }
        private void showApplicants4()
        {
            MySqlConnection conn = databaseConnection();
            DataSet ds = new DataSet();
            conn.Open();

            MySqlCommand cmd;

            cmd = conn.CreateCommand();
            string name = textBox2.Text;
            string number = textBox2.Text;
            cmd.CommandText = $"SELECT id AS ลำดับ , name AS ชื่อ , surname AS นามสกุล ,age AS อายุ , s1 AS อุณหภูมิ , s2 AS ไข้ , s3 AS ไอแห้ง , s4 AS ไอมีเสมหะ , s5 AS เจ็บคอ , s6 AS มีน้ำมูก ,province AS จังหวัด FROM `user` WHERE name=\"{name}\" OR surname=\"{name}\" OR s1=\"{number}\" OR province=\"{name}\" OR age=\"{number}\" OR s2=\"{name}\" OR sex=\"{name}\" ";


            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(ds);

            conn.Close();

            dataUser22.DataSource = ds.Tables[0].DefaultView;
        }
        private void showApplicants2()
        {
            MySqlConnection conn = databaseConnection();
            DataSet ds = new DataSet();
            conn.Open();

            MySqlCommand cmd;

            cmd = conn.CreateCommand();
            string name = textBox2.Text;
            string number = textBox2.Text;
            cmd.CommandText = $"SELECT id AS ลำดับ,name AS ชื่อ,surname AS นามสกุล,sex AS เพศ,age AS อายุ,pass AS เลขบัตรประจำตัวประชาชน,number AS เบอร์โทรศัพท์,address AS ที่อยู่ ,province AS จังหวัด FROM `user` WHERE name=\"{name}\" OR surname=\"{name}\" OR province=\"{name}\" OR age=\"{number}\" OR s2=\"{name}\" OR sex=\"{name}\"  ";


            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(ds);

            conn.Close();

            dataUser1.DataSource = ds.Tables[0].DefaultView;
        }

        private void dataUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            dataUser1.CurrentRow.Selected = true;


        }

        public Form7()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f = new Form2();
            f.Show();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            showdataUser1();
            showdataUser22();
        }

        private void search1_Click(object sender, EventArgs e)
        {
            showApplicants4();
            showApplicants2();
        }
        private List<Class1> allbook = new List<Class1>();
        private void print_Click(object sender, EventArgs e)
        {
            allbook.Clear();
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("   โปรแกรมลงทะเบียนผู้เสี่ยง COVID-19", new Font("TH SarabunPSK", 18, FontStyle.Bold), Brushes.Black, new PointF(260, 140));
            e.Graphics.DrawString("-------------------------------------------------------------------------------------------------------------------------------------", new Font("TH SarabunPSK", 18, FontStyle.Bold), Brushes.Black, new PointF(36, 160));
            e.Graphics.DrawString("รายการข้อมูลผู้ลงทะเบียน", new Font("TH SarabunPSK", 18, FontStyle.Bold), Brushes.Black, new PointF(50, 192));
            e.Graphics.DrawString("พิมพ์เมื่อ " + System.DateTime.Now.ToString("dd / MM / yyyy   HH : mm : ss น."), new Font("TH SarabunPSK", 18, FontStyle.Bold), Brushes.Black, new PointF(50, 215));
            e.Graphics.DrawString("--------------------------------------------------------------------------------------------------------------------------------------", new Font("TH SarabunPSK", 18, FontStyle.Bold), Brushes.Black, new PointF(36, 240));
            e.Graphics.DrawString("ชื่อ", new Font("TH SarabunPSK", 16, FontStyle.Bold), Brushes.Black, new PointF(50, 255));
            e.Graphics.DrawString("นามสกุล", new Font("TH SarabunPSK", 16, FontStyle.Bold), Brushes.Black, new PointF(145, 255));
            e.Graphics.DrawString("อายุ", new Font("TH SarabunPSK", 16, FontStyle.Bold), Brushes.Black, new PointF(250, 255));
            e.Graphics.DrawString("เพศ", new Font("TH SarabunPSK", 16, FontStyle.Bold), Brushes.Black, new PointF(320, 255));
            e.Graphics.DrawString("จังหวัด", new Font("TH SarabunPSK", 16, FontStyle.Bold), Brushes.Black, new PointF(380, 255));
            e.Graphics.DrawString("อุณหภูมิ", new Font("TH SarabunPSK", 16, FontStyle.Bold), Brushes.Black, new PointF(470, 255));
            e.Graphics.DrawString("สถานะความเสี่ยง", new Font("TH SarabunPSK", 16, FontStyle.Bold), Brushes.Black, new PointF(550, 255));
            e.Graphics.DrawString("เวลา", new Font("TH SarabunPSK", 16, FontStyle.Bold), Brushes.Black, new PointF(720, 255));
            e.Graphics.DrawString("--------------------------------------------------------------------------------------------------------------------------------------", new Font("TH SarabunPSK", 18, FontStyle.Bold), Brushes.Black, new PointF(38, 265));
            int y = 290;
            loaddata();
            foreach (var i in allbook)
            {
                e.Graphics.DrawString(i.name, new Font("TH SarabunPSK", 14, FontStyle.Regular), Brushes.Black, new PointF(50, y));
                e.Graphics.DrawString(i.surname, new Font("TH SarabunPSK", 14, FontStyle.Regular), Brushes.Black, new PointF(150, y));
                e.Graphics.DrawString(i.age, new Font("TH SarabunPSK", 14, FontStyle.Regular), Brushes.Black, new PointF(255, y));
                e.Graphics.DrawString(i.sex, new Font("TH SarabunPSK", 14, FontStyle.Regular), Brushes.Black, new PointF(323, y));
                e.Graphics.DrawString(i.province, new Font("TH SarabunPSK", 14, FontStyle.Regular), Brushes.Black, new PointF(380, y));
                e.Graphics.DrawString(i.s1, new Font("TH SarabunPSK", 14, FontStyle.Regular), Brushes.Black, new PointF(490, y));
                e.Graphics.DrawString(i.s2, new Font("TH SarabunPSK", 14, FontStyle.Regular), Brushes.Black, new PointF(580, y));
                e.Graphics.DrawString(i.time, new Font("TH SarabunPSK", 14, FontStyle.Regular), Brushes.Black, new PointF(680, y));


                y = y + 30;


            }


        }
        private void loaddata()
        {
            MySqlConnection conn = new MySqlConnection("host=127.0.0.1;username=root;password=;database=projectcovid;");

            conn.Open();

            string name = textBox2.Text;
            string number = textBox2.Text;
            if (name == "")
            {

                MySqlCommand cmd = new MySqlCommand($"SELECT name,surname,age,sex,province,s1,s2,time FROM user ", conn);
                MySqlDataReader adapter = cmd.ExecuteReader();

                while (adapter.Read())
                {
                    Program.name = adapter.GetString("name");
                    Program.surname = adapter.GetString("surname");
                    Program.age = adapter.GetString("age");
                    Program.sex = adapter.GetString("sex");
                    Program.province = adapter.GetString("province");
                    Program.s1 = adapter.GetString("s1");
                    Program.s2 = adapter.GetString("s2");
                    Program.time = adapter.GetString("time");

                    Class1 item = new Class1()
                    {
                        name = Program.name,
                        surname = Program.surname,
                        age = Program.age,
                        sex = Program.sex,
                        province = Program.province,
                        s1 = Program.s1,
                        s2 = Program.s2,
                        time = Program.time,

                    };
                    allbook.Add(item);
                }
            }
            else
            {
                MySqlCommand cmd = new MySqlCommand($"SELECT name,surname,age,sex,province,s1,s2,time FROM user WHERE name=\"{name}\" OR surname=\"{name}\" OR province=\"{name}\" OR age=\"{number}\" OR sex=\"{name}\" OR s2=\"{name}\"  ", conn);
                MySqlDataReader adapter = cmd.ExecuteReader();

                while (adapter.Read())
                {
                    Program.name = adapter.GetString("name");
                    Program.surname = adapter.GetString("surname");
                    Program.age = adapter.GetString("age");
                    Program.sex = adapter.GetString("sex");
                    Program.province = adapter.GetString("province");
                    Program.s1 = adapter.GetString("s1");
                    Program.s2 = adapter.GetString("s2");
                    Program.time = adapter.GetString("time");
                    Class1 item = new Class1()
                    {
                        name = Program.name,
                        surname = Program.surname,
                        age = Program.age,
                        sex = Program.sex,
                        province = Program.province,
                        s1 = Program.s1,
                        s2 = Program.s2,
                        time = Program.time,

                    };
                    allbook.Add(item);
                }

            }
        }


    }
}
