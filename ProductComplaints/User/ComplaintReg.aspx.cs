using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProductComplaints.User
{
    public partial class ComplaintReg : System.Web.UI.Page
    {
        BAL.ComplaintBal objcmplntbal = new BAL.ComplaintBal();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddlproduct.DataSource = objcmplntbal.getproduct();
                ddlproduct.DataTextField = "product_name";
                ddlproduct.DataValueField = "productId";
                ddlproduct.DataBind();
                ddlproduct.Items.Insert(0, new ListItem("-- Select --", "0"));
            }
        }

        protected void btnreg_Click(object sender, EventArgs e)
        {
            objcmplntbal.ProductId = Convert.ToInt32(ddlproduct.SelectedValue);
            objcmplntbal.CustomerId = Convert.ToInt32(Session["uid"]);
            objcmplntbal.Complaint = txtcomplt.Text;
            int i = objcmplntbal.insertComplaint();
            if (i == 1)
            {
                Response.Write("<script>alert('Complaint Registered Successfully');</script>");
                
            }
        }
    }
}