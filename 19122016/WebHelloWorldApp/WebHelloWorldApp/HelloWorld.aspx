﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HelloWorld.aspx.cs" Inherits="WebHelloWorldApp.HelloWorld" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Enter Name"></asp:Label>
        <asp:TextBox ID="nameTextBox" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="saveButton" runat="server" OnClick="saveButton_Click" Text="Save" />
        <asp:Button ID="showButton" runat="server" OnClick="showButton_Click" Text="Show" />
        <br />
        <asp:Label ID="showNameLabel" runat="server" Text="[displayNameLabel]"></asp:Label>
    
    </div>
    </form>
</body>
</html>
