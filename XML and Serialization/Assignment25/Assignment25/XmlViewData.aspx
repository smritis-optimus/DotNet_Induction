<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="XmlViewData.aspx.cs" Inherits="Assignment25.XmlViewData" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div align="center">
    <asp:DropDownList ID="DdlStudents" runat="server" onSelectedIndexChanged="DdlStudentsSelectedIndexChanged" AutoPostBack="true">
        <asp:ListItem ID="Select" Value="0" runat="server">--Select--</asp:ListItem>
        <asp:ListItem ID="Branch" Value="1" runat="server">Students of MCA Branch</asp:ListItem>
        <asp:ListItem ID="Grade" Value="2" runat="server">Students of Grade D</asp:ListItem>
            </asp:DropDownList>
        <br />
    </div>
        <div align="center">
            <asp:GridView ID="GrdStudents" runat="server"></asp:GridView>
        </div>
    </form>
</body>
</html>
