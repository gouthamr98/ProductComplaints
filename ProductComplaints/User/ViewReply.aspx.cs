using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProductComplaints.User
{
    public partial class ViewReply : System.Web.UI.Page
    {
        BAL.QuerryBal objquebal = new BAL.QuerryBal();
        protected void Page_Load(object sender, EventArgs e)
        {
            objquebal.CustomerId = Convert.ToInt32( Session["uid"]);
            GridView1.DataSource = objquebal.viewreply();
            GridView1.DataBind();
        }
    }
}