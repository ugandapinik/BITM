<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="indeUI.aspx.cs" Inherits="SimpleShowButton.indeUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>First Form</title>
    
</head>
<body>
    <form id="form1" runat="server">
        <div>
            
            <asp:label runat="server" text="Welcome To first Coding Class" Font-Bold="True" Font-Size="25px"></asp:label><br/>
            <br/>
            <!-- first Name -->
            <asp:label runat="server" text="First Name"></asp:label>
            <asp:TextBox ID="firstname" runat="server"></asp:TextBox><br/>
            
            <!-- last Name -->
            <asp:label runat="server" text="Last Name"></asp:label>
            <asp:TextBox ID="lastname" runat="server"></asp:TextBox><br/>
            
            <asp:button runat="server" text="Show" ID="show" OnClick="show_Click"/>
            <br/>
            
            <!-- display Name -->
            <asp:label ID="display_result" runat="server" text=""></asp:label>
        </div>
    </form>
</body>
</html>
