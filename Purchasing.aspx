<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Purchasing.aspx.cs" Inherits="ERPMIS331.Purchasing" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Purchasing</title>
</head>
<body>
    <div>
    <form id="form1" runat="server">
        <div><asp:Button runat="server"  Text="Logout" OnClick="LogOutBtn"></asp:Button></div>
        <div>
            <asp:ScriptManager ID="SCM1" runat="server"> </asp:ScriptManager>
                 <asp:Timer runat="server" Interval="60000" OnTick="TimeBasedDataLoad"></asp:Timer>
                     <asp:UpdatePanel ID="updatePandel1" runat="server">
                         <ContentTemplate>
                             <asp:GridView ID="purchaseGridView" runat="server"
                                 AllowSorting="false" AllowPaging="true" AutoGenerateColumns="false">
                                 <Columns>
                                     <asp:BoundField  DataField="Item" HeaderText ="Item to Purchase"/>
                                     <asp:BoundField  DataField="Quantity" HeaderText="Item Quantity"/>
                                     <asp:BoundField  DataField="Price" HeaderText="Priece Per Unit"/>
                                     <asp:BoundField  DataField="Supplier" HeaderText ="Item Supplier"/>  
                                     <asp:TemplateField>
                                         <ItemTemplate>
                                             <asp:Button runat="server" ID="AddPurchase" Text="Add To Purchase" CommandName="NewPurchase"
                                                 CommandArgument='<%# Eval("Item") %>' />
                                         </ItemTemplate>
                                     </asp:TemplateField>
                                     </Columns>
                             </asp:GridView>
                         </ContentTemplate>
                     </asp:UpdatePanel>
                </div>
             <div>
                <asp:FileUpload runat="server" ID="filePurchase"></asp:FileUpload><br />
                <asp:Button ID="PurchaseBtn" runat="server" Text="Upload Purchase File" OnClick="UploadPurchaseFile" />
         </div>
    </form>
   </div>
        
</body>
</html>
