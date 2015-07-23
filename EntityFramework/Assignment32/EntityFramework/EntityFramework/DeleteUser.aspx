<%@ Page Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeBehind="DeleteUser.aspx.cs" Inherits="EntityFramework.DeleteUser" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div style="font-family: Arial" style="margin-left: 280px" >
        <asp:Table runat="server">
            <asp:TableRow>
                <asp:TableCell>
      Enter id: 
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="Id" runat="server" BorderColor="Black" BorderStyle="Solid" Height="30px" Width="180px" placeholder="Enter Id"></asp:TextBox><br />
                    <br />
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell>
                    <asp:Button ID="Delete" runat="server" Text="Delete" OnClick="DeletUser_Click" Height="25px" Width="120px" />
                </asp:TableCell>
            </asp:TableRow>
        </asp:Table>
    </div>

</asp:Content>
