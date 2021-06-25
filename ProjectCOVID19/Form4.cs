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
using System.Threading;
using System.Globalization;

namespace ProjectCOVID19
{
    public partial class Form4 : Form
    {
        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=projectcovid;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }

        public Form4()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form8 f = new Form8();
            f.Show();
        }
        private void showUser()
        {
            MySqlConnection conn = databaseConnection();
            DataSet ds = new DataSet();
            conn.Open();

            MySqlCommand cmd;

            cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT id ,name, surname, sex, age, pass, number,address,province,time FROM user ";

            MySqlDataAdapter adpter = new MySqlDataAdapter(cmd);
            adpter.Fill(ds);

            conn.Close();

            dataUser.DataSource = ds.Tables[0].DefaultView;
        }


        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f = new Form2();
            f.Show();
        }

        private void dataUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            dataUser.CurrentRow.Selected = true;
            name.Text = dataUser.Rows[e.RowIndex].Cells["name"].FormattedValue.ToString();
            surname.Text = dataUser.Rows[e.RowIndex].Cells["surname"].FormattedValue.ToString();
            sex.Text = dataUser.Rows[e.RowIndex].Cells["sex"].FormattedValue.ToString();
            age.Text = dataUser.Rows[e.RowIndex].Cells["age"].FormattedValue.ToString();
            pass.Text = dataUser.Rows[e.RowIndex].Cells["pass"].FormattedValue.ToString();
            number.Text = dataUser.Rows[e.RowIndex].Cells["number"].FormattedValue.ToString();
            address.Text = dataUser.Rows[e.RowIndex].Cells["address"].FormattedValue.ToString();
            province.Text = dataUser.Rows[e.RowIndex].Cells["province"].FormattedValue.ToString();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            int selectedRow = dataUser.CurrentCell.RowIndex;
            int deleteId = Convert.ToInt32(dataUser.Rows[selectedRow].Cells["id"].Value);

            MySqlConnection conn = databaseConnection();

            String sql = "DELETE FROM user WHERE id = '" + deleteId + "'";

            MySqlCommand cmd = new MySqlCommand(sql, conn);

            conn.Open();

            int rows = cmd.ExecuteNonQuery();

            conn.Close();

            if (rows > 0)
            {
                showUser();

                MessageBox.Show("ลบข้อมูลสำเร็จ");

            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = databaseConnection();
            String sql = "INSERT INTO `user`(`name`, `surname`, `sex`, `age`, `pass`, `number`,`address`,`province`) VALUES ('" + name.Text + "','" + surname.Text + "','" + sex.Text + "','" + age.Text + "','" + pass.Text + "','" + number.Text + "','" + address.Text + "','" + province.Text + "')";
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            conn.Open();

            int rows = cmd.ExecuteNonQuery();

            conn.Close();

            if (rows > 0)
            {
                showUser();
                MessageBox.Show("บันทุกข้อมูลเรียบร้อย");

            }
            name.Text = "";
            surname.Text = "";
            sex.Text = "";
            age.Text = "";
            pass.Text = "";
            number.Text = "";
            address.Text = "";
            province.Text = "";
        }


        private void edit_Click(object sender, EventArgs e)
        {

            int selectedRow = dataUser.CurrentCell.RowIndex;
            int editId = Convert.ToInt32(dataUser.Rows[selectedRow].Cells["id"].Value);

            MySqlConnection conn = databaseConnection();

            String sql = "UPDATE user SET name = '" + name.Text + "',surname = '" + surname.Text + "',sex = '" + sex.Text + "',age = '" + age.Text + "',pass = '" + pass.Text + "',number = '" + number.Text + "',address = '" + address.Text + "',province = '" + province.Text + "' WHERE id = '" + editId + "'";

            MySqlCommand cmd = new MySqlCommand(sql, conn);


            conn.Open();

            int rows = cmd.ExecuteNonQuery();

            conn.Close();

            if (rows > 0)
            {
                showUser();
                MessageBox.Show("แก้ไขข้อมูลสำเร็จ");

            }
            name.Text = "";
            surname.Text = "";
            sex.Text = "";
            age.Text = "";
            pass.Text = "";
            number.Text = "";
            address.Text = "";
            province.Text = "";
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            showUser();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 f = new Form7();
            f.Show();
        }

        private void number_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar != 8))
            {
                e.Handled = true;
                MessageBox.Show("กรุณากรอกเฉพาะตัวเลข", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void age_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar != 8))
            {
                e.Handled = true;
                MessageBox.Show("กรุณากรอกเฉพาะตัวเลข", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void pass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar != 8))
            {
                e.Handled = true;
                MessageBox.Show("กรุณากรอกเฉพาะตัวเลข", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            age.Text = calulateAge(birthday.Value.ToString("yyyyMMdd"));

        }
        private string calulateAge(string dateDOB)
        {
            int now = int.Parse(DateTime.Today.ToString("yyyyMMdd"));
            int dob = int.Parse(dateDOB);
            string dif = (now - dob).ToString();
            string age001 = "0";
            if (dif.Length > 4)
                age001 = dif.Substring(0, dif.Length - 4);
            return age001;
        }

        private void dateTimePicker1_DropDown(object sender, EventArgs e)
        {
            DateTimeFormatInfo dt = Thread.CurrentThread.CurrentCulture.DateTimeFormat;
            this.birthday.CustomFormat = "dd MMM yyyy";
            this.birthday.Format = DateTimePickerFormat.Custom;
        }
    }
}
