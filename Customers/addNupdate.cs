using Semester_Project.Customers;
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

namespace Semester_Project.Invetory
{
    public partial class addNupdate : Form
    {
        public addNupdate()
        {
            InitializeComponent();
        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString);
            string query1 = "select * from inventory where itemname = '" + nametext.Text + "'";
            connection.Open();
            SqlCommand cmd = new SqlCommand(query1, connection);
            int NumberOfRowsWithUserName = Convert.ToInt32(cmd.ExecuteScalar());
            if (NumberOfRowsWithUserName > 0)
            {
                MessageBox.Show("Product already exists");

            }
            else
            {

                if (nametext.Text != "" || mobiletext.Text != "" || citytext.Text != "")
                {
                    string query = "insert into Customers_data(customerName, mobile, city) values('"
                        + nametext.Text
                        + "' , '"
                        + mobiletext.Text
                        + "' , '"
                        + citytext.Text
                        + " ')";
                    SqlCommand sqlCommand = new SqlCommand(query, connection);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Customer Added Successfully", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    connection.Close();
                }
                else
                {
                    MessageBox.Show("Enter Data", "Enter Data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                allCustomers allCustomers = new allCustomers();
                allCustomers.customers();
            }
        }

        private void updatebutton_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to update this customer info?", "Update Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
                    SqlConnection connection = new SqlConnection(cs);
                    string query = "update Customers_data set customerName = '" + nametext.Text + "'," +
                        " mobile = '" + mobiletext.Text + "'," +
                        " city = '" + citytext.Text + "'where customerName like '" + nametext.Text + "'";
                    connection.Open();
                    SqlCommand sqlCommand = new SqlCommand(query, connection);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Product Data Updated Successfully!", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    connection.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clearbutton_Click(object sender, EventArgs e)
        {
            nametext.Clear();
            mobiletext.Clear();
            citytext.Clear();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
