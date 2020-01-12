using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace dbms
{
    public partial class Select : Form
    {
        public Select()
        {
            InitializeComponent();
        }
            string Username;
        SqlCommand cmd;
        SqlConnection con;
        SqlDataReader rd;
        string pass;
        SqlDataAdapter sda;
        Connection c = new Connection();
        public Select(string user)
        {
       
            InitializeComponent();
            Username = user;
        }

        private void billDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bill b = new Bill();
            b.Show();
        }

        
        private void stockDetatilsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stock st = new Stock();
            st.Show();
        }

       

        private void customerDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customer sc = new Customer();
            sc.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin_Login Ad = new Admin_Login();
            this.Hide();
            Ad.Show();
        }

        private void billReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bill_Reports BR = new Bill_Reports();
            BR.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bill b = new Bill();
                b.Show();
        }

        private void btn_Stock_Click(object sender, EventArgs e)
        {
            Stock st = new Stock();
            st.Show();
        }

        private void btn_Customer_Click(object sender, EventArgs e)
        {
            Customer sc = new Customer();
            sc.Show();
        }

        private void btn_Report_Click(object sender, EventArgs e)
        {
            if (Username == "admin")
            {
                pnl_REport.Visible = true;
            }
            else
            {
                MessageBox.Show("Login as admin");
            }
           
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            Admin_Login Ad = new Admin_Login();
            this.Hide();
            Ad.Show();
        }

        private void btn_Emp_Click(object sender, EventArgs e)
        {
            if (Username == "admin")
            {
                Employee em = new Employee();
                em.Show();
            }
            else
            {
                MessageBox.Show("Login as admin");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Emplyee_Report er = new Emplyee_Report();
            er.Show();
        }

        private void Select_Load(object sender, EventArgs e)
        {
            pnl_REport.Visible = false;
        }

        private void logoutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Admin_Login l = new Admin_Login();
            this.Hide();
            l.Show();
        }

        private void btn_StockREp_Click(object sender, EventArgs e)
        {
            Stock_Report sr = new Stock_Report();
            sr.Show();
        }

        private void btn_BillREP_Click(object sender, EventArgs e)
        {
            Bill_Reports br = new Bill_Reports();
            br.Show();
        }
    }
}
