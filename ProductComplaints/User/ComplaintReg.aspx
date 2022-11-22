<%@ Page Title="" Language="C#" MasterPageFile="~/User/User.Master" AutoEventWireup="true" CodeBehind="ComplaintReg.aspx.cs" Inherits="ProductComplaints.User.ComplaintReg" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

      <style>
        .gradient-custom {
/* fallback for old browsers */
background: #f093fb;

/* Chrome 10-25, Safari 5.1-6 */
background: -webkit-linear-gradient(to bottom right, rgba(240, 147, 251, 1), rgba(245, 87, 108, 1));

/* W3C, IE 10+/ Edge, Firefox 16+, Chrome 26+, Opera 12+, Safari 7+ */
background: linear-gradient(to bottom right, rgba(240, 147, 251, 1), rgba(245, 87, 108, 1))
}

.card-registration .select-input.form-control[readonly]:not([disabled]) {
font-size: 1rem;
line-height: 2.15;
padding-left: .75em;
padding-right: .75em;
}
.card-registration .select-arrow {
top: 13px;
}
   </style>


     <section class="vh-150 gradient-custom">
  <div class="container py-5 h-100">
    <div class="row justify-content-center align-items-center h-100">
      <div class="col-12 col-lg-9 col-xl-7">
        <div class="card shadow-2-strong card-registration" style="border-radius: 15px;">
          <div class="card-body p-4 p-md-5">
            <h3 class="mb-4 pb-2 pb-md-0 mb-md-5">Complaint Registration</h3>
            <form>


                 <div class="row">
                <div class="col-12">

                  
                       <asp:DropDownList ID="ddlproduct" runat="server"  class="select form-control-lg"></asp:DropDownList>
                   
                  <label class="form-label select-label">Choose option</label>

                </div>
              </div>
                <br />
              <div class="row">
                <div class="col-md-6 mb-4">

                  <div class="form-outline">
                       
                      <asp:TextBox ID="txtcomplt" type="text" runat="server" class="form-control form-control-lg"></asp:TextBox>
                    <label class="form-label" for="firstName"> Enter your complaint</label>
                  </div>
                </div>
              </div>
             
               

              <div class="mt-4 pt-2">
                  <asp:Button ID="Button1" class="btn btn-primary btn-lg" runat="server" Text="Register" OnClick="btnreg_Click" />
              </div>

            </form>
          </div>
        </div>
      </div>
    </div>
  </div>
</section>

</asp:Content>
