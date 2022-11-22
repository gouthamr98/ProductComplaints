using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProductComplaints.Admin
{
    public partial class ProductReg : System.Web.UI.Page
    {

        BAL.ProductBal objprdtbl = new BAL.ProductBal();

        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                GridView1.DataSource = objprdtbl.viewproduct();
                GridView1.DataBind();
            }

        }

        protected void btnreg_Click(object sender, EventArgs e)
        {

            objprdtbl.ProductName = txtprdtname.Text;


            int i = objprdtbl.insertproduct();
            if (i == 1)
            {
                Response.Write("inserted success");

            }
            else
            {
                Response.Write("Faild");
            }
            GridView1.DataSource = objprdtbl.viewproduct();
            GridView1.DataBind();

        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString());

            TextBox txtname = new TextBox();
            txtname = (TextBox)GridView1.Rows[e.RowIndex].Cells[0].Controls[0];
            objprdtbl.ProductId = id;
            objprdtbl.ProductName = txtname.Text;
            int i = objprdtbl.productupdate();
            GridView1.DataSource = objprdtbl.viewproduct();
            GridView1.DataBind();
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            GridView1.DataSource = objprdtbl.viewproduct();
            GridView1.DataBind();

        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString());
            objprdtbl.ProductId = id;
            int i = objprdtbl.deleteproduct();
            GridView1.DataSource = objprdtbl.viewproduct();
            GridView1.DataBind();
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            GridView1.DataSource = objprdtbl.viewproduct();
            GridView1.DataBind();


        }
    }
}