<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/StudentPage.Master" CodeBehind="ViewBooks.aspx.cs" Inherits="LMS.PresentationUI.ViewBooks" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server"></asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:GridView ID="gvBooks" runat="server"></asp:GridView>
</asp:Content>