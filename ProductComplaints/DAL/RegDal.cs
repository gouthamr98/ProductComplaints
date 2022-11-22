using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ProductComplaints.DAL
{
    public class RegDal
    {
        public SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();

        public RegDal()
        {
            //call conncetionstring;conncetion string should be set in the web.conf file
            string conn = ConfigurationManager.ConnectionStrings["rose"].ConnectionString;
            con = new SqlConnection(conn);
            cmd.Connection = con;
        }
        public SqlConnection GetCon()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }

        public object loginInsert(BAL.RegBal obj)
        {
            GetCon();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into Login_Table values('" + obj.CustUname + "','" + obj.CustPswd + "','Customer','Not-Confirmed');select @@IDENTITY";
            object id = cmd.ExecuteScalar();
            return id;

        }
        public int userInsert(BAL.RegBal obj)
        { 
            string qry = "insert into customer_table values('" + obj.CustName + "','" + obj.CustGender + "','" + obj.CustPlace + "'," +
                "'" + obj.CustPin + "','" + obj.CustDistrict+ "','" + obj.CustEmail + "','" + obj.CustPhone + "','" + obj.LoginId + "')";
            SqlCommand cmd = new SqlCommand(qry, GetCon());
            return cmd.ExecuteNonQuery();
        }

        public DataTable Loginfun(BAL.RegBal obj)
        {
            string qry = "SELECT * FROM Login_table WHERE usename='" + obj.CustUname + "' AND password='" + obj.CustPswd + "'";
            SqlCommand cmd = new SqlCommand(qry, GetCon());
           
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable dtobj = new DataTable();
            ad.Fill(dtobj);
            return dtobj;
            
        }

        public DataTable ViewCustomer()
        {
            string s = "SELECT * FROM customer_table ct inner join Login_Table lt on ct.LoginId=lt.LoginId";
            SqlCommand cmd = new SqlCommand(s, GetCon());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }

        public int Confirmupdate(BAL.RegBal obj)
        {
            string s = "update Login_table set status='Confirmed' where LoginId='" + obj.LoginId + "'";
            SqlCommand cmd = new SqlCommand(s, GetCon());
            return cmd.ExecuteNonQuery();
        }


    }
}