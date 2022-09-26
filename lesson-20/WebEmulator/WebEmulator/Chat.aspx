<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Chat.aspx.cs" Inherits="Chat" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="lstChat" runat="server" Height="260px" Width="1009px"></asp:ListBox>
        </div>
        <p>
            <asp:TextBox ID="txtChat" runat="server" Height="55px" Width="568px"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" Height="36px" Text="SEND" Width="100px" OnClick="Button1_Click" />
        </p>
        <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            &nbsp;&nbsp;
        </p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
