<%@ Page Language="C#" MasterPageFile="~/Optimus.master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="EntityFramework.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css">
        .auto-style9 {
            color: #CC3300;
            padding-left:170px;
        }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <div>

        <p>
     <span class="auto-style9">&nbsp;Welcome,</span>
        </p>

        <asp:Table runat="server" Style="margin-left: 280px">
            <asp:TableRow runat="server">
                <asp:TableCell></asp:TableCell>
                <asp:TableHeaderCell>Log In</asp:TableHeaderCell>

            </asp:TableRow>

            <asp:TableRow>
                <asp:TableCell>Username: </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="username" runat="server" Width="190px"></asp:TextBox></asp:TableCell>
            </asp:TableRow>

            <asp:TableRow>
                <asp:TableCell>Password: </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="password" runat="server" TextMode="Password" Width="192px"></asp:TextBox></asp:TableCell>

            </asp:TableRow>

            <asp:TableRow>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell>
                    <asp:Button ID="Button1" runat="server" Font-Bold="True" Font-Size="Large" Text="Log In" Width="166px" OnClick="Button1_Click" />

                </asp:TableCell>
            </asp:TableRow>
        </asp:Table>


    </div>

</asp:Content>
