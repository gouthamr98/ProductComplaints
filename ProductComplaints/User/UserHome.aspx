<%@ Page Title="" Language="C#" MasterPageFile="~/User/User.Master" AutoEventWireup="true" CodeBehind="UserHome.aspx.cs" Inherits="ProductComplaints.User.UserHome" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  <style>
       /* Container holding the image and the text */
.container {
  position: relative;
  text-align: center;
  color: white;
}

/* Bottom left text */
.bottom-left {
  position: absolute;
  bottom: 8px;
  left: 16px;
  color:white;
}

/* Top left text */
.top-left {
  position: absolute;
  top: 100px;
  left: -150px;
  color:black;
  font-family:'Gill Sans', 'Gill Sans MT', Calibri, 'Trebuchet MS', sans-serif;
  font-size:35px;
  background-color:gray
}

/* Top right text */
.top-right {
  position: absolute;
  top: 8px;
  right: 16px;
}

/* Bottom right text */
.bottom-right {
  position: absolute;
  bottom: 150px;
  right: -130px;
   font-family:'Gill Sans', 'Gill Sans MT', Calibri, 'Trebuchet MS', sans-serif;
  font-size:35px;
  background-color:gray;
  color:black
}

/* Centered text */
.centered {
  position: absolute;
  top: 3%;
  left: 50%;
  transform: translate(-50%, -50%);
  color:white;
  font-size:3em;
}

    </style>

    <div class="container">
     
  <img src="../User/assets/images/ghome.jpg" alt="Snow" style="width:80%;">
  <div class="bottom-left">Bottom Left</div>
  <div class="top-left">You can Register <br />your complaint here</div>
  <div class="top-right">Top Right</div>
  <div class="bottom-right">We Will Help<br />with you queries</div>
  <div class="centered">User Home Page</div>
</div>
</asp:Content>
