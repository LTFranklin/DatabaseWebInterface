<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ChangeLocation.aspx.cs" Inherits="ChangeLocation" %>

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
            SelectCommand="SELECT UserName, FirstName, Surname, Location, Date FROM StaffDetails WHERE (UserName = @Query)"
            UpdateCommand="UPDATE [StaffDetails] SET [Location] = @Location, [Date] = @Date WHERE [UserName] = @UserName"
            InsertCommand="INSERT INTO [StaffDetails] ([Username], [FirstName], [Surname]) VALUES (@UserName, @FirstName, @Surname)">
            <SelectParameters>
                <asp:Parameter Name="Query" Type="String" />
            </SelectParameters>
            <UpdateParameters>
                <asp:Parameter Name="UserName" Type="String" />
                <asp:Parameter Name="Location" Type="String" />
                <asp:Parameter Name="Date" Type="String" />
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
        <asp:Button ID="add" runat="server" Text="Add Record" Width="100" OnClick="add_Click" />
        <asp:DetailsView ID="DetailsView2" runat="server" AutoGenerateRows="False" DataSourceID="ActiveBase" Height="50px" Width="400px" DataKeyNames="UserName" AutoGenerateEditButton="True" AutoGenerateInsertButton="True" OnItemInserting="DetailsView2_ItemInserting" OnItemUpdating="DetailsView2_ItemUpdating" OnItemInserted="DetailsView2_ItemInserted">
            <Fields>
                <asp:BoundField DataField="UserName" HeaderText="User Name:" ReadOnly="True" SortExpression="UserName" ApplyFormatInEditMode="True" />
                <asp:BoundField DataField="FirstName" HeaderText="First Name:" ReadOnly="True" SortExpression="FirstName" />
                <asp:BoundField DataField="Surname" HeaderText="Surname:" ReadOnly="True" SortExpression="Surname" />
                <asp:BoundField DataField="Location" HeaderText="Location:" SortExpression="Location" InsertVisible="False" />
                <asp:BoundField DataField="Date" HeaderText="Date/Time:" ReadOnly="True" SortExpression="Date" InsertVisible="False" />
            </Fields>
        </asp:DetailsView>
        <asp:Label ID="entryError" runat="server" Text="Error: Please ensure details are correct and not already present in database" Visible="false"></asp:Label>
        <p>
        <asp:Button ID="home" runat="server" Text="Home" Width="100px" OnClick="home_Click" />
        </p>
    </form>
</body>
</html>
