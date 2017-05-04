<%@ Page Language="C#" AutoEventWireup="true" CodeFile="EditDetails.aspx.cs" Inherits="EditDetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="userNameL" runat="server" Text="User Name: " Width="100px"></asp:Label>
            <asp:TextBox ID="userNameTB" runat="server" Width="150px"></asp:TextBox>
            <asp:Label ID="uError" runat="server" Text="Invalid Username" ForeColor="Red" Visible="false" Width="150px"></asp:Label>
        </div>
        <asp:SqlDataSource ID="ActiveBase" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>"
            SelectCommand="SELECT UserName, FirstName, Surname FROM StaffDetails WHERE (UserName = @Query)"
            UpdateCommand="UPDATE [StaffDetails] SET [FirstName] = @FirstName, [Surname] = @Surname WHERE [UserName] = @UserName">
            <SelectParameters>
                <asp:Parameter Name="Query" Type="String" />
            </SelectParameters>
            <UpdateParameters>
                <asp:Parameter Name="UserName" Type="String" />
                <asp:Parameter Name="FirstName" Type="String" />
                <asp:Parameter Name="Surname" Type="String" />
            </UpdateParameters>
        </asp:SqlDataSource>
<%--        <asp:SqlDataSource ID="ArchiveBase" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>"
            UpdateCommand="UPDATE [Locations] SET [Location] = @Location, [Date] = @Date WHERE [UserName] = @UserName">
            <UpdateParameters>
                <asp:Parameter Name="UserName" Type="String" />
                <asp:Parameter Name="Location" Type="String" />
                <asp:Parameter Name="Date" Type="String" />
            </UpdateParameters>
        </asp:SqlDataSource>--%>
        <asp:Button ID="search" runat="server" Text="Search" Width="100" OnClick="search_Click" />
        <asp:DetailsView ID="DetailsView2" runat="server" AutoGenerateRows="False" DataSourceID="ActiveBase" Height="50px" Width="400px" DataKeyNames="UserName" AutoGenerateEditButton="True">
            <Fields>
                <asp:BoundField DataField="UserName" HeaderText="User Name:" ReadOnly="True" SortExpression="UserName" ApplyFormatInEditMode="True" />
                <asp:BoundField DataField="FirstName" HeaderText="First Name:" SortExpression="FirstName" />
                <asp:BoundField DataField="Surname" HeaderText="Surname:" SortExpression="Surname" />
            </Fields>
        </asp:DetailsView>
        <asp:Button ID="home" runat="server" Text="Home" Width="100px" OnClick="home_Click" />
    </form>
</body>
</html>
