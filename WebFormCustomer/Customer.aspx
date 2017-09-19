<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Customer.aspx.cs" Inherits="WebFormCustomer.Customer" %>

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
                <td>
                    <asp:Label ID="lblName" runat="server" Text="Name"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblMobileNo" runat="server" Text="Mobile Nmuber"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtMobileNo" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblCountry" runat="server" Text="Country"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlCountries" Width="200px" DataTextField="CountryName" DataValueField="CountryId" runat="server" AutoPostBack="True" onselectedindexchanged="ddlCountries_SelectedIndexChanged"></asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblState" runat="server" Text="State"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlStates" DataValueField="StateId" DataTextField="StateName" Width="200px" runat="server" AutoPostBack="True" onselectedindexchanged="ddlStates_SelectedIndexChanged"></asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblCity" runat="server" Text="City"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlCities" Width="200px" DataTextField="CityName" DataValueField="CityId" runat="server" AutoPostBack="True" onselectedindexchanged="ddlCities_SelectedIndexChanged"></asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblLocality" runat="server" Text="Locality"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlLocalities" runat="server" Width="200px" DataTextField="LocalityName" DataValueField="LocalityId"></asp:DropDownList>
                </td>
            </tr>
        </table>



    </div>
    </form>
</body>
</html>
