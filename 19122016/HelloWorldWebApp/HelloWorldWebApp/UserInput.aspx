<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserInput.aspx.cs" Inherits="HelloWorldWebApp.UserInput" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="Input Last Value"></asp:Label>
        <asp:TextBox ID="lastValueTextBox" runat="server"></asp:TextBox>
        <br/>
        <asp:Button ID="showButton" runat="server" Text="Show Result" OnClick="showButton_Click" />
    
    </div>
    </form>
</body>
</html>
