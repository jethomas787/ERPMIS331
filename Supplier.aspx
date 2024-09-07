<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Supplier.aspx.cs" Inherits="ERPMIS331.Supplier" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SupplierPage.aspx.cs" Inherits="ERPMIS331.SupplierPage" %>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <asp:GridView ID="GridView1" runat="server" ItemType="ERPMIS331.Models.Supplier" DataKeyNames="SupplierID"
        SelectedMethod="SupplierGrid_GetData"
       AutoGenerateColumns="false">
        <Columns>
             <asp:DynamicField DataField="SupplierID" HeaderText ="SupplierID"
                 InsertVisible="False" ReadOnly="True" SortExpression="SupplierID" />
             <asp:DynamicField DataField="SupplierName" HeaderText ="SupplierName"
                 InsertVisible="False" ReadOnly="True" SortExpression="SupplierName" />
             <asp:DynamicField DataField="SupplierAddress"  HeaderText ="SupplierAddress"
                 InsertVisible="False" ReadOnly="True" SortExpression="SupplierAddress" />    
             <asp:DynamicField DataField="SupplierEmailAddress"   HeaderText ="SupplierEmailAddress"
                 InsertVisible="False" ReadOnly="True" SortExpression="SupplierEmailAddress" /> 
            <asp:DynamicField DataField="SupplierPhoneNumber"  HeaderText ="SupplierPhoneNumber"
                 InsertVisible="False" ReadOnly="True" SortExpression="SupplierPhoneNumber" /> 
        </Columns>
    </asp:GridView>
</asp:Content>


</asp:Content>
