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
    public partial class Admin_Login : Form
    {
        SqlCommand cmd;
        SqlConnection con;
        SqlDataReader rd;
        string pass;
        SqlDataAdapter sda;
        Connection c = new Connection();
        public Admin_Login()
        {
            InitializeComponent();
            con = new SqlConnection("Data Source=DESKTOP-R2B06FS;Initial Catalog=Medical_Store_Management;Integrated Security=True");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            // TODO: This line of code loads data into the 'medical_Store_ManagementDataSet.Login' table. You can move, or remove it, as needed.
            this.loginTableAdapter.Fill(this.medical_Store_ManagementDataSet.Login);
            usernameTextBox.Text = "";
            passwordTextBox.Text = "";
            btn_signup.Visible = false;
        }

        private void loginBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.loginBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.medical_Store_ManagementDataSet);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string val;

            string sql = "Select * From Login Where Username='" + usernameTextBox.Text + "'";
            val=c.Value(sql, 1);
            //cmd = new SqlCommand(sql, con);
            try
            {
                //con.Open();
                //rd = cmd.ExecuteReader();
                //while (rd.Read())
                //{
                //    pass = rd.GetValue(1).ToString();
                //}
                //con.Close();
                if (val == passwordTextBox.Text)
                {
                    MessageBox.Show("Welcome");
                    Select sc = new dbms.Select(usernameTextBox.Text);
                    this.Hide();
                    sc.Show();
                }
                else
                {
                    MessageBox.Show("Incorrect details");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btn_signup_Click(object sender, EventArgs e)
        {

            signup_panel.Visible = true;
            usernameTextBox1.Text = "";
            passwordTextBox1.Text = "";
            eMailTextBox.Text = "";
            account_StatusTextBox.Text = "";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
           
            string sql = "Insert into Login  values('" + usernameTextBox1.Text + "','" + passwordTextBox1.Text + "','"+eMailTextBox.Text+"','"+account_StatusTextBox.Text+"')";
            //c.IUD_Method(sql);
           // MessageBox.Show("signed up", "save", MessageBoxButtons.OK, MessageBoxIcon.Information);
            cmd = new SqlCommand(sql, con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Signed up");
                signup_panel.Visible = false;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        private void btn_User_Click(object sender, EventArgs e)
        {
            btn_signup.Visible = false;
        }

        private void btn_Admin_Click(object sender, EventArgs e)
        {
            btn_signup.Visible = true;
        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
