<%@ Page Title="Welcome" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChaiShai._Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
        <h1><%: Title %>.</h1>
        <h2>Your favourite Chai is now just a phone call away !</h2>
        <p class="lead">Now get your favourite Chai delivered right at your doorstep through our Chai-on-Call delivery service !You can order 
            our Chai flasks with great snacks for your meetings, conferences, customer visits, birthday celebrations or just when you feel like it.</p>
<asp:TextBox ID ="TextBoxOne" Text="Hi" runat ="server" />
</asp:Content>


