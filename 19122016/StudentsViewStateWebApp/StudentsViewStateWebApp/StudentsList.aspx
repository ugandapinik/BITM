<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentsList.aspx.cs" Inherits="StudentsViewStateWebApp.StudentsList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
        <asp:TextBox ID="nameTextBox" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="saveButton" runat="server" OnClick="saveButton_Click" Text="Save" />
        <asp:Button ID="showAllButton" runat="server" OnClick="showAllButton_Click" Text="Show All" />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Total Student"></asp:Label>
        <asp:Label ID="totalStudentLabel" runat="server" Text="Label"></asp:Label>
        <br />
        <asp:ListBox ID="allStudentsListBox" runat="server" Height="212px" Width="185px"></asp:ListBox>
    
    </div>
    </form>
</body>
</html>
