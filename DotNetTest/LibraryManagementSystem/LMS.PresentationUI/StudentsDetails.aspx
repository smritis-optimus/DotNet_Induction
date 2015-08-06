<%@ Page Title="" Language="C#" MasterPageFile="~/AdminPage.Master" AutoEventWireup="true" CodeFile="StudentsDetails.aspx.cs" Inherits="LMS.PresentationUI.StudentsDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server"></asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<asp:GridView ID="gvStudentDetails" runat="server" AutoGenerateColumns="False"
    OnRowCancelingEdit="GvStudentRowCancelingEdit"
         OnRowEditing="GvStudentRowEditing"
         OnRowUpdating="GvStudentRowUpdating"
         OnRowDeleting="GvStudentRowDeleting"        
        ShowFooter="True" OnSelectedIndexChanged="GvBooksSelectedIndexChanged" >
    <Columns>
        <asp:TemplateField HeaderText="Username" SortExpression="Username">
            <EditItemTemplate>
                <asp:Label ID="lblUsername" runat="server" Text='<%# Eval("Username") %>'></asp:Label>
            </EditItemTemplate>
            <ItemTemplate>
                <asp:Label ID="lblAddUserName" runat="server" Text='<%# Bind("Username") %>'></asp:Label>
            </ItemTemplate>
            <FooterTemplate>
                    <asp:TextBox ID="txtAddUserName" runat="server" Width="100%"></asp:TextBox>
                </FooterTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Password" SortExpression="Password">
            <EditItemTemplate>
                <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("Password") %>'></asp:TextBox>
            </EditItemTemplate>
            <ItemTemplate>
                <asp:Label ID="Label2" runat="server" Text='<%# Bind("Password") %>'></asp:Label>
            </ItemTemplate>
             <FooterTemplate>
                    <asp:TextBox ID="txtAddPassword" runat="server" Width="100%"></asp:TextBox>
                </FooterTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Name" SortExpression="Name">
            <EditItemTemplate>
                <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("Name") %>'></asp:TextBox>
            </EditItemTemplate>
            <ItemTemplate>
                <asp:Label ID="Label3" runat="server" Text='<%# Bind("Name") %>'></asp:Label>
            </ItemTemplate>
             <FooterTemplate>
                    <asp:TextBox ID="txtAddName" runat="server" Width="100%"></asp:TextBox>
                </FooterTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Age" SortExpression="Age">
            <EditItemTemplate>
                <asp:TextBox ID="TextBox3" runat="server" Text='<%# Bind("Age") %>'></asp:TextBox>
            </EditItemTemplate>
            <ItemTemplate>
                <asp:Label ID="Label4" runat="server" Text='<%# Bind("Age") %>'></asp:Label>
            </ItemTemplate>
         <FooterTemplate>
                    <asp:TextBox ID="txtAddAgee" runat="server" Width="100%"></asp:TextBox>
                </FooterTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Gender" SortExpression="Gender">
            <EditItemTemplate>
                <asp:TextBox ID="TextBox4" runat="server" Text='<%# Bind("Gender") %>'></asp:TextBox>
            </EditItemTemplate>
            <ItemTemplate>
                <asp:Label ID="Label5" runat="server" Text='<%# Bind("Gender") %>'></asp:Label>
            </ItemTemplate>
         <FooterTemplate>
                    <asp:TextBox ID="txtAddGender" runat="server" Width="100%"></asp:TextBox>
                </FooterTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Rollno" SortExpression="Rollno">
            <EditItemTemplate>
                <asp:TextBox ID="TextBox5" runat="server" Text='<%# Bind("Rollno") %>'></asp:TextBox>
            </EditItemTemplate>
            <ItemTemplate>
                <asp:Label ID="Label6" runat="server" Text='<%# Bind("Rollno") %>'></asp:Label>
            </ItemTemplate>
             <FooterTemplate>
                    <asp:TextBox ID="txtAddUserName" runat="server" Width="100%"></asp:TextBox>
                </FooterTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Branch" SortExpression="Branch">
            <EditItemTemplate>
                <asp:TextBox ID="TextBox6" runat="server" Text='<%# Bind("Branch") %>'></asp:TextBox>
            </EditItemTemplate>
            <ItemTemplate>
                <asp:Label ID="Label7" runat="server" Text='<%# Bind("Branch") %>'></asp:Label>
            </ItemTemplate>
             <FooterTemplate>
                    <asp:TextBox ID="txtAddUserName" runat="server" Width="100%"></asp:TextBox>
                </FooterTemplate>
        </asp:TemplateField>
         <asp:TemplateField>
                <ItemTemplate>
                    <asp:LinkButton ID="lblEdit" runat="server" CommandName="Edit">Edit</asp:LinkButton>
                    <asp:LinkButton ID="lblDelete" runat="server" CommandName="Delete">Delete</asp:LinkButton>
                </ItemTemplate>
              <FooterTemplate>
                    <asp:TextBox ID="txtAddUserName" runat="server" Width="100%"></asp:TextBox>
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
