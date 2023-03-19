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
    public partial class allproducts : Form
    {
        public allproducts()
        {
            InitializeComponent();
            loadproducts();

        }

        public void loadproducts()
        {
            int i = 0;
            dataGridView1.Rows.Clear();
            string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            string query = "select * FROM inventory WHERE itemName LIKE '%" + searchbox.Text + "%'" +
                "or Category LIKE '%" + searchbox.Text + "%'" +
                "or availableQuantity LIKE '%" + searchbox.Text + "%'";
            SqlCommand cm = new SqlCommand(query, con);
            con.Open();
            SqlDataReader dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dataGridView1.Rows.Add(dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString());
            }
            dr.Close();
            con.Close();

        }
        private void addbutton_Click(object sender, EventArgs e)
        {
            addNupdateproduct addNupdate = new addNupdateproduct();
            addNupdate.addbutton.Enabled = true;
            addNupdate.updatebutton.Enabled = false;
            addNupdate.Show();
            loadproducts();
        }

        private void searchbox_TextChanged(object sender, EventArgs e)
        {
            loadproducts();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGridView1.Columns[e.ColumnIndex].Name;
            if (colName == "edit")
            {
                addNupdateproduct addNupdate = new addNupdateproduct();
                addNupdate.nametext.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                addNupdate.categorytext.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                addNupdate.grosspricetext.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                addNupdate.netpricetext.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                addNupdate.quantitytext.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();

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
                    string query = "Delete from inventory where itemName like '" + dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString() + "' ";
                    connection.Open();
                    SqlCommand sqlCommand = new SqlCommand(query, connection);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Product Data Deleted Successfully!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    connection.Close();
                }
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            loadproducts();
        }
    }
}
