<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddSupplier.aspx.cs" Inherits="ERPMIS331.AddSupplier" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Add Supplier</title>
      <style>
        body {
            font-family: Arial, sans-serif;
            background-color: #f4f4f4;
            display: flex;
            justify-content: center;
            align-items: center;
            height: 100vh;
            margin: 0;
        }
        .container {
            background: white;
            padding: 20px;
            border-radius: 8px;
            box-shadow: 0 2px 10px rgba(0, 0, 0, 0.1);
            text-align: center;
        }
        h2 {
            margin-bottom: 20px;
        }
        .role-button {
            background-color: #007BFF;
            color: white;
            border: none;
            border-radius: 5px;
            padding: 15px 20px;
            font-size: 16px;
            cursor: pointer;
            margin: 10px;
            transition: background-color 0.3s;
        }
        .role-button:hover {
            background-color: #0056b3;
        }
        .button-container {
            display: flex;
            flex-wrap: wrap;
            justify-content: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:FormView runat="server" ID="SupplierFormView" ItemType="ERPMIS331.Models.ErpSupplier" 
               DefaultMode="Insert" OnItemInserting="SupplierFormView_ItemInserting">
                <InsertItemTemplate>
                    <label for="SupplierName">Supplier Name:</label>
                    <asp:TextBox ID="txtSupplierName" runat="server" Text='<%# Bind("SupplierName") %>' />
                     <br />
                    <label for="SupplierAddress">Address:</label>
                    <asp:TextBox ID="txtSupplierAddress" runat="server" Text='<%# Bind("SupplierAddress") %>' />
                     <br />
                   <label for="SupplierEmail">Email:</label>
                   <asp:TextBox ID="TxtSupplierEmail" runat="server" Text='<%# Bind("SupplierEmail") %>' />
                     <br />
                   <label for="SupplierPhoneNumber">Phone No:</label>
                   <asp:TextBox ID="TxtSupplierPhoneNumber" runat="server" Text='<%# Bind("SupplierPhoneNumber") %>' />
                    <br />
                    <asp:Button ID="btnInsert" runat="server" Text="Add Supplier" CommandName="Insert" />
                </InsertItemTemplate>
            </asp:FormView>
            <asp:Label ID="lblMessage" runat="server" ForeColor="Green"></asp:Label>
        </div>
    </form>
</body>
</html>
