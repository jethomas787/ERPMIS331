<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inventory.aspx.cs" Inherits="ERPProject.Inventory" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Inventory</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Inventory List</h2>
            <asp:GridView ID="GridViewInventory" runat="server" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField DataField="ERP_InventoryID" HeaderText="Inventory ID" />
                    <asp:BoundField DataField="ERP_ComponentID" HeaderText="Component ID" />
                    <asp:BoundField DataField="ERP_InventoryQty" HeaderText="Quantity" />
                    <asp:BoundField DataField="ERP_LastUpdate" HeaderText="Last Update" />
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>