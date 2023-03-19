namespace Semester_Project
{
    partial class Signin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Signin));
            this.ButtonSignin = new System.Windows.Forms.Button();
            this.textUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabel_forgotpass = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pass_show = new System.Windows.Forms.CheckBox();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.LinkLabel_signup = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonSignin
            // 
            this.ButtonSignin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonSignin.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.ButtonSignin.FlatAppearance.BorderSize = 2;
            this.ButtonSignin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.ButtonSignin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.ButtonSignin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonSignin.Font = new System.Drawing.Font("Raleway", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonSignin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(44)))), ((int)(((byte)(77)))));
            this.ButtonSignin.Location = new System.Drawing.Point(32, 332);
            this.ButtonSignin.Name = "ButtonSignin";
            this.ButtonSignin.Size = new System.Drawing.Size(193, 27);
            this.ButtonSignin.TabIndex = 2;
            this.ButtonSignin.Text = "Sign In";
            this.ButtonSignin.UseVisualStyleBackColor = true;
            this.ButtonSignin.Click += new System.EventHandler(this.buttonSignin_Click);
            // 
            // textUsername
            // 
            this.textUsername.Font = new System.Drawing.Font("Raleway", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textUsername.Location = new System.Drawing.Point(12, 193);
            this.textUsername.Name = "textUsername";
            this.textUsername.PlaceholderText = "Enter your username";
            this.textUsername.Size = new System.Drawing.Size(232, 22);
            this.textUsername.TabIndex = 0;
            this.textUsername.TextChanged += new System.EventHandler(this.textUsername_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Raleway", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(44)))), ((int)(((byte)(77)))));
            this.label1.Location = new System.Drawing.Point(12, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Raleway", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(44)))), ((int)(((byte)(77)))));
            this.label2.Location = new System.Drawing.Point(12, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Raleway", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(44)))), ((int)(((byte)(77)))));
            this.label3.Location = new System.Drawing.Point(76, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 37);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sign In";
            // 
            // linkLabel_forgotpass
            // 
            this.linkLabel_forgotpass.AutoSize = true;
            this.linkLabel_forgotpass.Font = new System.Drawing.Font("Raleway", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkLabel_forgotpass.LinkColor = System.Drawing.Color.DarkCyan;
            this.linkLabel_forgotpass.Location = new System.Drawing.Point(12, 279);
            this.linkLabel_forgotpass.Name = "linkLabel_forgotpass";
            this.linkLabel_forgotpass.Size = new System.Drawing.Size(101, 17);
            this.linkLabel_forgotpass.TabIndex = 4;
            this.linkLabel_forgotpass.TabStop = true;
            this.linkLabel_forgotpass.Text = "Forgot Password";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pass_show);
            this.panel1.Controls.Add(this.textPassword);
            this.panel1.Controls.Add(this.LinkLabel_signup);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.linkLabel_forgotpass);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.ButtonSignin);
            this.panel1.Controls.Add(this.textUsername);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.guna2PictureBox1);
            this.panel1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Location = new System.Drawing.Point(40, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(256, 397);
            this.panel1.TabIndex = 8;
            // 
            // pass_show
            // 
            this.pass_show.AutoSize = true;
            this.pass_show.Font = new System.Drawing.Font("Raleway", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pass_show.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(44)))), ((int)(((byte)(77)))));
            this.pass_show.Location = new System.Drawing.Point(159, 280);
            this.pass_show.Name = "pass_show";
            this.pass_show.Size = new System.Drawing.Size(85, 15);
            this.pass_show.TabIndex = 11;
            this.pass_show.Text = "Show Password";
            this.pass_show.UseVisualStyleBackColor = true;
            this.pass_show.CheckedChanged += new System.EventHandler(this.pass_show_CheckedChanged);
            // 
            // textPassword
            // 
            this.textPassword.Font = new System.Drawing.Font("Raleway", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textPassword.Location = new System.Drawing.Point(12, 248);
            this.textPassword.Name = "textPassword";
            this.textPassword.PlaceholderText = "Enter Your Password";
            this.textPassword.Size = new System.Drawing.Size(232, 22);
            this.textPassword.TabIndex = 1;
            this.textPassword.UseSystemPasswordChar = true;
            // 
            // LinkLabel_signup
            // 
            this.LinkLabel_signup.AutoSize = true;
            this.LinkLabel_signup.Font = new System.Drawing.Font("Raleway", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LinkLabel_signup.LinkColor = System.Drawing.Color.DarkCyan;
            this.LinkLabel_signup.Location = new System.Drawing.Point(134, 362);
            this.LinkLabel_signup.Name = "LinkLabel_signup";
            this.LinkLabel_signup.Size = new System.Drawing.Size(78, 17);
            this.LinkLabel_signup.TabIndex = 3;
            this.LinkLabel_signup.TabStop = true;
            this.LinkLabel_signup.Text = "Sign Up now";
            this.LinkLabel_signup.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Raleway", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(44)))), ((int)(((byte)(77)))));
            this.label4.Location = new System.Drawing.Point(46, 362);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Not a member?\r\n";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Rockwell", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(44)))), ((int)(((byte)(77)))));
            this.label5.Location = new System.Drawing.Point(23, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(210, 31);
            this.label5.TabIndex = 10;
            this.label5.Text = "______________";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Raleway", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(44)))), ((int)(((byte)(77)))));
            this.button1.Location = new System.Drawing.Point(131, 435);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::Semester_Project.Properties.Resources.logooo;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(-22, -20);
            this.guna2PictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(300, 166);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 12;
            this.guna2PictureBox1.TabStop = false;
            // 
            // Signin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(44)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(337, 461);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(44)))), ((int)(((byte)(77)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Signin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign in";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button ButtonSignin;
        private TextBox textUsername;
        private Label label1;
        private Label label2;
        private Label label3;
        private LinkLabel linkLabel_forgotpass;
        private Panel panel1;
        private LinkLabel LinkLabel_signup;
        private Label label4;
        private Label label5;
        private TextBox textPassword;
        private Button button1;
        private CheckBox pass_show;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
    }
}