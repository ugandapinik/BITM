<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BankAccountTransactionUI.aspx.cs" Inherits="CT.BankAccountTransactionWebFormApp.BankAccountTransactionUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <fieldset>
            <legend>Account Creation</legend>
            <div>
                <table>
                    <tr>
                        <td>
                            <asp:Label ID="Label2" runat="server" Text="Account Number"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="accountNumberTextBox" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label1" runat="server" Text="Customer Name"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="customerNameTextBox" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td></td>
                        <td></td>
                        <td>
                            <asp:Button ID="createButton" runat="server" Text="Create" OnClick="createButton_Click" />
                        </td>
                    </tr>
                </table>
            </div>
        </fieldset>
        <fieldset>
            <legend>Transaction</legend>
            <table>
                <tr>
                    <td>
                        <asp:Label ID="Label5" runat="server" Text="Amount"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="amountTextBox" runat="server"></asp:TextBox>
                        <asp:Label ID="messageLabel" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td></td>
                    <td>
                        <asp:Button ID="depositButton" runat="server" Text="Deposit" OnClick="depositButton_Click" />
                        <asp:Button ID="withdrawButton" runat="server" Text="Withdraw" OnClick="withdrawButton_Click" /></td>
                </tr>
                <tr>
                    <td></td>
                    <td>
                        <asp:Button ID="showReoportButton" runat="server" Text="Report" OnClick="showReoportButton_Click" /></td>
                    <td></td>
                </tr>
            </table>
            <asp:Label ID="reportLabel" runat="server"></asp:Label>
        </fieldset>
    </form>
</body>
</html>
