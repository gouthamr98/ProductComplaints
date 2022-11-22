using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProductComplaints.Guest
{
    public partial class UserReg : System.Web.UI.Page
    {
        //create object of business access layer
        BAL.RegBal objregbl = new BAL.RegBal();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnreg_Click(object sender, EventArgs e)
        {
           
            objregbl.CustName = txtname.Text;
            objregbl.CustGender = RadioButtonList1.SelectedValue;
            objregbl.CustPlace = txtplace.Text;
            objregbl.CustPin = txtpin.Text;
            objregbl.CustDistrict = txtdistrict.Text;
            objregbl.CustEmail = txtmail.Text;
            objregbl.CustPhone = txtphone.Text;
            objregbl.CustUname = txtuname.Text;
            objregbl.CustPswd = txtpswd.Text;
            object j = objregbl.insertlogin();
            objregbl.LoginId = Convert.ToInt32(j);




            int i = objregbl.insertcustomer();
            if (i == 1)
            {
                Response.Write("<script>alert('Customer Registered Successfully');</script>");

            }
            else
            {
                Response.Write("<script>alert('Customer Registered Faild');</script>");
            }

          
            
        }

      
    }
}