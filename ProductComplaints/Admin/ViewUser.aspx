<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="ViewUser.aspx.cs" Inherits="ProductComplaints.Admin.ViewUser" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h1>View User</h1>

    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="LoginId" OnRowDeleting="GridView1_RowDeleting">
        <Columns>
            <asp:BoundField DataField="customer_name" HeaderText="Customer Name" />
            <asp:BoundField DataField="gender" HeaderText="Gender" />
            <asp:BoundField DataField="place" HeaderText="Place" />
            <asp:BoundField DataField="pin_no" HeaderText="Pin.No" />
            <asp:BoundField DataField="district" HeaderText="District" />
            <asp:BoundField DataField="email" HeaderText="Email" />
            <asp:BoundField DataField="phone_no" HeaderText="Phone No" />
            <asp:BoundField DataField="status" HeaderText="Status" />
            <asp:CommandField DeleteText="StatusUpdate" HeaderText="UpdateStatus" ShowDeleteButton="True" />
        </Columns>
    </asp:GridView>



</asp:Content>
