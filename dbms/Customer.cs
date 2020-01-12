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
    public partial class Customer : Form
    {
        
        SqlDataAdapter sda;
        Connection c = new Connection();
        public Customer()
        {
            InitializeComponent();
            
        }

        private void customerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.medical_Store_ManagementDataSet);

        }

        private void Customer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'medical_Store_ManagementDataSet.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.medical_Store_ManagementDataSet.Customer);

        }
       
        private void btn_Cus_Ins_Click(object sender, EventArgs e)
        {
            string sql = "Insert into Customer values(" +customer_IdTextBox .Text + ",'" + customer_NameTextBox.Text + "',"+phone_NOTextBox.Text+")";
            Exception ex = c.IUD_Method(sql);
            if (ex == null)
            {
                MessageBox.Show("Inserted", "save", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btn_Cus_Upd_Click(object sender, EventArgs e)
        {
            string sql = "Update Customer set Customer_Name='" + customer_NameTextBox.Text + "',Phone_NO=" + phone_NOTextBox.Text+"where Customer_Id=" +customer_IdTextBox.Text+ "";
            Exception ex = c.IUD_Method(sql);
            if (ex == null)
            {
                MessageBox.Show("Updated", "save", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Cus_Del_Click(object sender, EventArgs e)
        {
            string sql = "Delete from Customer where Customer_Id=" + customer_IdTextBox.Text + "";
            Exception ex = c.IUD_Method(sql);
            if (ex == null)
            {
                MessageBox.Show("Deleted", "save", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btn_Customer_Reset_Click(object sender, EventArgs e)
        {
            customer_IdTextBox.Text = "";
            customer_NameTextBox.Text = "";
            phone_NOTextBox.Text = "";
            string q = "Select * from Customer";
            sda = c.Disp_IN_DGV(q);
          
            DataTable dt = new DataTable();
            sda.Fill(dt);
            customerDataGridView.DataSource = dt;
           
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Select se = new Select();
            this.Hide();
           
        }

        private void SearchTextbox_Textchanged(object sender, EventArgs e)
        {
            string sql = "Select * From Customer Where Customer_ID='" + Search_Textbox.Text + "'";
            sda = c.Disp_IN_DGV(sql);
            //sda = new SqlDataAdapter("Select * From Store_Stock Where Medicine_Name='" + SearchTextbox.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            customerDataGridView.DataSource = dt;

        }

        private void customerDataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int idx = e.RowIndex;
            customer_IdTextBox.Text = customerDataGridView.Rows[idx].Cells[0].Value.ToString();
           
            customer_NameTextBox.Text = customerDataGridView.Rows[idx].Cells[1].Value.ToString();
           phone_NOTextBox.Text = customerDataGridView.Rows[idx].Cells[2].Value.ToString();
            
        }
    }
}
