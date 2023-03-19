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
    public partial class addNupdateproduct : Form
    {
        public addNupdateproduct()
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

                if (nametext.Text != "" || categorytext.Text != "" || grosspricetext.Text != "" || netpricetext.Text != "" || quantitytext.Text != "")
                {
                    string query = "insert into inventory(itemName, Category, grossPrice, netPrice, availableQuantity) values('"
                        + nametext.Text
                        + "' , '"
                        + categorytext.Text
                        + "' , '"
                        + grosspricetext.Text
                        + "' , '"
                        + netpricetext.Text
                        + "' , '"
                        + quantitytext.Text
                        + " ')";
                    SqlCommand sqlCommand = new SqlCommand(query, connection);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Product Added Successfully", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    connection.Close();
                }
                else
                {
                    MessageBox.Show("Enter Data", "Enter Data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void updatebutton_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to update this porduct info?", "Update Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
                    SqlConnection connection = new SqlConnection(cs);
                    string query = "update inventory set itemName = '" + nametext.Text + "'," +
                        " Category = '" + categorytext.Text + "'," +
                        " grossPrice = '" + grosspricetext.Text + "'," +
                        " netPrice= '" + netpricetext.Text + "'," +
                        " availableQuantity = '" + quantitytext.Text + "'" +
                        "where itemName like '" + nametext.Text + "'" +
                        "or Category = '" + categorytext.Text + "'," +
                        " or grossPrice = '" + grosspricetext.Text + "'," +
                        " or netPrice= '" + netpricetext.Text + "'," +
                        " or availableQuantity = '" + quantitytext.Text + "'";
                    connection.Open();
                    SqlCommand sqlCommand = new SqlCommand(query, connection);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Product Data Updated Successfully!", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clearbutton_Click(object sender, EventArgs e)
        {
            nametext.Clear();
            categorytext.Clear();
            grosspricetext.Clear();
            netpricetext.Clear();
            quantitytext.Clear();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
