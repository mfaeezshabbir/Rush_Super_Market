using Semester_Project.Invetory;
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

namespace Semester_Project.Customers
{
    public partial class allCustomers : Form
    {
        public allCustomers()
        {
            InitializeComponent();
            customers();
        }

        public void customers()
        {
            int i = 0;
            customersdataGrid.Rows.Clear();
            string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            string query = "select * from Customers_data";
            SqlCommand cm = new SqlCommand(query, con);
            con.Open();
            SqlDataReader dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                customersdataGrid.Rows.Add(dr[1].ToString(), dr[2].ToString(), dr[3].ToString());
            }
            dr.Close();
            con.Close();

        }

        private void searchbox_TextChanged(object sender, EventArgs e)
        {
            int i = 0;
            customersdataGrid.Rows.Clear();
            string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            string query = "select * FROM Customers_data WHERE customerName LIKE '%" + searchbox.Text + "%'" +
                "or mobile LIKE '%" + searchbox.Text + "%'" +
                "or city LIKE '%" + searchbox.Text + "%'";
            SqlCommand cm = new SqlCommand(query, con);
            con.Open();
            SqlDataReader dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                customersdataGrid.Rows.Add(dr[1].ToString(), dr[2].ToString(), dr[3].ToString());
            }
            dr.Close();
            con.Close();
        }

        private void customersdataGrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //if (e.RowIndex >= 0)
            //{
            //    DataGridViewRow row = customersdataGrid.Rows[e.RowIndex];
            //    nametext.Text = row.Cells[0].Value.ToString();
            //    mobiletext.Text = row.Cells[1].Value.ToString();
            //    citytext.Text = row.Cells[2].Value.ToString();
            //}
        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            addNupdate addNupdate = new addNupdate();
            addNupdate.addbutton.Enabled = true;
            addNupdate.updatebutton.Enabled = false;
            addNupdate.Show();
            customers();
        }


        private void customersdataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = customersdataGrid.Columns[e.ColumnIndex].Name;
            if (colName == "edit")
            {
                addNupdate addNupdate = new addNupdate();
                addNupdate.nametext.Text = customersdataGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
                addNupdate.mobiletext.Text = customersdataGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
                addNupdate.citytext.Text = customersdataGrid.Rows[e.RowIndex].Cells[2].Value.ToString();

                addNupdate.addbutton.Enabled = false;
                addNupdate.updatebutton.Enabled = true;
                addNupdate.Show();
            }
            else if (colName == "delete")
            {
                if (MessageBox.Show("Are you sure you want to delete this product?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
                    SqlConnection connection = new SqlConnection(cs);
                    string query = "Delete from Customers_data where customerName like '" + customersdataGrid.Rows[e.RowIndex].Cells[0].Value.ToString() + "' ";
                    connection.Open();
                    SqlCommand sqlCommand = new SqlCommand(query, connection);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Product Data Deleted Successfully!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    connection.Close();
                }
            }
            customers();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            customers();
        }

        private void refreshbutton_Click(object sender, EventArgs e)
        {
            customers();
        }
    }
}