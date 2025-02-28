﻿// <auto-generated />
using System;
using FoodDeliveryApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FoodDeliveryApp.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20250228064017_Mig1")]
    partial class Mig1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FoodDeliveryApp.Models.Admin", b =>
                {
                    b.Property<int>("AdminId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AdminId"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("AdminId");

                    b.ToTable("Admins");

                    b.HasData(
                        new
                        {
                            AdminId = 1,
                            Email = "admin@example.com",
                            Name = "SuperAdmin",
                            Password = "admin@123",
                            PhoneNumber = "1234567890",
                            Role = "SuperAdmin"
                        });
                });

            modelBuilder.Entity("FoodDeliveryApp.Models.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerId"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("CustomerName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("CustomerId");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            CustomerId = 1,
                            Address = "123 Main Street",
                            CustomerName = "John Doe",
                            Email = "john@example.com",
                            Password = "john@123",
                            PhoneNumber = "9876543210"
                        },
                        new
                        {
                            CustomerId = 2,
                            Address = "456 South Avenue",
                            CustomerName = "Jane Smith",
                            Email = "jane@example.com",
                            Password = "jane@123",
                            PhoneNumber = "5554443322"
                        });
                });

            modelBuilder.Entity("FoodDeliveryApp.Models.Item", b =>
                {
                    b.Property<int>("ItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ItemId"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsAvailable")
                        .HasColumnType("bit");

                    b.Property<string>("ItemName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ItemId");

                    b.ToTable("Items");

                    b.HasData(
                        new
                        {
                            ItemId = 1,
                            Description = "Classic cheese pizza",
                            IsAvailable = true,
                            ItemName = "Margherita Pizza",
                            Price = 9.99m
                        },
                        new
                        {
                            ItemId = 2,
                            Description = "Delicious burger with veggie patty",
                            IsAvailable = true,
                            ItemName = "Veggie Burger",
                            Price = 7.49m
                        },
                        new
                        {
                            ItemId = 3,
                            Description = "Pizza with pepperoni toppings",
                            IsAvailable = true,
                            ItemName = "Pepperoni Pizza",
                            Price = 10.99m
                        },
                        new
                        {
                            ItemId = 4,
                            Description = "Juicy chicken burger",
                            IsAvailable = true,
                            ItemName = "Chicken Burger",
                            Price = 8.49m
                        },
                        new
                        {
                            ItemId = 5,
                            Description = "Crispy golden fries",
                            IsAvailable = true,
                            ItemName = "French Fries",
                            Price = 3.49m
                        });
                });

            modelBuilder.Entity("FoodDeliveryApp.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderId"));

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("OrderDateTime")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("OrderId");

                    b.HasIndex("CustomerId");

                    b.ToTable("Orders");

                    b.HasData(
                        new
                        {
                            OrderId = 1,
                            CustomerId = 1,
                            OrderDateTime = new DateTime(2025, 2, 28, 0, 10, 0, 0, DateTimeKind.Local),
                            Price = 9.99m,
                            Status = 1
                        },
                        new
                        {
                            OrderId = 2,
                            CustomerId = 2,
                            OrderDateTime = new DateTime(2025, 2, 28, 0, 25, 0, 0, DateTimeKind.Local),
                            Price = 7.49m,
                            Status = 2
                        },
                        new
                        {
                            OrderId = 3,
                            CustomerId = 1,
                            OrderDateTime = new DateTime(2025, 2, 28, 0, 32, 0, 0, DateTimeKind.Local),
                            Price = 10.98m,
                            Status = 2
                        },
                        new
                        {
                            OrderId = 4,
                            CustomerId = 2,
                            OrderDateTime = new DateTime(2025, 2, 28, 0, 45, 0, 0, DateTimeKind.Local),
                            Price = 10.99m,
                            Status = 1
                        },
                        new
                        {
                            OrderId = 5,
                            CustomerId = 2,
                            OrderDateTime = new DateTime(2025, 2, 28, 0, 45, 0, 0, DateTimeKind.Local),
                            Price = 10.98m,
                            Status = 3
                        },
                        new
                        {
                            OrderId = 6,
                            CustomerId = 1,
                            OrderDateTime = new DateTime(2025, 2, 28, 0, 50, 0, 0, DateTimeKind.Local),
                            Price = 10.99m,
                            Status = 3
                        });
                });

            modelBuilder.Entity("FoodDeliveryApp.Models.OrderItem", b =>
                {
                    b.Property<int>("OrderItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderItemId"));

                    b.Property<int>("ItemId")
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("OrderItemId");

                    b.HasIndex("ItemId");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderItems");

                    b.HasData(
                        new
                        {
                            OrderItemId = 1,
                            ItemId = 1,
                            OrderId = 1,
                            Quantity = 1,
                            UnitPrice = 9.99m
                        },
                        new
                        {
                            OrderItemId = 2,
                            ItemId = 2,
                            OrderId = 2,
                            Quantity = 1,
                            UnitPrice = 7.49m
                        },
                        new
                        {
                            OrderItemId = 3,
                            ItemId = 2,
                            OrderId = 3,
                            Quantity = 1,
                            UnitPrice = 7.49m
                        },
                        new
                        {
                            OrderItemId = 4,
                            ItemId = 5,
                            OrderId = 3,
                            Quantity = 1,
                            UnitPrice = 3.49m
                        },
                        new
                        {
                            OrderItemId = 5,
                            ItemId = 3,
                            OrderId = 4,
                            Quantity = 1,
                            UnitPrice = 10.99m
                        },
                        new
                        {
                            OrderItemId = 6,
                            ItemId = 2,
                            OrderId = 5,
                            Quantity = 1,
                            UnitPrice = 7.49m
                        },
                        new
                        {
                            OrderItemId = 7,
                            ItemId = 5,
                            OrderId = 5,
                            Quantity = 1,
                            UnitPrice = 3.49m
                        },
                        new
                        {
                            OrderItemId = 8,
                            ItemId = 3,
                            OrderId = 6,
                            Quantity = 1,
                            UnitPrice = 10.99m
                        });
                });

            modelBuilder.Entity("FoodDeliveryApp.Models.Order", b =>
                {
                    b.HasOne("FoodDeliveryApp.Models.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("FoodDeliveryApp.Models.OrderItem", b =>
                {
                    b.HasOne("FoodDeliveryApp.Models.Item", "Item")
                        .WithMany()
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FoodDeliveryApp.Models.Order", "Order")
                        .WithMany("OrderItems")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Item");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("FoodDeliveryApp.Models.Customer", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("FoodDeliveryApp.Models.Order", b =>
                {
                    b.Navigation("OrderItems");
                });
#pragma warning restore 612, 618
        }
    }
}
