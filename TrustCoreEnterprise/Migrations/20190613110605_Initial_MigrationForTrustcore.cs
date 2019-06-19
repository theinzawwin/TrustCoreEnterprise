using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TrustCoreEnterprise.Migrations
{
    public partial class Initial_MigrationForTrustcore : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AccountType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 50, nullable: true),
                    Description = table.Column<string>(maxLength: 50, nullable: true),
                    Status = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AssetDep",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AssetId = table.Column<int>(nullable: false),
                    DepDate = table.Column<DateTime>(type: "date", nullable: true),
                    DepPercent = table.Column<double>(nullable: true),
                    DepAmount = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssetDep", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    Description = table.Column<string>(maxLength: 50, nullable: true),
                    Code = table.Column<string>(maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    Nrc = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Occupation = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    CRCode = table.Column<string>(maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ExpenseCategory",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 50, nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExpenseCategory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Finance",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Account_Id = table.Column<int>(nullable: true),
                    Customer_Id = table.Column<int>(nullable: true),
                    Pay_Account_Id = table.Column<int>(nullable: true),
                    TotalAmount = table.Column<double>(nullable: true),
                    RemainAmount = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Finance", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GrossSummary",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 50, nullable: true),
                    Debit = table.Column<double>(nullable: true),
                    Credit = table.Column<double>(nullable: true),
                    Date = table.Column<DateTime>(type: "date", nullable: true),
                    Status = table.Column<string>(maxLength: 50, nullable: true),
                    TitleId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GrossSummary", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GrossTitle",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 100, nullable: true),
                    FromDate = table.Column<DateTime>(type: "date", nullable: true),
                    ToDate = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GrossTitle", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "IncomeCategory",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 50, nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IncomeCategory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Location",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 50, nullable: true),
                    Description = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Location", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pay_Supplier",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SupAccountId = table.Column<int>(nullable: true),
                    Pay_Date = table.Column<DateTime>(type: "date", nullable: true),
                    PayAmount = table.Column<double>(nullable: true),
                    TotalAmount = table.Column<double>(nullable: true),
                    RemainAmount = table.Column<double>(nullable: true),
                    Remark = table.Column<string>(maxLength: 50, nullable: true),
                    UserId = table.Column<int>(nullable: true),
                    SysDate = table.Column<DateTime>(type: "date", nullable: true),
                    PurchaseCredit_Id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pay_Supplier", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Privilege",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Privilege_Name = table.Column<string>(maxLength: 50, nullable: true),
                    Privilege_ShortName = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Privilege", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    Barcode = table.Column<string>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false),
                    Date = table.Column<DateTime>(type: "date", nullable: true),
                    SubcategoryId = table.Column<int>(nullable: true),
                    Sku = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProfitLoss",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Debit = table.Column<double>(nullable: true),
                    Credit = table.Column<double>(nullable: true),
                    FromDate = table.Column<DateTime>(type: "date", nullable: true),
                    ToDate = table.Column<DateTime>(type: "date", nullable: true),
                    Name = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProfitLoss", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Promotion",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 255, nullable: true),
                    StartDate = table.Column<DateTime>(type: "date", nullable: true),
                    EndDate = table.Column<DateTime>(type: "date", nullable: true),
                    Description = table.Column<string>(nullable: true),
                    SysDate = table.Column<DateTime>(type: "date", nullable: true),
                    Status = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Promotion", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Purchase_Invoice",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RefNo = table.Column<string>(maxLength: 50, nullable: true),
                    TotalAmount = table.Column<double>(nullable: false),
                    DiscountAmount = table.Column<double>(nullable: true),
                    NetTotal_Amount = table.Column<double>(nullable: false),
                    PayAmount = table.Column<double>(nullable: true),
                    RemainAmount = table.Column<double>(nullable: true),
                    Remark = table.Column<string>(nullable: true),
                    Supplier_Id = table.Column<int>(nullable: true),
                    UserId = table.Column<int>(nullable: true),
                    PurchaseDate = table.Column<DateTime>(type: "date", nullable: true),
                    SysDate = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Purchase_Invoice", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PurchaseOrder",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    InvoiceNo = table.Column<string>(maxLength: 50, nullable: true),
                    OrderDate = table.Column<DateTime>(type: "date", nullable: true),
                    SupplierId = table.Column<int>(nullable: false),
                    OrderStatus = table.Column<string>(maxLength: 50, nullable: false),
                    ReceivedDate = table.Column<DateTime>(type: "date", nullable: true),
                    Address = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseOrder", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PurchaseReturn",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    StockId = table.Column<int>(nullable: true),
                    Quantity = table.Column<int>(nullable: true),
                    PurchasePrice = table.Column<double>(nullable: true),
                    Remark = table.Column<string>(maxLength: 50, nullable: true),
                    TotalPurchasePrice = table.Column<double>(nullable: true),
                    Status = table.Column<string>(maxLength: 50, nullable: true),
                    ReturnDate = table.Column<DateTime>(type: "date", nullable: true),
                    UserId = table.Column<int>(nullable: true),
                    RefNo = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseReturn", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RestTable",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    Person = table.Column<string>(nullable: true),
                    Available = table.Column<bool>(nullable: false),
                    Status = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RestTable", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SaleOrder",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    InvoiceNo = table.Column<string>(maxLength: 50, nullable: false),
                    OrderDate = table.Column<DateTime>(type: "date", nullable: true),
                    CustomerId = table.Column<int>(nullable: true),
                    OrderStatus = table.Column<string>(maxLength: 15, nullable: true),
                    SaleDate = table.Column<DateTime>(type: "date", nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Status = table.Column<bool>(nullable: true),
                    SaleType = table.Column<string>(maxLength: 50, nullable: true),
                    Sale_Status = table.Column<string>(maxLength: 50, nullable: true),
                    DiscountPercent = table.Column<double>(nullable: true),
                    DiscountAmount = table.Column<double>(nullable: true),
                    UserId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SaleOrder", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ServiceCategory",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceCategory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ServiceItem",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Amount = table.Column<double>(nullable: true),
                    ServiceCategoryId = table.Column<int>(nullable: true),
                    Barcode = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceItem", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Setting",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 50, nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Contact = table.Column<string>(maxLength: 50, nullable: true),
                    OpenTime = table.Column<string>(maxLength: 15, nullable: true),
                    CloseTime = table.Column<string>(maxLength: 15, nullable: true),
                    VoucherNo = table.Column<string>(maxLength: 3, nullable: true),
                    BackupPath = table.Column<string>(maxLength: 50, nullable: true),
                    CRCode = table.Column<string>(maxLength: 15, nullable: true),
                    Tax = table.Column<double>(nullable: true),
                    Email = table.Column<string>(maxLength: 50, nullable: true),
                    InvoiceNo = table.Column<string>(maxLength: 3, nullable: true),
                    QuotationNo = table.Column<string>(maxLength: 3, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Setting", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sold_ServiceItem",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ServiceId = table.Column<int>(nullable: true),
                    UnitPrice = table.Column<double>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    Sell_Date = table.Column<DateTime>(type: "date", nullable: false),
                    TotalAmount = table.Column<double>(nullable: false),
                    BillId = table.Column<int>(nullable: false),
                    NetAmount = table.Column<double>(nullable: true),
                    Status = table.Column<string>(maxLength: 10, nullable: true),
                    DiscountAmount = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sold_ServiceItem", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StockAdjust",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    StockId = table.Column<int>(nullable: false),
                    AdjustQuantity = table.Column<int>(nullable: true),
                    Reason = table.Column<string>(maxLength: 255, nullable: true),
                    UserId = table.Column<int>(nullable: true),
                    Date = table.Column<DateTime>(type: "date", nullable: true),
                    HandQuantity = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockAdjust", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Subcategories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false),
                    Unit = table.Column<string>(maxLength: 20, nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subcategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Supplier",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 50, nullable: true),
                    Phone = table.Column<string>(maxLength: 15, nullable: true),
                    Address = table.Column<string>(nullable: true),
                    SupplierNo = table.Column<string>(maxLength: 50, nullable: true),
                    Company = table.Column<string>(maxLength: 50, nullable: true),
                    Email = table.Column<string>(maxLength: 50, nullable: true),
                    Date = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Supplier", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TargetDiscount",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TargetAmount = table.Column<double>(nullable: true),
                    Status = table.Column<int>(nullable: true),
                    DiscountAmount = table.Column<double>(nullable: true),
                    ProId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TargetDiscount", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Account",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 50, nullable: true),
                    AccountTypeId = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Account", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Account_AccountType",
                        column: x => x.AccountTypeId,
                        principalTable: "AccountType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Sku",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CategoryId = table.Column<int>(nullable: true),
                    Name = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sku", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sku_Categories",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Customer_Account",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Open_Date = table.Column<DateTime>(type: "date", nullable: true),
                    Customer_Id = table.Column<int>(nullable: true),
                    TotalAmount = table.Column<double>(nullable: true),
                    Date = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer_Account", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Customer_Account_Customers",
                        column: x => x.Customer_Id,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Expense",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 50, nullable: true),
                    Description = table.Column<string>(maxLength: 50, nullable: true),
                    Amount = table.Column<double>(nullable: true),
                    ExpenseDate = table.Column<DateTime>(type: "date", nullable: true),
                    SysDate = table.Column<DateTime>(type: "date", nullable: true),
                    ExpenseCategoryId = table.Column<int>(nullable: false),
                    Status = table.Column<string>(maxLength: 10, nullable: true),
                    UserId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Expense", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Expense_ExpenseCategory",
                        column: x => x.ExpenseCategoryId,
                        principalTable: "ExpenseCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Income",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 255, nullable: true),
                    Amount = table.Column<double>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    IncomeDate = table.Column<DateTime>(type: "date", nullable: true),
                    SysDate = table.Column<DateTime>(type: "date", nullable: true),
                    IncomeCatId = table.Column<int>(nullable: true),
                    UserId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Income", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Income_IncomeCategory",
                        column: x => x.IncomeCatId,
                        principalTable: "IncomeCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Stocks",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Barcode = table.Column<string>(maxLength: 50, nullable: false),
                    Purchase_Price = table.Column<double>(nullable: true),
                    Sell_Price = table.Column<double>(nullable: true),
                    Quantity = table.Column<int>(nullable: true),
                    ProductId = table.Column<int>(nullable: false),
                    Discount = table.Column<int>(nullable: true),
                    FromDate = table.Column<DateTime>(type: "date", nullable: true),
                    ToDate = table.Column<DateTime>(type: "date", nullable: true),
                    BulkSell_Price = table.Column<double>(nullable: true),
                    BulkQuantity = table.Column<int>(nullable: true),
                    MinimumQuantity = table.Column<int>(nullable: true),
                    RetFormula = table.Column<int>(nullable: true),
                    RetAmount = table.Column<double>(nullable: true),
                    BulkFormula = table.Column<int>(nullable: true),
                    BulkAmount = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stocks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductStock",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FocHead",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ProId = table.Column<int>(nullable: true),
                    Status = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FocHead", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FocHead_Promotion",
                        column: x => x.ProId,
                        principalTable: "Promotion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ItemDiscount",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    StockId = table.Column<int>(nullable: true),
                    Status = table.Column<int>(nullable: true),
                    DiscountAmount = table.Column<double>(nullable: true),
                    ProId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemDiscount", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Promotion",
                        column: x => x.ProId,
                        principalTable: "Promotion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "POrder_Product",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    StockId = table.Column<int>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    Price = table.Column<double>(nullable: false),
                    TotalAmount = table.Column<double>(nullable: false),
                    OrderId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_POrder_Product", x => x.Id);
                    table.ForeignKey(
                        name: "FK_POrder_Product_PurchaseOrder",
                        column: x => x.OrderId,
                        principalTable: "PurchaseOrder",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LoginUser",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserName = table.Column<string>(maxLength: 50, nullable: true),
                    Password = table.Column<string>(maxLength: 50, nullable: false),
                    Role_Id = table.Column<int>(nullable: true),
                    Status = table.Column<bool>(nullable: true),
                    DelStatus = table.Column<string>(maxLength: 15, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoginUser", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LoginUser_Role",
                        column: x => x.Role_Id,
                        principalTable: "Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Role_Privilege",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Role_Id = table.Column<int>(nullable: true),
                    Privilege_Id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role_Privilege", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Role_Privilege_Role",
                        column: x => x.Role_Id,
                        principalTable: "Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Debit_Supplier",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Supplier_Id = table.Column<int>(nullable: true),
                    Amount = table.Column<double>(nullable: true),
                    Date = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Debit_Supplier", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Debit_Supplier_Supplier",
                        column: x => x.Supplier_Id,
                        principalTable: "Supplier",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Asset",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AccountId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: true),
                    Debit = table.Column<double>(nullable: true),
                    PurchaseDate = table.Column<DateTime>(type: "date", nullable: true),
                    Status = table.Column<bool>(nullable: true),
                    Description = table.Column<string>(maxLength: 255, nullable: true),
                    Credit = table.Column<double>(nullable: true),
                    AccountStatus = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Asset", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Asset_Account",
                        column: x => x.AccountId,
                        principalTable: "Account",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Journal",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AccountId = table.Column<int>(nullable: true),
                    Debit = table.Column<double>(nullable: true),
                    Credit = table.Column<double>(nullable: true),
                    CreateDate = table.Column<DateTime>(type: "date", nullable: true),
                    JournalDate = table.Column<DateTime>(type: "date", nullable: true),
                    AccountStatus = table.Column<string>(maxLength: 50, nullable: true),
                    RefId = table.Column<int>(nullable: true),
                    Description = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Journal", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Journal_Account",
                        column: x => x.AccountId,
                        principalTable: "Account",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Purchase_Item",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Quantity = table.Column<int>(nullable: false),
                    Purchase_Price = table.Column<double>(nullable: false),
                    StockId = table.Column<int>(nullable: false),
                    TotalAmount = table.Column<double>(nullable: true),
                    Purchase_Date = table.Column<DateTime>(type: "datetime", nullable: true),
                    Supplier_Id = table.Column<int>(nullable: true),
                    PayAmount = table.Column<double>(nullable: true),
                    RemainAmount = table.Column<double>(nullable: true),
                    UserId = table.Column<int>(nullable: true),
                    RefNo = table.Column<string>(maxLength: 50, nullable: true),
                    PurchaseInvoiceId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Purchase_Item", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductPurchase_Item",
                        column: x => x.StockId,
                        principalTable: "Stocks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Sold_Item",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    StockId = table.Column<int>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    UnitPrice = table.Column<double>(nullable: false),
                    TotalAmount = table.Column<double>(nullable: false),
                    Sell_Date = table.Column<DateTime>(type: "date", nullable: false),
                    DebtId = table.Column<int>(nullable: true),
                    BillId = table.Column<int>(nullable: true),
                    DiscountAmount = table.Column<double>(nullable: true),
                    NetAmount = table.Column<double>(nullable: true),
                    Status = table.Column<string>(maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sold_Item", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StockSold_Item",
                        column: x => x.StockId,
                        principalTable: "Stocks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SOrder_Product",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    StockId = table.Column<int>(nullable: false),
                    Quantity = table.Column<int>(nullable: true),
                    Price = table.Column<double>(nullable: true),
                    TotalAmount = table.Column<double>(nullable: true),
                    OrderId = table.Column<int>(nullable: false),
                    NetAmount = table.Column<double>(nullable: true),
                    Discount = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SOrder_Product", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SOrder_Product_SOrder_Product",
                        column: x => x.StockId,
                        principalTable: "Stocks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StockLoss",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    StockId = table.Column<int>(nullable: false),
                    LossQuantity = table.Column<int>(nullable: false),
                    PurchasePrice = table.Column<double>(nullable: false),
                    Remark = table.Column<string>(maxLength: 255, nullable: true),
                    UserId = table.Column<int>(nullable: false),
                    TotalQuantity = table.Column<int>(nullable: true),
                    TotalAmount = table.Column<double>(nullable: true),
                    Date = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockLoss", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StockLoss_Stocks",
                        column: x => x.StockId,
                        principalTable: "Stocks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FocPay",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FocId = table.Column<int>(nullable: true),
                    StockId = table.Column<int>(nullable: true),
                    Qty = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FocPay", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FocPay_FocHead",
                        column: x => x.FocId,
                        principalTable: "FocHead",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FocSell",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FocId = table.Column<int>(nullable: true),
                    StockId = table.Column<int>(nullable: true),
                    Qty = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FocSell", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FocSell_FocHead",
                        column: x => x.FocId,
                        principalTable: "FocHead",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Bills",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Bill_Date = table.Column<DateTime>(type: "date", nullable: false),
                    Total_Amount = table.Column<double>(nullable: false),
                    Discount_Amount = table.Column<double>(nullable: false),
                    Tax_Amount = table.Column<double>(nullable: false),
                    Pay_Amount = table.Column<double>(nullable: false),
                    Remain_Amount = table.Column<double>(nullable: false),
                    Customer_Id = table.Column<int>(nullable: true),
                    Refund_Amount = table.Column<double>(nullable: true),
                    VoucherNo = table.Column<string>(maxLength: 50, nullable: true),
                    Bill_Time = table.Column<string>(maxLength: 15, nullable: true),
                    CashierId = table.Column<int>(nullable: false),
                    SubTotal_Amount = table.Column<double>(nullable: true),
                    NetTotal_Amount = table.Column<double>(nullable: true),
                    Sale_Status = table.Column<string>(maxLength: 20, nullable: true),
                    VoucherDisPercent = table.Column<double>(nullable: true),
                    VoucherDisAmount = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bills", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bills_LoginUser",
                        column: x => x.CashierId,
                        principalTable: "LoginUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SaleReturn",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    VoucherNo = table.Column<string>(maxLength: 50, nullable: true),
                    StockId = table.Column<int>(nullable: true),
                    Sell_Price = table.Column<double>(nullable: true),
                    Quantity = table.Column<int>(nullable: true),
                    TotalAmount = table.Column<double>(nullable: false),
                    Remark = table.Column<string>(maxLength: 50, nullable: true),
                    UserId = table.Column<int>(nullable: false),
                    ReturnDate = table.Column<DateTime>(type: "date", nullable: true),
                    CustomerName = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SaleReturn", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SaleReturn_LoginUser",
                        column: x => x.UserId,
                        principalTable: "LoginUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Purchase_Credit",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SupplierAccount_Id = table.Column<int>(nullable: false),
                    Date = table.Column<DateTime>(type: "date", nullable: true),
                    Credit_Amount = table.Column<double>(nullable: true),
                    PurchaseInvoice_Id = table.Column<int>(nullable: true),
                    Status = table.Column<string>(maxLength: 10, nullable: true),
                    Remain_Amount = table.Column<double>(nullable: true),
                    SysDate = table.Column<DateTime>(type: "date", nullable: true),
                    UserId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Purchase_Credit", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Debit_Supplier_Account_Id",
                        column: x => x.SupplierAccount_Id,
                        principalTable: "Debit_Supplier",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Debit_Account",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Account_Id = table.Column<int>(nullable: true),
                    Debit_Date = table.Column<DateTime>(type: "date", nullable: false),
                    Debit_Amount = table.Column<double>(nullable: true),
                    BillId = table.Column<int>(nullable: true),
                    Status = table.Column<string>(maxLength: 10, nullable: true),
                    Remain_Amount = table.Column<double>(nullable: true),
                    SysDate = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Debit_Account", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Debit_Account_Bills",
                        column: x => x.BillId,
                        principalTable: "Bills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Pay_Account",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Account_Id = table.Column<int>(nullable: true),
                    Pay_Date = table.Column<DateTime>(type: "date", nullable: true),
                    PayAmount = table.Column<double>(nullable: true),
                    TotalAmount = table.Column<double>(nullable: true),
                    RemainAmount = table.Column<double>(nullable: true),
                    UserId = table.Column<int>(nullable: true),
                    DebitAccount_Id = table.Column<int>(nullable: true),
                    SysDate = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pay_Account", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pay_Account_Pay_Account",
                        column: x => x.Account_Id,
                        principalTable: "Customer_Account",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "Debit_Account_Id",
                        column: x => x.DebitAccount_Id,
                        principalTable: "Debit_Account",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Account_AccountTypeId",
                table: "Account",
                column: "AccountTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Asset_AccountId",
                table: "Asset",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Bills_CashierId",
                table: "Bills",
                column: "CashierId");

            migrationBuilder.CreateIndex(
                name: "IX_Customer_Account_Customer_Id",
                table: "Customer_Account",
                column: "Customer_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Debit_Account_BillId",
                table: "Debit_Account",
                column: "BillId");

            migrationBuilder.CreateIndex(
                name: "IX_Debit_Supplier_Supplier_Id",
                table: "Debit_Supplier",
                column: "Supplier_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Expense_ExpenseCategoryId",
                table: "Expense",
                column: "ExpenseCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_FocHead_ProId",
                table: "FocHead",
                column: "ProId");

            migrationBuilder.CreateIndex(
                name: "IX_FocPay_FocId",
                table: "FocPay",
                column: "FocId");

            migrationBuilder.CreateIndex(
                name: "IX_FocSell_FocId",
                table: "FocSell",
                column: "FocId");

            migrationBuilder.CreateIndex(
                name: "IX_Income_IncomeCatId",
                table: "Income",
                column: "IncomeCatId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemDiscount_ProId",
                table: "ItemDiscount",
                column: "ProId");

            migrationBuilder.CreateIndex(
                name: "IX_Journal_AccountId",
                table: "Journal",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_LoginUser_Role_Id",
                table: "LoginUser",
                column: "Role_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Pay_Account_Account_Id",
                table: "Pay_Account",
                column: "Account_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Pay_Account_DebitAccount_Id",
                table: "Pay_Account",
                column: "DebitAccount_Id");

            migrationBuilder.CreateIndex(
                name: "IX_POrder_Product_OrderId",
                table: "POrder_Product",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_FK_ProductSubcategory",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Purchase_Credit_SupplierAccount_Id",
                table: "Purchase_Credit",
                column: "SupplierAccount_Id");

            migrationBuilder.CreateIndex(
                name: "IX_FK_ProductPurchase_Item",
                table: "Purchase_Item",
                column: "StockId");

            migrationBuilder.CreateIndex(
                name: "IX_Role_Privilege_Role_Id",
                table: "Role_Privilege",
                column: "Role_Id");

            migrationBuilder.CreateIndex(
                name: "IX_SaleReturn_UserId",
                table: "SaleReturn",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Sku_CategoryId",
                table: "Sku",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_FK_StockSold_Item",
                table: "Sold_Item",
                column: "StockId");

            migrationBuilder.CreateIndex(
                name: "IX_SOrder_Product_StockId",
                table: "SOrder_Product",
                column: "StockId");

            migrationBuilder.CreateIndex(
                name: "IX_StockLoss_StockId",
                table: "StockLoss",
                column: "StockId");

            migrationBuilder.CreateIndex(
                name: "IX_FK_ProductStock",
                table: "Stocks",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_FK_CategorySubcategory",
                table: "Subcategories",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Asset");

            migrationBuilder.DropTable(
                name: "AssetDep");

            migrationBuilder.DropTable(
                name: "Expense");

            migrationBuilder.DropTable(
                name: "Finance");

            migrationBuilder.DropTable(
                name: "FocPay");

            migrationBuilder.DropTable(
                name: "FocSell");

            migrationBuilder.DropTable(
                name: "GrossSummary");

            migrationBuilder.DropTable(
                name: "GrossTitle");

            migrationBuilder.DropTable(
                name: "Income");

            migrationBuilder.DropTable(
                name: "ItemDiscount");

            migrationBuilder.DropTable(
                name: "Journal");

            migrationBuilder.DropTable(
                name: "Location");

            migrationBuilder.DropTable(
                name: "Pay_Account");

            migrationBuilder.DropTable(
                name: "Pay_Supplier");

            migrationBuilder.DropTable(
                name: "POrder_Product");

            migrationBuilder.DropTable(
                name: "Privilege");

            migrationBuilder.DropTable(
                name: "ProfitLoss");

            migrationBuilder.DropTable(
                name: "Purchase_Credit");

            migrationBuilder.DropTable(
                name: "Purchase_Invoice");

            migrationBuilder.DropTable(
                name: "Purchase_Item");

            migrationBuilder.DropTable(
                name: "PurchaseReturn");

            migrationBuilder.DropTable(
                name: "RestTable");

            migrationBuilder.DropTable(
                name: "Role_Privilege");

            migrationBuilder.DropTable(
                name: "SaleOrder");

            migrationBuilder.DropTable(
                name: "SaleReturn");

            migrationBuilder.DropTable(
                name: "ServiceCategory");

            migrationBuilder.DropTable(
                name: "ServiceItem");

            migrationBuilder.DropTable(
                name: "Setting");

            migrationBuilder.DropTable(
                name: "Sku");

            migrationBuilder.DropTable(
                name: "Sold_Item");

            migrationBuilder.DropTable(
                name: "Sold_ServiceItem");

            migrationBuilder.DropTable(
                name: "SOrder_Product");

            migrationBuilder.DropTable(
                name: "StockAdjust");

            migrationBuilder.DropTable(
                name: "StockLoss");

            migrationBuilder.DropTable(
                name: "Subcategories");

            migrationBuilder.DropTable(
                name: "TargetDiscount");

            migrationBuilder.DropTable(
                name: "ExpenseCategory");

            migrationBuilder.DropTable(
                name: "FocHead");

            migrationBuilder.DropTable(
                name: "IncomeCategory");

            migrationBuilder.DropTable(
                name: "Account");

            migrationBuilder.DropTable(
                name: "Customer_Account");

            migrationBuilder.DropTable(
                name: "Debit_Account");

            migrationBuilder.DropTable(
                name: "PurchaseOrder");

            migrationBuilder.DropTable(
                name: "Debit_Supplier");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Stocks");

            migrationBuilder.DropTable(
                name: "Promotion");

            migrationBuilder.DropTable(
                name: "AccountType");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Bills");

            migrationBuilder.DropTable(
                name: "Supplier");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "LoginUser");

            migrationBuilder.DropTable(
                name: "Role");
        }
    }
}
