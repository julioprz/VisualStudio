<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="TestOGrande.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="Button1" runat="server" Text="Button1" OnClick="Button1_Click" /><asp:Button ID="Button2" runat="server" Text="Button2" OnClick="Button2_Click" />
       <br />
        <asp:Label ID="LblSort" runat="server" Text=""></asp:Label>
        <asp:Label ID="LblResult" runat="server" Text=""></asp:Label>
    </div>
    </form>
</body>
</html>
