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
using CrystalDecisions.CrystalReports.Engine;


namespace dbms
{
    public partial class Bill_Reports : Form
    {
        SqlCommand cmd;
        SqlConnection con;
        SqlDataReader rd;
        SqlDataAdapter sda;
       
        public Bill_Reports()
        {
            con = new SqlConnection("Data Source=DESKTOP-R2B06FS;Initial Catalog=Medical_Store_Management;Integrated Security=True");
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_Show_Click(object sender, EventArgs e)
        {//all
            ReportDocument cry = new ReportDocument();
            string sql = "Select * from Customer_Bill";
            sda = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            sda.Fill(ds,"Customer_Bill");
            cry.Load(@"C:\Users\USER\Documents\Visual Studio 2015\Projects\dbms\dbms\CrystalReport1.rpt");
            cry.SetDataSource(ds);
            crystalReportViewer1.ReportSource = cry;
            cry.Refresh();
        }

        private void btn_Show_Click_1(object sender, EventArgs e)
        {
            ReportDocument cry = new ReportDocument();
            string sql = "Select * from Customer_Bill where Cus_Id ="+textBox_Show.Text+"";
            sda = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            sda.Fill(ds,"Customer_Bill");
            cry.Load(@"C:\Users\USER\Documents\Visual Studio 2015\Projects\dbms\dbms\CrystalReport1.rpt");
            cry.SetDataSource(ds);
            crystalReportViewer1.ReportSource = cry;
            cry.Refresh();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            Bill_Reports br = new Bill_Reports();
            this.Hide();
        }
    }
}
