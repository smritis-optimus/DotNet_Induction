 <%@Page Title="" Language="C#" MasterPageFile="~/AdminPage.Master" AutoEventWireup="true" CodeFile="IssueHistoryOfAllStudentsType1.aspx.cs" Inherits="LMS.PresentationUI.IssueHistoryOfAllStudentsType1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server"></asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
        <asp:GridView ID="GridView2" runat="server" style="float:left"></asp:GridView>
        <asp:GridView ID="GridView1" runat="server" style="float:left" AutoGenerateColumns="false">
              <Columns>
                            <asp:TemplateField HeaderText="IssueID" SortExpression="BookID">
                                <ItemTemplate>
                                    <asp:Label ID="lblBookID" runat="server" Text='<%# Bind("BookID") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Name" SortExpression="Name">
                                <ItemTemplate>
                                    <asp:Label ID="lblName" runat="server" Text='<%# Bind("Name") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Author" SortExpression="Author">
                                <ItemTemplate>
                                    <asp:Label ID="lblAuthor" runat="server" Text='<%# Bind("Author") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                  </Columns>
        </asp:GridView>
</asp:Content>