<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DeleteStudents.aspx.cs" Inherits="Ado.netAssignment.DeleteStudents" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table align="center">
        <tr>
            <td align="center" colspan="3">Delete Student</td>
        </tr>
        <tr>
            <td></td>
            <td align="center"> 
                <asp:DropDownList ID="dlStream" runat="server" AutoPostBack="True" OnSelectedIndexChanged="dlStream_SelectedIndexChanged"></asp:DropDownList>
            </td>
            <td></td>
        </tr>
        <tr>
            
            <td>
                <asp:ListBox ID="ltNames1" runat="server" ></asp:ListBox>

            </td>
            <td>
                <asp:Button ID="btnLeft" runat="server" Text="Move Left" OnClick="btnLeft_Click"  />
                <asp:Button ID="btnRight" runat="server" Text="Move Right" OnClick="btnRight_Click" />
            </td>
            <td>
                <asp:ListBox ID="ltNames2" runat="server"></asp:ListBox>
            </td>
        </tr>
        <tr>
            <td></td>
            <td align="center">
                <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" />
            </td>
            <td></td>
        </tr>
    </table>
    </div>
    </form>
</body>
</html>
