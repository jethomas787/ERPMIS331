using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ERPMIS331.Models
{
    public partial class MIS331_ERPContext : DbContext
    {
        public MIS331_ERPContext()
        {
        }

        public MIS331_ERPContext(DbContextOptions<MIS331_ERPContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ErpBillOfMaterials> ErpBillOfMaterials { get; set; }
        public virtual DbSet<ErpComponents> ErpComponents { get; set; }
        public virtual DbSet<ErpCustomer> ErpCustomer { get; set; }
        public virtual DbSet<ErpDept> ErpDept { get; set; }
        public virtual DbSet<ErpInventory> ErpInventory { get; set; }
        public virtual DbSet<ErpProduct> ErpProduct { get; set; }
        public virtual DbSet<ErpPurchase> ErpPurchase { get; set; }
        public virtual DbSet<ErpPurchaseOrderDetails> ErpPurchaseOrderDetails { get; set; }
        public virtual DbSet<ErpPurchaseOrders> ErpPurchaseOrders { get; set; }
        public virtual DbSet<ErpRole> ErpRole { get; set; }
        public virtual DbSet<ErpSalesOrder> ErpSalesOrder { get; set; }
        public virtual DbSet<ErpSupplier> ErpSupplier { get; set; }
        public virtual DbSet<ErpUser> ErpUser { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=WSAMZN-1DLMM209; Database=MIS331_ERP; UID=MIS331DB_User; Password=MIS331ERP;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ErpBillOfMaterials>(entity =>
            {
                entity.HasKey(e => e.ErpBoMid);

                entity.ToTable("ERP_BillOfMaterials");

                entity.Property(e => e.ErpBoMid).HasColumnName("ERP_BoMID");

                entity.Property(e => e.ErpBoMqty)
                    .HasColumnName("ERP_BoMQty")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ErpBoMuoM)
                    .HasColumnName("ERP_BoMUoM")
                    .HasMaxLength(10);

                entity.Property(e => e.ErpComponentId).HasColumnName("ERP_ComponentID");

                entity.Property(e => e.ErpProductId).HasColumnName("ERP_ProductID");

                entity.HasOne(d => d.ErpComponent)
                    .WithMany(p => p.ErpBillOfMaterials)
                    .HasForeignKey(d => d.ErpComponentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ERP_BillOfMaterials_ERP_Components");

                entity.HasOne(d => d.ErpProduct)
                    .WithMany(p => p.ErpBillOfMaterials)
                    .HasForeignKey(d => d.ErpProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ERP_BillOfMaterials_ERP_Product");
            });

            modelBuilder.Entity<ErpComponents>(entity =>
            {
                entity.HasKey(e => e.ErpComponentId);

                entity.ToTable("ERP_Components");

                entity.Property(e => e.ErpComponentId).HasColumnName("ERP_ComponentID");

                entity.Property(e => e.ErpComponentCpu)
                    .HasColumnName("ERP_ComponentCPU")
                    .HasColumnType("money");

                entity.Property(e => e.ErpComponentName)
                    .IsRequired()
                    .HasColumnName("ERP_ComponentName")
                    .HasMaxLength(50);

                entity.Property(e => e.ErpComponentQty)
                    .HasColumnName("ERP_ComponentQty")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ErpComponentReorderLvl)
                    .HasColumnName("ERP_ComponentReorderLvl")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ErpSupplierId).HasColumnName("ERP_SupplierID");

                entity.HasOne(d => d.ErpSupplier)
                    .WithMany(p => p.ErpComponents)
                    .HasForeignKey(d => d.ErpSupplierId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ERP_Components_ERP_Supplier");
            });

            modelBuilder.Entity<ErpCustomer>(entity =>
            {
                entity.ToTable("ERP_Customer");

                entity.Property(e => e.ErpCustomerId).HasColumnName("ERP_CustomerID");

                entity.Property(e => e.ErpName)
                    .IsRequired()
                    .HasColumnName("ERP_Name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ErpDept>(entity =>
            {
                entity.HasKey(e => e.DeptId);

                entity.ToTable("ERP_Dept");

                entity.Property(e => e.DeptId).HasColumnName("DeptID");

                entity.Property(e => e.Department)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ErpInventory>(entity =>
            {
                entity.ToTable("ERP_Inventory");

                entity.Property(e => e.ErpInventoryId).HasColumnName("ERP_InventoryID");

                entity.Property(e => e.ErpComponentId).HasColumnName("ERP_ComponentID");

                entity.Property(e => e.ErpInventoryQty)
                    .HasColumnName("ERP_InventoryQty")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ErpLastUpdate)
                    .IsRequired()
                    .HasColumnName("ERP_LastUpdate")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.ErpComponent)
                    .WithMany(p => p.ErpInventory)
                    .HasForeignKey(d => d.ErpComponentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ERP_Inventory_ERP_Components");
            });

            modelBuilder.Entity<ErpProduct>(entity =>
            {
                entity.ToTable("ERP_Product");

                entity.Property(e => e.ErpProductId).HasColumnName("ERP_ProductID");

                entity.Property(e => e.ErpProductDesc)
                    .HasColumnName("ERP_ProductDesc")
                    .HasColumnType("text");

                entity.Property(e => e.ErpProductName)
                    .IsRequired()
                    .HasColumnName("ERP_ProductName");

                entity.Property(e => e.ErpProductPrice)
                    .HasColumnName("ERP_ProductPrice")
                    .HasColumnType("money");

                entity.Property(e => e.ErpProductQtyLvl)
                    .HasColumnName("ERP_ProductQtyLvl")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ErpProoductUoM)
                    .IsRequired()
                    .HasColumnName("ERP_ProoductUoM")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ErpPurchase>(entity =>
            {
                entity.ToTable("ERP_Purchase");

                entity.Property(e => e.ErpPurchaseId).HasColumnName("ERP_PurchaseID");

                entity.Property(e => e.ErpPurchaseDate)
                    .HasColumnName("ERP_PurchaseDate")
                    .HasColumnType("date");

                entity.Property(e => e.ErpPurchaseQty)
                    .HasColumnName("ERP_PurchaseQty")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ErpPurchaseUnitPrice)
                    .HasColumnName("ERP_PurchaseUnitPrice")
                    .HasColumnType("money");

                entity.Property(e => e.ErpSupplierId).HasColumnName("ERP_SupplierID");

                entity.HasOne(d => d.ErpSupplier)
                    .WithMany(p => p.ErpPurchase)
                    .HasForeignKey(d => d.ErpSupplierId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ERP_Purchase_ERP_Supplier");
            });

            modelBuilder.Entity<ErpPurchaseOrderDetails>(entity =>
            {
                entity.HasKey(e => e.ErpPurchaseOrderId);

                entity.ToTable("ERP_PurchaseOrderDetails");

                entity.Property(e => e.ErpPurchaseOrderId)
                    .HasColumnName("ERP_PurchaseOrderID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ErpComponentId).HasColumnName("ERP_ComponentID");

                entity.Property(e => e.ErpPoQty)
                    .HasColumnName("ERP_PO_Qty")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ErpUnitPrice)
                    .HasColumnName("ERP_UnitPrice")
                    .HasColumnType("money");

                entity.HasOne(d => d.ErpComponent)
                    .WithMany(p => p.ErpPurchaseOrderDetails)
                    .HasForeignKey(d => d.ErpComponentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ERP_PurchaseOrderDetails_ERP_Components");

                entity.HasOne(d => d.ErpPurchaseOrder)
                    .WithOne(p => p.ErpPurchaseOrderDetails)
                    .HasForeignKey<ErpPurchaseOrderDetails>(d => d.ErpPurchaseOrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ERP_PurchaseOrderDetails_ERP_PurchaseOrders");
            });

            modelBuilder.Entity<ErpPurchaseOrders>(entity =>
            {
                entity.HasKey(e => e.ErpPurchaseOrderId);

                entity.ToTable("ERP_PurchaseOrders");

                entity.Property(e => e.ErpPurchaseOrderId).HasColumnName("ERP_PurchaseOrderID");

                entity.Property(e => e.ErpPurchaseOrderDate)
                    .HasColumnName("ERP_PurchaseOrderDate")
                    .HasColumnType("date");

                entity.Property(e => e.ErpPurchaseStatus)
                    .IsRequired()
                    .HasColumnName("ERP_PurchaseStatus")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ErpPurchaseTotalAmt)
                    .HasColumnName("ERP_PurchaseTotalAmt")
                    .HasColumnType("money");

                entity.Property(e => e.ErpSupplierId).HasColumnName("ERP_SupplierID");

                entity.HasOne(d => d.ErpSupplier)
                    .WithMany(p => p.ErpPurchaseOrders)
                    .HasForeignKey(d => d.ErpSupplierId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ERP_PurchaseOrders_ERP_Supplier");
            });

            modelBuilder.Entity<ErpRole>(entity =>
            {
                entity.HasKey(e => e.RoleId);

                entity.ToTable("ERP_Role");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.Role)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ErpSalesOrder>(entity =>
            {
                entity.ToTable("ERP_SalesOrder");

                entity.Property(e => e.ErpSalesOrderId).HasColumnName("ERP_SalesOrderID");

                entity.Property(e => e.ErpCustomerId).HasColumnName("ERP_CustomerID");

                entity.Property(e => e.ErpOrderDate)
                    .HasColumnName("ERP_OrderDate")
                    .HasColumnType("date");

                entity.Property(e => e.ErpOrderStatus)
                    .IsRequired()
                    .HasColumnName("ERP_OrderStatus")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ErpOrderTotal)
                    .HasColumnName("ERP_OrderTotal")
                    .HasColumnType("money");

                entity.HasOne(d => d.ErpCustomer)
                    .WithMany(p => p.ErpSalesOrder)
                    .HasForeignKey(d => d.ErpCustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ERP_SalesOrder_ERP_Customer");
            });

            modelBuilder.Entity<ErpSupplier>(entity =>
            {
                entity.HasKey(e => e.SupplierId);

                entity.ToTable("ERP_Supplier");

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

                entity.Property(e => e.SupplierAddress).IsRequired();

                entity.Property(e => e.SupplierEmail)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.SupplierName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.SupplierPhoneNumber)
                    .HasMaxLength(11)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ErpUser>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.ToTable("ERP_User");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.DateHired).HasColumnType("date");

                entity.Property(e => e.DeptId).HasColumnName("DeptID");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.HasOne(d => d.Dept)
                    .WithMany(p => p.ErpUser)
                    .HasForeignKey(d => d.DeptId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ERP_User_ERP_Dept");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.ErpUser)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ERP_User_ERP_Role");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
