<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Student.aspx.cs" Inherits="DesignPatternMVP.View.Student" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table>
        <tr>
            <td colspan="2">
                Student  Record
            </td>
        </tr>
        <tr>
            <td>
                Name :
            </td>
            <td>
                <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            </td>
        </tr>
          <tr>
            <td>
                Age : 
            </td>
            <td>
                <asp:TextBox ID="txtAge" runat="server"></asp:TextBox>
            </td>
        </tr>
          <tr>
            <td>
                Rollno : 
            </td>
            <td>
                <asp:TextBox ID="txtRollNo" runat="server"></asp:TextBox>
            </td>
        </tr>
          <tr>
            <td>
                Branch : 
            </td>
            <td>
                <asp:TextBox ID="txtBranch" runat="server"></asp:TextBox>
            </td>
        </tr>
          <tr>
            <td>
             
            </td>
            <td>
                <asp:Button ID="btnAddStudent" runat="server" Text="Add Student" OnClick="btnAddStudent_Click" style="height: 26px"/>
            </td>
        </tr>
    </table>

    </div>
        <asp:Label ID="lblMessage" runat="server" ForeColor="Red"></asp:Label>
        <asp:GridView ID="gvStudents" runat="server"></asp:GridView>
    </form>
</body>
</html>
