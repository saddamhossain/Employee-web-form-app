<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Employee.aspx.cs" Inherits="EmployeeWebApp.Employee" %>

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
    
    </div>
        <div>
            
            <asp:Label ID="Label2" runat="server" Text="Email"></asp:Label>
            <asp:TextBox ID="emailTextBox" runat="server"></asp:TextBox>
            
            </div>
        <div>
            <asp:Label ID="Label3" runat="server" Text="Address"></asp:Label>
            <asp:TextBox ID="addressTextBox" runat="server"></asp:TextBox>
            </div>
        <div>
            <asp:Button ID="saveButton" runat="server" OnClick="saveButton_Click" Text="Save" />
            <asp:Button ID="retriveButton" runat="server" OnClick="retriveButton_Click" Text="Retrive" />
            </div>
    </form>
</body>
</html>
