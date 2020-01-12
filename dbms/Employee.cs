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
using System.IO;

namespace dbms
{
    public partial class Employee : Form
    {
        string imgloc = "";
        SqlDataAdapter sda;
        Connection c = new Connection();
        SqlCommand cmd;
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-R2B06FS;Initial Catalog=Medical_Store_Management;Integrated Security=True");
        public Employee()
        {
            InitializeComponent();
        }

        private void employeeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.medical_Store_ManagementDataSet);

        }

        private void Employee_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'medical_Store_ManagementDataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.medical_Store_ManagementDataSet.Employee);

        }

        

        private void btn_Emp_Ins_Click(object sender, EventArgs e)
        {
            if (login_IdTextBox.Text == "")
            {
                login_IdTextBox.Text = null;
                string sql = "Insert into Employee values (" + emp_IDTextBox.Text + ",' " + emp_NameTextBox.Text + "'," + phone_NoTextBox.Text + "," + cNICTextBox.Text + ",'" + salaryTextBox.Text + "','" + login_IdTextBox.Text + "','" + statusTextBox.Text + "')";
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
        }

        private void btn_Emp_Upd_Click(object sender, EventArgs e)
        {
            string sql = "Update Employee set Emp_Name='" +emp_NameTextBox.Text + "',Phone_No=" + phone_NoTextBox.Text + ",cNIC=" + cNICTextBox.Text + ",Salary='" + salaryTextBox.Text + "',Login_Id='" + login_IdTextBox.Text + "',Status='" + salaryTextBox.Text + "'where Emp_ID="+emp_IDTextBox.Text+"";
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

        private void btn_Emp_Del_Click(object sender, EventArgs e)
        {
            string sql = "Delete from  Employee where Emp_ID=" + emp_IDTextBox.Text + "";
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

        private void employeeDataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            int idx = e.RowIndex;
            emp_IDTextBox.Text = employeeDataGridView.Rows[idx].Cells[0].Value.ToString();
           // SetSelectedsubject(employeeDataGridView.Rows[idx].Cells[1].Value.ToString());
            emp_NameTextBox.Text = employeeDataGridView.Rows[idx].Cells[1].Value.ToString();
            phone_NoTextBox.Text = employeeDataGridView.Rows[idx].Cells[2].Value.ToString();
            cNICTextBox.Text = employeeDataGridView.Rows[idx].Cells[3].Value.ToString();
            salaryTextBox.Text = employeeDataGridView.Rows[idx].Cells[4].Value.ToString();
            login_IdTextBox.Text = employeeDataGridView.Rows[idx].Cells[5].Value.ToString();
            statusTextBox.Text = employeeDataGridView.Rows[idx].Cells[6].Value.ToString();
            //cbm_option.SelectedText = gv_questions.Rows[idx].Cells[8].Value.ToString();
            //SetCorrectOption(gv_questions.Rows[idx].Cells[8].Value.ToString());
        }

        private void btn_Emp_Reset_Click(object sender, EventArgs e)
        {
            emp_IDTextBox.Text = "";
            emp_NameTextBox.Text = "";
            phone_NoTextBox.Text = "";
            cNICTextBox.Text = "";
            salaryTextBox.Text = "";
            login_IdTextBox.Text = "";
            statusTextBox.Text = "";
            
            string q = "Select * from Employee";
            sda = c.Disp_IN_DGV(q);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            employeeDataGridView.DataSource = dt;
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Employee em = new Employee();
            this.Hide();
        }
    }
}
