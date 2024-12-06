﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StoreSystem.Data;

#nullable disable

namespace StoreSystem.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20241206183941_updatestoreItemsName")]
    partial class updatestoreItemsName
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("StoreSystem.Models.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18, 2)");

                    b.HasKey("Id");

                    b.ToTable("items");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Lorem Ipsum",
                            Name = "Samasung S24",
                            Price = 2000m
                        },
                        new
                        {
                            Id = 2,
                            Description = "Lorem Ipsum",
                            Name = "Iphone 14",
                            Price = 3000m
                        });
                });

            modelBuilder.Entity("StoreSystem.Models.Store", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Latitude")
                        .HasColumnType("float");

                    b.Property<double>("Longitude")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("stores");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Ahmed Orabi Square",
                            Latitude = 0.0,
                            Longitude = 0.0,
                            Name = "Manshia Store",
                            PhoneNumber = "0123456789"
                        },
                        new
                        {
                            Id = 2,
                            Address = "Front of sidi Gaber Elsheikh tram station",
                            Latitude = 0.0,
                            Longitude = 0.0,
                            Name = "Sidi Gaber Store",
                            PhoneNumber = "0123456789"
                        });
                });

            modelBuilder.Entity("StoreSystem.Models.StoreItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("StoreId")
                        .HasColumnType("int");

                    b.Property<int>("itemId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("StoreId");

                    b.HasIndex("itemId");

                    b.ToTable("storeItems");
                });

            modelBuilder.Entity("StoreSystem.Models.StoreItem", b =>
                {
                    b.HasOne("StoreSystem.Models.Store", "store")
                        .WithMany("Items")
                        .HasForeignKey("StoreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StoreSystem.Models.Item", "Item")
                        .WithMany()
                        .HasForeignKey("itemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Item");

                    b.Navigation("store");
                });

            modelBuilder.Entity("StoreSystem.Models.Store", b =>
                {
                    b.Navigation("Items");
                });
#pragma warning restore 612, 618
        }
    }
}
