<%@ Page Language="C#" MasterPageFile="~/Optimus.master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="EntityFramework1.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style9 {
            color: #CC3300;
        }
    </style>
    </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">


    <div>

        <p>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <span class="auto-style9">&nbsp;Welcome,</span>
        </p>
        <p>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;Log In
        </p>
        <p style="margin-left: 280px">
            Username:&nbsp;
        <asp:TextBox ID="username" runat="server" Width="190px"></asp:TextBox>
        </p>
        <p style="margin-left: 280px">
            Password:&nbsp;&nbsp;
        <asp:TextBox ID="password" runat="server" TextMode="Password" Width="192px"></asp:TextBox>
        </p>
        <p style="margin-left: 400px">
            <asp:Button ID="Button1" runat="server" Font-Bold="True" Font-Size="Large" Text="Log In" Width="166px" OnClick="Button1_Click" />
        </p>
        <p>
            &nbsp;
        </p>

    </div>
    </asp:Content>