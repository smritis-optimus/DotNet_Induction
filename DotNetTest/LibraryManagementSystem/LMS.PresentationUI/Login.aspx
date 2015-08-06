<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="LMS.PresentationUI.Login" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:Table ID="Table1" runat="server" align="center">
        <asp:TableHeaderRow>
            <asp:TableHeaderCell ColumnSpan="2">Login</asp:TableHeaderCell>
        </asp:TableHeaderRow>
        <asp:TableRow>
            <asp:TableCell>
                Username : 
            </asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
            </asp:TableCell>
        </asp:TableRow>
         <asp:TableRow>
            <asp:TableCell>
                Password : 
            </asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="txtPassword" type="password" runat="server"></asp:TextBox>
            </asp:TableCell>
        </asp:TableRow>
         <asp:TableRow>
            <asp:TableCell>              
            </asp:TableCell>
            <asp:TableCell>
                <asp:Button ID="Button1" ID-="btnLogin" runat="server" Text="Login" OnClick="BtnLogin_Click" />
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableFooterRow>
            <asp:TableCell ColumnSpan="2">
                <a href="StudentRegistration.aspx"><asp:Label runat="server">
                    Create an account
                </asp:Label></a>
            </asp:TableCell>
        </asp:TableFooterRow>
    </asp:Table>
       
    </div>
    </form>
</body>
</html>
