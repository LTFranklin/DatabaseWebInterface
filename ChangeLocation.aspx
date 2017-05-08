<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ChangeLocation.aspx.cs" Inherits="ChangeLocation" %>

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
            <asp:Button ID="search" Text="Search" runat="server" Width="100" OnClick="search_Click"/>
        </div>
                <div>
            <asp:Label Text="Username:" runat="server" Width="100"></asp:Label>
            <asp:TextBox ID="userTB" runat="server" Width="150" ></asp:TextBox>

        </div>
        <div>
            <asp:Label Text="Location:" runat="server" Width="100"></asp:Label>
                <asp:TextBox ID="locTB" runat="server" Width="150" ></asp:TextBox>
        </div>
        <div>
            <asp:Label Text="Date:" runat="server" Width="100"></asp:Label>
                <asp:TextBox ID="dateTB" runat="server" Width="150" ReadOnly ="true"></asp:TextBox>
        </div>
        <div>
            <asp:Button ID="updateB" Text="Update" runat="server" Width="100" OnClick="updateB_Click"/>
        </div>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>"></asp:SqlDataSource>
                <asp:Label ID="errorL" runat="server" Text="" Width="250"></asp:Label>
                <div>
            <asp:Button ID="homeB" Text="Home" runat="server" Width="100" OnClick="homeB_Click" />
        </div>
    </form>
</body>
</html>
