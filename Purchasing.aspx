<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Purchasing.aspx.cs" Inherits="ERPMIS331.Purchasing" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server">
                <Columns>
                    <asp:BoundField  DataField="ErpPurchaseId" HeaderText ="Purchase ID"
                        InsertVisible="False" ReadOnly="True" SortExpression="ErpPurchaseId" />
                    
                    <asp:BoundField  DataField="SupplierName" HeaderText ="Supplier Name"
                        InsertVisible="False" ReadOnly="True" SortExpression="SupplierName" />
                    
                    <asp:BoundField  DataField="ComponentName" HeaderText ="Item"
                        InsertVisible="False" ReadOnly="True" SortExpression="ComponentName" />
                    
                    <asp:BoundField  DataField="ErpPurchaseDate" HeaderText ="Purchase Date"
                        InsertVisible="False" ReadOnly="True" SortExpression="ErpPurchaseDate" />
                    
                    <asp:BoundField  DataField="ErpPurchaseUnitPrice" HeaderText ="Purchase Unit Price"
                        InsertVisible="False" ReadOnly="True" SortExpression="ErpPurchaseUnitPrice" />
                    
                    <asp:BoundField  DataField="ErpPurchaseTotalAmt" HeaderText ="Purchase Total Amount"
                        InsertVisible="False" ReadOnly="True" SortExpression="ErpPurchaseTotalAmt" />

                    <asp:BoundField  DataField="ErpPurchaseTotalAmt" HeaderText ="Purchase Total Amount"
                        InsertVisible="False" ReadOnly="True" SortExpression="ErpPurchaseTotalAmt" />
                </Columns>
            </asp:GridView>
        </div>
        <div>
            <asp:FileUpload runat="server" ID="filePurchase"></asp:FileUpload><br />
            <asp:Button ID="PurchaseBtn" runat="server" Text="Upload Purchase File" OnClick="UploadPurchaseFile" />
        </div>
    </form>
</body>
</html>
