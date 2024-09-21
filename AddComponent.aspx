<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddComponent.aspx.cs" Inherits="ERPProject.AddComponent" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Add Component</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Add New ERP Component</h2>
            <asp:Label ID="LabelMessage" runat="server" ForeColor="Green" Visible="false"></asp:Label>
            <div>
                <label>Component Name:</label>
                <asp:TextBox ID="TextBoxName" runat="server"></asp:TextBox>
            </div>
            <div>
                <label>CPU:</label>
                <asp:TextBox ID="TextBoxCPU" runat="server"></asp:TextBox>
            </div>
            <div>
                <label>Quantity:</label>
                <asp:TextBox ID="TextBoxQty" runat="server"></asp:TextBox>
            </div>
            <div>
                <label>Reorder Level:</label>
                <asp:TextBox ID="TextBoxReorderLevel" runat="server"></asp:TextBox>
            </div>
            <div>
                <label>Supplier ID:</label>
                <asp:TextBox ID="TextBoxSupplierID" runat="server"></asp:TextBox>
            </div>
            <div>
                <asp:Button ID="ButtonAdd" runat="server" Text="Add Component" OnClick="ButtonAdd_Click" />
            </div>
        </div>
    </form>
</body>
</html>
