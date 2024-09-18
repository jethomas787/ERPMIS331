<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="ERPMIS331.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
           
            <asp:Label ID="Label1" runat="server" Text="User Name"></asp:Label> <br />
            <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox> <br />
            <asp:Label ID="Label2" runat="server" Text="Password" ></asp:Label> <br />
            <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" ></asp:TextBox> <br />
            <asp:Button ID="Login_Btn" runat="server" OnClick="LoginBtn" Text="Login" />
        </div>
    </form>
</body>
    </html>
   
