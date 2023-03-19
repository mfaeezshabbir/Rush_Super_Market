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

namespace Semester_Project
{
    public partial class allUsers : Form
    {
        public allUsers()
        {
            InitializeComponent();
            Users();        
        }

        public void Users()
        {
            int i = 0;
            dataGridView1.Rows.Clear();
            string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            string query = "select * from user_data_table where Concat(username, firstname, lastname) like '%"+ searchbox.Text +"%'";
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
            addNupdateuser addNupdateuser = new addNupdateuser();
            addNupdateuser.addbtn.Enabled = true;
            addNupdateuser.updatebtn.Enabled = false;
            addNupdateuser.Show();

        }

        private void searchbox_TextChanged(object sender, EventArgs e)
        {
            Users();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGridView1.Columns[e.ColumnIndex].Name;
            if (colName == "edit")
            {
                addNupdateuser addNupdateuser = new addNupdateuser();
                addNupdateuser.textFname.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString(); ;
                addNupdateuser.textLname.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString(); ;
                addNupdateuser.textEmail.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                addNupdateuser.textUsername.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                addNupdateuser.textPassword.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();

                addNupdateuser.addbtn.Enabled = false;
                addNupdateuser.updatebtn.Enabled = true;
                addNupdateuser.Show();
                

            }
            else if (colName == "delete")
            {
                if (MessageBox.Show("Are you sure you want to delete this user?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
                    SqlConnection connection = new SqlConnection(cs);
                    string query = "Delete from user_data_table where firstname like " +
                        "'" + dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString() + "' ";
                    connection.Open();
                    SqlCommand sqlCommand = new SqlCommand(query, connection);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("User Deleted Successfully!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    connection.Close();
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Users();
        }
    }
}
