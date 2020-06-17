<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="COVIDLocationTracker._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <p>&nbsp;<asp:DropDownList ID="StateSelect" runat="server">
            <asp:ListItem Value="0">State</asp:ListItem>
            <asp:ListItem Value="arizona">arizona</asp:ListItem>
            <asp:ListItem Value="california">california</asp:ListItem>
            <asp:ListItem Value="delaware">delaware</asp:ListItem>
            <asp:ListItem Value="florida">florida</asp:ListItem>
            <asp:ListItem Value="massachusetts">massachusetts</asp:ListItem>
            <asp:ListItem Value="nevada">nevada</asp:ListItem>
            <asp:ListItem Value="new-jersey<">new-jersey</asp:ListItem>
            <asp:ListItem Value="new-york">new-york</asp:ListItem>
            <asp:ListItem Value="pennsylvania">pennsylvania</asp:ListItem>
            <asp:ListItem Value="texas">texas</asp:ListItem>
            <asp:ListItem Value="utah">utah</asp:ListItem>
            <asp:ListItem Value="washington">washington</asp:ListItem>
            </asp:DropDownList>
            <asp:TextBox ID="ZipCode" runat="server" placeholder="Zip Code"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
        </p>
        <p>
            <asp:Label ID="Output" runat="server"></asp:Label>
        </p>
        <div class="col-md-4">
            <p>
              
            </p>
        </div>
    </div>

</asp:Content>
