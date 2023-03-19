using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Semester_Project
{
    public partial class Signup_Form : Form
    {
        public Signup_Form()
        {
            InitializeComponent();
        }
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var signin = new Signin();
            signin  .Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool check = TnP.Checked;
            if (textFname.Text == "" || textLname.Text == "" || textEmail.Text == "" || textUsername.Text == "" || textPassword.Text == "" || check == false)
            {
                MessageBox.Show("Please enter data in all feilds", "Enter Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (textPassword.Text.Length < 8)
            {
                MessageBox.Show("Password Should be of 8 characters");
            }
            else if (textPassword.Text != textConfirmpassword.Text)
            {
                MessageBox.Show("Password Do Not Match🤔", "Password Do Not Match", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlConnection connection = new SqlConnection(cs);
                connection.Open();
                string query = "insert into user_data_table(firstname, lastname, username, email, password) values('"
                    + textFname.Text
                    + "' , '"
                    + textLname.Text
                    + "' , '"
                    + textUsername.Text
                    + "' , '"
                    + textEmail.Text
                    + "' , '"
                    + textPassword.Text
                    + " ')";
                SqlCommand sqlCommand = new SqlCommand(query, connection);
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Data Submitted Successfully");
                connection.Close();
            }
            textFname.Clear();
            textLname.Clear();
            textEmail.Clear();
            textUsername.Clear();
            textPassword.Clear();
            textConfirmpassword.Clear();
            TnP.Checked = false;
        }

        private void textFname_TextChanged(object sender, EventArgs e)
        {

        }

        private void Signup_Form_Load(object sender, EventArgs e)
        {

        }

        private void textEmail_TextChanged(object sender, EventArgs e)
        {


        }

        private void Exitbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBoxTandP_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void textPassword_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}

