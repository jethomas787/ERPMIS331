<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Supplier.aspx.cs" Inherits="ERPMIS331.Supplier" %>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <asp:GridView ID="GridView1" runat="server" ItemType="ERPMIS331.Models.Supplier" DataKeyNames="SupplierID"
        OnPageIndexChanging="GridView1_PageIndexChanging" OnRowCancelingEdit="GridView1_RowCancelingEdit" 
        OnRowDeleting="GridView1_RowDeleting" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating"

        SelectedMethod="SupplierGrid_GetData"
        
       AutoGenerateColumns="false">
        <Columns>
             <asp:BoundField  DataField="SupplierID" HeaderText ="Supplier ID"
                 InsertVisible="False" ReadOnly="True" SortExpression="SupplierID" />
             <asp:BoundField  DataField="SupplierName" HeaderText ="Supplier Name"
                 InsertVisible="False" ReadOnly="True" SortExpression="SupplierName" />
             <asp:BoundField  DataField="SupplierAddress"  HeaderText ="Supplie rAddress"
                 InsertVisible="False" ReadOnly="True" SortExpression="SupplierAddress" />    
             <asp:BoundField  DataField="SupplierEmail"   HeaderText ="Supplier Email"
                 InsertVisible="False" ReadOnly="True" SortExpression="SupplierEmail" /> 
            <asp:BoundField  DataField="SupplierPhoneNumber"  HeaderText ="Supplier Phone Number"
                 InsertVisible="False" ReadOnly="True" SortExpression="SupplierPhoneNumber" /> 
             <asp:CommandField ShowEditButton="true" />  
             <asp:CommandField ShowDeleteButton="true" />
        </Columns>
    </asp:GridView>
</asp:Content>


