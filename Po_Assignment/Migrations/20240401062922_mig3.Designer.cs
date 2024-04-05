﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Po_Assignment.Dal;

#nullable disable

namespace Po_Assignment.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240401062922_mig3")]
    partial class mig3
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Po_Assignment.Models.MaterialEntry", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar(5)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("LongText")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int?>("Min_Order_Quantity")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("Reorder_Level")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("int");

                    b.Property<string>("ShortText")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<int?>("Unit")
                        .IsRequired()
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("MaterialMasters");
                });

            modelBuilder.Entity("Po_Assignment.Models.Po_Details", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<DateTime>("ExpectedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ItemNotes")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("ItemQuantity")
                        .HasColumnType("int");

                    b.Property<float>("ItemRate")
                        .HasColumnType("real");

                    b.Property<float>("ItemValue")
                        .HasColumnType("real");

                    b.Property<int>("MaterialEntryId")
                        .HasColumnType("int")
                        .HasColumnName("MaterialID");

                    b.Property<int>("OrderID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("MaterialEntryId");

                    b.ToTable("PoDetailsMaster");
                });

            modelBuilder.Entity("Po_Assignment.Models.Po_header", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Notes")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("OrderNumber")
                        .HasColumnType("int");

                    b.Property<string>("OrderStatus")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar(5)");

                    b.Property<int>("OrderValue")
                        .HasColumnType("int");

                    b.Property<int>("VendorMasterId")
                        .HasColumnType("int")
                        .HasColumnName("VendorID");

                    b.HasKey("ID");

                    b.HasIndex("VendorMasterId");

                    b.ToTable("PoHeadersMaster");
                });

            modelBuilder.Entity("Po_Assignment.Models.VendorMaster", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AddressLine1")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("AddressLine2")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar(5)");

                    b.Property<string>("ContactEmail")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("ContactNo")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("ValidTillDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("VendorMasters");
                });

            modelBuilder.Entity("Po_Assignment.Models.Po_Details", b =>
                {
                    b.HasOne("Po_Assignment.Models.MaterialEntry", "MaterialEntry")
                        .WithMany()
                        .HasForeignKey("MaterialEntryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MaterialEntry");
                });

            modelBuilder.Entity("Po_Assignment.Models.Po_header", b =>
                {
                    b.HasOne("Po_Assignment.Models.VendorMaster", "VendorMaster")
                        .WithMany()
                        .HasForeignKey("VendorMasterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("VendorMaster");
                });
#pragma warning restore 612, 618
        }
    }
}
