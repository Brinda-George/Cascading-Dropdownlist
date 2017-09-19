<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="LoginUser.ascx.cs" Inherits="WebFormCustomer.LoginUser" %>
<div>
        <table style="width: 100%;">
            <tr>
                <td>User Name:</td>
                <td>
                    <asp:TextBox ID="txtName" runat="server"></asp:TextBox>

                </td>
            </tr>
            <tr>
                <td>Password:</td>
                <td>
                    <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td></td>
                <td>
                    <asp:Button ID="Submit" runat="server" Text="Submit" OnClick="Submit_Click" />

                </td>
            </tr>
        </table>
    </div>