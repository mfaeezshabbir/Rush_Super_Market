using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Semester_Project.Invetory;

namespace Semester_Project
{
    public partial class Signin : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;

        public Signin()
        {
            InitializeComponent();
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

       public static string username;

        public static string showname
        {
            get { return username; }
            set { username = value; }
        }




        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var signupform = new Signup_Form();
            signupform.Show();
            Hide();
        }

        private void buttonSignin_Click(object sender, EventArgs e)
        {
            if (textUsername.Text != "" || textPassword.Text != "")
            {
                showname = textUsername.Text;

                SqlConnection con = new SqlConnection(cs);
                string query = "select * from user_data_table where username = '" + textUsername.Text + "' and password = '" + textPassword.Text + "'";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, con);
                DataTable dataTable = new();
                sqlDataAdapter.Fill(dataTable);
                con.Open();
                if (dataTable.Rows.Count == 1)
                {
                    MessageBox.Show("Welcome " + textUsername.Text + "", "ACCESS GRANTED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Home home = new Home();
                    this.Hide();
                    home.Show();

                }
                else
                {
                    MessageBox.Show("Invalid username or password!", "ACCESS DENITED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                con.Close();
            }
            else
            {
                MessageBox.Show("Enter Data", "Enter Data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void textUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pass_show_CheckedChanged(object sender, EventArgs e)
        {
            bool check = pass_show.Checked;

            switch (check)
            {
                case true:
                    textPassword.UseSystemPasswordChar = false;
                    break;
                default:
                    textPassword.UseSystemPasswordChar = true;
                    break;
            }
        }
    }
}
