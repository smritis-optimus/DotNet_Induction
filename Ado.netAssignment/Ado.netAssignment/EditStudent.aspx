<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EditStudent.aspx.cs" Inherits="Ado.netAssignment.EditStudent" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
  
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
     <table align="center">
        <tr>
            <td align="center"> Edit Student</td>
            <td> </td>
        </tr>
        <tr>
        
            <td>
                <asp:TextBox ID="txtId" runat="server" placeholder="Enter Id"></asp:TextBox>

            </td>
            <td>

                <asp:Button ID="btnSearch" runat="server" Text="Search" OnClick="btnSearch_Click" />
            </td>
          
        </tr>
        <tr>
         
         
                        <td >Name</td>
                        <td >
                            <asp:TextBox ID="txtName" runat="server" Enabled="False"></asp:TextBox>
                        </td>
                      
                    </tr>
                    <tr>
                        <td>Age</td>
                        <td>
                            <asp:TextBox ID="txtAge" runat="server" Enabled="False"></asp:TextBox>
                        </td>
                        
                    </tr>
                   
                    <tr>
                        <td>Stream</td>
                        <td>
                            <asp:DropDownList ID="dlStream" runat="server" Enabled="False">
                            </asp:DropDownList>
                        </td>
                      
                    </tr>
                     <tr>
                        <td>State</td>
                        <td>
                            <asp:DropDownList ID="dlState" runat="server" Enabled="False">
                            </asp:DropDownList>
                        </td>
                       >
                    </tr>
                    <tr>
                        <td>
                            <asp:Button ID="btnUpdate" runat="server" Enabled="False" Text="Update" ValidationGroup="form1" OnClick="btnUpdate_Click" />
                        </td>
                        <td>
                            
                        </td>
                        <td>&nbsp;</td>
                    </tr>
            
        
    </table>
    </div>
    </form>
</body>
</html>
