<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ReadFromXML.aspx.cs" Inherits="Assignment26.ReadFromXML" %>

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
            <td colspan="2" text-align="center">
                XML File Upload
            </td>
        </tr>
        <tr>
            <td>
                Select a XML file :
            </td>
            <td>
                <asp:FileUpload ID="fileUpload" runat="server" />
            </td>
        </tr>
        <tr>
            <td>

            </td>
            <td>
                <asp:Button ID="btnUpload" runat="server" Text="Upload" OnClick="btnUpload_Click"/>
            </td>
        </tr>
        <tr>
            <td> </td>
            <td>
                <asp:Label ID="lblMessage" runat="server" Text="" />
            </td>
        </tr>
    </table>
    </div>
    </form>
</body>
</html>
