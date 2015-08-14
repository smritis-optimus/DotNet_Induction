<%@ Page Title="" Language="C#" MasterPageFile="~/AdminPage.Master" AutoEventWireup="true" CodeFile="IssueHistoryOfAllStudents.aspx.cs" Inherits="LMS.PresentationUI.IssueHistoryOfAllStudents" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server"></asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <asp:GridView ID="gvStudentDetails" runat="server" AutoGenerateColumns="False">
        <Columns>
            <asp:TemplateField HeaderText="Username" SortExpression="Username">
                <ItemTemplate>
                    <asp:Label ID="lblAddUserName" runat="server" Text='<%# Bind("Username") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Password" SortExpression="Password">
                <ItemTemplate>
                    <asp:Label ID="lblPassword" runat="server" Text='<%# Bind("Password") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Name" SortExpression="Name">
                <ItemTemplate>
                    <asp:Label ID="lblName" runat="server" Text='<%# Bind("Name") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Age" SortExpression="Age">
                <ItemTemplate>
                    <asp:Label ID="lblAge" runat="server" Text='<%# Bind("Age") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Gender" SortExpression="Gender">
                <ItemTemplate>
                    <asp:Label ID="lblGender" runat="server" Text='<%# Bind("Gender") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Rollno" SortExpression="Rollno">
                <ItemTemplate>
                    <asp:Label ID="lblRollno" runat="server" Text='<%# Bind("Rollno") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Branch" SortExpression="Branch">
                <ItemTemplate>
                    <asp:Label ID="lblBranch" runat="server" Text='<%# Bind("Branch") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="IssueDetails" SortExpression="IssueDetails">
                <ItemTemplate>
                    <asp:GridView ID="gvIssueDetails" runat="server" AutoGenerateColumns="False" DataSource='<%# Bind("IssueDetails") %>'>
                        <Columns>
                            <asp:TemplateField HeaderText="IssueID" SortExpression="IssueID">
                                <ItemTemplate>
                                    <asp:Label ID="lblIssueID" runat="server" Text='<%# Bind("IssueID") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="BookID" SortExpression="BookID">
                                <ItemTemplate>
                                    <asp:Label ID="lblBookID" runat="server" Text='<%# Bind("BookID") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="IssueDate" SortExpression="IssueDate">
                                <ItemTemplate>
                                    <asp:Label ID="lblIssueDate" runat="server" Text='<%# Bind("IssueDate") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="WithdrawDate" SortExpression="WithdrawDate">
                                <ItemTemplate>
                                    <asp:Label ID="lblWithdrawDate" runat="server" Text='<%# Bind("WithdrawDate") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
</asp:Content>
