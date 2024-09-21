<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="ERPMIS331.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
     <style>
        body {
            font-family: Arial, sans-serif;
            background-color: #f4f4f4;
            display: flex;
            justify-content: center;
            align-items: center;
            height: 100vh;
            margin: 0;
        }
        .login-container {
            background-color: #fff;
            padding: 20px;
            border-radius: 5px;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
            width: 300px;
        }
        h2 {
            text-align: center;
            margin-bottom: 20px;
        }
        input[type="text"], input[type="password"] {
            width: calc(100% - 20px);
            padding: 10px;
            margin: 5px 0 15px;
            border: 1px solid #ccc;
            border-radius: 4px;
            display: block;
            box-sizing: border-box;
        }
        input[type="button"], input[type="submit"] {
            background-color: #5cb85c;
            color: white;
            padding: 10px;
            border: none;
            border-radius: 4px;
            cursor: pointer;
            width: 100%;
        }
        input[type="button"]:hover, input[type="submit"]:hover {
            background-color: #4cae4c;
        }
        .error-message {
            color: red;
            text-align: center;
            visibility: hidden; /* Initially hidden */
        }
    </style>
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
   
