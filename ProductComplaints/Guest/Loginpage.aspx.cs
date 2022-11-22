using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProductComplaints.Guest
{
    public partial class Loginpage : System.Web.UI.Page
    {

        BAL.RegBal objregbl = new BAL.RegBal();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnreg_Click(object sender, EventArgs e)
        {
            objregbl.CustUname = txtuname.Text;
            objregbl.CustPswd = txtpswd.Text;

            DataTable dtobj = objregbl.loginfun();

            if (dtobj.Rows.Count == 1)
            {
                Session["uid"] = dtobj.Rows[0]["LoginId"];
                Session["uname"] = dtobj.Rows[0]["usename"].ToString();
                string a = dtobj.Rows[0]["role"].ToString().Trim();

                if (a == "Admin")
                {
                    Response.Write("<script>alert('Admin Login Faild')</script>");
                    Response.Redirect("../Admin/AdminHome.aspx");
                }
                else
                {
                    string c = dtobj.Rows[0]["status"].ToString().Trim();

                    if (c=="Confirmed")
                    {
                        Response.Write("<script>alert('Successfully logged in')</script>");
                        Response.Redirect("../User/UserHome.aspx");
                    }
                    else
                    {
                        Response.Write("<script>alert('Failed to login')</script>");
                        Response.Redirect("../Guest/GuestHome.aspx");
                    }
                }
            }
        }
    }
}