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
    public partial class Stock : Form
    {
    //  SqlConnection con;
     // SqlCommand cmd;
   
          SqlDataAdapter sda;
        Connection c = new Connection();
        public Stock()
        {
            InitializeComponent();
          
        }
        
        private void store_StockBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.store_StockBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.medical_Store_ManagementDataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'medical_Store_ManagementDataSet.Store_Stock' table. You can move, or remove it, as needed.
            this.store_StockTableAdapter.Fill(this.medical_Store_ManagementDataSet.Store_Stock);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sql = "Update Store_Stock set Medicine_Name='" + medicine_NameTextBox.Text + "',Quantity=" + quantityTextBox.Text + ",Pack_size=" + pack_sizeTextBox.Text + ",mg='" + mgTextBox.Text + "',Purpose='" + purposeTextBox.Text + "',Price=" + priceTextBox.Text + ",Expiry_Date='" + expiry_DateDateTimePicker.Text + "',Company_Name='" + company_NameTextBox.Text + "',Category='" + categoryTextBox.Text + "' where Medicine_id="+medicine_idTextBox.Text+"";
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

        private void button3_Click(object sender, EventArgs e)
        {
            string sql = "Delete from  Store_Stock where Medicine_id="+medicine_idTextBox.Text+"";
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

        private void btn_INS_Click(object sender, EventArgs e)
        {
            string sql = "Insert into Store_Stock values ("+medicine_idTextBox.Text+",' " + medicine_NameTextBox.Text + "'," + quantityTextBox.Text + "," + pack_sizeTextBox.Text + ",'" + mgTextBox.Text + "','" + purposeTextBox.Text + "'," + priceTextBox.Text + ",'" + expiry_DateDateTimePicker.Text + "','" + company_NameTextBox.Text + "','" + categoryTextBox.Text + "')";
            Exception ex =c.IUD_Method(sql);
            if (ex== null)
            {
                MessageBox.Show("Inserted", "save", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Stock_Reset_Click(object sender, EventArgs e)
        {
            medicine_idTextBox.Text = "";
            medicine_NameTextBox.Text = "";
            quantityTextBox.Text = "";
            pack_sizeTextBox.Text = "";
            mgTextBox.Text = "";
            purposeTextBox.Text = "";
            priceTextBox.Text = "";
            categoryTextBox.Text = "";
            company_NameTextBox.Text = "";
            string q = "Select * from Store_Stock";
            sda=c.Disp_IN_DGV(q);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            store_StockDataGridView.DataSource = dt;
            
        }

       
        private void btn_Close_Click(object sender, EventArgs e)
        {
            Select se = new Select();
            this.Hide();
            
        }


        private void Searchtextbox_Textchange(object sender, EventArgs e)
        {
           
            string sql = "Select * From Store_Stock Where Medicine_Name='" + SearchTextbox.Text + "'";
            sda=c.Disp_IN_DGV(sql);
            
            DataTable dt = new DataTable();
            sda.Fill(dt);
            store_StockDataGridView.DataSource = dt;
            

        }

        private void store_StockDataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int idx = e.RowIndex;
            medicine_idTextBox.Text = store_StockDataGridView.Rows[idx].Cells[0].Value.ToString();
           
            medicine_NameTextBox.Text = store_StockDataGridView.Rows[idx].Cells[1].Value.ToString();
            quantityTextBox.Text = store_StockDataGridView.Rows[idx].Cells[2].Value.ToString();
            pack_sizeTextBox.Text = store_StockDataGridView.Rows[idx].Cells[3].Value.ToString();
            mgTextBox.Text = store_StockDataGridView.Rows[idx].Cells[4].Value.ToString();
            purposeTextBox.Text =store_StockDataGridView.Rows[idx].Cells[5].Value.ToString();
            priceTextBox.Text = store_StockDataGridView.Rows[idx].Cells[6].Value.ToString();
            
            expiry_DateDateTimePicker.Text = store_StockDataGridView.Rows[idx].Cells[7].Value.ToString();
            // SetSelectedsubject(employeeDataGridView.Rows[idx].Cells[1].Value.ToString());
            company_NameTextBox.Text = store_StockDataGridView.Rows[idx].Cells[8].Value.ToString();
            categoryTextBox.Text = store_StockDataGridView.Rows[idx].Cells[9].Value.ToString();
            
        }
    }
}
