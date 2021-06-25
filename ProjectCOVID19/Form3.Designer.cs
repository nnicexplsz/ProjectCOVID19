
namespace ProjectCOVID19
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.name = new System.Windows.Forms.TextBox();
            this.surname = new System.Windows.Forms.TextBox();
            this.save = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.s2 = new System.Windows.Forms.ComboBox();
            this.s3 = new System.Windows.Forms.ComboBox();
            this.s4 = new System.Windows.Forms.ComboBox();
            this.s5 = new System.Windows.Forms.ComboBox();
            this.s6 = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.dataUser = new System.Windows.Forms.DataGridView();
            this.s1 = new System.Windows.Forms.TextBox();
            this.edit = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataUser)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-7, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1183, 630);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // name
            // 
            this.name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.name.Location = new System.Drawing.Point(151, 105);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(161, 17);
            this.name.TabIndex = 1;
            // 
            // surname
            // 
            this.surname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.surname.Location = new System.Drawing.Point(490, 105);
            this.surname.Name = "surname";
            this.surname.Size = new System.Drawing.Size(160, 17);
            this.surname.TabIndex = 2;
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.DarkGreen;
            this.save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.save.Font = new System.Drawing.Font("4815_KwangMD_Catthai", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.save.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.save.Location = new System.Drawing.Point(943, 295);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(173, 38);
            this.save.TabIndex = 5;
            this.save.Text = "บันทึกข้อมูล";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.Red;
            this.delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.delete.Font = new System.Drawing.Font("4815_KwangMD_Catthai", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.delete.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.delete.Location = new System.Drawing.Point(943, 427);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(173, 38);
            this.delete.TabIndex = 5;
            this.delete.Text = "ลบข้อมูล";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label1.Font = new System.Drawing.Font("Bebas", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(9, 604);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 14);
            this.label1.TabIndex = 9;
            this.label1.Text = "©Version 9.2.4";
            // 
            // s2
            // 
            this.s2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.s2.FormattingEnabled = true;
            this.s2.Items.AddRange(new object[] {
            "ไม่มีอาการ",
            "มีอาการเล็กน้อย",
            "มีอาการ"});
            this.s2.Location = new System.Drawing.Point(185, 195);
            this.s2.Name = "s2";
            this.s2.Size = new System.Drawing.Size(121, 26);
            this.s2.TabIndex = 10;
            // 
            // s3
            // 
            this.s3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.s3.FormattingEnabled = true;
            this.s3.Items.AddRange(new object[] {
            "ไม่มีอาการ",
            "มีอาการเล็กน้อย",
            "มีอาการ"});
            this.s3.Location = new System.Drawing.Point(185, 252);
            this.s3.Name = "s3";
            this.s3.Size = new System.Drawing.Size(121, 26);
            this.s3.TabIndex = 11;
            // 
            // s4
            // 
            this.s4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.s4.FormattingEnabled = true;
            this.s4.Items.AddRange(new object[] {
            "ไม่มีอาการ",
            "มีอาการเล็กน้อย",
            "มีอาการ"});
            this.s4.Location = new System.Drawing.Point(185, 307);
            this.s4.Name = "s4";
            this.s4.Size = new System.Drawing.Size(121, 26);
            this.s4.TabIndex = 12;
            // 
            // s5
            // 
            this.s5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.s5.FormattingEnabled = true;
            this.s5.Items.AddRange(new object[] {
            "ไม่มีอาการ",
            "มีอาการเล็กน้อย",
            "มีอาการ"});
            this.s5.Location = new System.Drawing.Point(185, 363);
            this.s5.Name = "s5";
            this.s5.Size = new System.Drawing.Size(121, 26);
            this.s5.TabIndex = 13;
            // 
            // s6
            // 
            this.s6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.s6.FormattingEnabled = true;
            this.s6.Items.AddRange(new object[] {
            "ไม่มีอาการ",
            "มีอาการเล็กน้อย",
            "มีอาการ"});
            this.s6.Location = new System.Drawing.Point(185, 415);
            this.s6.Name = "s6";
            this.s6.Size = new System.Drawing.Size(121, 26);
            this.s6.TabIndex = 14;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.PeachPuff;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("4815_KwangMD_Catthai", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.button3.ForeColor = System.Drawing.Color.Chocolate;
            this.button3.Location = new System.Drawing.Point(1013, 553);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(142, 38);
            this.button3.TabIndex = 15;
            this.button3.Text = "กลับไปหน้าหลัก";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataUser
            // 
            this.dataUser.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dataUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataUser.Location = new System.Drawing.Point(332, 169);
            this.dataUser.Name = "dataUser";
            this.dataUser.Size = new System.Drawing.Size(605, 304);
            this.dataUser.TabIndex = 16;
            this.dataUser.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataUser_CellClick);
            this.dataUser.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataUser_CellContentClick);
            // 
            // s1
            // 
            this.s1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.s1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.s1.Location = new System.Drawing.Point(824, 105);
            this.s1.MaxLength = 5;
            this.s1.Name = "s1";
            this.s1.Size = new System.Drawing.Size(126, 17);
            this.s1.TabIndex = 18;
            this.s1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.s1_KeyPress);
            // 
            // edit
            // 
            this.edit.BackColor = System.Drawing.Color.Yellow;
            this.edit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.edit.Font = new System.Drawing.Font("4815_KwangMD_Catthai", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.edit.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.edit.Location = new System.Drawing.Point(943, 383);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(173, 38);
            this.edit.TabIndex = 19;
            this.edit.Text = "แก้ไขข้อมูลผู้เสี่ยง";
            this.edit.UseVisualStyleBackColor = false;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("4815_KwangMD_Catthai", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(943, 339);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(173, 38);
            this.button2.TabIndex = 20;
            this.button2.Text = "แสดงข้อมูลทั้งหมด";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1167, 624);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.s1);
            this.Controls.Add(this.dataUser);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.s6);
            this.Controls.Add(this.s5);
            this.Controls.Add(this.s4);
            this.Controls.Add(this.s3);
            this.Controls.Add(this.s2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.save);
            this.Controls.Add(this.surname);
            this.Controls.Add(this.name);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox surname;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox s2;
        private System.Windows.Forms.ComboBox s3;
        private System.Windows.Forms.ComboBox s4;
        private System.Windows.Forms.ComboBox s5;
        private System.Windows.Forms.ComboBox s6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataUser;
        private System.Windows.Forms.TextBox s1;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Button button2;
    }
}