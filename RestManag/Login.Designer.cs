namespace RestManag
{
    partial class Login
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
            this.usernamel = new System.Windows.Forms.Label();
            this.passwordl = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.clearbutton = new System.Windows.Forms.Button();
            this.Loginbutton = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Exitbutton = new System.Windows.Forms.Button();
            this.usersTableAdapter1 = new RestManag.CorrectDatabaseDataSetTableAdapters.UsersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // usernamel
            // 
            this.usernamel.AutoSize = true;
            this.usernamel.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernamel.Location = new System.Drawing.Point(44, 62);
            this.usernamel.Name = "usernamel";
            this.usernamel.Size = new System.Drawing.Size(82, 18);
            this.usernamel.TabIndex = 1;
            this.usernamel.Text = "Username";
            // 
            // passwordl
            // 
            this.passwordl.AutoSize = true;
            this.passwordl.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordl.Location = new System.Drawing.Point(43, 94);
            this.passwordl.Name = "passwordl";
            this.passwordl.Size = new System.Drawing.Size(81, 18);
            this.passwordl.TabIndex = 2;
            this.passwordl.Text = "Password";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(171, 60);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(167, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(171, 97);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(167, 20);
            this.textBox2.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::RestManag.Properties.Resources._3BE0800188BB83BD4D39F91CDC0115933667C30FC0333D8E5D_pimgpsh_fullsize_distr;
            this.pictureBox1.Location = new System.Drawing.Point(144, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(21, 20);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // clearbutton
            // 
            this.clearbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.clearbutton.Image = global::RestManag.Properties.Resources._776022FAF85955B3DCA4CF1E576C106697D03916556D9FE294_pimgpsh_fullsize_distr;
            this.clearbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.clearbutton.Location = new System.Drawing.Point(171, 165);
            this.clearbutton.Name = "clearbutton";
            this.clearbutton.Size = new System.Drawing.Size(75, 27);
            this.clearbutton.TabIndex = 5;
            this.clearbutton.Text = "  Clear";
            this.clearbutton.UseVisualStyleBackColor = true;
            // 
            // Loginbutton
            // 
            this.Loginbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Loginbutton.Image = global::RestManag.Properties.Resources._E2044651974571362A01E7FB777DE9A7886909B0A98A6D6AB2_pimgpsh_fullsize_distr;
            this.Loginbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Loginbutton.Location = new System.Drawing.Point(258, 165);
            this.Loginbutton.Name = "Loginbutton";
            this.Loginbutton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Loginbutton.Size = new System.Drawing.Size(80, 27);
            this.Loginbutton.TabIndex = 0;
            this.Loginbutton.Text = "  Log in";
            this.Loginbutton.UseVisualStyleBackColor = true;
            this.Loginbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::RestManag.Properties.Resources._2B601CF12D3B1EC04D7B52FC07D06490A340B45C85BB83F735_pimgpsh_fullsize_distr1;
            this.pictureBox2.Location = new System.Drawing.Point(144, 97);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 20);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // Exitbutton
            // 
            this.Exitbutton.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exitbutton.Location = new System.Drawing.Point(519, 429);
            this.Exitbutton.Name = "Exitbutton";
            this.Exitbutton.Size = new System.Drawing.Size(75, 36);
            this.Exitbutton.TabIndex = 8;
            this.Exitbutton.Text = "Exit";
            this.Exitbutton.UseVisualStyleBackColor = true;
            this.Exitbutton.Click += new System.EventHandler(this.Exitbutton_Click);
            // 
            // usersTableAdapter1
            // 
            this.usersTableAdapter1.ClearBeforeFill = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RestManag.Properties.Resources.original_014_matteo_rizzo_funghi_porcini_timo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(606, 466);
            this.Controls.Add(this.Exitbutton);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.clearbutton);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.passwordl);
            this.Controls.Add(this.usernamel);
            this.Controls.Add(this.Loginbutton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Text = "Login Window";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        private System.Windows.Forms.Button Loginbutton;
        private System.Windows.Forms.Label usernamel;
        private System.Windows.Forms.Label passwordl;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button clearbutton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button Exitbutton;
        private CorrectDatabaseDataSetTableAdapters.UsersTableAdapter usersTableAdapter1;
    }
}

