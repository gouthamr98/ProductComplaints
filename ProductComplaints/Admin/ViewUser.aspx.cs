using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProductComplaints.Admin
{
    public partial class ViewUser : System.Web.UI.Page
    {
        BAL.RegBal objprdtbl = new BAL.RegBal();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GridView1.DataSource = objprdtbl.viewcustomer();
                GridView1.DataBind();
            }
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

            int id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString());
            objprdtbl.LoginId = id;
            int i = objprdtbl.Updateconfirm();
            GridView1.DataSource = objprdtbl.viewcustomer();
            GridView1.DataBind();
        }
    }
}