<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="COVIDLocationTracker._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <p>&nbsp;<asp:DropDownList ID="StateSelect" runat="server">
            <asp:ListItem Value="0">State</asp:ListItem>
            <asp:ListItem Value="01">arizona</asp:ListItem>
            <asp:ListItem Value="02">california</asp:ListItem>
            <asp:ListItem Value="03">delaware</asp:ListItem>
            <asp:ListItem Value="04">florida</asp:ListItem>
            <asp:ListItem Value="05">massachusetts</asp:ListItem>
            <asp:ListItem Value="06">nevada</asp:ListItem>
            <asp:ListItem Value="07">new-jersey</asp:ListItem>
            <asp:ListItem Value="08">new-york</asp:ListItem>
            <asp:ListItem Value="09">pennsylvania</asp:ListItem>
            <asp:ListItem Value="10">texas</asp:ListItem>
            <asp:ListItem Value="11">utah</asp:ListItem>
            <asp:ListItem Value="12">washington</asp:ListItem>
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
