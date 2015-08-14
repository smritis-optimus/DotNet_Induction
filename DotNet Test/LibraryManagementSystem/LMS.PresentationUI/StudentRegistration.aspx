<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentRegistration.aspx.cs" Inherits="LMS.PresentationUI.StudentRegistration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:Table runat="server" align="center">
        <asp:TableFooterRow>
            <asp:TableHeaderCell ColumnSpan="2">
                Create an account
            </asp:TableHeaderCell>
        </asp:TableFooterRow>
        <asp:TableRow>
            <asp:TableCell>
                Enter your Name : 
            </asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                Enter Age : 
            </asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="txtAge" runat="server"></asp:TextBox>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                Enter Gender : 
            </asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="txtGender" runat="server"></asp:TextBox>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                Enter RollNo : 
            </asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="txtRollNo" runat="server"></asp:TextBox>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                Enter Branch : 
            </asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="txtBranch" runat="server"></asp:TextBox>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                Enter Username : 
            </asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                Enter Password : 
            </asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="txtPassword" type="password" runat="server"></asp:TextBox>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>

            </asp:TableCell>
            <asp:TableCell>
                <asp:Button ID="btnCreate" Text="Create Account" runat="server" OnClick="BtnCreate_Click" />
            </asp:TableCell>
        </asp:TableRow>
    </asp:Table>
    </div>
    </form>
</body>
</html>
