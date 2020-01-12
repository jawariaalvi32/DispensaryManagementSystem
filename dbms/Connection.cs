using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace dbms
{
    class Connection
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-R2B06FS;Initial Catalog=Medical_Store_Management;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter sda;
        SqlDataReader rd;
        //for insert update delete
        public Exception IUD_Method (string q)
        {
           
            cmd = new SqlCommand(q, con);
            try
            {
                Exception e = null;
                con.Open();
                //cmd.Parameters.Add(new SqlParameter("@img", img));
                //int x = cmd.ExecuteNonQuery();
                cmd.ExecuteNonQuery();
                con.Close();
                return e;
            }
            catch (Exception ex)
            {
                con.Close();
               return ex;
            }
            //con.Open();
            //    cmd.ExecuteNonQuery();
            //    con.Close();
        }
        public SqlDataAdapter Disp_IN_DGV (string q)
        {
            
            con.Open();
            sda = new SqlDataAdapter(q, con);

            con.Close();
            return sda;
        }
        public int CalcultedValue(string q, int n)
        {
            cmd = new SqlCommand(q, con);
            int Value = 1;
            
                con.Open();
                rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    Value = Convert.ToInt32(rd.GetValue(n));
                }
                con.Close();
                return Value;
        }
        public string Value(string q, int n)
        {
            cmd = new SqlCommand(q, con);
            string Value="";

            con.Open();
            rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                Value = Convert.ToString(rd.GetValue(n));
            }
            con.Close();
            return Value;
        }
    }
}
