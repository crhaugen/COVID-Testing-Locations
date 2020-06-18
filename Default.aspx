<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="COVIDLocationTracker._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <%--<div class="row">
        <div class="col-md-4">
            <p>
                New User: 
       
                <br />
                <br />
                <asp:TextBox ID="newUserName" runat="server" placeholder="Username"></asp:TextBox><br />
                <br />
                <asp:TextBox ID="newPassword" input type="password" runat="server" placeholder="Password"></asp:TextBox><br />
                <br />
                <asp:TextBox ID="reNewPassword" input type="password" runat="server" placeholder="Repeat Password"></asp:TextBox><br />
                <br />
                <asp:Button ID="CreateUser" runat="server" Text="Create Account" OnClick="CreateUser_Click" /><br />
                &nbsp;
       
            </p>
        </div>
        <div class="col-md-4">
            <p>
                Returning User:
                <br /><br />
                <asp:TextBox ID="UserName" runat="server" placeholder="Username"></asp:TextBox>
                <br /><br />
                <asp:TextBox ID="Password" input type="password" runat="server" placeholder="Password"></asp:TextBox>
                <br />
                <br />
                <asp:Button ID="Login" runat="server" OnClick="Login_Click" Text="Login" />
                <br />
                <br />
                <p>
                    <asp:Label ID="Output" runat="server"></asp:Label>
        </div>
    </div>--%>

    <div class="login-page">
        <div class="form">
            <p style ="font-size: large;">
                COVID-19 Testing Locations Finder.
                <br />
                <br />

                Enter state and zip code to find COVID-19 testing locations nearest to you.
                <br />
                
       
            </p>
        </div>
        <div class="form">
                <asp:DropDownList ID="StateSelect" runat="server">
            <asp:ListItem Value="0">State</asp:ListItem>
            <asp:ListItem Value="arizona">Arizona</asp:ListItem>
            <asp:ListItem Value="california">California</asp:ListItem>
            <asp:ListItem Value="delaware">Delaware</asp:ListItem>
            <asp:ListItem Value="florida">Florida</asp:ListItem>
            <asp:ListItem Value="massachusetts">Massachusetts</asp:ListItem>
            <asp:ListItem Value="nevada">Nevada</asp:ListItem>
            <asp:ListItem Value="new-jersey<">New Jersey</asp:ListItem>
            <asp:ListItem Value="new-york">New York</asp:ListItem>
            <asp:ListItem Value="pennsylvania">Pennsylvania</asp:ListItem>
            <asp:ListItem Value="texas">Texas</asp:ListItem>
            <asp:ListItem Value="utah">Utah</asp:ListItem>
            <asp:ListItem Value="washington">Washington</asp:ListItem>
            </asp:DropDownList>
            <br />
     
            <asp:TextBox ID="ZipCode" runat="server" placeholder="Zip Code"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Search" />
                <br />
                <br />
                <asp:Label ID="Output" runat="server"></asp:Label>    
               
        </div>
    </div>
</asp:Content>
