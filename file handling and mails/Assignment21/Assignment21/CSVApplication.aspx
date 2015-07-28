<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CSVApplication.aspx.cs" Inherits="Assignment21.CSVApplication" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table align="center"style="font-family: Cambria; font-size: medium; font-weight: bold; border-collapse: collapse; border-spacing: 4px;">
            <tr>
                <td>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    Upload using CSV
                    <br />
                </td>
            </tr>
            <tr>
                <td>
                     <asp:FileUpload ID="fileUploadCSV" runat="server" />
                     <br />
                </td>
            </tr>
            <tr>
                <td> <asp:Label ID="lblMessage" runat="server" Text=""></asp:Label></td>
            </tr>
            <tr>
                <td>
                     <asp:Button ID="btnSaveToDB" runat="server" Text="Save Students To DB" OnClick="btnSaveToDB_Click" />
                </td>
            </tr>
        </table>
       
       
    </div>
    </form>
</body>
</html>
