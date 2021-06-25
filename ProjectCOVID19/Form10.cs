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
    public partial class Form10 : Form
    {
        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=projectcovid;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }
        public Form10()
        {
            InitializeComponent();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Username2_TextChanged(object sender, EventArgs e)
        {

        }

        private void black_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form11 f = new Form11();
            f.Show();
        }

        private void Apply_Click(object sender, EventArgs e)
        {
            string Username = Username2.Text;
            string Password = Password2.Text;
            string Confirm = ConfirmPass.Text;

            if (NameText3.Text != "" && SurnameText3.Text != "" && Username2.Text != "" && Password2.Text != "" && ConfirmPass.Text != "" && Phonenumber.Text != "" && Address.Text != "")
            {
                if (Password2.Text == ConfirmPass.Text)
                {

                    if (Phonenumber.TextLength < 10)
                    {
                        MessageBox.Show("กรุณากรอกเบอร์โทรศัพท์ให้ถูกต้อง", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    else if (Username.Length < 6 || Password.Length < 6 || Confirm.Length < 6)
                    {
                        MessageBox.Show("กรุณากรอก Username และ Password อย่างน้อย 6 ตัว");
                    }
                    else
                    {

                        MySqlConnection conn = databaseConnection();
                        String sql = "INSERT INTO login_user (Name, Surname,Phonenumber,Username,Password,Address) VALUES('" + NameText3.Text + "','" + SurnameText3.Text + "' ,'" + Phonenumber.Text + "','" + Username2.Text + "','" + Password2.Text + "','" + Address.Text + "')";
                        MySqlCommand cmd = new MySqlCommand(sql, conn);
                        conn.Open();
                        int rows = cmd.ExecuteNonQuery();
                        conn.Close();

                        if (rows > 0)
                        {
                            MessageBox.Show("สร้างบัญชีผู้ใช้สำเร็จ");
                            Form11 a = new Form11();
                            this.Hide();
                            a.Show(); 
                        }

                        NameText3.Clear();
                        SurnameText3.Clear();
                        Username2.Clear();
                        Password2.Clear();

                    }

                }
                else
                {
                    MessageBox.Show("รหัสผ่านไม่ตรงกัน");
                }

            }
            else
            {
                MessageBox.Show("กรุณากรอกข้อมูลให้ครบ");
            }
        }

        private void checkBox2_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                Password2.PasswordChar = '\0';
                ConfirmPass.PasswordChar = '\0';
            }
            else
            {
                Password2.PasswordChar = '•';
                ConfirmPass.PasswordChar = '•';
            }
        }

        private void Loing_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form11 f = new Form11();
            f.Show();
        }

        private void Username2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (System.Text.Encoding.UTF8.GetByteCount(new char[] { e.KeyChar }) > 1)
            {
                e.Handled = true;
                MessageBox.Show("กรุณากรอกภาษาอังกฤษหรือตัวเลข", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Password2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (System.Text.Encoding.UTF8.GetByteCount(new char[] { e.KeyChar }) > 1)
            {
                e.Handled = true;
                MessageBox.Show("กรุณากรอกภาษาอังกฤษหรือตัวเลข", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Phonenumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar != 8))
            {
                e.Handled = true;
                MessageBox.Show("กรุณากรอกเฉพาะตัวเลข", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ConfirmPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (System.Text.Encoding.UTF8.GetByteCount(new char[] { e.KeyChar }) > 1)
            {
                e.Handled = true;
                MessageBox.Show("กรุณากรอกภาษาอังกฤษหรือตัวเลข", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
