<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PersonalInfoUI.aspx.cs" Inherits="PersonalInfoWebApp.PersonalInfoUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="First Name"></asp:Label>
        <asp:TextBox ID="firstNameTextBox" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Last Name"></asp:Label>
        <asp:TextBox ID="lastNameTextBox" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Father's Name"></asp:Label>
        <asp:TextBox ID="fatherNameTextBox" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label4" runat="server" Text="Mother's Name"></asp:Label>
        <asp:TextBox ID="motherNameTextBox" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label5" runat="server" Text="Address"></asp:Label>
        <asp:TextBox ID="addressTextBox" runat="server" Height="40px" TextMode="MultiLine"></asp:TextBox>
        <br />
        <asp:Button ID="saveButton" runat="server" OnClick="saveButton_Click" Text="Save" />
&nbsp;<asp:Button ID="showAllButton" runat="server" OnClick="showAllButton_Click" Text="Show All Information" />
        <br />
        <asp:Button ID="nameButton" runat="server" OnClick="nameButton_Click" Text="Name" />
        <asp:Button ID="parentsButton" runat="server" OnClick="parentsButton_Click" Text="Parent's Name" />
        <asp:Button ID="addressButton" runat="server" OnClick="addressButton_Click" Text="Address" />
    
    </div>
    </form>
</body>
</html>
