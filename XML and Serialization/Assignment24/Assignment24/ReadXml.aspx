<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ReadXml.aspx.cs" Inherits="Assignment24.ReadXml" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div align="centre">

            <a href="ViewXml.aspx">Go to xml page</a>
            <br />

            <br />
        </div>
        <div>
            <table align="center">
                <tr>
                    <td>
                        <asp:Button ID="btnAddNode" runat="server" Text="Add Node" OnClick="btnAddNode_Click" />
                    </td>

                    <td></td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="btnFirstChild" runat="server" Text="First Child" OnClick="btnFirstChild_Click" />
                    </td>

                    <td>
                        <asp:TextBox ID="txtFirstChild" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="btnInsertBefore" runat="server" Text="Insert Before" OnClick="btnInsertBefore_Click" />
                    </td>

                    <td></td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="btnRemoveNode" runat="server" Text="Remove Node" OnClick="btnRemoveNode_Click" />

                    </td>

                    <td></td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="btnChildNode" runat="server" Text="Child Node" OnClick="btnChildNode_Click" />
                    </td>

                    <td><asp:TextBox ID="txtChildNodes" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="btnTotalNode" runat="server" Text="Total Nodes" OnClick="btnTotalNode_Click" />
                    </td>

                    <td>
                        <asp:TextBox ID="txtCountNodes" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="btnReplaceChild" runat="server" Text="Replace Child" OnClick="btnReplaceChild_Click" />
                    </td>

                    <td></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
