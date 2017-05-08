<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Details.aspx.cs" Inherits="Details" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label Text="Username:" runat="server" Width="100"></asp:Label>
            <asp:TextBox ID="searchTB" runat="server" Width="150"></asp:TextBox>
        </div>
        <div>
            <asp:Button ID="search" Text="Search" runat="server" Width="100" OnClick="search_Click" />
        </div>
        <div>
            <asp:Label Text="Username:" runat="server" Width="100"></asp:Label>
            <asp:TextBox ID="userTB" runat="server" Width="150"></asp:TextBox>

        </div>
        <div>
            <asp:Label Text="First Name:" runat="server" Width="100"></asp:Label>
            <asp:TextBox ID="firstTB" runat="server" Width="150"></asp:TextBox>
        </div>
        <div>
            <asp:Label Text="Surname:" runat="server" Width="100"></asp:Label>
            <asp:TextBox ID="surTB" runat="server" Width="150"></asp:TextBox>
        </div>
        <div>
            <asp:Button ID="updateB" Text="Update" runat="server" Width="100" OnClick="updateB_Click" />
            <asp:Button ID="addB" Text="Add" runat="server" Width="100" OnClick="addB_Click" />
        </div>

        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>"></asp:SqlDataSource>
        <asp:Label ID="errorL" runat="server" Text="" Width="250"></asp:Label>
        <div>
            <asp:Button ID="homeB" Text="Home" runat="server" Width="100" OnClick="homeB_Click" />
        </div>
    </form>
</body>
</html>
