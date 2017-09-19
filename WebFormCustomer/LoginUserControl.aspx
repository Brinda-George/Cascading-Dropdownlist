<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginUserControl.aspx.cs" Inherits="WebFormCustomer.LoginUserControl" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
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
    </form>
</body>
</html>
