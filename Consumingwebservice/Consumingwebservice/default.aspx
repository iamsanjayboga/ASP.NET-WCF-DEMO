<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="Consumingwebservice._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="Calculate" OnClick="GreetingBtn_Click"></asp:Button>
        <asp:Label ID="Label1" runat="server" Text="label"></asp:Label>
    </form>
</body>
</html>
