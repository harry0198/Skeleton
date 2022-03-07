<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        <asp:Label ID="lblGameID" runat="server" Text="Game ID" width="80px"></asp:Label>
        &nbsp;<asp:TextBox ID="txtGameID" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblGameName" runat="server" Text="Game Name" width="80px"></asp:Label>
        &nbsp;<asp:TextBox ID="txtGameName" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblPrice" runat="server" Text="Price" width="80px"></asp:Label>
        &nbsp;<asp:TextBox ID="txtPrice" runat="server"></asp:TextBox>
        <br />
            <asp:CheckBox ID="chkAvailability" runat="server" Text="Availability" />
            <br />
            <asp:Label ID="lblReleaseDate" runat="server" Text="Release Date"></asp:Label>
            &nbsp;<asp:TextBox ID="txtlReleaseDate" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblAgeRating" runat="server" Text="Age Rating" width="80px"></asp:Label>
            &nbsp;<asp:TextBox ID="txtAgeRating" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblError" runat="server"></asp:Label>
            <br />
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
&nbsp;<asp:Button ID="btnCancel" runat="server" Text="Cancel" />
            <br />
        </div>
        <br />
    </form>
</body>
</html>
