<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Products.aspx.cs" Inherits="ERPProject.Products" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Products</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Product List</h2>
            <asp:GridView ID="GridViewProducts" runat="server" AutoGenerateColumns="False" OnRowCommand="GridViewProducts_RowCommand">
                <Columns>
                    <asp:BoundField DataField="ERP_ProductID" HeaderText="Product ID" />
                    <asp:BoundField DataField="ERP_ProductName" HeaderText="Product Name" />
                    <asp:BoundField DataField="ERP_ProductPrice" HeaderText="Product Price" />
                    <asp:BoundField DataField="ERP_ProductQtyLvl" HeaderText="Available Quantity" />
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:Button ID="ButtonOrder" runat="server" Text="Order" CommandName="OrderProduct" CommandArgument='<%# Eval("ERP_ProductID") %>' />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>