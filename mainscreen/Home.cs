using Semester_Project.Invetory;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using Semester_Project.mainscreen;
using Semester_Project.Customers;
using Semester_Project.Orders;

namespace Semester_Project
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;

        //public void loadform(object Form)
        //{
        //    if (this.mainpanel.Controls.Count > 0)
        //        this.mainpanel.Controls.RemoveAt(0);
        //    Form f = (Form)Form;
        //    f.TopLevel = false;
        //    f.Dock = DockStyle.Fill;
        //    this.mainpanel.Controls.Add(f);
        //    this.mainpanel.Tag = f;
        //    f.Show();
        //}

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            mainpanel.Controls.Add(childForm);
            mainpanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void Home_Load(object sender, EventArgs e)
        {
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Exit Applicaton", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
            //this.Close();
            //Signin login = new Signin();
            //login.Show();
        }

        private void Home_Load_1(object sender, EventArgs e)
        {
            openChildForm(new Dashboard());
        }


        private void viewallproducts_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select * from inventory";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, con);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            var ap = new allproducts();
            ap.Show();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        

       

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Sign Out?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Dispose();
                new Signin().Show();
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new About());
        }

        private void customersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new allCustomers());
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new allUsers());
        }

        private void inventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new allproducts());

        }

        private void ordersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new allOrders());

        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new Dashboard());
        }
    }
}
