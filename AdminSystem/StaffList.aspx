<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstStaffList" runat="server" style="z-index: 1; left: 12px; top: 49px; position: absolute; height: 386px; width: 514px"></asp:ListBox>
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 19px; top: 448px; position: absolute" Text="ADD" />
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 91px; top: 449px; position: absolute; height: 28px; width: 54px" Text="EDIT" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 674px; top: 431px; position: absolute"></asp:Label>
    </form>
</body>
</html>
