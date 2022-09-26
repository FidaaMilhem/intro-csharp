<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Calc.aspx.cs" Inherits="Calc" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    
    <h1>calculus Magnificus</h1>
    <form id="form1" runat="server">
        <p>
            <asp:Button ID="BtnSqure" runat="server" Height="33px" OnClick="BtnSqure_Click" Text="Square" Width="85px" />
            <asp:TextBox ID="txtNumber" runat="server" Width="137px"></asp:TextBox>
        </p>
        <div>
            <asp:Button ID="BtnSqrt" runat="server" Height="27px" OnClick="BtnSqrt_Click" Text="Square Root" Width="83px" />
        </div>
        <p>
            <asp:Label ID="lblResult" runat="server" BorderColor="#FF0066" BorderStyle="Solid"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
    </form>
   
</body>
</html>
