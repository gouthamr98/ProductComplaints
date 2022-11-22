using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProductComplaints.User
{
    public partial class QuerryReg : System.Web.UI.Page
    {
        BAL.QuerryBal objquerybal = new BAL.QuerryBal();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddlproduct.DataSource = objquerybal.getproduct();
                ddlproduct.DataTextField = "product_name";
                ddlproduct.DataValueField = "productId";
                ddlproduct.DataBind();
                ddlproduct.Items.Insert(0, new ListItem("-- Select --", "0"));
            }
        }

        protected void btnreg_Click(object sender, EventArgs e)
        {
            objquerybal.ProductId = Convert.ToInt32(ddlproduct.SelectedValue);
            objquerybal.CustomerId = Convert.ToInt32(Session["uid"]);
            objquerybal.Querry = txtqry.Text;
            int i = objquerybal.insertQuerry();
            if (i == 1)
            {
                Response.Write("<script>alert('Querry Registered Successfully');</script>");
                
            }
        }
    }
}