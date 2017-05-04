<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
            <div>
        <asp:Button ID ="changeLocB" runat="server" Text="View/Change Location" width ="150" OnClick="changeLocB_Click"/>
       </div>
            <div>
        <asp:Button ID ="editDetB" runat="server" Text="Add/Edit Details" width ="150" OnClick="editDetB_Click"/>
       </div>
            <div>
        <asp:Button ID ="pastLocB" runat="server" Text="Past Location" width ="150" OnClick="pastLocB_Click"/>
       </div>
            <div>
        <asp:Button ID ="locPop" runat="server" Text="Location Population" width ="150" OnClick="locPop_Click"/>
       </div>
    </form>
</body>
</html>
