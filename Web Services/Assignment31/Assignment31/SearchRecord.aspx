<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SearchRecord.aspx.cs" Inherits="Assignment31.SearchRecord" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="SearchStudent.js"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ScriptManager runat="server">
         <Services>
                <asp:ServiceReference Path="~/StudentRecord.asmx" />
            </Services>
        </asp:ScriptManager>
        <table>
            <tr>
                <td>Enter Id : 
                </td>
                <td>
                    <input id="txtId" type="text" />
                    <input id="btnSearch" type="button" value="Get Student" onclick="GetStudentById()" />
                </td>

            </tr>
            <tr>
                <td>Name : 
                </td>
                <td>
                    <input id="txtName" type="text" />
                </td>
            </tr>
            <tr>
                <td>Gender : 
                </td>
                <td>
                    <input id="txtGender" type="text" />
                </td>
            </tr>
            <tr>
                <td>Age : 
                </td>
                <td>
                    <input id="txtAge" type="text" />
                </td>
            </tr>
            <tr>
                <td>Stream : 
                </td>
                <td>
                    <input id="txtStream" type="text" />
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
