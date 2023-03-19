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

namespace Semester_Project
{
    public partial class addNupdateuser : Form
    {
        public addNupdateuser()
        {
            InitializeComponent();
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to update this porduct info?", "Update Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
                    SqlConnection connection = new SqlConnection(cs);
                    string query = "update user_data_table set firstname = '" + textFname.Text + "'," +
                        " lastname = '" + textLname.Text + "'," +
                        " email = '" + textEmail.Text + "'," +
                        " username= '" + textUsername.Text + "'," +
                        " password = '" + textPassword.Text + "'" +
                        "where firstname like '" + textFname.Text +"'"+
                        "or lastname = '" + textLname.Text + "'" +
                        "or email = '" + textEmail.Text + "'" +
                        "or username= '" + textUsername.Text + "'" +
                        "or password = '" + textPassword.Text + "'";
                    connection.Open();
                    SqlCommand sqlCommand = new SqlCommand(query, connection);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("User Data Updated Successfully!", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
            SqlConnection connection = new SqlConnection(cs);
            string query = "insert into user_data_table(firstname, lastname, email, username, " +
                "password) values('"
                        + textFname.Text
                        + "' , '"
                        + textLname.Text
                        + "' , '"
                        + textEmail.Text
                        + "' , '"
                        + textUsername.Text
                        + "' , '"
                        + textPassword.Text
                        + " ')";
            connection.Open();
            SqlCommand sqlCommand = new SqlCommand(query, connection);
            sqlCommand.ExecuteNonQuery();
            MessageBox.Show("User Added Successfully!", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
            connection.Close();
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
