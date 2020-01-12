using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using CrystalDecisions.CrystalReports.Engine;

namespace dbms
{
    public partial class Bill : Form
    {
        SqlDataAdapter sda;
        Connection c = new Connection();
     
        public Bill()
        {
            InitializeComponent();
          
          
        }

        private void customer_BillBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customer_BillBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.medical_Store_ManagementDataSet);

        }

        private void Bill_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'medical_Store_ManagementDataSet1.Customer_Bill' table. You can move, or remove it, as needed.
           // this.customer_BillTableAdapter1.Fill(this.medical_Store_ManagementDataSet1.Customer_Bill);
            // TODO: This line of code loads data into the 'medical_Store_ManagementDataSet.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.medical_Store_ManagementDataSet.Customer);
            // TODO: This line of code loads data into the 'medical_Store_ManagementDataSet.Customer_Bill' table. You can move, or remove it, as needed.
            this.customer_BillTableAdapter.Fill(this.medical_Store_ManagementDataSet.Customer_Bill);
            Disp_Data();
            
        }

        public void Disp_Data()
        {
           
            string sql = "Select * from Customer_Bill";
            sda = c.Disp_IN_DGV(sql);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            customer_BillDataGridView.DataSource = dt;
           

        }
        private void btn_Bil_Ins_Click(object sender, EventArgs e)
        {
            // - karega stock mai se medicine
            Decimal Quantity = 1;
            string sql1 = "Select * from Store_Stock where Medicine_id=" + med_IDTextBox.Text;
            Quantity=c.CalcultedValue(sql1, 3);
          
            Quantity = Quantity - Convert.ToDecimal(quantityTextBox.Text);
            // - krne k bd stock m quntity update karega
            string sql2 = "Update Store_Stock set Quantity=" + Quantity + " where Medicine_id=" + med_IDTextBox.Text + " ";
            Exception ex1 = c.IUD_Method(sql2);
            if (ex1 == null)
            {
              //  MessageBox.Show("Updated", "save", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(ex1.Message);
            }

            // ab bill mai value insert karega
            string sql = "Insert into Customer_Bill values("+cus_IDTextBox.Text+","+med_IDTextBox.Text+","+quantityTextBox.Text+","+total_AmountTextBox.Text+","+0+","+0+")";
            Exception ex = c.IUD_Method(sql);
            if (ex == null)
            {
                MessageBox.Show("Inserted", "save", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(ex.Message);
            }

            string sql3 = "Select * from Customer_Bill";
            sda=c.Disp_IN_DGV(sql3);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            customer_BillDataGridView.DataSource = dt;

        }

        private void quantityTextBox_TextChanged(object sender, EventArgs e)
        {
            Decimal Med_Price = 1;
            string sql = "Select * From Store_Stock Where Medicine_id='" + med_IDTextBox.Text + "'";
            Med_Price=c.CalcultedValue(sql, 6);
                total_AmountTextBox.Text = (Convert.ToDecimal(quantityTextBox.Text) * (Med_Price)).ToString();
  
           
        }

       
        private void btn_Grand_Total_Click(object sender, EventArgs e)
        {
            //int Total = 1;
            string sql = "Select sum (Total_Amount)from Customer_Bill where Cus_ID ="+cus_IDTextBox.Text;
            int val=c.CalcultedValue(sql, 0);
            textBox_Grand_Tot.Text = val.ToString();
           
        }

        private void btn_Report_Click(object sender, EventArgs e)
        {
            Bill_Reports r = new Bill_Reports();
            r.Show();
            this.Hide();
            
        }

        private void btn_Bill_Reset_Click(object sender, EventArgs e)
        {
            cus_IDTextBox.Text = "";
            med_IDTextBox.Text = "";
            textBox_Grand_Tot.Text = "";
            paid_amountTextBox.Text = "";
            return_AmountTextBox.Text = "";
            string q = "Select * from Customer_Bill";
            sda = c.Disp_IN_DGV(q);
           
            DataTable dt = new DataTable();
            sda.Fill(dt);
            customer_BillDataGridView.DataSource = dt;
        
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Select se = new Select();
            this.Hide();
            
        }

        private void btn_bil_Upd_Click(object sender, EventArgs e)
        {
            string sql = "Update Customer_Bill set Quantity='" + quantityTextBox.Text + "',Total_Amount=" + total_AmountTextBox.Text + "where Cus_Id=" + cus_IDTextBox.Text +"and Med_Id="+med_IDTextBox.Text+ "";
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

        private void Btn_bil_Del_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM [dbo].[Customer_Bill]  WHERE  Cus_ID="+cus_IDTextBox.Text;
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

        private void RET_AMOUNT_Click(object sender, EventArgs e)
        {
            int tot =Convert.ToInt32( textBox_Grand_Tot.Text);
            int p = Convert.ToInt32(paid_amountTextBox.Text);
            int RA = p - tot;
            return_AmountTextBox.Text =Convert.ToString( RA);

        }

        private void customer_BillDataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int idx = e.RowIndex;
            cus_IDTextBox.Text = customer_BillDataGridView.Rows[idx].Cells[0].Value.ToString();
            // SetSelectedsubject(employeeDataGridView.Rows[idx].Cells[1].Value.ToString());
            med_IDTextBox.Text = customer_BillDataGridView.Rows[idx].Cells[1].Value.ToString();
            quantityTextBox.Text = customer_BillDataGridView.Rows[idx].Cells[2].Value.ToString();
            total_AmountTextBox.Text =customer_BillDataGridView.Rows[idx].Cells[3].Value.ToString();
           
        }
    }
}

