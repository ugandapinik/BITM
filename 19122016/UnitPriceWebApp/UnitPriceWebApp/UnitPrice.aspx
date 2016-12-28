<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UnitPrice.aspx.cs" Inherits="UnitPriceWebApp.UnitPrice" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Number of items"></asp:Label>
        <asp:TextBox ID="itemNumberTextBox" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Unit price"></asp:Label>
        <asp:TextBox ID="unitPriceTextBox" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="saveButton" runat="server" OnClick="saveButton_Click" Text="Save" />
        <asp:Button ID="totalPriceButton" runat="server" OnClick="totalPriceButton_Click" Text="Show total price" />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Total Price"></asp:Label>
        <asp:Label ID="totalPriceLabel" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
