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
    public partial class Form3 : Form
    {
        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=projectcovid;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f = new Form2();
            f.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form9 f = new Form9();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f = new Form2();
            f.Show();
        }
        private void showUser()
        {
            MySqlConnection conn = databaseConnection();
            DataSet ds = new DataSet();
            conn.Open();

            MySqlCommand cmd;

            cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT id , name ,surname ,s1 ,s2 ,s3 ,s4 ,s5 ,s6 ,time FROM user "; 
            MySqlDataAdapter adpter = new MySqlDataAdapter(cmd);
            adpter.Fill(ds);

            conn.Close();

            dataUser.DataSource = ds.Tables[0].DefaultView;
        }

        private void dataUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataUser.CurrentRow.Selected = true;        
            name.Text = dataUser.Rows[e.RowIndex].Cells["name"].FormattedValue.ToString();
            surname.Text = dataUser.Rows[e.RowIndex].Cells["surname"].FormattedValue.ToString();
            s1.Text = dataUser.Rows[e.RowIndex].Cells["s1"].FormattedValue.ToString();
            s2.Text = dataUser.Rows[e.RowIndex].Cells["s2"].FormattedValue.ToString();
            s3.Text = dataUser.Rows[e.RowIndex].Cells["s3"].FormattedValue.ToString();
            s4.Text = dataUser.Rows[e.RowIndex].Cells["s4"].FormattedValue.ToString();
            s5.Text = dataUser.Rows[e.RowIndex].Cells["s5"].FormattedValue.ToString();
            s6.Text = dataUser.Rows[e.RowIndex].Cells["s6"].FormattedValue.ToString();
        }

        private void edit_Click(object sender, EventArgs e)
        {

            int selectedRow = dataUser.CurrentCell.RowIndex;
            int editId = Convert.ToInt32(dataUser.Rows[selectedRow].Cells["id"].Value);

            MySqlConnection conn = databaseConnection();

            String sql = "UPDATE `user` SET name = '" + name.Text + "',surname = '" + surname.Text + "',s1 = '" + s1.Text + "',s2 = '" + s2.Text + "',s3 = '" + s3.Text + "',s4 = '" + s4.Text + "',s5 = '" + s5.Text + "',s6 = '" + s6.Text + "' WHERE id = '" + editId + "'";    

            MySqlCommand cmd = new MySqlCommand(sql, conn);


            conn.Open();

            int rows = cmd.ExecuteNonQuery();
            Double ss1 = Convert.ToDouble(s1.Text);

            conn.Close();
            string ss2 = s2.SelectedItem.ToString();
            int x1 = 0, x2 = 0, x3 = 0, x4 = 0, x5 = 0;
            int sum = 0;
            if (s2.Text == "มีอาการเล็กน้อย"|| s2.Text =="มีอาการ") 
            {
                x1 = 1;
            }
            if (s3.Text == "มีอาการเล็กน้อย" || s3.Text == "มีอาการ")
            {
                x2 = 1;
            }
            if (s4.Text == "มีอาการเล็กน้อย" || s4.Text == "มีอาการ")
            {
                x3 = 1;
            }
            if (s5.Text == "มีอาการเล็กน้อย" || s5.Text == "มีอาการ")
            {
                x4 = 1;
            }
            if (s6.Text == "มีอาการเล็กน้อย" || s6.Text == "มีอาการ")
            {
                x5 = 1;
            }
            sum = x1 + x2 + x3 + x4 + x5;

            if (rows > 0)
            {
                showUser();
                if (ss1 < 37)
                {
                    MessageBox.Show("บันทึกข้อมูลเรียบร้อย \n\nท่านมีอุณหภูมิปกติ");
                    if (sum >= 4)
                    {
                        MessageBox.Show("ท่านมีอาการร้ายแรง \nควรพบแพทย์และไปโรงพยาบาลให้เร็วที่สุด \nเฝ้าระวังห้ามใช้สิ่งของร่วมกับคนอื่น", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (sum >= 3)
                    {
                        MessageBox.Show("ท่านมีอาการเสี่ยงเป็น COVID-19 \nกรุณาอยู่ในพื้นที่กักตัว 14 วัน \nเฝ้าระวังห้ามใช้สิ่งของร่วมกับคนอื่น");
                    }
                    else if (sum >= 2)
                    {
                        MessageBox.Show("ท่านมีอาการเสี่ยงเป็น  COVID-19 \nมั่นสังเกตอาการตัวเองบ่อยครั้ง ");
                    }
                    else if (sum >= 1)
                    {
                        MessageBox.Show("ท่านไม่มีอาการเสี่ยงเป็น  COVID-19 ");
                    }
                }
                else if (ss1 < 38)
                {
                    {
                        MessageBox.Show("บันทึกข้อมูลเรียบร้อย \n\nท่านมีไข้อ่อน");
                        if (sum >= 4)
                        {
                            MessageBox.Show("ท่านมีอาการร้ายแรง \nควรพบแพทย์และไปโรงพยาบาลให้เร็วที่สุด \nเฝ้าระวังห้ามใช้สิ่งของร่วมกับคนอื่น", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (sum >= 3)
                        {
                            MessageBox.Show("ท่านมีอาการเสี่ยงเป็น COVID-19 \nกรุณาอยู่ในพื้นที่กักตัว 14 วัน \nเฝ้าระวังห้ามใช้สิ่งของร่วมกับคนอื่น");
                        }
                        else if (sum >= 2)
                        {
                            MessageBox.Show("ท่านมีอาการเสี่ยงเป็น  COVID-19 \nมั่นสังเกตอาการตัวเองบ่อยครั้ง ");
                        }
                        else if (sum >= 1)
                        {
                            MessageBox.Show("ท่านไม่มีอาการเสี่ยงเป็น  COVID-19 ");
                        }
                    }
                }
                else if (ss1 > 38)
                {
                    {
                        MessageBox.Show("บันทึกข้อมูลเรียบร้อย \n\nท่านมีไข้สูง");
                        if (sum >= 4)
                        {
                            MessageBox.Show("ท่านมีอาการร้ายแรง \nควรพบแพทย์และไปโรงพยาบาลให้เร็วที่สุด \nเฝ้าระวังห้ามใช้สิ่งของร่วมกับคนอื่น", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (sum >= 3)
                        {
                            MessageBox.Show("ท่านมีอาการเสี่ยงเป็น COVID-19 \nกรุณาอยู่ในพื้นที่กักตัว 14 วัน \nเฝ้าระวังห้ามใช้สิ่งของร่วมกับคนอื่น");
                        }
                        else if (sum >= 2)
                        {
                            MessageBox.Show("ท่านมีอาการเสี่ยงเป็น  COVID-19 \nมั่นสังเกตอาการตัวเองบ่อยครั้ง ");
                        }
                        else if (sum >= 1)
                        {
                            MessageBox.Show("ท่านไม่มีอาการเสี่ยงเป็น  COVID-19 ");
                        }
                    }
                }
                name.Text = "";
                surname.Text = "";
                s1.Text = "";
                s2.Text = "";
                s3.Text = "";
                s4.Text = "";
                s5.Text = "";
                s6.Text = "";

            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            int selectedRow = dataUser.CurrentCell.RowIndex;
            int editId = Convert.ToInt32(dataUser.Rows[selectedRow].Cells["id"].Value);

            MySqlConnection conn = databaseConnection();

            String sql = "UPDATE `user` SET name = '" + name.Text + "',surname = '" + surname.Text + "',s1 = '" + s1.Text + "',s2 = '" + s2.Text + "',s3 = '" + s3.Text + "',s4 = '" + s4.Text + "',s5 = '" + s5.Text + "',s6 = '" + s6.Text + "' WHERE id = '" + editId + "'";

            MySqlCommand cmd = new MySqlCommand(sql, conn);

            
            conn.Open();

            int rows = cmd.ExecuteNonQuery();
            Double ss1 = Convert.ToDouble(s1.Text);

            conn.Close();
            string ss2 = s2.SelectedItem.ToString();
            int x1 = 0, x2 = 0, x3 = 0, x4 = 0, x5 = 0;
            int sum = 0;
            if (s2.Text == "มีอาการเล็กน้อย" || s2.Text == "มีอาการ")
            {
                x1 = 1;
            }
            if (s3.Text == "มีอาการเล็กน้อย" || s3.Text == "มีอาการ")
            {
                x2 = 1;
            }
            if (s4.Text == "มีอาการเล็กน้อย" || s4.Text == "มีอาการ")
            {
                x3 = 1;
            }
            if (s5.Text == "มีอาการเล็กน้อย" || s5.Text == "มีอาการ")
            {
                x4 = 1;
            }
            if (s6.Text == "มีอาการเล็กน้อย" || s6.Text == "มีอาการ")
            {
                x5 = 1;
            }
            sum = x1 + x2 + x3 + x4 + x5;

            if (rows > 0)
            {
                showUser();
                if (ss1 < 37)
                {
                    MessageBox.Show("บันทึกข้อมูลเรียบร้อย \n\nท่านมีอุณหภูมิปกติ");
                    if (sum >= 4)
                    {
                        MessageBox.Show("ท่านมีอาการร้ายแรง \nควรพบแพทย์และไปโรงพยาบาลให้เร็วที่สุด \nเฝ้าระวังห้ามใช้สิ่งของร่วมกับคนอื่น", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (sum >= 3)
                    {
                        MessageBox.Show("ท่านมีอาการเสี่ยงเป็น COVID-19 \nกรุณาอยู่ในพื้นที่กักตัว 14 วัน \nเฝ้าระวังห้ามใช้สิ่งของร่วมกับคนอื่น");
                    }
                    else if (sum >= 2)
                    {
                        MessageBox.Show("ท่านมีอาการเสี่ยงเป็น  COVID-19 \nมั่นสังเกตอาการตัวเองบ่อยครั้ง ");
                    }
                    else if (sum >= 1)
                    {
                        MessageBox.Show("ท่านไม่มีอาการเสี่ยงเป็น  COVID-19 ");
                    }
                }
                else if (ss1 < 38)
                {
                    {
                        MessageBox.Show("บันทึกข้อมูลเรียบร้อย \n\nท่านมีไข้อ่อน");
                        if (sum >= 4)
                        {
                            MessageBox.Show("ท่านมีอาการร้ายแรง \nควรพบแพทย์และไปโรงพยาบาลให้เร็วที่สุด \nเฝ้าระวังห้ามใช้สิ่งของร่วมกับคนอื่น", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (sum >= 3)
                        {
                            MessageBox.Show("ท่านมีอาการเสี่ยงเป็น COVID-19 \nกรุณาอยู่ในพื้นที่กักตัว 14 วัน \nเฝ้าระวังห้ามใช้สิ่งของร่วมกับคนอื่น");
                        }
                        else if (sum >= 2)
                        {
                            MessageBox.Show("ท่านมีอาการเสี่ยงเป็น  COVID-19 \nมั่นสังเกตอาการตัวเองบ่อยครั้ง ");
                        }
                        else if (sum >= 1)
                        {
                            MessageBox.Show("ท่านไม่มีอาการเสี่ยงเป็น  COVID-19 ");
                        }
                    }
                }
                else if (ss1 > 38)
                {
                    {
                        MessageBox.Show("บันทึกข้อมูลเรียบร้อย \n\nท่านมีไข้สูง");
                        if (sum >= 4)
                        {
                            MessageBox.Show("ท่านมีอาการร้ายแรง \nควรพบแพทย์และไปโรงพยาบาลให้เร็วที่สุด \nเฝ้าระวังห้ามใช้สิ่งของร่วมกับคนอื่น", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (sum >= 3)
                        {
                            MessageBox.Show("ท่านมีอาการเสี่ยงเป็น COVID-19 \nกรุณาอยู่ในพื้นที่กักตัว 14 วัน \nเฝ้าระวังห้ามใช้สิ่งของร่วมกับคนอื่น");
                        }
                        else if (sum >= 2)
                        {
                            MessageBox.Show("ท่านมีอาการเสี่ยงเป็น  COVID-19 \nมั่นสังเกตอาการตัวเองบ่อยครั้ง ");
                        }
                        else if (sum >= 1)
                        {
                            MessageBox.Show("ท่านไม่มีอาการเสี่ยงเป็น  COVID-19 ");
                        }
                    }
                }
                name.Text = "";
                surname.Text = "";
                s1.Text = "";
                s2.Text = "";
                s3.Text = "";
                s4.Text = "";
                s5.Text = "";
                s6.Text = "";
            }

        }

        private void delete_Click(object sender, EventArgs e)
        {
            int selectedRow = dataUser.CurrentCell.RowIndex;
            int deleteId = Convert.ToInt32(dataUser.Rows[selectedRow].Cells["id"].Value);

            MySqlConnection conn = databaseConnection();

            String sql = "DELETE FROM `user` WHERE id = '" + deleteId + "'";

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

        private void Form3_Load(object sender, EventArgs e)
        {
            showUser();

            s2.SelectedIndex = 0;
            s3.SelectedIndex = 0;
            s4.SelectedIndex = 0;
            s5.SelectedIndex = 0;
            s6.SelectedIndex = 0;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form7 f = new Form7();
            f.Show();
        }

        private void s1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar != 8))
            {
                e.Handled = true;
                MessageBox.Show("กรุณากรอกเฉพาะตัวเลข", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
