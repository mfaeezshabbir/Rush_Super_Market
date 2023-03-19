namespace Semester_Project.Invetory
{
    partial class addNupdate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addNupdate));
            this.nametext = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addbutton = new System.Windows.Forms.Button();
            this.heading = new System.Windows.Forms.Label();
            this.mobiletext = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.citytext = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.updatebutton = new System.Windows.Forms.Button();
            this.clearbutton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.exit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nametext
            // 
            this.nametext.Location = new System.Drawing.Point(156, 79);
            this.nametext.Name = "nametext";
            this.nametext.Size = new System.Drawing.Size(239, 25);
            this.nametext.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer Name";
            // 
            // addbutton
            // 
            this.addbutton.Font = new System.Drawing.Font("Raleway", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(44)))), ((int)(((byte)(77)))));
            this.addbutton.Location = new System.Drawing.Point(156, 191);
            this.addbutton.Margin = new System.Windows.Forms.Padding(0);
            this.addbutton.Name = "addbutton";
            this.addbutton.Size = new System.Drawing.Size(75, 31);
            this.addbutton.TabIndex = 2;
            this.addbutton.Text = "Add";
            this.addbutton.UseVisualStyleBackColor = true;
            this.addbutton.Click += new System.EventHandler(this.addbutton_Click);
            // 
            // heading
            // 
            this.heading.AutoSize = true;
            this.heading.Font = new System.Drawing.Font("Raleway Medium", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.heading.Location = new System.Drawing.Point(21, 0);
            this.heading.Name = "heading";
            this.heading.Size = new System.Drawing.Size(208, 37);
            this.heading.TabIndex = 1;
            this.heading.Text = "Customer Info";
            // 
            // mobiletext
            // 
            this.mobiletext.Location = new System.Drawing.Point(156, 115);
            this.mobiletext.Name = "mobiletext";
            this.mobiletext.Size = new System.Drawing.Size(239, 25);
            this.mobiletext.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Customer Mobile";
            // 
            // citytext
            // 
            this.citytext.Location = new System.Drawing.Point(156, 151);
            this.citytext.Name = "citytext";
            this.citytext.Size = new System.Drawing.Size(239, 25);
            this.citytext.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Customer City";
            // 
            // updatebutton
            // 
            this.updatebutton.Font = new System.Drawing.Font("Raleway", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.updatebutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(44)))), ((int)(((byte)(77)))));
            this.updatebutton.Location = new System.Drawing.Point(238, 191);
            this.updatebutton.Margin = new System.Windows.Forms.Padding(0);
            this.updatebutton.Name = "updatebutton";
            this.updatebutton.Size = new System.Drawing.Size(75, 31);
            this.updatebutton.TabIndex = 2;
            this.updatebutton.Text = "Update";
            this.updatebutton.UseVisualStyleBackColor = true;
            this.updatebutton.Click += new System.EventHandler(this.updatebutton_Click);
            // 
            // clearbutton
            // 
            this.clearbutton.Font = new System.Drawing.Font("Raleway", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.clearbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(44)))), ((int)(((byte)(77)))));
            this.clearbutton.Location = new System.Drawing.Point(320, 191);
            this.clearbutton.Margin = new System.Windows.Forms.Padding(0);
            this.clearbutton.Name = "clearbutton";
            this.clearbutton.Size = new System.Drawing.Size(75, 31);
            this.clearbutton.TabIndex = 2;
            this.clearbutton.Text = "Clear";
            this.clearbutton.UseVisualStyleBackColor = true;
            this.clearbutton.Click += new System.EventHandler(this.clearbutton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.clearbutton);
            this.panel1.Controls.Add(this.heading);
            this.panel1.Controls.Add(this.updatebutton);
            this.panel1.Controls.Add(this.nametext);
            this.panel1.Controls.Add(this.addbutton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.mobiletext);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.citytext);
            this.panel1.Location = new System.Drawing.Point(17, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(416, 222);
            this.panel1.TabIndex = 3;
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Transparent;
            this.exit.Font = new System.Drawing.Font("Raleway", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(44)))), ((int)(((byte)(77)))));
            this.exit.Image = global::Semester_Project.Properties.Resources.Cancel_25px;
            this.exit.Location = new System.Drawing.Point(415, 15);
            this.exit.Margin = new System.Windows.Forms.Padding(0);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(30, 30);
            this.exit.TabIndex = 2;
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // addNupdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(44)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(450, 250);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Raleway", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "addNupdate";
            this.Text = "addNupdate";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public TextBox nametext;
        private Label label1;
        public Button addbutton;
        private Label heading;
        public TextBox mobiletext;
        private Label label2;
        public TextBox citytext;
        private Label label3;
        public Button updatebutton;
        public Button clearbutton;
        private Panel panel1;
        public Button exit;
    }
}