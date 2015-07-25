<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="All Students.aspx.cs" Inherits="Ado.netAssignment.All_Students" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table style="width: 100%;">
        <tr>
            <td style="width: 80%;text-align:center">
                <h2>All Students</h2>
            </td>
           
        </tr>
        <tr>
            
            <td align="center">
                <asp:DropDownList ID="dlStream" runat="server" AutoPostBack="True" OnSelectedIndexChanged="dlStream_SelectedIndexChanged"></asp:DropDownList>
            </td>
          
        </tr>
        <tr>
          
            <td align="center">
                <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" AllowSorting="True" onSorting="GridView1_Sorting">
                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                    <EditRowStyle BackColor="#999999" />
                    <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                    <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                    <SortedAscendingCellStyle BackColor="#E9E7E2" />
                    <SortedAscendingHeaderStyle BackColor="#506C8C" />
                    <SortedDescendingCellStyle BackColor="#FFFDF8" />
                    <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
                </asp:GridView>
                <br />
            </td>
          
        </tr>
    </table>
    </div>
    </form>
</body>
</html>
