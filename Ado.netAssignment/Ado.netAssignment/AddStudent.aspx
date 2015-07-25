<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddStudent.aspx.cs" Inherits="Ado.netAssignment.AddStudent" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div align="center">
    <table style="width: 100%;">
        <tr>
            <td colspan="3">Add Student</td>
           
        </tr>
        <tr>
            <td>Id</td>
            <td>
                <asp:TextBox ID="txtId" runat="server" placeholder="Enter Id"></asp:TextBox>
            </td>
            
        </tr>
        <tr>
            <td>Name</td>
            <td>
                <asp:TextBox ID="txtName" runat="server" placeholder="Enter Name"></asp:TextBox>
            </td>
           
        </tr>
       
        <tr>
            <td>Age</td>
            <td>
                
                <asp:TextBox ID="txtAge" runat="server" placeholder="Enter Age"></asp:TextBox>
                <asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="Age not appropriate" ControlToValidate="txtAge" MaximumValue="30" MinimumValue="16"></asp:RangeValidator>
            </td>
           
        </tr>
        <tr>
            <td>Stream</td>
            <td>
                <asp:DropDownList ID="dlStream" runat="server">
                </asp:DropDownList>
            </td>
           
        </tr>
        <tr>
            <td>State</td>
            <td>
                <asp:DropDownList ID="dlState" runat="server">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="btnAdd" runat="server" Text="Add Record" ValidationGroup="form1" OnClick="btnAdd_Click" style="margin-left: 60px" Width="95px" />
            </td>
            <td>
                
            </td>
        </tr>
    </table>
    </div>
    </form>
</body>
</html>
