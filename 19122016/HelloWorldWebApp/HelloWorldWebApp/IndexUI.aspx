<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="IndexUI.aspx.cs" Inherits="HelloWorldWebApp.IndexUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
            <asp:TextBox ID="nameTextBox" runat="server" Width="190px"></asp:TextBox>
            </br>
            <asp:Button ID="showButton" runat="server" OnClick="showButton_Click" Text="Show" />


            <br />
            <asp:Label ID="nameLabel" runat="server"></asp:Label>


            <br />


        </div>
    </form>
</body>
</html>
