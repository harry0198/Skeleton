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
        <asp:ListBox ID="lstStaffList" runat="server" style="z-index: 1; left: 12px; top: 49px; position: absolute; height: 337px; width: 444px"></asp:ListBox>
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 17px; top: 398px; position: absolute; height: 27px; width: 54px;" Text="ADD" />
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 82px; top: 398px; position: absolute; height: 28px; width: 54px" Text="EDIT" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 674px; top: 431px; position: absolute"></asp:Label>
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 152px; top: 397px; position: absolute" Text="DELETE" />
        <asp:Label ID="lblUsernameEnter" runat="server" style="z-index: 1; left: 303px; top: 425px; position: absolute" Text="Enter a Username"></asp:Label>
        <asp:TextBox ID="txtUsername" runat="server" style="z-index: 1; left: 458px; top: 423px; position: absolute"></asp:TextBox>
        <asp:Button ID="btnApply" runat="server" OnClick="btnApply_Click" style="z-index: 1; left: 346px; top: 460px; position: absolute" Text="Apply" />
        <asp:Button ID="btnClear" runat="server" OnClick="btnClear_Click" style="z-index: 1; left: 423px; top: 459px; position: absolute" Text="Clear" />
    </form>
</body>
</html>
