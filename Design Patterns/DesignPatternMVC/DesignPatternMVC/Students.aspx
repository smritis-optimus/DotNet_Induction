<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Students.aspx.cs" Inherits="DesignPatternMVC.Students" %>
<%@ Register Src="~/View/StudentView.ascx" TagPrefix="uc3" TagName="Student" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <style type="text/css">
        body {
            font-family:Verdana;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div style="border:1px solid; width:500px; height:500px; margin:auto auto;">
        <uc3:Student runat="server" id="Student" />
    </div>
    </form>
</body>
</html>
