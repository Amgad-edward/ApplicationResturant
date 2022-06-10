﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ModelData.Models;

#nullable disable

namespace InSaideResturant.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ModelData.Models.AccountReceipt", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateOnly>("DatePay")
                        .HasColumnType("date");

                    b.Property<int>("Idreceipt")
                        .HasColumnType("int");

                    b.Property<int>("Idrestaurant")
                        .HasColumnType("int");

                    b.Property<decimal>("MoneyPay")
                        .HasColumnType("decimal(65,30)");

                    b.Property<string>("NumberPay")
                        .HasColumnType("longtext");

                    b.Property<int>("PaymentBy")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Idreceipt");

                    b.HasIndex("Idrestaurant");

                    b.ToTable("accountreceipt");
                });

            modelBuilder.Entity("ModelData.Models.Area", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Idresetaurant")
                        .HasColumnType("int");

                    b.Property<string>("NameArea")
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)");

                    b.HasKey("id");

                    b.HasIndex("Idresetaurant");

                    b.ToTable("area");
                });

            modelBuilder.Entity("ModelData.Models.BarCode", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Code")
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)");

                    b.Property<int>("IdNameProduct")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdNameProduct");

                    b.ToTable("barcode");
                });

            modelBuilder.Entity("ModelData.Models.CategoryFood", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Idresetaurant")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasMaxLength(70)
                        .HasColumnType("varchar(70)");

                    b.HasKey("Id");

                    b.HasIndex("Idresetaurant");

                    b.ToTable("categoryfood");
                });

            modelBuilder.Entity("ModelData.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .HasMaxLength(130)
                        .HasColumnType("varchar(130)");

                    b.Property<string>("Name")
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)");

                    b.Property<string>("Password")
                        .HasColumnType("longtext");

                    b.Property<string>("Phone")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("customer");
                });

            modelBuilder.Entity("ModelData.Models.Delivery", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateOnly>("Date")
                        .HasColumnType("date");

                    b.Property<int?>("EmplyeesDelvieryId")
                        .HasColumnType("int");

                    b.Property<bool>("ISDone")
                        .HasColumnType("tinyint(1)");

                    b.Property<int?>("IdCustomer")
                        .HasColumnType("int");

                    b.Property<int>("IdEmpdelivery")
                        .HasColumnType("int");

                    b.Property<int?>("IdToEmplyee")
                        .HasColumnType("int");

                    b.Property<int>("Idresetaurant")
                        .HasColumnType("int");

                    b.Property<decimal>("ServicesDelivery")
                        .HasColumnType("decimal(65,30)");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("Id");

                    b.HasIndex("EmplyeesDelvieryId");

                    b.HasIndex("IdCustomer");

                    b.HasIndex("Idresetaurant");

                    b.ToTable("delivery");
                });

            modelBuilder.Entity("ModelData.Models.DetailsDish", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<double>("CountWeight")
                        .HasColumnType("double");

                    b.Property<int>("IdDishFood")
                        .HasColumnType("int");

                    b.Property<int>("IdProduct")
                        .HasColumnType("int");

                    b.Property<decimal>("PriceExpensive")
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("Id");

                    b.HasIndex("IdDishFood");

                    b.HasIndex("IdProduct");

                    b.ToTable("detailsdish");
                });

            modelBuilder.Entity("ModelData.Models.DishFood", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Idcategory")
                        .HasColumnType("int");

                    b.Property<int>("Idresetaurant")
                        .HasColumnType("int");

                    b.Property<int>("Idweight")
                        .HasColumnType("int");

                    b.Property<string>("NameDish")
                        .HasMaxLength(75)
                        .HasColumnType("varchar(75)");

                    b.Property<decimal>("PriceBuy")
                        .HasColumnType("decimal(65,30)");

                    b.Property<string>("SubjectDetail")
                        .HasMaxLength(130)
                        .HasColumnType("varchar(130)");

                    b.HasKey("Id");

                    b.HasIndex("Idcategory");

                    b.HasIndex("Idresetaurant");

                    b.HasIndex("Idweight");

                    b.ToTable("dishfood");
                });

            modelBuilder.Entity("ModelData.Models.DishRequired", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("ISDone")
                        .HasColumnType("tinyint(1)");

                    b.Property<int?>("IdDelivery")
                        .HasColumnType("int");

                    b.Property<int>("IdDish")
                        .HasColumnType("int");

                    b.Property<int>("IdReservation")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdDelivery");

                    b.HasIndex("IdDish");

                    b.HasIndex("IdReservation");

                    b.ToTable("dishrequired");
                });

            modelBuilder.Entity("ModelData.Models.Emplyees", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateOnly?>("DateBirth")
                        .HasColumnType("date");

                    b.Property<DateOnly?>("DatestartWork")
                        .HasColumnType("date");

                    b.Property<int>("Idresetaurant")
                        .HasColumnType("int");

                    b.Property<string>("Jop")
                        .IsRequired()
                        .HasMaxLength(75)
                        .HasColumnType("varchar(75)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)");

                    b.Property<decimal>("SalaryHour")
                        .HasColumnType("decimal(65,30)");

                    b.Property<int>("Weekend")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Idresetaurant");

                    b.ToTable("emplyees");
                });

            modelBuilder.Entity("ModelData.Models.Logins", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("Cacher")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("DataEntry")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("Garson")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("ISAdmin")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("IdEmplyee")
                        .HasColumnType("int");

                    b.Property<bool>("Kitchen")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)");

                    b.Property<bool>("TelSales")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)");

                    b.HasKey("Id");

                    b.HasIndex("IdEmplyee");

                    b.ToTable("logins");
                });

            modelBuilder.Entity("ModelData.Models.NameProduct", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)");

                    b.Property<int>("WeightId")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("WeightId");

                    b.ToTable("nameproduct");
                });

            modelBuilder.Entity("ModelData.Models.PayMoney", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("CodeReceipt")
                        .HasMaxLength(47)
                        .HasColumnType("varchar(47)");

                    b.Property<int>("IdReservation")
                        .HasColumnType("int");

                    b.Property<int>("Idresetaurant")
                        .HasColumnType("int");

                    b.Property<decimal>("PriceFood")
                        .HasColumnType("decimal(65,30)");

                    b.Property<decimal>("PriceServecis")
                        .HasColumnType("decimal(65,30)");

                    b.Property<string>("VisaCode")
                        .HasMaxLength(77)
                        .HasColumnType("varchar(77)");

                    b.Property<int>("paymentBy")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdReservation");

                    b.HasIndex("Idresetaurant");

                    b.ToTable("paymoney");
                });

            modelBuilder.Entity("ModelData.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateOnly?>("DateExpired")
                        .HasColumnType("date");

                    b.Property<int>("IdNameProduct")
                        .HasColumnType("int");

                    b.Property<int>("Idresetaurant")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(65,30)");

                    b.Property<double>("TotalWeightIN")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.HasIndex("IdNameProduct");

                    b.HasIndex("Idresetaurant");

                    b.ToTable("product");
                });

            modelBuilder.Entity("ModelData.Models.Receipt", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("CodeNumber")
                        .HasMaxLength(27)
                        .HasColumnType("varchar(27)");

                    b.Property<DateOnly>("Date")
                        .HasColumnType("date");

                    b.Property<int>("Discount")
                        .HasColumnType("int");

                    b.Property<int>("Idrestourant")
                        .HasColumnType("int");

                    b.Property<int>("Idsupplier")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Idrestourant");

                    b.HasIndex("Idsupplier");

                    b.ToTable("receipt");
                });

            modelBuilder.Entity("ModelData.Models.ReceiptItems", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateOnly?>("DateExpierd")
                        .HasColumnType("date");

                    b.Property<int>("IdNameproduct")
                        .HasColumnType("int");

                    b.Property<int>("IdReceipt")
                        .HasColumnType("int");

                    b.Property<decimal>("PriceAll")
                        .HasColumnType("decimal(65,30)");

                    b.Property<double>("TotalWeights")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.HasIndex("IdNameproduct");

                    b.HasIndex("IdReceipt");

                    b.ToTable("receiptitems");
                });

            modelBuilder.Entity("ModelData.Models.Reservation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("CustomerId")
                        .HasColumnType("int");

                    b.Property<DateOnly>("Date")
                        .HasColumnType("date");

                    b.Property<int>("Idresetaurant")
                        .HasColumnType("int");

                    b.Property<bool>("IsPayment")
                        .HasColumnType("tinyint(1)");

                    b.Property<TimeOnly?>("TimeEnd")
                        .HasColumnType("time(0)");

                    b.Property<TimeOnly?>("Timestart")
                        .HasColumnType("time(0)");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("Idresetaurant");

                    b.ToTable("reservation");
                });

            modelBuilder.Entity("ModelData.Models.RestaurantAndBranches", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(130)
                        .HasColumnType("varchar(130)");

                    b.Property<string>("LocationCode")
                        .HasMaxLength(101)
                        .HasColumnType("varchar(101)");

                    b.Property<string>("NameAndBranch")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("varchar(70)");

                    b.Property<string>("Phones")
                        .HasMaxLength(101)
                        .HasColumnType("varchar(101)");

                    b.Property<byte[]>("Photo")
                        .HasMaxLength(10000000)
                        .HasColumnType("longblob");

                    b.HasKey("Id");

                    b.ToTable("restaurantandbranches");
                });

            modelBuilder.Entity("ModelData.Models.Service", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("IdRestourant")
                        .HasColumnType("int");

                    b.Property<bool>("IsFixed")
                        .HasColumnType("tinyint(1)");

                    b.Property<decimal>("MoneyConst")
                        .HasColumnType("decimal(65,30)");

                    b.Property<int>("PaymentService")
                        .HasColumnType("int");

                    b.Property<int>("Rate")
                        .HasColumnType("int");

                    b.Property<string>("ServiceName")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("varchar(70)");

                    b.HasKey("Id");

                    b.HasIndex("IdRestourant");

                    b.ToTable("service");
                });

            modelBuilder.Entity("ModelData.Models.ServiceReservation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("IdReservation")
                        .HasColumnType("int");

                    b.Property<int>("IdService")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdReservation");

                    b.HasIndex("IdService");

                    b.ToTable("servicereservation");
                });

            modelBuilder.Entity("ModelData.Models.Supplier", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("NameSupplier")
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)");

                    b.Property<string>("Phones")
                        .HasMaxLength(77)
                        .HasColumnType("varchar(77)");

                    b.HasKey("Id");

                    b.ToTable("supplier");
                });

            modelBuilder.Entity("ModelData.Models.TablesReservation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("IdRevervation")
                        .HasColumnType("int");

                    b.Property<int>("IdTable")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdRevervation");

                    b.HasIndex("IdTable");

                    b.ToTable("tablesreservation");
                });

            modelBuilder.Entity("ModelData.Models.TheTable", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CountChair")
                        .HasColumnType("int");

                    b.Property<int>("IdArea")
                        .HasColumnType("int");

                    b.Property<int>("Idresetaurant")
                        .HasColumnType("int");

                    b.Property<bool>("IsRreserved")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("TableCode")
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.HasKey("Id");

                    b.HasIndex("IdArea");

                    b.HasIndex("Idresetaurant");

                    b.ToTable("table");
                });

            modelBuilder.Entity("ModelData.Models.WeightProduct", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<double>("CountSamll")
                        .HasColumnType("double");

                    b.Property<string>("NameBig")
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)");

                    b.Property<string>("NameSmall")
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)");

                    b.HasKey("ID");

                    b.ToTable("weightproduct");
                });

            modelBuilder.Entity("ModelData.Models.WorkTable", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateOnly>("Date")
                        .HasColumnType("date");

                    b.Property<int>("IdEmplyee")
                        .HasColumnType("int");

                    b.Property<TimeOnly>("TimeLeave")
                        .HasColumnType("Time");

                    b.Property<TimeOnly>("TimePresence")
                        .HasColumnType("Time");

                    b.HasKey("Id");

                    b.HasIndex("IdEmplyee");

                    b.ToTable("worktable");
                });

            modelBuilder.Entity("ModelData.Models.AccountReceipt", b =>
                {
                    b.HasOne("ModelData.Models.Receipt", "Receipt")
                        .WithMany("AccountReceipts")
                        .HasForeignKey("Idreceipt")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ModelData.Models.RestaurantAndBranches", "Restaurant")
                        .WithMany("AccountReceipts")
                        .HasForeignKey("Idrestaurant")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Receipt");

                    b.Navigation("Restaurant");
                });

            modelBuilder.Entity("ModelData.Models.Area", b =>
                {
                    b.HasOne("ModelData.Models.RestaurantAndBranches", "Restaurant")
                        .WithMany("Areas")
                        .HasForeignKey("Idresetaurant")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Restaurant");
                });

            modelBuilder.Entity("ModelData.Models.BarCode", b =>
                {
                    b.HasOne("ModelData.Models.NameProduct", "NameProduct")
                        .WithMany("BarCodess")
                        .HasForeignKey("IdNameProduct")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("NameProduct");
                });

            modelBuilder.Entity("ModelData.Models.CategoryFood", b =>
                {
                    b.HasOne("ModelData.Models.RestaurantAndBranches", "Restaurant")
                        .WithMany()
                        .HasForeignKey("Idresetaurant")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Restaurant");
                });

            modelBuilder.Entity("ModelData.Models.Delivery", b =>
                {
                    b.HasOne("ModelData.Models.Emplyees", "EmplyeesDelviery")
                        .WithMany("DeliverysOFThisEmplyess")
                        .HasForeignKey("EmplyeesDelvieryId");

                    b.HasOne("ModelData.Models.Customer", "Customer")
                        .WithMany("Deliveries")
                        .HasForeignKey("IdCustomer");

                    b.HasOne("ModelData.Models.RestaurantAndBranches", "Restaurant")
                        .WithMany()
                        .HasForeignKey("Idresetaurant")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("EmplyeesDelviery");

                    b.Navigation("Restaurant");
                });

            modelBuilder.Entity("ModelData.Models.DetailsDish", b =>
                {
                    b.HasOne("ModelData.Models.DishFood", "Dish")
                        .WithMany("DetailsDishes")
                        .HasForeignKey("IdDishFood")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ModelData.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("IdProduct")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Dish");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("ModelData.Models.DishFood", b =>
                {
                    b.HasOne("ModelData.Models.CategoryFood", "category")
                        .WithMany()
                        .HasForeignKey("Idcategory")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ModelData.Models.RestaurantAndBranches", "Restaurant")
                        .WithMany("DishFoods")
                        .HasForeignKey("Idresetaurant")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ModelData.Models.WeightProduct", "weightOfDish")
                        .WithMany()
                        .HasForeignKey("Idweight")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Restaurant");

                    b.Navigation("category");

                    b.Navigation("weightOfDish");
                });

            modelBuilder.Entity("ModelData.Models.DishRequired", b =>
                {
                    b.HasOne("ModelData.Models.Delivery", "Delivery")
                        .WithMany("Dishes")
                        .HasForeignKey("IdDelivery");

                    b.HasOne("ModelData.Models.DishFood", "Dish")
                        .WithMany()
                        .HasForeignKey("IdDish")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ModelData.Models.Reservation", "Reservation")
                        .WithMany("DishFoods")
                        .HasForeignKey("IdReservation")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Delivery");

                    b.Navigation("Dish");

                    b.Navigation("Reservation");
                });

            modelBuilder.Entity("ModelData.Models.Emplyees", b =>
                {
                    b.HasOne("ModelData.Models.RestaurantAndBranches", "Restaurant")
                        .WithMany("Emplyees")
                        .HasForeignKey("Idresetaurant")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Restaurant");
                });

            modelBuilder.Entity("ModelData.Models.Logins", b =>
                {
                    b.HasOne("ModelData.Models.Emplyees", "emp")
                        .WithMany()
                        .HasForeignKey("IdEmplyee")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("emp");
                });

            modelBuilder.Entity("ModelData.Models.NameProduct", b =>
                {
                    b.HasOne("ModelData.Models.WeightProduct", "weight")
                        .WithMany()
                        .HasForeignKey("WeightId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("weight");
                });

            modelBuilder.Entity("ModelData.Models.PayMoney", b =>
                {
                    b.HasOne("ModelData.Models.Reservation", "Reservation")
                        .WithMany()
                        .HasForeignKey("IdReservation")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ModelData.Models.RestaurantAndBranches", "Restaurant")
                        .WithMany()
                        .HasForeignKey("Idresetaurant")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Reservation");

                    b.Navigation("Restaurant");
                });

            modelBuilder.Entity("ModelData.Models.Product", b =>
                {
                    b.HasOne("ModelData.Models.NameProduct", "NameProduct")
                        .WithMany()
                        .HasForeignKey("IdNameProduct")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ModelData.Models.RestaurantAndBranches", "Restaurant")
                        .WithMany("Products")
                        .HasForeignKey("Idresetaurant")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("NameProduct");

                    b.Navigation("Restaurant");
                });

            modelBuilder.Entity("ModelData.Models.Receipt", b =>
                {
                    b.HasOne("ModelData.Models.RestaurantAndBranches", "Restourant")
                        .WithMany("Receipts")
                        .HasForeignKey("Idrestourant")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ModelData.Models.Supplier", "Supplier")
                        .WithMany("Receipts")
                        .HasForeignKey("Idsupplier")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Restourant");

                    b.Navigation("Supplier");
                });

            modelBuilder.Entity("ModelData.Models.ReceiptItems", b =>
                {
                    b.HasOne("ModelData.Models.NameProduct", "NameProduct")
                        .WithMany()
                        .HasForeignKey("IdNameproduct")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ModelData.Models.Receipt", "Receipt")
                        .WithMany("ReceiptItems")
                        .HasForeignKey("IdReceipt")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("NameProduct");

                    b.Navigation("Receipt");
                });

            modelBuilder.Entity("ModelData.Models.Reservation", b =>
                {
                    b.HasOne("ModelData.Models.Customer", "Customer")
                        .WithMany("Reservations")
                        .HasForeignKey("CustomerId");

                    b.HasOne("ModelData.Models.RestaurantAndBranches", "Restaurant")
                        .WithMany("Reservations")
                        .HasForeignKey("Idresetaurant")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Restaurant");
                });

            modelBuilder.Entity("ModelData.Models.Service", b =>
                {
                    b.HasOne("ModelData.Models.RestaurantAndBranches", "Restourant")
                        .WithMany("Services")
                        .HasForeignKey("IdRestourant")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Restourant");
                });

            modelBuilder.Entity("ModelData.Models.ServiceReservation", b =>
                {
                    b.HasOne("ModelData.Models.Reservation", "Reservation")
                        .WithMany("ServiceReservations")
                        .HasForeignKey("IdReservation")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ModelData.Models.Service", "Service")
                        .WithMany()
                        .HasForeignKey("IdService")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Reservation");

                    b.Navigation("Service");
                });

            modelBuilder.Entity("ModelData.Models.TablesReservation", b =>
                {
                    b.HasOne("ModelData.Models.Reservation", "Revervation")
                        .WithMany("TablesReserved")
                        .HasForeignKey("IdRevervation")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ModelData.Models.TheTable", "Table")
                        .WithMany()
                        .HasForeignKey("IdTable")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Revervation");

                    b.Navigation("Table");
                });

            modelBuilder.Entity("ModelData.Models.TheTable", b =>
                {
                    b.HasOne("ModelData.Models.Area", "Area")
                        .WithMany("Tables")
                        .HasForeignKey("IdArea")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ModelData.Models.RestaurantAndBranches", "Restaurant")
                        .WithMany("Tables")
                        .HasForeignKey("Idresetaurant")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Area");

                    b.Navigation("Restaurant");
                });

            modelBuilder.Entity("ModelData.Models.WorkTable", b =>
                {
                    b.HasOne("ModelData.Models.Emplyees", "Emplyee")
                        .WithMany("WorksTable")
                        .HasForeignKey("IdEmplyee")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Emplyee");
                });

            modelBuilder.Entity("ModelData.Models.Area", b =>
                {
                    b.Navigation("Tables");
                });

            modelBuilder.Entity("ModelData.Models.Customer", b =>
                {
                    b.Navigation("Deliveries");

                    b.Navigation("Reservations");
                });

            modelBuilder.Entity("ModelData.Models.Delivery", b =>
                {
                    b.Navigation("Dishes");
                });

            modelBuilder.Entity("ModelData.Models.DishFood", b =>
                {
                    b.Navigation("DetailsDishes");
                });

            modelBuilder.Entity("ModelData.Models.Emplyees", b =>
                {
                    b.Navigation("DeliverysOFThisEmplyess");

                    b.Navigation("WorksTable");
                });

            modelBuilder.Entity("ModelData.Models.NameProduct", b =>
                {
                    b.Navigation("BarCodess");
                });

            modelBuilder.Entity("ModelData.Models.Receipt", b =>
                {
                    b.Navigation("AccountReceipts");

                    b.Navigation("ReceiptItems");
                });

            modelBuilder.Entity("ModelData.Models.Reservation", b =>
                {
                    b.Navigation("DishFoods");

                    b.Navigation("ServiceReservations");

                    b.Navigation("TablesReserved");
                });

            modelBuilder.Entity("ModelData.Models.RestaurantAndBranches", b =>
                {
                    b.Navigation("AccountReceipts");

                    b.Navigation("Areas");

                    b.Navigation("DishFoods");

                    b.Navigation("Emplyees");

                    b.Navigation("Products");

                    b.Navigation("Receipts");

                    b.Navigation("Reservations");

                    b.Navigation("Services");

                    b.Navigation("Tables");
                });

            modelBuilder.Entity("ModelData.Models.Supplier", b =>
                {
                    b.Navigation("Receipts");
                });
#pragma warning restore 612, 618
        }
    }
}
