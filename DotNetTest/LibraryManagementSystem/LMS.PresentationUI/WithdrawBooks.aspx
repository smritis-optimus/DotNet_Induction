<%@ Page Title="" Language="C#" MasterPageFile="~/AdminPage.Master" AutoEventWireup="true" CodeFile="WithdrawBooks.aspx.cs" Inherits="LMS.PresentationUI.WithdrawBooks" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server"></asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <asp:Table ID="Table1" runat="server" align="center">
        <asp:TableRow>
            <asp:TableCell>
                Select Book :
            </asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="txtBookID" runat="server"> </asp:TextBox>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                Select Student :
            </asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="txtUserName" runat="server">
                </asp:TextBox>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
            </asp:TableCell>
            <asp:TableCell>
                <asp:Button ID="btnWithDraw" OnClick="BtnWithDraw_Click" runat="server" Text="WithDraw" />
            </asp:TableCell>
        </asp:TableRow>
    </asp:Table>
</asp:Content>
