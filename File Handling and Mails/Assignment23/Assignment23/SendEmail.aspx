<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SendEmail.aspx.cs" Inherits="Assignment23.SendEmail" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div width="700px" align="center">
        <asp:Label ID="lblFolder" runat="server" Text="Enter Path : "></asp:Label>
        <asp:TextBox ID="txtFolder" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" />
    </div>
    </form>
</body>
</html>
