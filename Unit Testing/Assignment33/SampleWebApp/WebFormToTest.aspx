<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormToTest.aspx.cs" Inherits="SampleWebApp.WebFormToTest" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        
     Enter 10th percentage : <asp:TextBox ID="txtPercentage" runat="server"></asp:TextBox><br />

        <asp:Button ID="btnSubmit" runat="server" Text="Enter" OnClick="BtnSubmit_Click" />
    </div>
    </form>
</body>
</html>
