<%@ Page Title="" Language="C#" MasterPageFile="~/AdminPage.Master" AutoEventWireup="true" CodeFile="BooksDetails.aspx.cs" Inherits="LMS.PresentationUI.BooksDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server"></asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<asp:GridView ID="gvBooks" runat="server" AutoGenerateColumns="False"
         OnRowCancelingEdit="GvBooksRowCancelingEdit"
         OnRowEditing="GvBooksRowEditing"
         OnRowUpdating="GvBooksRowUpdating"
         OnRowDeleting="GvBooksRowDeleting"        
        ShowFooter="True" OnSelectedIndexChanged="GvBooksSelectedIndexChanged" >
    <Columns>
        <asp:TemplateField HeaderText="BookID">
            <EditItemTemplate>
                    <asp:Label ID="lblBookID" runat="server" Text='<%# Eval("BookID") %>'></asp:Label>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="lblBindBookID" runat="server" Text='<%# Bind("BookID") %>'></asp:Label>
                </ItemTemplate>
                <FooterTemplate>
                    <asp:TextBox ID="txtAddBookID" runat="server" Width="100%"></asp:TextBox>
                </FooterTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Name">
            <EditItemTemplate>
                    <asp:TextBox ID="txtName" runat="server"  Width="100%" Text='<%# Eval("Name")  %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="lblBindName" runat="server" Text='<%# Bind("Name") %>'></asp:Label>
                </ItemTemplate>
                <FooterTemplate>
                    <asp:TextBox ID="txtAddName" runat="server" Width="100%"></asp:TextBox>
                </FooterTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Author">
            <EditItemTemplate>
                    <asp:TextBox ID="txtAuthor" runat="server"  Width="100%" Text='<%# Eval("Author") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="lblBindAuthor" runat="server" Text='<%# Bind("Author") %>'></asp:Label>
                </ItemTemplate>
                <FooterTemplate>
                    <asp:TextBox ID="txtAddAuthor" runat="server" Width="100%"> </asp:TextBox>
                </FooterTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Category">
            <EditItemTemplate>
                    <asp:TextBox ID="txtCategory" runat="server"  Width="100%" Text='<%# Eval("Category") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="lblBindCategory" runat="server" Text='<%# Bind("Category") %>'></asp:Label>
                </ItemTemplate>
                <FooterTemplate>
                    <asp:TextBox ID="txtAddCategory" runat="server" Width="100%"></asp:TextBox>
                </FooterTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Quantity">
            <EditItemTemplate>
                    <asp:Textbox ID="txtQuantity" runat="server"  Width="100%" Text='<%# Eval("Quantity") %>'></asp:Textbox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="lblBindQuantity" runat="server" Text='<%# Bind("Quantity") %>'></asp:Label>
                </ItemTemplate>
                <FooterTemplate>
                    <asp:TextBox ID="txtAddQuantity" runat="server" Width="100%"></asp:TextBox>
                </FooterTemplate>
        </asp:TemplateField>
        <asp:TemplateField>
                <ItemTemplate>
                    <asp:LinkButton ID="lblEdit" runat="server" CommandName="Edit">Edit</asp:LinkButton>
                    <asp:LinkButton ID="lblDelete" runat="server" CommandName="Delete">Delete</asp:LinkButton>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:LinkButton ID="lblUpdate" runat="server" CommandName="Update">Update</asp:LinkButton>
                    <asp:LinkButton ID="lblCancel" runat="server" CommandName="Cancel">Cancel</asp:LinkButton>
                </EditItemTemplate>
                <FooterTemplate>
                    <asp:Button ID="InsertData" runat="server" Text="Insert" OnClick="GvBooksSelectedIndexChanged" />
                </FooterTemplate>
            </asp:TemplateField>
    </Columns>
    </asp:GridView>
</asp:Content>

