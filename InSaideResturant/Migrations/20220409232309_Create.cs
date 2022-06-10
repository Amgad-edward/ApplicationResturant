using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InSaideResturant.Migrations
{
    public partial class Create : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "customer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Phone = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Address = table.Column<string>(type: "varchar(130)", maxLength: 130, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Password = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_customer", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "restaurantandbranches",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NameAndBranch = table.Column<string>(type: "varchar(70)", maxLength: 70, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Address = table.Column<string>(type: "varchar(130)", maxLength: 130, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LocationCode = table.Column<string>(type: "varchar(101)", maxLength: 101, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Phones = table.Column<string>(type: "varchar(101)", maxLength: 101, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Photo = table.Column<byte[]>(type: "longblob", maxLength: 10000000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_restaurantandbranches", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "supplier",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NameSupplier = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Phones = table.Column<string>(type: "varchar(77)", maxLength: 77, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_supplier", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "weightproduct",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NameBig = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NameSmall = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CountSamll = table.Column<double>(type: "double", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_weightproduct", x => x.ID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "area",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NameArea = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Idresetaurant = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_area", x => x.id);
                    table.ForeignKey(
                        name: "FK_area_restaurantandbranches_Idresetaurant",
                        column: x => x.Idresetaurant,
                        principalTable: "restaurantandbranches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "categoryfood",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(70)", maxLength: 70, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Idresetaurant = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_categoryfood", x => x.Id);
                    table.ForeignKey(
                        name: "FK_categoryfood_restaurantandbranches_Idresetaurant",
                        column: x => x.Idresetaurant,
                        principalTable: "restaurantandbranches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "emplyees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Jop = table.Column<string>(type: "varchar(75)", maxLength: 75, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SalaryHour = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    DateBirth = table.Column<DateOnly>(type: "date", nullable: true),
                    DatestartWork = table.Column<DateOnly>(type: "date", nullable: true),
                    Idresetaurant = table.Column<int>(type: "int", nullable: false),
                    Weekend = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_emplyees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_emplyees_restaurantandbranches_Idresetaurant",
                        column: x => x.Idresetaurant,
                        principalTable: "restaurantandbranches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "reservation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Idresetaurant = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateOnly>(type: "date", nullable: false),
                    Timestart = table.Column<TimeOnly>(type: "time(0)", nullable: true),
                    TimeEnd = table.Column<TimeOnly>(type: "time(0)", nullable: true),
                    CustomerId = table.Column<int>(type: "int", nullable: true),
                    ISDone = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_reservation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_reservation_customer_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "customer",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_reservation_restaurantandbranches_Idresetaurant",
                        column: x => x.Idresetaurant,
                        principalTable: "restaurantandbranches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "receipt",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CodeNumber = table.Column<string>(type: "varchar(27)", maxLength: 27, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Date = table.Column<DateOnly>(type: "date", nullable: false),
                    Idrestourant = table.Column<int>(type: "int", nullable: false),
                    Idsupplier = table.Column<int>(type: "int", nullable: false),
                    Discount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_receipt", x => x.Id);
                    table.ForeignKey(
                        name: "FK_receipt_restaurantandbranches_Idrestourant",
                        column: x => x.Idrestourant,
                        principalTable: "restaurantandbranches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_receipt_supplier_Idsupplier",
                        column: x => x.Idsupplier,
                        principalTable: "supplier",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "nameproduct",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    WeightId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_nameproduct", x => x.ID);
                    table.ForeignKey(
                        name: "FK_nameproduct_weightproduct_WeightId",
                        column: x => x.WeightId,
                        principalTable: "weightproduct",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "table",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    TableCode = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CountChair = table.Column<int>(type: "int", nullable: false),
                    IdArea = table.Column<int>(type: "int", nullable: false),
                    Idresetaurant = table.Column<int>(type: "int", nullable: false),
                    IsRreserved = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_table", x => x.Id);
                    table.ForeignKey(
                        name: "FK_table_area_IdArea",
                        column: x => x.IdArea,
                        principalTable: "area",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_table_restaurantandbranches_Idresetaurant",
                        column: x => x.Idresetaurant,
                        principalTable: "restaurantandbranches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "dishfood",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NameDish = table.Column<string>(type: "varchar(75)", maxLength: 75, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PriceBuy = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    Idweight = table.Column<int>(type: "int", nullable: false),
                    SubjectDetail = table.Column<string>(type: "varchar(130)", maxLength: 130, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Idcategory = table.Column<int>(type: "int", nullable: false),
                    Idresetaurant = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dishfood", x => x.Id);
                    table.ForeignKey(
                        name: "FK_dishfood_categoryfood_Idcategory",
                        column: x => x.Idcategory,
                        principalTable: "categoryfood",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_dishfood_restaurantandbranches_Idresetaurant",
                        column: x => x.Idresetaurant,
                        principalTable: "restaurantandbranches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_dishfood_weightproduct_Idweight",
                        column: x => x.Idweight,
                        principalTable: "weightproduct",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "delivery",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Idresetaurant = table.Column<int>(type: "int", nullable: false),
                    IdCustomer = table.Column<int>(type: "int", nullable: true),
                    Date = table.Column<DateOnly>(type: "date", nullable: false),
                    IdToEmplyee = table.Column<int>(type: "int", nullable: true),
                    ServicesDelivery = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    TotalPrice = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    IdEmpdelivery = table.Column<int>(type: "int", nullable: false),
                    EmplyeesDelvieryId = table.Column<int>(type: "int", nullable: true),
                    ISDone = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_delivery", x => x.Id);
                    table.ForeignKey(
                        name: "FK_delivery_customer_IdCustomer",
                        column: x => x.IdCustomer,
                        principalTable: "customer",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_delivery_emplyees_EmplyeesDelvieryId",
                        column: x => x.EmplyeesDelvieryId,
                        principalTable: "emplyees",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_delivery_restaurantandbranches_Idresetaurant",
                        column: x => x.Idresetaurant,
                        principalTable: "restaurantandbranches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "logins",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Username = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Password = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ISAdmin = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IdEmplyee = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_logins", x => x.Id);
                    table.ForeignKey(
                        name: "FK_logins_emplyees_IdEmplyee",
                        column: x => x.IdEmplyee,
                        principalTable: "emplyees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "worktable",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdEmplyee = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateOnly>(type: "date", nullable: false),
                    TimePresence = table.Column<TimeOnly>(type: "Time", nullable: false),
                    TimeLeave = table.Column<TimeOnly>(type: "Time", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_worktable", x => x.Id);
                    table.ForeignKey(
                        name: "FK_worktable_emplyees_IdEmplyee",
                        column: x => x.IdEmplyee,
                        principalTable: "emplyees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "paymoney",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdReservation = table.Column<int>(type: "int", nullable: false),
                    PriceFood = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    PriceServecis = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    CodeReceipt = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    paymentBy = table.Column<int>(type: "int", nullable: false),
                    VisaCode = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ISpay = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Idresetaurant = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_paymoney", x => x.Id);
                    table.ForeignKey(
                        name: "FK_paymoney_reservation_IdReservation",
                        column: x => x.IdReservation,
                        principalTable: "reservation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_paymoney_restaurantandbranches_Idresetaurant",
                        column: x => x.Idresetaurant,
                        principalTable: "restaurantandbranches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "accountreceipt",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Idreceipt = table.Column<int>(type: "int", nullable: false),
                    Idrestaurant = table.Column<int>(type: "int", nullable: false),
                    MoneyPay = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    DatePay = table.Column<DateOnly>(type: "date", nullable: false),
                    NumberPay = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PaymentBy = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_accountreceipt", x => x.Id);
                    table.ForeignKey(
                        name: "FK_accountreceipt_receipt_Idreceipt",
                        column: x => x.Idreceipt,
                        principalTable: "receipt",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_accountreceipt_restaurantandbranches_Idrestaurant",
                        column: x => x.Idrestaurant,
                        principalTable: "restaurantandbranches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "barcode",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Code = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdNameProduct = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_barcode", x => x.Id);
                    table.ForeignKey(
                        name: "FK_barcode_nameproduct_IdNameProduct",
                        column: x => x.IdNameProduct,
                        principalTable: "nameproduct",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "product",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdNameProduct = table.Column<int>(type: "int", nullable: false),
                    TotalWeightIN = table.Column<double>(type: "double", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    DateExpired = table.Column<DateOnly>(type: "date", nullable: true),
                    Idresetaurant = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_product", x => x.Id);
                    table.ForeignKey(
                        name: "FK_product_nameproduct_IdNameProduct",
                        column: x => x.IdNameProduct,
                        principalTable: "nameproduct",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_product_restaurantandbranches_Idresetaurant",
                        column: x => x.Idresetaurant,
                        principalTable: "restaurantandbranches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "receiptitems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdReceipt = table.Column<int>(type: "int", nullable: false),
                    IdNameproduct = table.Column<int>(type: "int", nullable: false),
                    TotalWeights = table.Column<double>(type: "double", nullable: false),
                    PriceAll = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    DateExpierd = table.Column<DateOnly>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_receiptitems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_receiptitems_nameproduct_IdNameproduct",
                        column: x => x.IdNameproduct,
                        principalTable: "nameproduct",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_receiptitems_receipt_IdReceipt",
                        column: x => x.IdReceipt,
                        principalTable: "receipt",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "tablesreservation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdRevervation = table.Column<int>(type: "int", nullable: false),
                    IdTable = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tablesreservation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tablesreservation_reservation_IdRevervation",
                        column: x => x.IdRevervation,
                        principalTable: "reservation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tablesreservation_table_IdTable",
                        column: x => x.IdTable,
                        principalTable: "table",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "dishrequired",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdReservation = table.Column<int>(type: "int", nullable: false),
                    IdDish = table.Column<int>(type: "int", nullable: false),
                    IdDelivery = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dishrequired", x => x.Id);
                    table.ForeignKey(
                        name: "FK_dishrequired_delivery_IdDelivery",
                        column: x => x.IdDelivery,
                        principalTable: "delivery",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_dishrequired_dishfood_IdDish",
                        column: x => x.IdDish,
                        principalTable: "dishfood",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_dishrequired_reservation_IdReservation",
                        column: x => x.IdReservation,
                        principalTable: "reservation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "detailsdish",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdProduct = table.Column<int>(type: "int", nullable: false),
                    CountWeight = table.Column<double>(type: "double", nullable: false),
                    PriceExpensive = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    IdDishFood = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_detailsdish", x => x.Id);
                    table.ForeignKey(
                        name: "FK_detailsdish_dishfood_IdDishFood",
                        column: x => x.IdDishFood,
                        principalTable: "dishfood",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_detailsdish_product_IdProduct",
                        column: x => x.IdProduct,
                        principalTable: "product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_accountreceipt_Idreceipt",
                table: "accountreceipt",
                column: "Idreceipt");

            migrationBuilder.CreateIndex(
                name: "IX_accountreceipt_Idrestaurant",
                table: "accountreceipt",
                column: "Idrestaurant");

            migrationBuilder.CreateIndex(
                name: "IX_area_Idresetaurant",
                table: "area",
                column: "Idresetaurant");

            migrationBuilder.CreateIndex(
                name: "IX_barcode_IdNameProduct",
                table: "barcode",
                column: "IdNameProduct");

            migrationBuilder.CreateIndex(
                name: "IX_categoryfood_Idresetaurant",
                table: "categoryfood",
                column: "Idresetaurant");

            migrationBuilder.CreateIndex(
                name: "IX_delivery_EmplyeesDelvieryId",
                table: "delivery",
                column: "EmplyeesDelvieryId");

            migrationBuilder.CreateIndex(
                name: "IX_delivery_IdCustomer",
                table: "delivery",
                column: "IdCustomer");

            migrationBuilder.CreateIndex(
                name: "IX_delivery_Idresetaurant",
                table: "delivery",
                column: "Idresetaurant");

            migrationBuilder.CreateIndex(
                name: "IX_detailsdish_IdDishFood",
                table: "detailsdish",
                column: "IdDishFood");

            migrationBuilder.CreateIndex(
                name: "IX_detailsdish_IdProduct",
                table: "detailsdish",
                column: "IdProduct");

            migrationBuilder.CreateIndex(
                name: "IX_dishfood_Idcategory",
                table: "dishfood",
                column: "Idcategory");

            migrationBuilder.CreateIndex(
                name: "IX_dishfood_Idresetaurant",
                table: "dishfood",
                column: "Idresetaurant");

            migrationBuilder.CreateIndex(
                name: "IX_dishfood_Idweight",
                table: "dishfood",
                column: "Idweight");

            migrationBuilder.CreateIndex(
                name: "IX_dishrequired_IdDelivery",
                table: "dishrequired",
                column: "IdDelivery");

            migrationBuilder.CreateIndex(
                name: "IX_dishrequired_IdDish",
                table: "dishrequired",
                column: "IdDish");

            migrationBuilder.CreateIndex(
                name: "IX_dishrequired_IdReservation",
                table: "dishrequired",
                column: "IdReservation");

            migrationBuilder.CreateIndex(
                name: "IX_emplyees_Idresetaurant",
                table: "emplyees",
                column: "Idresetaurant");

            migrationBuilder.CreateIndex(
                name: "IX_logins_IdEmplyee",
                table: "logins",
                column: "IdEmplyee");

            migrationBuilder.CreateIndex(
                name: "IX_nameproduct_WeightId",
                table: "nameproduct",
                column: "WeightId");

            migrationBuilder.CreateIndex(
                name: "IX_paymoney_IdReservation",
                table: "paymoney",
                column: "IdReservation");

            migrationBuilder.CreateIndex(
                name: "IX_paymoney_Idresetaurant",
                table: "paymoney",
                column: "Idresetaurant");

            migrationBuilder.CreateIndex(
                name: "IX_product_IdNameProduct",
                table: "product",
                column: "IdNameProduct");

            migrationBuilder.CreateIndex(
                name: "IX_product_Idresetaurant",
                table: "product",
                column: "Idresetaurant");

            migrationBuilder.CreateIndex(
                name: "IX_receipt_Idrestourant",
                table: "receipt",
                column: "Idrestourant");

            migrationBuilder.CreateIndex(
                name: "IX_receipt_Idsupplier",
                table: "receipt",
                column: "Idsupplier");

            migrationBuilder.CreateIndex(
                name: "IX_receiptitems_IdNameproduct",
                table: "receiptitems",
                column: "IdNameproduct");

            migrationBuilder.CreateIndex(
                name: "IX_receiptitems_IdReceipt",
                table: "receiptitems",
                column: "IdReceipt");

            migrationBuilder.CreateIndex(
                name: "IX_reservation_CustomerId",
                table: "reservation",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_reservation_Idresetaurant",
                table: "reservation",
                column: "Idresetaurant");

            migrationBuilder.CreateIndex(
                name: "IX_table_IdArea",
                table: "table",
                column: "IdArea");

            migrationBuilder.CreateIndex(
                name: "IX_table_Idresetaurant",
                table: "table",
                column: "Idresetaurant");

            migrationBuilder.CreateIndex(
                name: "IX_tablesreservation_IdRevervation",
                table: "tablesreservation",
                column: "IdRevervation");

            migrationBuilder.CreateIndex(
                name: "IX_tablesreservation_IdTable",
                table: "tablesreservation",
                column: "IdTable");

            migrationBuilder.CreateIndex(
                name: "IX_worktable_IdEmplyee",
                table: "worktable",
                column: "IdEmplyee");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "accountreceipt");

            migrationBuilder.DropTable(
                name: "barcode");

            migrationBuilder.DropTable(
                name: "detailsdish");

            migrationBuilder.DropTable(
                name: "dishrequired");

            migrationBuilder.DropTable(
                name: "logins");

            migrationBuilder.DropTable(
                name: "paymoney");

            migrationBuilder.DropTable(
                name: "receiptitems");

            migrationBuilder.DropTable(
                name: "tablesreservation");

            migrationBuilder.DropTable(
                name: "worktable");

            migrationBuilder.DropTable(
                name: "product");

            migrationBuilder.DropTable(
                name: "delivery");

            migrationBuilder.DropTable(
                name: "dishfood");

            migrationBuilder.DropTable(
                name: "receipt");

            migrationBuilder.DropTable(
                name: "reservation");

            migrationBuilder.DropTable(
                name: "table");

            migrationBuilder.DropTable(
                name: "nameproduct");

            migrationBuilder.DropTable(
                name: "emplyees");

            migrationBuilder.DropTable(
                name: "categoryfood");

            migrationBuilder.DropTable(
                name: "supplier");

            migrationBuilder.DropTable(
                name: "customer");

            migrationBuilder.DropTable(
                name: "area");

            migrationBuilder.DropTable(
                name: "weightproduct");

            migrationBuilder.DropTable(
                name: "restaurantandbranches");
        }
    }
}
