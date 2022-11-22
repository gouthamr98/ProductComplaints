<%@ Page Title="" Language="C#" MasterPageFile="~/Guest/Guest.Master" AutoEventWireup="true" CodeBehind="Loginpage.aspx.cs" Inherits="ProductComplaints.Guest.Loginpage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    
     <style>
       
.container1{
    height:100vh;
    display:flex;
    justify-content:center;
    align-items:center;
}

.card1{
    width:360px;
    height:370px;
    background-color:#fff;
    border-radius:10px;
    border:none;
    padding:20px;
}

.form1{
    margin-top:15px;
}

.form label{
    font-weight:700;
    font-size:14px;
}
.form input{
    height:45px;
    border:2px solid #eee;
    transition:all 0.9s;
}

.form input:focus{
    box-shadow:none;
    border:2px solid #2541B2;
}

.social-button{
    height:45px;
    background-color:#2541B2;
}

.login-button{
    margin-top:15px;
}

.login-button button{
    height:45px;
}
     </style>





     <div class="container1">
    <div class="card1">
        <div class="d-flex justify-content-center">
            <h4>Login</h4>
        </div>
        <button class="btn btn-primary mt-2 social-button">Signin using open ID</button>
        <div class="form1">
            <label>User-Name</label>
            <asp:TextBox ID="txtuname" class="form-control" type="text" runat="server"></asp:TextBox>
          
        </div>
        
        <div class="form">
            <label class="d-flex justify-content-between align-items-center"><span>Password</span></label>
            <asp:TextBox ID="txtpswd" class="form-control" type="text" runat="server"></asp:TextBox>
            
        </div>
        
        <div class="login-button">
            <asp:Button  runat="server" class="btn btn-success w-100" Text="LogIn" OnClick="btnreg_Click" />
          
        </div>
        
        
    </div>
</div>



</asp:Content>
