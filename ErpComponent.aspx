<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ErpComponent.aspx.cs" Inherits="ERPProject.ErpComponent" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>ERP Components</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            background-color: #f4f4f4;
            margin: 0;
            padding: 20px;
        }
        .container {
            background-color: #fff;
            padding: 20px;
            border-radius: 5px;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
            max-width: 800px;
            margin: auto;
        }
        h2, h3 {
            text-align: center;
            color: #333;
        }
        .form-group {
            margin: 15px 0;
        }
        label {
            display: block;
            margin-bottom: 5px;
            color: #555;
        }
        input[type="text"] {
            width: calc(100% - 20px);
            padding: 10px;
            border: 1px solid #ccc;
            border-radius: 4px;
            box-sizing: border-box;
        }
        .button-container {
            text-align: center;
        }
        .add-button {
            background-color: #5cb85c;
            color: white;
            padding: 10px 20px;
            border: none;
            border-radius: 4px;
            cursor: pointer;
        }
        .add-button:hover {
            background-color: #4cae4c;
        }
        .error-message {
            color: red;
            text-align: center;
        }
        .grid-view {
            margin-top: 20px;
            width: 100%;
            border-collapse: collapse;
        }
        .grid-view th, .grid-view td {
            border: 1px solid #ddd;
            padding: 8px;
        }
        .grid-view th {
            background-color: #f2f2f2;
        }
        .total-quantity {
            text-align: center;
            font-weight: bold;
            margin-top: 20px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h2>ERP Component List</h2>

            <h3>Add New Component</h3>
            <div class="form-group">
                <label for="TextBoxComponentName">Component Name:</label>
                <asp:TextBox ID="TextBoxComponentName" runat="server"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="TextBoxCPU">CPU:</label>
                <asp:TextBox ID="TextBoxCPU" runat="server"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="TextBoxQty">Quantity:</label>
                <asp:TextBox ID="TextBoxQty" runat="server"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="TextBoxReorderLevel">Reorder Level:</label>
                <asp:TextBox ID="TextBoxReorderLevel" runat="server"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="TextBoxSupplierID">Supplier ID:</label>
                <asp:TextBox ID="TextBoxSupplierID" runat="server"></asp:TextBox>
            </div>
            <div class="button-container">
                <asp:Button ID="ButtonAddComponent" runat="server" Text="Add Component" CssClass="add-button" OnClick="ButtonAddComponent_Click" />
                <asp:Label ID="LabelAddMessage" runat="server" ForeColor="Green" Visible="false"></asp:Label>
            </div>

            <h3>Current Components</h3>
            <asp:GridView ID="GridViewComponents" runat="server" AutoGenerateColumns="False" CssClass="grid-view">
                <Columns>
                    <asp:BoundField DataField="ERP_ComponentID" HeaderText="Component ID" />
                    <asp:BoundField DataField="ERP_ComponentName" HeaderText="Component Name" />
                    <asp:BoundField DataField="ERP_ComponentCPU" HeaderText="CPU" />
                    <asp:BoundField DataField="ERP_ComponentQty" HeaderText="Quantity" />
                    <asp:BoundField DataField="ERP_ComponentReorderLvl" HeaderText="Reorder Level" />
                    <asp:BoundField DataField="ERP_SupplierID" HeaderText="Supplier ID" />
                </Columns>
            </asp:GridView>

            <asp:Label ID="LabelError" runat="server" CssClass="error-message" Visible="false"></asp:Label>

            <h3 class="total-quantity">Total Quantity: <asp:Label ID="LabelTotalQty" runat="server" Text="0"></asp:Label></h3>
        </div>
    </form>
</body>
</html>