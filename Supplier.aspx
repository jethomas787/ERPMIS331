<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Supplier.aspx.cs" Inherits="ERPMIS331.Supplier" %>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <asp:GridView ID="GridView1" runat="server" ItemType="ERPMIS331.Models.Supplier" DataKeyNames="SupplierID"
        OnPageIndexChanging="PageIndexChanging"          
        SelectedMethod="SupplierGrid_GetData"
        OnRowCancelingEdit="RowCancelingEdit" 
        OnRowEditing="RowEditing"          
        OnRowUpdating="RowUpdating">  

       AutoGenerateColumns="false">
        <Columns>
             <asp:BoundField  DataField="SupplierID" HeaderText ="SupplierID"
                 InsertVisible="False" ReadOnly="True" SortExpression="SupplierID" />
             <asp:BoundField  DataField="SupplierName" HeaderText ="SupplierName"
                 InsertVisible="False" ReadOnly="True" SortExpression="SupplierName" />
             <asp:BoundField  DataField="SupplierAddress"  HeaderText ="SupplierAddress"
                 InsertVisible="False" ReadOnly="True" SortExpression="SupplierAddress" />    
             <asp:BoundField  DataField="SupplierEmail"   HeaderText ="SupplierEmail"
                 InsertVisible="False" ReadOnly="True" SortExpression="SupplierEmail" /> 
            <asp:BoundField  DataField="SupplierPhoneNumber"  HeaderText ="SupplierPhoneNumber"
                 InsertVisible="False" ReadOnly="True" SortExpression="SupplierPhoneNumber" /> 
        </Columns>
    </asp:GridView>
</asp:Content>


