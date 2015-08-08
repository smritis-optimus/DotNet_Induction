<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/StudentPage.Master" CodeBehind="IssueHistory.aspx.cs" Inherits="LMS.PresentationUI.IssueHistory" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server"></asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <asp:GridView ID="gvHistory" runat="server"></asp:GridView>
</asp:Content>