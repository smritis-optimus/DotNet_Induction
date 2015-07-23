<%@ Page Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeBehind="ViewUser.aspx.cs" Inherits="EntityFramework.ViewUser" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False"
         OnRowCancelingEdit="GridView1_RowCancelingEdit"
         OnRowEditing="GridView1_RowEditing"
         OnRowUpdating="GridView1_RowUpdating"
         OnRowDeleting="GridView1_RowDeleting"        
        ShowFooter="True" OnSelectedIndexChanged="GridView1_SelectedIndexChanged1" > <Columns>


            <asp:TemplateField HeaderText="Id" SortExpression="Id">
                <EditItemTemplate>
                    <asp:Label ID="Label1" runat="server" Text='<%# Eval("Id") %>'></asp:Label>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label1" runat="server" Text='<%# Bind("Id") %>'></asp:Label>
                </ItemTemplate>
                <FooterTemplate>
                    <asp:TextBox ID="Id" runat="server" Width="50px"></asp:TextBox>
                </FooterTemplate>
    </asp:TemplateField>

            <asp:TemplateField HeaderText="FirstName" SortExpression="FirstName">
                <EditItemTemplate>
                    <asp:TextBox ID="txt_fname" runat="server" Text='<%# Bind("FirstName") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label2" runat="server" Text='<%# Bind("FirstName") %>'></asp:Label>
                </ItemTemplate>
                <FooterTemplate>
                    <asp:TextBox ID="FirstName" runat="server" Width="150px"></asp:TextBox>
                </FooterTemplate>
            </asp:TemplateField>

            <asp:TemplateField HeaderText="LastName" SortExpression="LastName">
                <EditItemTemplate>
                    <asp:TextBox ID="txt_lname" runat="server" Text='<%# Bind("LastName") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label3" runat="server" Text='<%# Bind("LastName") %>'></asp:Label>
                </ItemTemplate>
                <FooterTemplate>
                    <asp:TextBox ID="Lastname" runat="server" Width="150px"></asp:TextBox>
                </FooterTemplate>
            </asp:TemplateField>

            <asp:TemplateField HeaderText="Role" SortExpression="Role">
                <EditItemTemplate>
                    <asp:TextBox ID="txt_role" runat="server" Text='<%# Bind("Role") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label4" runat="server" Text='<%# Bind("Role") %>'></asp:Label>
                </ItemTemplate>
                 <FooterTemplate>
                    <asp:TextBox ID="Role" runat="server" Width="100px"></asp:TextBox>
                </FooterTemplate>
            </asp:TemplateField>

            <asp:TemplateField HeaderText="Age" SortExpression="Age">
                <EditItemTemplate>
                    <asp:TextBox ID="txt_age" runat="server" Text='<%# Bind("Age") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label5" runat="server" Text='<%# Bind("Age") %>'></asp:Label>
                </ItemTemplate>
                <FooterTemplate>
                     <asp:TextBox ID="Age" runat="server" Width="50px"></asp:TextBox>
                  </FooterTemplate>
              </asp:TemplateField>

            <asp:TemplateField HeaderText="Address" SortExpression="Address">
                <EditItemTemplate>
                    <asp:TextBox ID="txt_address" runat="server" Text='<%# Bind("Address") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label6" runat="server" Text='<%# Bind("Address") %>'></asp:Label>
                </ItemTemplate>
                <FooterTemplate>
                     <asp:TextBox ID="Address" runat="server" Width="150px"></asp:TextBox>
                  </FooterTemplate>
              </asp:TemplateField>
           

            <asp:TemplateField HeaderText="Phone" SortExpression="Phone">
                <EditItemTemplate>
                    <asp:TextBox ID="txt_phone" runat="server" Text='<%# Bind("Phone") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label7" runat="server" Text='<%# Bind("Phone") %>'></asp:Label>
                </ItemTemplate>
                <FooterTemplate>
                     <asp:TextBox ID="Phone" runat="server" Width="150px"></asp:TextBox>
                  </FooterTemplate>
              </asp:TemplateField>
           

            <asp:TemplateField>
                <ItemTemplate>
                    <asp:LinkButton ID="LB1" runat="server" CommandName="Edit">Edit</asp:LinkButton>
                    <asp:LinkButton ID="LB2" runat="server" CommandName="Delete">Delete</asp:LinkButton>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:LinkButton ID="LB3" runat="server" CommandName="Update">Update</asp:LinkButton>
                    <asp:LinkButton ID="LB4" runat="server" CommandName="Cancel">Cancel</asp:LinkButton>
                </EditItemTemplate>
                <FooterTemplate>
                    <asp:Button ID="InsertData" runat="server" Text="Insert" OnClick="GridView1_SelectedIndexChanged1" />
                </FooterTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>

</asp:Content>


