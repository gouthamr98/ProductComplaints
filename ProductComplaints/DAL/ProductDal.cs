using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ProductComplaints.DAL
{
    public class ProductDal
    {
        public SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();

        public ProductDal()
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
        public int ProductInsert(BAL.ProductBal obj)
        {
            string qry = "insert into product_table values('" + obj.ProductName + "')";
            SqlCommand cmd = new SqlCommand(qry, GetCon());
            return cmd.ExecuteNonQuery();
        }

        public DataTable ViewProduct()
        {
            string s = "SELECT * FROM product_table";
            SqlCommand cmd = new SqlCommand(s, GetCon());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }

       

        public int ProductUpdate(BAL.ProductBal obj)
            {
                string s = "update product_table set product_name='" + obj.ProductName + "' where productId='" + obj.ProductId + "'";
                SqlCommand cmd = new SqlCommand(s, GetCon());
                return cmd.ExecuteNonQuery();
            }
        
        public int Deleteproduct(BAL.ProductBal obj)
        {
            string s = "delete from product_table where productId='" + obj.ProductId + "'";
            SqlCommand cmd = new SqlCommand(s, GetCon());
            return cmd.ExecuteNonQuery();
        }
    }
}