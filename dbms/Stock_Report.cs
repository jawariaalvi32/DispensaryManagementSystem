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
    public partial class Stock_Report : Form
    {
        SqlConnection con;
        SqlDataAdapter sda;
        public Stock_Report()
        {
            InitializeComponent();
            con = new SqlConnection("Data Source=DESKTOP-R2B06FS;Initial Catalog=Medical_Store_Management;Integrated Security=True");
        }

        private void btn_Show_Click(object sender, EventArgs e)
        {
            ReportDocument cry = new ReportDocument();
            string sql = "Select * from Store_Stock where Medicine_id =" + Show_Textbx.Text + "";
            sda = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            sda.Fill(ds, "Store_Stock");
            cry.Load(@"C:\Users\USER\Documents\rdbms\dbms\dbms\CrystalReport3.rpt");
            cry.SetDataSource(ds);
            crystalReportViewer3.ReportSource = cry;
            cry.Refresh();
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            ReportDocument cry = new ReportDocument();
            string sql = "Select * from Store_Stock";
            sda = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            sda.Fill(ds, "Store_Stock");
            cry.Load(@"C:\Users\USER\Documents\rdbms\dbms\dbms\CrystalReport3.rpt");
            cry.SetDataSource(ds);
            crystalReportViewer3.ReportSource = cry;
            cry.Refresh();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Stock_Report sr = new Stock_Report();
            this.Hide();
        }
    }
}
