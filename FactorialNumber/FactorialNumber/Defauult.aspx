<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Defauult.aspx.cs" Inherits="FactorialNumber.Defauult" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="TxtBxNum" runat="server"></asp:TextBox>
        <asp:Button ID="BttnGetFact" runat="server" Text="Get Factorial" OnClick="BttnGetFact_Click" />
        <asp:Label ID="LblFact" runat="server" Text=""></asp:Label>
    </div>
        <div>
        <asp:TextBox ID="TxtBxNumFibb" runat="server"></asp:TextBox>
        <asp:Button ID="BttnFibonacci" runat="server" Text="Get Fibonacci" OnClick="BttnFibonacci_Click" />
        <asp:Label ID="LblNumFibonnaci" runat="server" Text=""></asp:Label>
    </div>
    </form>
</body>
</html>
