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
    public partial class Form11 : Form
    {
        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=projectcovid;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }
        public Form11()
        {
            InitializeComponent();
        }

        private void complete_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form10 f = new Form10();
            f.Show();
        }

        private void Loing_Click(object sender, EventArgs e)
        { MySqlConnection conn = databaseConnection();
            conn.Open();

            MySqlCommand cmd;

            cmd = conn.CreateCommand();
            cmd.CommandText = $"SELECT * FROM login_user WHERE Username = \"{Username.Text}\" AND Password = \"{Password.Text}\"";
             MySqlDataReader row = cmd.ExecuteReader();
            if (row.HasRows)
            {
                
                Form2 a = new Form2();
                this.Hide();
                a.Show();
                MessageBox.Show("เข้าสู่ระบบสำเร็จ");
            }
            else
            {
                MessageBox.Show("ชื่อผู้ใช้ หรือ รหัสไม่ถูกต้อง");
            }
            conn.Close();
        }

        private void Username_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (System.Text.Encoding.UTF8.GetByteCount(new char[] { e.KeyChar }) > 1)
            {
                e.Handled = true;
            }
        }

        private void Password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (System.Text.Encoding.UTF8.GetByteCount(new char[] { e.KeyChar }) > 1)
            {
                e.Handled = true;
            }
        }

   

        private void A_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 a = new Form2();
            this.Hide();
            a.Show();
        }
    }
}
