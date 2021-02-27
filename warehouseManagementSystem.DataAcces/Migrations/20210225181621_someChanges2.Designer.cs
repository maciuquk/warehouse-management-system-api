﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using warehouseManagementSystem.DataAcces;

namespace warehouseManagementSystem.DataAcces.Migrations
{
    [DbContext(typeof(WarehouseStorageContext))]
    [Migration("20210225181621_someChanges2")]
    partial class someChanges2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ItemMM", b =>
                {
                    b.Property<int>("ItemsId")
                        .HasColumnType("int");

                    b.Property<int>("MMsId")
                        .HasColumnType("int");

                    b.HasKey("ItemsId", "MMsId");

                    b.HasIndex("MMsId");

                    b.ToTable("ItemMM");
                });

            modelBuilder.Entity("ItemPZ", b =>
                {
                    b.Property<int>("ItemsId")
                        .HasColumnType("int");

                    b.Property<int>("PZsId")
                        .HasColumnType("int");

                    b.HasKey("ItemsId", "PZsId");

                    b.HasIndex("PZsId");

                    b.ToTable("ItemPZ");
                });

            modelBuilder.Entity("ItemPlace", b =>
                {
                    b.Property<int>("ItemsId")
                        .HasColumnType("int");

                    b.Property<int>("PlacesId")
                        .HasColumnType("int");

                    b.HasKey("ItemsId", "PlacesId");

                    b.HasIndex("PlacesId");

                    b.ToTable("ItemPlace");
                });

            modelBuilder.Entity("ItemWZ", b =>
                {
                    b.Property<int>("ItemsId")
                        .HasColumnType("int");

                    b.Property<int>("WZsId")
                        .HasColumnType("int");

                    b.HasKey("ItemsId", "WZsId");

                    b.HasIndex("WZsId");

                    b.ToTable("ItemWZ");
                });

            modelBuilder.Entity("ItemWarehouse", b =>
                {
                    b.Property<int>("ItemsId")
                        .HasColumnType("int");

                    b.Property<int>("WarehousesId")
                        .HasColumnType("int");

                    b.HasKey("ItemsId", "WarehousesId");

                    b.HasIndex("WarehousesId");

                    b.ToTable("ItemWarehouse");
                });

            modelBuilder.Entity("warehouseManagementSystem.DataAcces.Entities.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("PhotoUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Quantity")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("warehouseManagementSystem.DataAcces.Entities.MM", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Number")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("MMs");
                });

            modelBuilder.Entity("warehouseManagementSystem.DataAcces.Entities.PZ", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Number")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PZs");
                });

            modelBuilder.Entity("warehouseManagementSystem.DataAcces.Entities.Place", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("CurrentOccupied")
                        .HasColumnType("float");

                    b.Property<double>("MaxCapacity")
                        .HasColumnType("float");

                    b.Property<int>("PositionX")
                        .HasColumnType("int");

                    b.Property<int>("PositionY")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Places");
                });

            modelBuilder.Entity("warehouseManagementSystem.DataAcces.Entities.WZ", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Number")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("WZs");
                });

            modelBuilder.Entity("warehouseManagementSystem.DataAcces.Entities.Warehouse", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Warehouse");
                });

            modelBuilder.Entity("ItemMM", b =>
                {
                    b.HasOne("warehouseManagementSystem.DataAcces.Entities.Item", null)
                        .WithMany()
                        .HasForeignKey("ItemsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("warehouseManagementSystem.DataAcces.Entities.MM", null)
                        .WithMany()
                        .HasForeignKey("MMsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ItemPZ", b =>
                {
                    b.HasOne("warehouseManagementSystem.DataAcces.Entities.Item", null)
                        .WithMany()
                        .HasForeignKey("ItemsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("warehouseManagementSystem.DataAcces.Entities.PZ", null)
                        .WithMany()
                        .HasForeignKey("PZsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ItemPlace", b =>
                {
                    b.HasOne("warehouseManagementSystem.DataAcces.Entities.Item", null)
                        .WithMany()
                        .HasForeignKey("ItemsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("warehouseManagementSystem.DataAcces.Entities.Place", null)
                        .WithMany()
                        .HasForeignKey("PlacesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ItemWZ", b =>
                {
                    b.HasOne("warehouseManagementSystem.DataAcces.Entities.Item", null)
                        .WithMany()
                        .HasForeignKey("ItemsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("warehouseManagementSystem.DataAcces.Entities.WZ", null)
                        .WithMany()
                        .HasForeignKey("WZsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ItemWarehouse", b =>
                {
                    b.HasOne("warehouseManagementSystem.DataAcces.Entities.Item", null)
                        .WithMany()
                        .HasForeignKey("ItemsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("warehouseManagementSystem.DataAcces.Entities.Warehouse", null)
                        .WithMany()
                        .HasForeignKey("WarehousesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
