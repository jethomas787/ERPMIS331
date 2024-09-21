<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OrderProduct.aspx.cs" Inherits="ERPProject.OrderProduct" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Purchase Order</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            background-color: #f4f4f4;
        }
        .container {
            background: white;
            padding: 20px;
            border-radius: 8px;
            box-shadow: 0 2px 10px rgba(0, 0, 0, 0.1);
            max-width: 600px;
            margin: auto;
        }
        h2 {
            text-align: center;
        }
        .button {
            background-color: #007BFF;
            color: white;
            border: none;
            border-radius: 5px;
            padding: 10px 15px;
            cursor: pointer;
            transition: background-color 0.3s;
        }
        .button:hover {
            background-color: #0056b3;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h2>Create Purchase Order</h2>
            <div>
                <asp:DropDownList ID="DropDownComponents" runat="server"></asp:DropDownList>
                <asp:TextBox ID="TextBoxQuantity" runat="server" Placeholder="Quantity"></asp:TextBox>
                <asp:Label ID="LabelError" runat="server" ForeColor="Red"></asp:Label>
                <br />
                <asp:Button ID="ButtonSubmitOrder" runat="server" Text="Submit Order" OnClick="ButtonSubmitOrder_Click" CssClass="button" />
            </div>
            <div>
                <h4>Total Cost: $<asp:Label ID="LabelTotalCost" runat="server" Text="0.00"></asp:Label></h4>
            </div>
        </div>
    </form>
</body>
</html>