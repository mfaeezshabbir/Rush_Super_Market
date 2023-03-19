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

namespace Semester_Project.Orders
{
    public partial class allOrders : Form
    {
        public allOrders()
        {
            InitializeComponent();
            Orders();
        }

        public void Orders()
        {
            int i = 0;
            dataGridView1.Rows.Clear();
            string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            string query = "SELECT * from orders where productname Like '%"+searchbox.Text+"%'" +
                "or customername Like '%"+searchbox.Text+"%'";
            SqlCommand cm = new SqlCommand(query, con);
            con.Open();
            SqlDataReader dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dataGridView1.Rows.Add(i, dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString());
            }
            dr.Close();
            con.Close();

        }

        private void searchbox_TextChanged(object sender, EventArgs e)
        {
            Orders();
        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            newOrder newOrder = new newOrder();
            newOrder.Show();
            Orders();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGridView1.Columns[e.ColumnIndex].Name;

            if (colName == "delete")
            {
                if (MessageBox.Show("Are you sure you want to delete this order?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
                    SqlConnection connection = new SqlConnection(cs);
                    string query = "DELETE FROM orders WHERE qty like '" + dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString() + "'";
                    connection.Open();
                    SqlCommand sqlCommand = new SqlCommand(query, connection);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Product Data Deleted Successfully!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    connection.Close();

                    SqlCommand cm2 = new SqlCommand("update inventory set availableQuantity= (availableQuantity + '" + dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString() + "') WHERE itemName = '" + dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString() + "' ", connection);
                    connection.Open();
                    cm2.ExecuteNonQuery();
                    connection.Close();
                    Orders();
                }
            }
        }

        private void refreshbutton_Click(object sender, EventArgs e)
        {
            Orders();
        }
    }
}
