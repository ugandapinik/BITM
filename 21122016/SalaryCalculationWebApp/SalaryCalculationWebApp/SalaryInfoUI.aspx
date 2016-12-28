<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SalaryInfoUI.aspx.cs" Inherits="SalaryCalculationWebApp.SalaryInfoUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="Basic Salary"></asp:Label>
                        <asp:TextBox ID="basicSalaryTextBox" runat="server"></asp:TextBox>
                        <br />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text="Conveyance"></asp:Label>
                        <asp:TextBox ID="conveyanceTextBox" runat="server"></asp:TextBox>
                        <asp:Label ID="Label4" runat="server" Text="% of Basic"></asp:Label>
                        <br />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label3" runat="server" Text="House Rent"></asp:Label>
                        <asp:TextBox ID="houseRentTextBox" runat="server"></asp:TextBox>
                        <asp:Label ID="Label5" runat="server" Text="% of Basic"></asp:Label>
                        <br />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="saveButton" runat="server" OnClick="saveButton_Click" Text="Save" />
                        <asp:Button ID="showTotalSalaryButton" runat="server" OnClick="showTotalSalaryButton_Click" Text="Show Total Salary" />
                        <br />
                    </td>
                </tr>
                <asp:Label ID="totalSalaryLabel" runat="server"></asp:Label>
            </table>

        </div>
    </form>
</body>
</html>
