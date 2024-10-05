USE [MIS331_ERP]
GO
/****** Object:  Table [dbo].[ERP_BillOfMaterials]    Script Date: 9/21/2024 5:22:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ERP_BillOfMaterials](
	[ERP_BoMID] [smallint] IDENTITY(1,1) NOT NULL,
	[ERP_ProductID] [smallint] NOT NULL,
	[ERP_ComponentID] [smallint] NOT NULL,
	[ERP_BoMQty] [decimal](18, 0) NOT NULL,
	[ERP_BoMUoM] [nvarchar](10) NULL,
 CONSTRAINT [PK_ERP_BillOfMaterials] PRIMARY KEY CLUSTERED 
(
	[ERP_BoMID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ERP_Components]    Script Date: 9/21/2024 5:22:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ERP_Components](
	[ERP_ComponentID] [smallint] IDENTITY(1,1) NOT NULL,
	[ERP_ComponentName] [nvarchar](50) NOT NULL,
	[ERP_ComponentCPU] [money] NOT NULL,
	[ERP_ComponentQty] [decimal](18, 0) NOT NULL,
	[ERP_ComponentReorderLvl] [decimal](18, 0) NOT NULL,
	[ERP_SupplierID] [smallint] NOT NULL,
 CONSTRAINT [PK_ERP_Components] PRIMARY KEY CLUSTERED 
(
	[ERP_ComponentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ERP_Customer]    Script Date: 9/21/2024 5:22:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ERP_Customer](
	[ERP_CustomerID] [smallint] IDENTITY(1,1) NOT NULL,
	[ERP_Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_ERP_Customer] PRIMARY KEY CLUSTERED 
(
	[ERP_CustomerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ERP_Dept]    Script Date: 9/21/2024 5:22:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ERP_Dept](
	[DeptID] [smallint] IDENTITY(1,1) NOT NULL,
	[Department] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_ERP_Dept] PRIMARY KEY CLUSTERED 
(
	[DeptID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ERP_Inventory]    Script Date: 9/21/2024 5:22:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ERP_Inventory](
	[ERP_InventoryID] [smallint] IDENTITY(1,1) NOT NULL,
	[ERP_ComponentID] [smallint] NOT NULL,
	[ERP_InventoryQty] [decimal](18, 0) NOT NULL,
	[ERP_LastUpdate] [timestamp] NOT NULL,
 CONSTRAINT [PK_ERP_Inventory] PRIMARY KEY CLUSTERED 
(
	[ERP_InventoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ERP_Product]    Script Date: 9/21/2024 5:22:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ERP_Product](
	[ERP_ProductID] [smallint] IDENTITY(1,1) NOT NULL,
	[ERP_ProductName] [nvarchar](max) NOT NULL,
	[ERP_ProductDesc] [text] NULL,
	[ERP_ProductPrice] [money] NOT NULL,
	[ERP_ProoductUoM] [varchar](10) NOT NULL,
	[ERP_ProductQtyLvl] [decimal](18, 0) NOT NULL,
 CONSTRAINT [PK_ERP_Product] PRIMARY KEY CLUSTERED 
(
	[ERP_ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ERP_Purchase]    Script Date: 9/21/2024 5:22:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ERP_Purchase](
	[ERP_PurchaseID] [smallint] IDENTITY(1,1) NOT NULL,
	[ERP_SupplierID] [smallint] NOT NULL,
	[ERP_PurchaseDate] [date] NOT NULL,
	[ERP_PurchaseQty] [decimal](18, 0) NOT NULL,
	[ERP_PurchaseUnitPrice] [money] NOT NULL,
 CONSTRAINT [PK_ERP_Purchase] PRIMARY KEY CLUSTERED 
(
	[ERP_PurchaseID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ERP_PurchaseOrderDetails]    Script Date: 9/21/2024 5:22:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ERP_PurchaseOrderDetails](
	[ERP_PurchaseOrderID] [smallint] IDENTITY(1,1) NOT NULL,
	[ERP_ComponentID] [smallint] NOT NULL,
	[ERP_PO_Qty] [decimal](18, 0) NOT NULL,
	[ERP_UnitPrice] [money] NOT NULL,
 CONSTRAINT [PK_ERP_PurchaseOrderDetails] PRIMARY KEY CLUSTERED 
(
	[ERP_PurchaseOrderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ERP_PurchaseOrders]    Script Date: 9/21/2024 5:22:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ERP_PurchaseOrders](
	[ERP_PurchaseOrderID] [smallint] IDENTITY(1,1) NOT NULL,
	[ERP_SupplierID] [smallint] NOT NULL,
	[ERP_PurchaseOrderDate] [date] NOT NULL,
	[ERP_PurchaseTotalAmt] [money] NOT NULL,
	[ERP_PurchaseStatus] [varchar](10) NOT NULL,
 CONSTRAINT [PK_ERP_PurchaseOrders] PRIMARY KEY CLUSTERED 
(
	[ERP_PurchaseOrderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ERP_Role]    Script Date: 9/21/2024 5:22:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ERP_Role](
	[RoleID] [smallint] IDENTITY(1,1) NOT NULL,
	[Role] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_ERP_Role] PRIMARY KEY CLUSTERED 
(
	[RoleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ERP_SalesOrder]    Script Date: 9/21/2024 5:22:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ERP_SalesOrder](
	[ERP_SalesOrderID] [smallint] IDENTITY(1,1) NOT NULL,
	[ERP_CustomerID] [smallint] NOT NULL,
	[ERP_OrderDate] [date] NOT NULL,
	[ERP_OrderTotal] [money] NOT NULL,
	[ERP_OrderStatus] [varchar](10) NOT NULL,
 CONSTRAINT [PK_ERP_SalesOrder] PRIMARY KEY CLUSTERED 
(
	[ERP_SalesOrderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ERP_Supplier]    Script Date: 9/21/2024 5:22:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ERP_Supplier](
	[SupplierID] [smallint] IDENTITY(1,1) NOT NULL,
	[SupplierName] [nvarchar](50) NOT NULL,
	[SupplierAddress] [nvarchar](max) NOT NULL,
	[SupplierEmail] [nvarchar](50) NOT NULL,
	[SupplierPhoneNumber] [varchar](11) NULL,
 CONSTRAINT [PK_ERP_Supplier] PRIMARY KEY CLUSTERED 
(
	[SupplierID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ERP_User]    Script Date: 9/21/2024 5:22:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ERP_User](
	[UserID] [smallint] IDENTITY(1,1) NOT NULL,
	[UserName] [nchar](50) NOT NULL,
	[Password] [nchar](50) NOT NULL,
	[RoleID] [smallint] NOT NULL,
	[DeptID] [smallint] NOT NULL,
	[DateHired] [date] NOT NULL,
 CONSTRAINT [PK_ERP_User] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[ERP_BillOfMaterials]  WITH CHECK ADD  CONSTRAINT [FK_ERP_BillOfMaterials_ERP_Components] FOREIGN KEY([ERP_ComponentID])
REFERENCES [dbo].[ERP_Components] ([ERP_ComponentID])
GO
ALTER TABLE [dbo].[ERP_BillOfMaterials] CHECK CONSTRAINT [FK_ERP_BillOfMaterials_ERP_Components]
GO
ALTER TABLE [dbo].[ERP_BillOfMaterials]  WITH CHECK ADD  CONSTRAINT [FK_ERP_BillOfMaterials_ERP_Product] FOREIGN KEY([ERP_ProductID])
REFERENCES [dbo].[ERP_Product] ([ERP_ProductID])
GO
ALTER TABLE [dbo].[ERP_BillOfMaterials] CHECK CONSTRAINT [FK_ERP_BillOfMaterials_ERP_Product]
GO
ALTER TABLE [dbo].[ERP_Components]  WITH CHECK ADD  CONSTRAINT [FK_ERP_Components_ERP_Supplier] FOREIGN KEY([ERP_SupplierID])
REFERENCES [dbo].[ERP_Supplier] ([SupplierID])
GO
ALTER TABLE [dbo].[ERP_Components] CHECK CONSTRAINT [FK_ERP_Components_ERP_Supplier]
GO
ALTER TABLE [dbo].[ERP_Inventory]  WITH CHECK ADD  CONSTRAINT [FK_ERP_Inventory_ERP_Components] FOREIGN KEY([ERP_ComponentID])
REFERENCES [dbo].[ERP_Components] ([ERP_ComponentID])
GO
ALTER TABLE [dbo].[ERP_Inventory] CHECK CONSTRAINT [FK_ERP_Inventory_ERP_Components]
GO
ALTER TABLE [dbo].[ERP_Purchase]  WITH CHECK ADD  CONSTRAINT [FK_ERP_Purchase_ERP_Supplier] FOREIGN KEY([ERP_SupplierID])
REFERENCES [dbo].[ERP_Supplier] ([SupplierID])
GO
ALTER TABLE [dbo].[ERP_Purchase] CHECK CONSTRAINT [FK_ERP_Purchase_ERP_Supplier]
GO
ALTER TABLE [dbo].[ERP_PurchaseOrderDetails]  WITH CHECK ADD  CONSTRAINT [FK_ERP_PurchaseOrderDetails_ERP_Components] FOREIGN KEY([ERP_ComponentID])
REFERENCES [dbo].[ERP_Components] ([ERP_ComponentID])
GO
ALTER TABLE [dbo].[ERP_PurchaseOrderDetails] CHECK CONSTRAINT [FK_ERP_PurchaseOrderDetails_ERP_Components]
GO
ALTER TABLE [dbo].[ERP_PurchaseOrderDetails]  WITH CHECK ADD  CONSTRAINT [FK_ERP_PurchaseOrderDetails_ERP_PurchaseOrders] FOREIGN KEY([ERP_PurchaseOrderID])
REFERENCES [dbo].[ERP_PurchaseOrders] ([ERP_PurchaseOrderID])
GO
ALTER TABLE [dbo].[ERP_PurchaseOrderDetails] CHECK CONSTRAINT [FK_ERP_PurchaseOrderDetails_ERP_PurchaseOrders]
GO
ALTER TABLE [dbo].[ERP_PurchaseOrders]  WITH CHECK ADD  CONSTRAINT [FK_ERP_PurchaseOrders_ERP_Supplier] FOREIGN KEY([ERP_SupplierID])
REFERENCES [dbo].[ERP_Supplier] ([SupplierID])
GO
ALTER TABLE [dbo].[ERP_PurchaseOrders] CHECK CONSTRAINT [FK_ERP_PurchaseOrders_ERP_Supplier]
GO
ALTER TABLE [dbo].[ERP_SalesOrder]  WITH CHECK ADD  CONSTRAINT [FK_ERP_SalesOrder_ERP_Customer] FOREIGN KEY([ERP_CustomerID])
REFERENCES [dbo].[ERP_Customer] ([ERP_CustomerID])
GO
ALTER TABLE [dbo].[ERP_SalesOrder] CHECK CONSTRAINT [FK_ERP_SalesOrder_ERP_Customer]
GO
ALTER TABLE [dbo].[ERP_User]  WITH CHECK ADD  CONSTRAINT [FK_ERP_User_ERP_Dept] FOREIGN KEY([DeptID])
REFERENCES [dbo].[ERP_Dept] ([DeptID])
GO
ALTER TABLE [dbo].[ERP_User] CHECK CONSTRAINT [FK_ERP_User_ERP_Dept]
GO
ALTER TABLE [dbo].[ERP_User]  WITH CHECK ADD  CONSTRAINT [FK_ERP_User_ERP_Role] FOREIGN KEY([RoleID])
REFERENCES [dbo].[ERP_Role] ([RoleID])
GO
ALTER TABLE [dbo].[ERP_User] CHECK CONSTRAINT [FK_ERP_User_ERP_Role]
GO
ALTER TABLE [dbo].[ERP_User]  WITH CHECK ADD  CONSTRAINT [FK_ERP_User_ERP_User] FOREIGN KEY([UserID])
REFERENCES [dbo].[ERP_User] ([UserID])
GO
ALTER TABLE [dbo].[ERP_User] CHECK CONSTRAINT [FK_ERP_User_ERP_User]
GO
