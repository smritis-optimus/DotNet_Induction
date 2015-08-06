<%@ Page Title="" Language="C#" MasterPageFile="~/AdminPage.Master" AutoEventWireup="true" CodeFile="IssueBooks.aspx.cs" Inherits="LMS.PresentationUI.IssueBooks" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server"></asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <asp:Table runat="server" align="center">
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
                <asp:Button ID="btnIssue" OnClick="BtnIssue_Click" runat="server" Text="Issue" />
            </asp:TableCell>
        </asp:TableRow>
    </asp:Table>
</asp:Content>
