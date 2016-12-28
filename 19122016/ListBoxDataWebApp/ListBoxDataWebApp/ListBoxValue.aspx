<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListBoxValue.aspx.cs" Inherits="ListBoxDataWebApp.ListBoxValue" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" Text="Input Last Value"></asp:Label>
        <asp:TextBox ID="inputValueTextBox" runat="server"></asp:TextBox>
    <div>
    
        <asp:Button ID="showButton" runat="server" OnClick="showButton_Click" Text="Show In ListBox" />
        <br />
        <asp:ListBox ID="valueListBox" runat="server" Height="188px" Width="101px"></asp:ListBox>
    
    </div>
    </form>
</body>
</html>
