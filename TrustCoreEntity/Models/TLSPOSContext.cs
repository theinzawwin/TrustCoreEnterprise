using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using TrustCoreEntity.Models;

namespace TrustCoreEntity.Models
{
    public partial class TLSPOSContext : DbContext
    {
        public TLSPOSContext()
        {
        }

        public TLSPOSContext(DbContextOptions<TLSPOSContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Account> Account { get; set; }
        public virtual DbSet<AccountType> AccountType { get; set; }
        public virtual DbSet<Asset> Asset { get; set; }
        public virtual DbSet<AssetDep> AssetDep { get; set; }
        public virtual DbSet<Bills> Bills { get; set; }
        public virtual DbSet<Categories> Categories { get; set; }
        public virtual DbSet<CustomerAccount> CustomerAccount { get; set; }
        public virtual DbSet<Customers> Customers { get; set; }
        public virtual DbSet<DebitAccount> DebitAccount { get; set; }
        public virtual DbSet<DebitSupplier> DebitSupplier { get; set; }
        public virtual DbSet<Expense> Expense { get; set; }
        public virtual DbSet<ExpenseCategory> ExpenseCategory { get; set; }
        public virtual DbSet<Finance> Finance { get; set; }
        public virtual DbSet<FocHead> FocHead { get; set; }
        public virtual DbSet<FocPay> FocPay { get; set; }
        public virtual DbSet<FocSell> FocSell { get; set; }
        public virtual DbSet<GrossSummary> GrossSummary { get; set; }
        public virtual DbSet<GrossTitle> GrossTitle { get; set; }
        public virtual DbSet<Income> Income { get; set; }
        public virtual DbSet<IncomeCategory> IncomeCategory { get; set; }
        public virtual DbSet<ItemDiscount> ItemDiscount { get; set; }
        public virtual DbSet<Journal> Journal { get; set; }
        public virtual DbSet<Location> Location { get; set; }
        public virtual DbSet<LoginUser> LoginUser { get; set; }
        public virtual DbSet<PayAccount> PayAccount { get; set; }
        public virtual DbSet<PaySupplier> PaySupplier { get; set; }
        public virtual DbSet<PorderProduct> PorderProduct { get; set; }
        public virtual DbSet<Privilege> Privilege { get; set; }
        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<ProfitLoss> ProfitLoss { get; set; }
        public virtual DbSet<Promotion> Promotion { get; set; }
        public virtual DbSet<PurchaseCredit> PurchaseCredit { get; set; }
        public virtual DbSet<PurchaseInvoice> PurchaseInvoice { get; set; }
        public virtual DbSet<PurchaseItem> PurchaseItem { get; set; }
        public virtual DbSet<PurchaseOrder> PurchaseOrder { get; set; }
        public virtual DbSet<PurchaseReturn> PurchaseReturn { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<RolePrivilege> RolePrivilege { get; set; }
        public virtual DbSet<SaleOrder> SaleOrder { get; set; }
        public virtual DbSet<SaleReturn> SaleReturn { get; set; }
        public virtual DbSet<ServiceCategory> ServiceCategory { get; set; }
        public virtual DbSet<ServiceItem> ServiceItem { get; set; }
        public virtual DbSet<Setting> Setting { get; set; }
        public virtual DbSet<Sku> Sku { get; set; }
        public virtual DbSet<SoldItem> SoldItem { get; set; }
        public virtual DbSet<SoldServiceItem> SoldServiceItem { get; set; }
        public virtual DbSet<SorderProduct> SorderProduct { get; set; }
        public virtual DbSet<StockAdjust> StockAdjust { get; set; }
        public virtual DbSet<StockLoss> StockLoss { get; set; }
        public virtual DbSet<Stocks> Stocks { get; set; }
        public virtual DbSet<Subcategories> Subcategories { get; set; }
        public virtual DbSet<Supplier> Supplier { get; set; }
        public virtual DbSet<TargetDiscount> TargetDiscount { get; set; }
        public virtual DbSet<RestTable> RestTables { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>(entity =>
            {
                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.HasOne(d => d.AccountType)
                    .WithMany(p => p.Account)
                    .HasForeignKey(d => d.AccountTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Account_AccountType");
            });

            modelBuilder.Entity<AccountType>(entity =>
            {
                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Status).HasMaxLength(50);
            });

            modelBuilder.Entity<Asset>(entity =>
            {
                entity.Property(e => e.AccountStatus).HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.PurchaseDate).HasColumnType("date");

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.Asset)
                    .HasForeignKey(d => d.AccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Asset_Account");
            });

            modelBuilder.Entity<AssetDep>(entity =>
            {
                entity.Property(e => e.DepDate).HasColumnType("date");
            });

            modelBuilder.Entity<Bills>(entity =>
            {
                entity.Property(e => e.BillDate)
                    .HasColumnName("Bill_Date")
                    .HasColumnType("date");

                entity.Property(e => e.BillTime)
                    .HasColumnName("Bill_Time")
                    .HasMaxLength(15);

                entity.Property(e => e.CustomerId).HasColumnName("Customer_Id");

                entity.Property(e => e.DiscountAmount).HasColumnName("Discount_Amount");

                entity.Property(e => e.NetTotalAmount).HasColumnName("NetTotal_Amount");

                entity.Property(e => e.PayAmount).HasColumnName("Pay_Amount");

                entity.Property(e => e.RefundAmount).HasColumnName("Refund_Amount");

                entity.Property(e => e.RemainAmount).HasColumnName("Remain_Amount");

                entity.Property(e => e.SaleStatus)
                    .HasColumnName("Sale_Status")
                    .HasMaxLength(20);

                entity.Property(e => e.SubTotalAmount).HasColumnName("SubTotal_Amount");

                entity.Property(e => e.TaxAmount).HasColumnName("Tax_Amount");

                entity.Property(e => e.TotalAmount).HasColumnName("Total_Amount");

                entity.Property(e => e.VoucherNo).HasMaxLength(50);

                entity.HasOne(d => d.Cashier)
                    .WithMany(p => p.Bills)
                    .HasForeignKey(d => d.CashierId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Bills_LoginUser");
            });

            modelBuilder.Entity<Categories>(entity =>
            {
                entity.Property(e => e.Code).HasMaxLength(10);

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.Name).IsRequired();
            });

            modelBuilder.Entity<CustomerAccount>(entity =>
            {
                entity.ToTable("Customer_Account");

                entity.Property(e => e.CustomerId).HasColumnName("Customer_Id");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.OpenDate)
                    .HasColumnName("Open_Date")
                    .HasColumnType("date");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.CustomerAccount)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_Customer_Account_Customers");
            });

            modelBuilder.Entity<Customers>(entity =>
            {
                entity.Property(e => e.Crcode)
                    .IsRequired()
                    .HasColumnName("CRCode")
                    .HasMaxLength(15);

                entity.Property(e => e.Name).IsRequired();
            });

            modelBuilder.Entity<DebitAccount>(entity =>
            {
                entity.ToTable("Debit_Account");

                entity.Property(e => e.AccountId).HasColumnName("Account_Id");

                entity.Property(e => e.DebitAmount).HasColumnName("Debit_Amount");

                entity.Property(e => e.DebitDate)
                    .HasColumnName("Debit_Date")
                    .HasColumnType("date");

                entity.Property(e => e.RemainAmount).HasColumnName("Remain_Amount");

                entity.Property(e => e.Status).HasMaxLength(10);

                entity.Property(e => e.SysDate).HasColumnType("date");

                entity.HasOne(d => d.Bill)
                    .WithMany(p => p.DebitAccount)
                    .HasForeignKey(d => d.BillId)
                    .HasConstraintName("FK_Debit_Account_Bills");
            });

            modelBuilder.Entity<DebitSupplier>(entity =>
            {
                entity.ToTable("Debit_Supplier");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.SupplierId).HasColumnName("Supplier_Id");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.DebitSupplier)
                    .HasForeignKey(d => d.SupplierId)
                    .HasConstraintName("FK_Debit_Supplier_Supplier");
            });

            modelBuilder.Entity<Expense>(entity =>
            {
                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.ExpenseDate).HasColumnType("date");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Status).HasMaxLength(10);

                entity.Property(e => e.SysDate).HasColumnType("date");

                entity.HasOne(d => d.ExpenseCategory)
                    .WithMany(p => p.Expense)
                    .HasForeignKey(d => d.ExpenseCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Expense_ExpenseCategory");
            });

            modelBuilder.Entity<ExpenseCategory>(entity =>
            {
                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<Finance>(entity =>
            {
                entity.Property(e => e.AccountId).HasColumnName("Account_Id");

                entity.Property(e => e.CustomerId).HasColumnName("Customer_Id");

                entity.Property(e => e.PayAccountId).HasColumnName("Pay_Account_Id");
            });

            modelBuilder.Entity<FocHead>(entity =>
            {
                entity.Property(e => e.Status).HasMaxLength(50);

                entity.HasOne(d => d.Pro)
                    .WithMany(p => p.FocHead)
                    .HasForeignKey(d => d.ProId)
                    .HasConstraintName("FK_FocHead_Promotion");
            });

            modelBuilder.Entity<FocPay>(entity =>
            {
                entity.HasOne(d => d.Foc)
                    .WithMany(p => p.FocPay)
                    .HasForeignKey(d => d.FocId)
                    .HasConstraintName("FK_FocPay_FocHead");
            });

            modelBuilder.Entity<FocSell>(entity =>
            {
                entity.HasOne(d => d.Foc)
                    .WithMany(p => p.FocSell)
                    .HasForeignKey(d => d.FocId)
                    .HasConstraintName("FK_FocSell_FocHead");
            });

            modelBuilder.Entity<GrossSummary>(entity =>
            {
                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Status).HasMaxLength(50);
            });

            modelBuilder.Entity<GrossTitle>(entity =>
            {
                entity.Property(e => e.FromDate).HasColumnType("date");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.ToDate).HasColumnType("date");
            });

            modelBuilder.Entity<Income>(entity =>
            {
                entity.Property(e => e.IncomeDate).HasColumnType("date");

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.Property(e => e.SysDate).HasColumnType("date");

                entity.HasOne(d => d.IncomeCat)
                    .WithMany(p => p.Income)
                    .HasForeignKey(d => d.IncomeCatId)
                    .HasConstraintName("FK_Income_IncomeCategory");
            });

            modelBuilder.Entity<IncomeCategory>(entity =>
            {
                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<ItemDiscount>(entity =>
            {
                entity.HasOne(d => d.Pro)
                    .WithMany(p => p.ItemDiscount)
                    .HasForeignKey(d => d.ProId)
                    .HasConstraintName("FK_Promotion");
            });

            modelBuilder.Entity<Journal>(entity =>
            {
                entity.Property(e => e.AccountStatus).HasMaxLength(50);

                entity.Property(e => e.CreateDate).HasColumnType("date");

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.JournalDate).HasColumnType("date");

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.Journal)
                    .HasForeignKey(d => d.AccountId)
                    .HasConstraintName("FK_Journal_Account");
            });

            modelBuilder.Entity<Location>(entity =>
            {
                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<LoginUser>(entity =>
            {
                entity.Property(e => e.DelStatus).HasMaxLength(15);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.RoleId).HasColumnName("Role_Id");

                entity.Property(e => e.UserName).HasMaxLength(50);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.LoginUser)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_LoginUser_Role");
            });

            modelBuilder.Entity<PayAccount>(entity =>
            {
                entity.ToTable("Pay_Account");

                entity.Property(e => e.AccountId).HasColumnName("Account_Id");

                entity.Property(e => e.DebitAccountId).HasColumnName("DebitAccount_Id");

                entity.Property(e => e.PayDate)
                    .HasColumnName("Pay_Date")
                    .HasColumnType("date");

                entity.Property(e => e.SysDate).HasColumnType("date");

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.PayAccount)
                    .HasForeignKey(d => d.AccountId)
                    .HasConstraintName("FK_Pay_Account_Pay_Account");

                entity.HasOne(d => d.DebitAccount)
                    .WithMany(p => p.PayAccount)
                    .HasForeignKey(d => d.DebitAccountId)
                    .HasConstraintName("Debit_Account_Id");
            });

            modelBuilder.Entity<PaySupplier>(entity =>
            {
                entity.ToTable("Pay_Supplier");

                entity.Property(e => e.PayDate)
                    .HasColumnName("Pay_Date")
                    .HasColumnType("date");

                entity.Property(e => e.PurchaseCreditId).HasColumnName("PurchaseCredit_Id");

                entity.Property(e => e.Remark).HasMaxLength(50);

                entity.Property(e => e.SysDate).HasColumnType("date");
            });

            modelBuilder.Entity<PorderProduct>(entity =>
            {
                entity.ToTable("POrder_Product");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.PorderProduct)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_POrder_Product_PurchaseOrder");
            });

            modelBuilder.Entity<Privilege>(entity =>
            {
                entity.Property(e => e.PrivilegeName)
                    .HasColumnName("Privilege_Name")
                    .HasMaxLength(50);

                entity.Property(e => e.PrivilegeShortName)
                    .HasColumnName("Privilege_ShortName")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Products>(entity =>
            {
                entity.HasIndex(e => e.CategoryId)
                    .HasName("IX_FK_ProductSubcategory");

                entity.Property(e => e.Barcode).IsRequired();

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.Name).IsRequired();

                entity.Property(e => e.Sku).HasMaxLength(50);
            });

            modelBuilder.Entity<ProfitLoss>(entity =>
            {
                entity.Property(e => e.FromDate).HasColumnType("date");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.ToDate).HasColumnType("date");
            });

            modelBuilder.Entity<Promotion>(entity =>
            {
                entity.Property(e => e.EndDate).HasColumnType("date");

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.Property(e => e.StartDate).HasColumnType("date");

                entity.Property(e => e.SysDate).HasColumnType("date");
            });

            modelBuilder.Entity<PurchaseCredit>(entity =>
            {
                entity.ToTable("Purchase_Credit");

                entity.Property(e => e.CreditAmount).HasColumnName("Credit_Amount");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.PurchaseInvoiceId).HasColumnName("PurchaseInvoice_Id");

                entity.Property(e => e.RemainAmount).HasColumnName("Remain_Amount");

                entity.Property(e => e.Status).HasMaxLength(10);

                entity.Property(e => e.SupplierAccountId).HasColumnName("SupplierAccount_Id");

                entity.Property(e => e.SysDate).HasColumnType("date");

                entity.HasOne(d => d.SupplierAccount)
                    .WithMany(p => p.PurchaseCredit)
                    .HasForeignKey(d => d.SupplierAccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Debit_Supplier_Account_Id");
            });

            modelBuilder.Entity<PurchaseInvoice>(entity =>
            {
                entity.ToTable("Purchase_Invoice");

                entity.Property(e => e.NetTotalAmount).HasColumnName("NetTotal_Amount");

                entity.Property(e => e.PurchaseDate).HasColumnType("date");

                entity.Property(e => e.RefNo).HasMaxLength(50);

                entity.Property(e => e.SupplierId).HasColumnName("Supplier_Id");

                entity.Property(e => e.SysDate).HasColumnType("date");
            });

            modelBuilder.Entity<PurchaseItem>(entity =>
            {
                entity.ToTable("Purchase_Item");

                entity.HasIndex(e => e.StockId)
                    .HasName("IX_FK_ProductPurchase_Item");

                entity.Property(e => e.PurchaseDate)
                    .HasColumnName("Purchase_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.PurchasePrice).HasColumnName("Purchase_Price");

                entity.Property(e => e.RefNo).HasMaxLength(50);

                entity.Property(e => e.SupplierId).HasColumnName("Supplier_Id");

                entity.HasOne(d => d.Stock)
                    .WithMany(p => p.PurchaseItem)
                    .HasForeignKey(d => d.StockId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductPurchase_Item");
            });

            modelBuilder.Entity<PurchaseOrder>(entity =>
            {
                entity.Property(e => e.InvoiceNo).HasMaxLength(50);

                entity.Property(e => e.OrderDate).HasColumnType("date");

                entity.Property(e => e.OrderStatus)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ReceivedDate).HasColumnType("date");
            });

            modelBuilder.Entity<PurchaseReturn>(entity =>
            {
                entity.Property(e => e.RefNo).HasMaxLength(50);

                entity.Property(e => e.Remark).HasMaxLength(50);

                entity.Property(e => e.ReturnDate).HasColumnType("date");

                entity.Property(e => e.Status).HasMaxLength(50);
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<RolePrivilege>(entity =>
            {
                entity.ToTable("Role_Privilege");

                entity.Property(e => e.PrivilegeId).HasColumnName("Privilege_Id");

                entity.Property(e => e.RoleId).HasColumnName("Role_Id");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.RolePrivilege)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_Role_Privilege_Role");
            });

            modelBuilder.Entity<SaleOrder>(entity =>
            {
                entity.Property(e => e.InvoiceNo)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.OrderDate).HasColumnType("date");

                entity.Property(e => e.OrderStatus).HasMaxLength(15);

                entity.Property(e => e.SaleDate).HasColumnType("date");

                entity.Property(e => e.SaleStatus)
                    .HasColumnName("Sale_Status")
                    .HasMaxLength(50);

                entity.Property(e => e.SaleType).HasMaxLength(50);
            });

            modelBuilder.Entity<SaleReturn>(entity =>
            {
                entity.Property(e => e.CustomerName).HasMaxLength(50);

                entity.Property(e => e.Remark).HasMaxLength(50);

                entity.Property(e => e.ReturnDate).HasColumnType("date");

                entity.Property(e => e.SellPrice).HasColumnName("Sell_Price");

                entity.Property(e => e.VoucherNo).HasMaxLength(50);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.SaleReturn)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SaleReturn_LoginUser");
            });

            modelBuilder.Entity<ServiceItem>(entity =>
            {
                entity.Property(e => e.Barcode).HasMaxLength(50);
            });

            modelBuilder.Entity<Setting>(entity =>
            {
                entity.Property(e => e.BackupPath).HasMaxLength(50);

                entity.Property(e => e.CloseTime).HasMaxLength(15);

                entity.Property(e => e.Contact).HasMaxLength(50);

                entity.Property(e => e.Crcode)
                    .HasColumnName("CRCode")
                    .HasMaxLength(15);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.InvoiceNo).HasMaxLength(3);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.OpenTime).HasMaxLength(15);

                entity.Property(e => e.QuotationNo).HasMaxLength(3);

                entity.Property(e => e.VoucherNo).HasMaxLength(3);
            });

            modelBuilder.Entity<Sku>(entity =>
            {
                entity.Property(e => e.Name).HasMaxLength(50);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Sku)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_Sku_Categories");
            });

            modelBuilder.Entity<SoldItem>(entity =>
            {
                entity.ToTable("Sold_Item");

                entity.HasIndex(e => e.StockId)
                    .HasName("IX_FK_StockSold_Item");

                entity.Property(e => e.SellDate)
                    .HasColumnName("Sell_Date")
                    .HasColumnType("date");

                entity.Property(e => e.Status).HasMaxLength(10);

                entity.HasOne(d => d.Stock)
                    .WithMany(p => p.SoldItem)
                    .HasForeignKey(d => d.StockId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StockSold_Item");
            });

            modelBuilder.Entity<SoldServiceItem>(entity =>
            {
                entity.ToTable("Sold_ServiceItem");

                entity.Property(e => e.SellDate)
                    .HasColumnName("Sell_Date")
                    .HasColumnType("date");

                entity.Property(e => e.Status).HasMaxLength(10);
            });

            modelBuilder.Entity<SorderProduct>(entity =>
            {
                entity.ToTable("SOrder_Product");

                entity.HasOne(d => d.Stock)
                    .WithMany(p => p.SorderProduct)
                    .HasForeignKey(d => d.StockId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SOrder_Product_SOrder_Product");
            });

            modelBuilder.Entity<StockAdjust>(entity =>
            {
                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.Reason).HasMaxLength(255);
            });

            modelBuilder.Entity<StockLoss>(entity =>
            {
                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.Remark).HasMaxLength(255);

                entity.HasOne(d => d.Stock)
                    .WithMany(p => p.StockLoss)
                    .HasForeignKey(d => d.StockId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StockLoss_Stocks");
            });

            modelBuilder.Entity<Stocks>(entity =>
            {
                entity.HasIndex(e => e.ProductId)
                    .HasName("IX_FK_ProductStock");

                entity.Property(e => e.Barcode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.BulkSellPrice).HasColumnName("BulkSell_Price");

                entity.Property(e => e.FromDate).HasColumnType("date");

                entity.Property(e => e.PurchasePrice).HasColumnName("Purchase_Price");

                entity.Property(e => e.SellPrice).HasColumnName("Sell_Price");

                entity.Property(e => e.ToDate).HasColumnType("date");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.Stocks)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductStock");
            });

            modelBuilder.Entity<Subcategories>(entity =>
            {
                entity.HasIndex(e => e.CategoryId)
                    .HasName("IX_FK_CategorySubcategory");

                entity.Property(e => e.Name).IsRequired();

                entity.Property(e => e.Unit).HasMaxLength(20);
            });

            modelBuilder.Entity<Supplier>(entity =>
            {
                entity.Property(e => e.Company).HasMaxLength(50);

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Phone).HasMaxLength(15);

                entity.Property(e => e.SupplierNo).HasMaxLength(50);
            });
        }
    }
}
