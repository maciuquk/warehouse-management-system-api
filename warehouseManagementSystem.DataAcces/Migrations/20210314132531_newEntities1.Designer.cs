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
    [Migration("20210314132531_newEntities1")]
    partial class newEntities1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GoodsIssuedItem", b =>
                {
                    b.Property<int>("GoodsIssuedsId")
                        .HasColumnType("int");

                    b.Property<int>("ItemsId")
                        .HasColumnType("int");

                    b.HasKey("GoodsIssuedsId", "ItemsId");

                    b.HasIndex("ItemsId");

                    b.ToTable("GoodsIssuedItem");
                });

            modelBuilder.Entity("GoodsReceiveItem", b =>
                {
                    b.Property<int>("GoodsReceivesId")
                        .HasColumnType("int");

                    b.Property<int>("ItemsId")
                        .HasColumnType("int");

                    b.HasKey("GoodsReceivesId", "ItemsId");

                    b.HasIndex("ItemsId");

                    b.ToTable("GoodsReceiveItem");
                });

            modelBuilder.Entity("InterBranchTransferItem", b =>
                {
                    b.Property<int>("InterBranchTransfersId")
                        .HasColumnType("int");

                    b.Property<int>("ItemsId")
                        .HasColumnType("int");

                    b.HasKey("InterBranchTransfersId", "ItemsId");

                    b.HasIndex("ItemsId");

                    b.ToTable("InterBranchTransferItem");
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

            modelBuilder.Entity("warehouseManagementSystem.DataAcces.Entities.GoodsIssued", b =>
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

                    b.ToTable("GoodsIssueds");
                });

            modelBuilder.Entity("warehouseManagementSystem.DataAcces.Entities.GoodsReceive", b =>
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

                    b.ToTable("GoodsReceiveds");
                });

            modelBuilder.Entity("warehouseManagementSystem.DataAcces.Entities.InterBranchTransfer", b =>
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

                    b.ToTable("InterBranchTransfers");
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

            modelBuilder.Entity("warehouseManagementSystem.DataAcces.Entities.Warehouse", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Warehouses");
                });

            modelBuilder.Entity("GoodsIssuedItem", b =>
                {
                    b.HasOne("warehouseManagementSystem.DataAcces.Entities.GoodsIssued", null)
                        .WithMany()
                        .HasForeignKey("GoodsIssuedsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("warehouseManagementSystem.DataAcces.Entities.Item", null)
                        .WithMany()
                        .HasForeignKey("ItemsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GoodsReceiveItem", b =>
                {
                    b.HasOne("warehouseManagementSystem.DataAcces.Entities.GoodsReceive", null)
                        .WithMany()
                        .HasForeignKey("GoodsReceivesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("warehouseManagementSystem.DataAcces.Entities.Item", null)
                        .WithMany()
                        .HasForeignKey("ItemsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("InterBranchTransferItem", b =>
                {
                    b.HasOne("warehouseManagementSystem.DataAcces.Entities.InterBranchTransfer", null)
                        .WithMany()
                        .HasForeignKey("InterBranchTransfersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("warehouseManagementSystem.DataAcces.Entities.Item", null)
                        .WithMany()
                        .HasForeignKey("ItemsId")
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
