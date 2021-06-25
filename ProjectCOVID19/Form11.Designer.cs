
namespace ProjectCOVID19
{
    partial class Form11
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form11));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Loing = new System.Windows.Forms.Button();
            this.complete = new System.Windows.Forms.Button();
            this.Username = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.A = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(546, 701);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Loing
            // 
            this.Loing.BackColor = System.Drawing.SystemColors.Control;
            this.Loing.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Loing.BackgroundImage")));
            this.Loing.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Loing.Font = new System.Drawing.Font("supermarket", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loing.ForeColor = System.Drawing.Color.FloralWhite;
            this.Loing.Location = new System.Drawing.Point(226, 473);
            this.Loing.Name = "Loing";
            this.Loing.Size = new System.Drawing.Size(78, 45);
            this.Loing.TabIndex = 3;
            this.Loing.Text = "Login";
            this.Loing.UseVisualStyleBackColor = false;
            this.Loing.Click += new System.EventHandler(this.Loing_Click);
            // 
            // complete
            // 
            this.complete.BackColor = System.Drawing.Color.Black;
            this.complete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("complete.BackgroundImage")));
            this.complete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.complete.Font = new System.Drawing.Font("supermarket", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.complete.ForeColor = System.Drawing.Color.FloralWhite;
            this.complete.Location = new System.Drawing.Point(353, 511);
            this.complete.Margin = new System.Windows.Forms.Padding(2);
            this.complete.Name = "complete";
            this.complete.Size = new System.Drawing.Size(138, 41);
            this.complete.TabIndex = 6;
            this.complete.Text = "สมัครสมาชิกใหม่";
            this.complete.UseVisualStyleBackColor = false;
            this.complete.Click += new System.EventHandler(this.complete_Click);
            // 
            // Username
            // 
            this.Username.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Username.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Username.Location = new System.Drawing.Point(164, 347);
            this.Username.Margin = new System.Windows.Forms.Padding(2);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(187, 19);
            this.Username.TabIndex = 7;
            this.Username.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Username_KeyPress);
            // 
            // Password
            // 
            this.Password.BackColor = System.Drawing.Color.White;
            this.Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Password.Location = new System.Drawing.Point(165, 427);
            this.Password.Margin = new System.Windows.Forms.Padding(2);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(187, 19);
            this.Password.TabIndex = 8;
            this.Password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Password_KeyPress);
            // 
            // A
            // 
            this.A.ActiveLinkColor = System.Drawing.Color.LightSeaGreen;
            this.A.AutoSize = true;
            this.A.BackColor = System.Drawing.Color.LightSeaGreen;
            this.A.LinkColor = System.Drawing.Color.LightSeaGreen;
            this.A.Location = new System.Drawing.Point(514, 147);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(14, 13);
            this.A.TabIndex = 9;
            this.A.TabStop = true;
            this.A.Text = "A";
            this.A.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.A_LinkClicked);
            // 
            // Form11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 694);
            this.Controls.Add(this.A);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.complete);
            this.Controls.Add(this.Loing);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form11";
            this.Text = "Form11";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Loing;
        private System.Windows.Forms.Button complete;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.LinkLabel A;
    }
}