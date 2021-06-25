
namespace ProjectCOVID19
{
    partial class Form10
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form10));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.NameText3 = new System.Windows.Forms.TextBox();
            this.SurnameText3 = new System.Windows.Forms.TextBox();
            this.Phonenumber = new System.Windows.Forms.TextBox();
            this.Username2 = new System.Windows.Forms.TextBox();
            this.Password2 = new System.Windows.Forms.TextBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.ConfirmPass = new System.Windows.Forms.TextBox();
            this.Apply = new System.Windows.Forms.Button();
            this.black = new System.Windows.Forms.Button();
            this.Loing = new System.Windows.Forms.Button();
            this.Address = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-5, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(595, 746);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // NameText3
            // 
            this.NameText3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NameText3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.NameText3.Location = new System.Drawing.Point(92, 192);
            this.NameText3.Margin = new System.Windows.Forms.Padding(2);
            this.NameText3.Name = "NameText3";
            this.NameText3.Size = new System.Drawing.Size(152, 19);
            this.NameText3.TabIndex = 4;
            // 
            // SurnameText3
            // 
            this.SurnameText3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SurnameText3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.SurnameText3.Location = new System.Drawing.Point(302, 192);
            this.SurnameText3.Margin = new System.Windows.Forms.Padding(2);
            this.SurnameText3.Name = "SurnameText3";
            this.SurnameText3.Size = new System.Drawing.Size(145, 19);
            this.SurnameText3.TabIndex = 5;
            // 
            // Phonenumber
            // 
            this.Phonenumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Phonenumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Phonenumber.Location = new System.Drawing.Point(95, 269);
            this.Phonenumber.Margin = new System.Windows.Forms.Padding(2);
            this.Phonenumber.MaxLength = 10;
            this.Phonenumber.Name = "Phonenumber";
            this.Phonenumber.Size = new System.Drawing.Size(330, 17);
            this.Phonenumber.TabIndex = 26;
            this.Phonenumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Phonenumber_KeyPress);
            // 
            // Username2
            // 
            this.Username2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Username2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Username2.Location = new System.Drawing.Point(94, 414);
            this.Username2.Margin = new System.Windows.Forms.Padding(2);
            this.Username2.Name = "Username2";
            this.Username2.Size = new System.Drawing.Size(330, 17);
            this.Username2.TabIndex = 27;
            this.Username2.TextChanged += new System.EventHandler(this.Username2_TextChanged);
            this.Username2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Username2_KeyPress);
            // 
            // Password2
            // 
            this.Password2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Password2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Password2.Location = new System.Drawing.Point(95, 490);
            this.Password2.Margin = new System.Windows.Forms.Padding(2);
            this.Password2.Name = "Password2";
            this.Password2.PasswordChar = '*';
            this.Password2.Size = new System.Drawing.Size(330, 17);
            this.Password2.TabIndex = 28;
            this.Password2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Password2_KeyPress);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("checkBox2.BackgroundImage")));
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.checkBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkBox2.Location = new System.Drawing.Point(82, 599);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(119, 20);
            this.checkBox2.TabIndex = 29;
            this.checkBox2.Text = "Showpassword";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged_1);
            // 
            // ConfirmPass
            // 
            this.ConfirmPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ConfirmPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.ConfirmPass.Location = new System.Drawing.Point(94, 565);
            this.ConfirmPass.Margin = new System.Windows.Forms.Padding(2);
            this.ConfirmPass.Name = "ConfirmPass";
            this.ConfirmPass.PasswordChar = '*';
            this.ConfirmPass.Size = new System.Drawing.Size(350, 17);
            this.ConfirmPass.TabIndex = 30;
            this.ConfirmPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ConfirmPass_KeyPress);
            // 
            // Apply
            // 
            this.Apply.BackColor = System.Drawing.Color.Black;
            this.Apply.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Apply.BackgroundImage")));
            this.Apply.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Apply.Font = new System.Drawing.Font("supermarket", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Apply.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Apply.Location = new System.Drawing.Point(205, 609);
            this.Apply.Margin = new System.Windows.Forms.Padding(2);
            this.Apply.Name = "Apply";
            this.Apply.Size = new System.Drawing.Size(143, 46);
            this.Apply.TabIndex = 32;
            this.Apply.Text = "สร้างบัญชีผู้ใช้";
            this.Apply.UseVisualStyleBackColor = false;
            this.Apply.Click += new System.EventHandler(this.Apply_Click);
            // 
            // black
            // 
            this.black.BackColor = System.Drawing.Color.IndianRed;
            this.black.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.black.Font = new System.Drawing.Font("supermarket", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.black.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.black.Location = new System.Drawing.Point(450, 650);
            this.black.Name = "black";
            this.black.Size = new System.Drawing.Size(104, 46);
            this.black.TabIndex = 33;
            this.black.Text = "ย้อนกลับ";
            this.black.UseVisualStyleBackColor = false;
            this.black.Click += new System.EventHandler(this.black_Click);
            // 
            // Loing
            // 
            this.Loing.BackColor = System.Drawing.SystemColors.Control;
            this.Loing.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Loing.BackgroundImage")));
            this.Loing.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Loing.Font = new System.Drawing.Font("supermarket", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loing.ForeColor = System.Drawing.Color.FloralWhite;
            this.Loing.Location = new System.Drawing.Point(450, 599);
            this.Loing.Name = "Loing";
            this.Loing.Size = new System.Drawing.Size(104, 45);
            this.Loing.TabIndex = 34;
            this.Loing.Text = "เข้าสู่ระบบ";
            this.Loing.UseVisualStyleBackColor = false;
            this.Loing.Click += new System.EventHandler(this.Loing_Click);
            // 
            // Address
            // 
            this.Address.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Address.Location = new System.Drawing.Point(95, 343);
            this.Address.Margin = new System.Windows.Forms.Padding(2);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(352, 19);
            this.Address.TabIndex = 35;
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 741);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.Loing);
            this.Controls.Add(this.black);
            this.Controls.Add(this.Apply);
            this.Controls.Add(this.ConfirmPass);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.Password2);
            this.Controls.Add(this.Username2);
            this.Controls.Add(this.Phonenumber);
            this.Controls.Add(this.SurnameText3);
            this.Controls.Add(this.NameText3);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form10";
            this.Text = "Form10";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox NameText3;
        private System.Windows.Forms.TextBox SurnameText3;
        private System.Windows.Forms.TextBox Phonenumber;
        private System.Windows.Forms.TextBox Username2;
        private System.Windows.Forms.TextBox Password2;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.TextBox ConfirmPass;
        private System.Windows.Forms.Button Apply;
        private System.Windows.Forms.Button black;
        private System.Windows.Forms.Button Loing;
        private System.Windows.Forms.TextBox Address;
    }
}