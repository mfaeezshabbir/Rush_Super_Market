using Microsoft.VisualBasic.Devices;
using Semester_Project.Invetory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semester_Project.Orders
{
    public partial class newOrder : Form
    {
        public newOrder()
        {
            InitializeComponent();
            Customer();
            Product();
        }

        public void Customer()
        {
            int i = 0;
            string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
            SqlConnection connection = new SqlConnection(cs);
            customerdatagrid.Rows.Clear();
            string query = "SELECT ID, customerName FROM Customers_data WHERE CONCAT(ID, customerName) LIKE '%" + customersearcbox.Text + "%'";
            SqlCommand cm = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                customerdatagrid.Rows.Add(dr[0].ToString(), dr[1].ToString());
            }
            dr.Close();

        }

        public void Product()
        {
            int i = 0;
            productdatagrid.Rows.Clear();
            string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
            SqlConnection connection = new SqlConnection(cs);

            SqlCommand cm = new SqlCommand("SELECT * FROM inventory WHERE CONCAT(itemID, itemName, grossPrice, availableQuantity) LIKE '%" + productsearchbox.Text + "%' and availablequantity > 0", connection);
            connection.Open();
            SqlDataReader dr = cm.ExecuteReader();

            while (dr.Read())
            {
                i++;
                productdatagrid.Rows.Add(i, dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[5].ToString());
            }
            dr.Close();
            connection.Close();
        }
        public void total_Click(object sender, EventArgs e)
        {
           
        }
        public void placeorderbutton_Click(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
            SqlConnection connection = new SqlConnection(cs);

            try
            {
                if (cidtext.Text == "")
                {
                    MessageBox.Show("Please select customer!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (pidtext.Text == "")
                {
                    MessageBox.Show("Please select product!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (MessageBox.Show("Are you sure you want to insert this order?", "Saving Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    SqlCommand cm = new SqlCommand("INSERT INTO orders (orderdate, productname, customername, qty, price, total) VALUES(@odate, @pname, @cname, @qty, @price, @total)", connection);
                    cm.Parameters.AddWithValue("@odate", orderdate.Value);
                    cm.Parameters.AddWithValue("@pname", pnametext.Text);
                    cm.Parameters.AddWithValue("@cname", cnametext.Text);
                    cm.Parameters.AddWithValue("@qty", Convert.ToInt32(quantitynumber.Text));
                    cm.Parameters.AddWithValue("@price", Convert.ToInt32(pricetext.Text));
                    cm.Parameters.AddWithValue("@total", Convert.ToInt32(totaltext.Text));
                    MessageBox.Show("Order has been successfully placed.");
                    connection.Open();
                    cm.ExecuteNonQuery();
                    connection.Close();

                    SqlCommand cm2 = new SqlCommand("update inventory set availableQuantity= (availableQuantity - '" + int.Parse(quantitynumber.Text) + "') WHERE itemName = '" + pnametext.Text + "' ", connection);
                    connection.Open();
                    cm2.ExecuteNonQuery();
                    connection.Close();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);


            }
            Product();
        }


        private void customerdatagrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cidtext.Text = customerdatagrid.Rows[e.RowIndex].Cells[0].Value.ToString();
            cnametext.Text = customerdatagrid.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void productdatagrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pidtext.Text = productdatagrid.Rows[e.RowIndex].Cells[0].Value.ToString();
            pnametext.Text = productdatagrid.Rows[e.RowIndex].Cells[1].Value.ToString();
            pricetext.Text = productdatagrid.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void productsearchbox_TextChanged(object sender, EventArgs e)
        {
            Product();
        }

        private void customersearcbox_TextChanged(object sender, EventArgs e)
        {
            Customer();
        }

        private void quantitynumber_TextChanged(object sender, EventArgs e)
        {
            int qty = 0;
            string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
            SqlConnection connection = new SqlConnection(cs);
            SqlCommand cm = new SqlCommand("SELECT availableQuantity FROM inventory WHERE itemId='" + pidtext.Text + "'", connection);
            connection.Open();
            SqlDataReader dr = cm.ExecuteReader();
            while (dr.Read())
            {
                qty = Convert.ToInt32(dr["availableQuantity"].ToString());
            }
            dr.Close();
            connection.Close();


            if (int.Parse(quantitynumber.Text) > qty)
            {
                int total = int.Parse(pricetext.Text) * int.Parse(quantitynumber.Text);
                totaltext.Text = total.ToString();
            }
            else
            {
                MessageBox.Show("Instock quantity is not enough!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            addNupdate addNupdate = new addNupdate();
            addNupdate.addbutton.Enabled = true;
            addNupdate.updatebutton.Enabled = false;
            addNupdate.Show();
            Customer();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addNupdateproduct addNupdateproduct = new addNupdateproduct();
            addNupdateproduct.addbutton.Enabled = true;
            addNupdateproduct.updatebutton.Enabled = false;
            addNupdateproduct.Show();
            Product();
        }
    }
}
