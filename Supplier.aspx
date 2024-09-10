﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Supplier.aspx.cs" Inherits="ERPMIS331.Supplier" %>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <asp:GridView ID="GridView1" runat="server" ItemType="ERPMIS331.Models.Supplier" DataKeyNames="SupplierID"
        AutoGenerateEditButton="true"        
        OnRowCancelingEdit="GridView1_RowCancelingEdit" 
        OnRowEditing="GridView1_RowEditing"          
        OnRowUpdating="GridView1_RowUpdating"
       AutoGenerateColumns="false">
        <Columns>
             <asp:BoundField  DataField="SupplierID" HeaderText ="Supplier ID"
                 InsertVisible="False" ReadOnly="True" SortExpression="SupplierID" />
             <asp:BoundField  DataField="SupplierName" HeaderText ="Supplier Name"
                 InsertVisible="True" ReadOnly="False" SortExpression="SupplierName" />
             <asp:BoundField  DataField="SupplierAddress"  HeaderText ="Supplier Address"
                 InsertVisible="True" ReadOnly="False" SortExpression="SupplierAddress" />    
             <asp:BoundField  DataField="SupplierEmail"   HeaderText ="Supplier Email"
                 InsertVisible="True" ReadOnly="False" SortExpression="SupplierEmail" /> 
            <asp:BoundField  DataField="SupplierPhoneNumber"  HeaderText ="Supplier Phone Number"
                 InsertVisible="True" ReadOnly="False" SortExpression="SupplierPhoneNumber" /> 
        </Columns>
    </asp:GridView>
</asp:Content>


