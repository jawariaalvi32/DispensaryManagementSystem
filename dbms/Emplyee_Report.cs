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
    public partial class Emplyee_Report : Form
    {
        SqlCommand cmd;
        SqlConnection con;
        SqlDataReader rd;
        SqlDataAdapter sda;
        public Emplyee_Report()
        {
            InitializeComponent();
            con = new SqlConnection("Data Source=DESKTOP-R2B06FS;Initial Catalog=Medical_Store_Management;Integrated Security=True");
        }

        private void btn_Show_Click(object sender, EventArgs e)
        {
            ReportDocument cry = new ReportDocument();
            string sql = "Select * from Employee where Emp_ID=" + textBoxshow.Text + "";
            sda = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            sda.Fill(ds, "Employee");
            cry.Load(@"C:\Users\USER\Documents\rdbms\dbms\dbms\CrystalReport2.rpt");
            cry.SetDataSource(ds);
            crystalReportViewer2.ReportSource = cry;
            cry.Refresh();
        }

        private void btn_showall_Click(object sender, EventArgs e)
        {
            ReportDocument cry = new ReportDocument();
            string sql = "Select * from Employee";
            sda = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            sda.Fill(ds, "Employee");
            cry.Load(@"C:\Users\USER\Documents\rdbms\dbms\dbms\CrystalReport2.rpt");
            cry.SetDataSource(ds);
            crystalReportViewer2.ReportSource = cry;
            cry.Refresh();
        }

        private void crystalReportViewer2_Load(object sender, EventArgs e)
        {

        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            Emplyee_Report er = new Emplyee_Report();
            this.Hide();
        }
    }
}
