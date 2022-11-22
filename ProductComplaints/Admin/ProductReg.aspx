<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="ProductReg.aspx.cs" Inherits="ProductComplaints.Admin.ProductReg" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <h3 align="center">Product Registartion</h3>
    <table align="center">
        <tr>
            <td>Product-Name</td>
            <td>
                <asp:TextBox ID="txtprdtname" runat="server"></asp:TextBox></td>
        </tr>
        
        <tr>
            <td>
                <asp:Button ID="btnreg" runat="server" Text="Register" OnClick="btnreg_Click" /></td>
        </tr>
    </table>

    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="productId" style="margin-right: 0px" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowDeleting="GridView1_RowDeleting" OnRowUpdating="GridView1_RowUpdating" OnRowEditing="GridView1_RowEditing">
        <Columns>
            <asp:BoundField HeaderText="product name" DataField="product_name" />
            <asp:CommandField HeaderText="Edit" ShowEditButton="True" />
            <asp:CommandField HeaderText="Delete" ShowDeleteButton="True" />
        </Columns>
     </asp:GridView>
</asp:Content>
