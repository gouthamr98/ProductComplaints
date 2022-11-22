using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ProductComplaints.DAL
{
    public class QuerryDal
    {
        public SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();

        public QuerryDal()
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

        public DataTable Getproduct(BAL.QuerryBal obj)
        {
            string s = "SELECT * FROM product_table";
            SqlCommand cmd = new SqlCommand(s, GetCon());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public int QuerryInsert(BAL.QuerryBal obj)
        {
            string qry = "insert into querry_table values('" + obj.CustomerId + "','" + obj.ProductId + "','" + obj.Querry + "','Querry-Received',GETDATE(),'no-reply')";
            SqlCommand cmd = new SqlCommand(qry, GetCon());
            return cmd.ExecuteNonQuery();
        }

        public DataTable queryview(BAL.QuerryBal obj)
        {
            string s = "select * from customer_table tb inner join querry_table qrt on tb.customerId=qrt.customerId inner join product_table pt on pt.productId=qrt.productId";
            SqlCommand cmd = new SqlCommand(s, GetCon());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public int QuerryUpdate(BAL.QuerryBal obj)
        {

            string qry = "update querry_table set reply='" + obj.Reply + "' where querryId='" + obj.QuerryId + "'";
            SqlCommand cmd = new SqlCommand(qry, GetCon());
            return cmd.ExecuteNonQuery();
        }
        public DataTable Replyview(BAL.QuerryBal obj)
        {
            string s = "select * from product_table pt inner join querry_table qt on pt.productId=qt.productId where qt.customerId='"+obj.CustomerId+"'";
            SqlCommand cmd = new SqlCommand(s, GetCon());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}