<%@ Page Language="C#" MasterPageFile="~/NormalUser.master" AutoEventWireup="true" CodeBehind="Upload.aspx.cs" Inherits="EntityFramework1.Upload" %>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <div>
        <asp:FileUpload ID="FileUpload1" runat="server" />
   
     <br />
        <asp:Button ID="UploadFile" runat="server" OnClick="Upload_Click" 
         Text="Upload File" />&nbsp;<br />
        <br />
        <asp:Label ID="UploadLabel" runat="server"></asp:Label></div>
    

</asp:Content>
  
