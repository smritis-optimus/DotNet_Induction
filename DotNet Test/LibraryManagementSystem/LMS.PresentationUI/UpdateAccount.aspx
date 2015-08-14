<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/StudentPage.Master" CodeBehind="UpdateAccount.aspx.cs" Inherits="LMS.PresentationUI.UpdateAccount" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server"></asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Table ID="Table1" runat="server" align="center">
        <asp:TableFooterRow>
            <asp:TableHeaderCell ColumnSpan="2">
               Update your account
            </asp:TableHeaderCell>
        </asp:TableFooterRow>
        <asp:TableRow>
            <asp:TableCell>
                 Name : 
            </asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                 Age : 
            </asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="txtAge" runat="server"></asp:TextBox>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
              Gender : 
            </asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="txtGender" runat="server"></asp:TextBox>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
           RollNo : 
            </asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="txtRollNo" runat="server"></asp:TextBox>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
               Branch : 
            </asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="txtBranch" runat="server"></asp:TextBox>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                Enter Password : 
            </asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>

            </asp:TableCell>
            <asp:TableCell>
                <asp:Button ID="btnUpdate" Text="Update Account" runat="server" OnClick="BtnUpdate_Click" />
            </asp:TableCell>
        </asp:TableRow>
    </asp:Table>
</asp:Content>