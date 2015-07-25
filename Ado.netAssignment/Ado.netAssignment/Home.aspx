<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Ado.netAssignment.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table align="center" border="1" style="font-family: 'Comic Sans MS'; font-size: medium; font-style: normal; color: #000080">
            <tr>
                <td>
                <a href="AddStudent.aspx"> <asp:Label ID="lblAdd" runat="server" Text="Add Students"></asp:Label></a>
                </td>
            </tr>
            <tr>
                <td>
                       <a href="All Students.aspx"><asp:Label ID="lblAll" runat="server" Text="All Students"></asp:Label></a>  
                </td>
            </tr>
            <tr>
                <td>
                    <a href="EditStudent.aspx"><asp:Label ID="lblEdit" runat="server" Text="Edit Students"></asp:Label></a> 
        
                </td>
            </tr>
            <tr>
                <td>
                   <a href="ShowAllStudens.aspx">  <asp:Label ID="lblShow" runat="server" Text="Show all Students"></asp:Label></a>
        
                </td>
            </tr>
           <tr>
                <td>
                   <a href="DeleteStudents.aspx">  <asp:Label ID="lblDelete" runat="server" Text="Delete Students"></asp:Label></a>
        
                </td>
            </tr>
        </table>
       
    
    </div>
    </form>
</body>
</html>
