using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ProductComplaints.DAL
{
    public class ComplaintDal
    {

        public SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();

        public ComplaintDal()
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

        public DataTable Getproduct(BAL.ComplaintBal obj)
        {
            string s = "SELECT * FROM product_table";
            SqlCommand cmd = new SqlCommand(s, GetCon());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public int complaintInsert(BAL.ComplaintBal obj)
        {
            string qry = "insert into complaint_table values('" + obj.CustomerId + "','" + obj.ProductId + "','" + obj.Complaint + "',GETDATE(),'Complaint Received')";
            SqlCommand cmd = new SqlCommand(qry, GetCon());
            return cmd.ExecuteNonQuery();
        }

        public DataTable complaintview(BAL.ComplaintBal obj)
        {
            string s = "select * from customer_table tb inner join complaint_table cmt on tb.customerId=cmt.customerId inner join product_table pt on pt.productId=cmt.productId";
            SqlCommand cmd = new SqlCommand(s, GetCon());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public int Changecmpltstatus(BAL.ComplaintBal obj)
        {
            string s = "update complaint_table set status='Complaint Confirmed' where complaintId='" + obj.ComplaintId + "'";
            SqlCommand cmd = new SqlCommand(s, GetCon());
            return cmd.ExecuteNonQuery();
        }

        public DataTable Viewcomplaintstatus(BAL.ComplaintBal obj)
        {
            string s = "select * from customer_table tb inner join complaint_table cmt on tb.customerId=cmt.customerId inner join product_table pt on pt.productId=cmt.productId where cmt.customerId='"+ obj.CustomerId +"'";
            SqlCommand cmd = new SqlCommand(s, GetCon());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}