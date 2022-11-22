using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProductComplaints.User
{
    public partial class ComplaintStatus : System.Web.UI.Page
    {
        BAL.ComplaintBal objcomtbl = new BAL.ComplaintBal();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                objcomtbl.CustomerId = Convert.ToInt32(Session["uid"]);
                GridView1.DataSource = objcomtbl.viewcomplaintstatus();
                GridView1.DataBind();
            }
           
        }
    }
}