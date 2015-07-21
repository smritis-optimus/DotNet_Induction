<%@ Page Title="" Language="C#" MasterPageFile="~/Optimus.master" AutoEventWireup="true" CodeFile="ViewSiteMap.aspx.cs" Inherits="ViewSiteMap" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server"> 
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     
      <asp:SiteMapDataSource ID="SiteMapDataSource1" Runat="server" />
    <asp:TreeView ID="TreeView1" Runat="Server" DataSourceID="SiteMapDataSource1">
  </asp:TreeView>
</asp:Content>

