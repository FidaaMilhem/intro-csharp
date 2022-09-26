<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Calc.aspx.cs" Inherits="Calc" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <h1>Calculator</h1>
    <form id="form1" runat="server">
    <p>
        <asp:TextBox ID="txtNumber1" runat="server" Height="19px" Width="61px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtNumber2" runat="server" Height="19px" Width="61px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblResult" runat="server" BackColor="#99CCFF" BorderColor="#FFFFCC" EnableTheming="True" Height="30px" Width="163px"></asp:Label>
        </p>
        <div>
            <asp:Button ID="btnAdd" runat="server" Height="25px" Text="+" Width="47px" OnClick="btnAdd_Click" />
        </div>
        <p>
            <asp:Button ID="btnSub" runat="server" Height="25px" Text="-" Width="47px" OnClick="btnSub_Click" />
        </p>
        <p>
            <asp:Button ID="btnMul" runat="server" Height="27px" Text="*" Width="47px" OnClick="btnMul_Click" />
        </p>
        <p>
            <asp:Button ID="btnDiv" runat="server" Height="27px" Text="/" Width="47px" OnClick="btnDiv_Click" />
        </p>
        <p>
            <asp:Button ID="btnPow" runat="server" Height="27px" Text="^" Width="47px" OnClick="btnPow_Click" />
        </p>
        <p>
            <asp:Button ID="btnModule" runat="server" Height="27px" Text="%" Width="47px" OnClick="btnModule_Click" />
        </p>
        <p>
            <asp:Button ID="btnRoot" runat="server" OnClick="btnRoot_Click" Text="√" Width="44px" />
        </p>
    </form>
</body>
</html>
