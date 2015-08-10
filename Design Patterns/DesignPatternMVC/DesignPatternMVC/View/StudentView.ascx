<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="StudentView.ascx.cs" Inherits="DesignPatternMVC.View.StudentView" %>
<div style="height: 30px; background-color: rgb(0, 148, 255); color: white; margin-bottom: 10px;">
    <asp:label style="display: block;" 
      text="Student Details" runat="server" id="lblHeading" />
</div>
<table>
    <tr>
        <td>
            <span>Name :</span>
        </td>
        <td>
            <asp:label runat="server" id="lblName" />
        </td>
    </tr>
       <tr>
        <td>
            <span>Rollno :</span>
        </td>
        <td>
            <asp:label runat="server" id="lblRollno" />
        </td>
    </tr>
       <tr>
        <td>
            <span>Age :</span>
        </td>
        <td>
            <asp:label runat="server" id="lblAge" />
        </td>
    </tr>
       <tr>
        <td>
            <span>Branch :</span>
        </td>
       
        <td>
            <asp:label runat="server" id="lblBranch" />
        </td>
    </tr>
    <tr>
             <td>
            <asp:button onclick="btnDelete_Click" 
              text="Delete" runat="server" id="btnDelete">
        </asp:button>
        </td>
    </tr>
</table>
<table style="padding: 10px 0px; float: left; width: 365px;">
    <tbody><tr>
        <td style="font-weight: bold;">Name : </td>
        <td><asp:textbox runat="server" id="txtName" /></td>
    </tr>
    <tr>
        <td style="font-weight: bold;">Rollno : </td>
        <td><asp:textbox runat="server" id="txtRollno" /></td>
    </tr>
    <tr>
        <td style="font-weight: bold;">Age : </td>
        <td><asp:textbox runat="server" id="txtAge" /></td>
    </tr>
           <tr>
        <td style="font-weight: bold;">Branch : </td>
        <td><asp:textbox runat="server" id="txtBranch" /></td>
    </tr>
    <tr>
             <td>
                 <asp:button onclick="btnAdd_Click" 
              text="Add" runat="server" id="btnAdd">
        </asp:button>
             </td>
        <td>
            <asp:button onclick="btnUpdate_Click" 
              text="Update" runat="server" id="btnUpdate">
        </asp:button>

        </td>
   
       
    </tr>
</tbody>
</table>