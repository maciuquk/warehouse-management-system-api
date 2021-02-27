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
    [Migration("20210221165740_addOtherManyToMany")]
    partial class addOtherManyToMany
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GoodsIssuedWZItem", b =>
                {
                    b.Property<int>("GoodsIssuedWZsId")
                        .HasColumnType("int");

                    b.Property<int>("ItemsId")
                        .HasColumnType("int");

                    b.HasKey("GoodsIssuedWZsId", "ItemsId");

                    b.HasIndex("ItemsId");

                    b.ToTable("GoodsIssuedWZItem");
                });

            modelBuilder.Entity("InterBranchTransferRWItem", b =>
                {
                    b.Property<int>("InterBranchTransferRWsId")
                        .HasColumnType("int");

                    b.Property<int>("ItemsId")
                        .HasColumnType("int");

                    b.HasKey("InterBranchTransferRWsId", "ItemsId");

                    b.HasIndex("ItemsId");

                    b.ToTable("InterBranchTransferRWItem");
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

            modelBuilder.Entity("ItemReceptionOfGoodsPZ", b =>
                {
                    b.Property<int>("ItemsId")
                        .HasColumnType("int");

                    b.Property<int>("ReceptionOfGoodsPZsId")
                        .HasColumnType("int");

                    b.HasKey("ItemsId", "ReceptionOfGoodsPZsId");

                    b.HasIndex("ReceptionOfGoodsPZsId");

                    b.ToTable("ItemReceptionOfGoodsPZ");
                });

            modelBuilder.Entity("warehouseManagementSystem.DataAcces.Entities.GoodsIssuedWZ", b =>
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

                    b.ToTable("GoodsIssuedWZ");
                });

            modelBuilder.Entity("warehouseManagementSystem.DataAcces.Entities.InterBranchTransferRW", b =>
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

                    b.ToTable("InterBranchTransferRW");
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

                    b.ToTable("Place");
                });

            modelBuilder.Entity("warehouseManagementSystem.DataAcces.Entities.ReceptionOfGoodsPZ", b =>
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

                    b.ToTable("ReceptionOfGoodsPZs");
                });

            modelBuilder.Entity("GoodsIssuedWZItem", b =>
                {
                    b.HasOne("warehouseManagementSystem.DataAcces.Entities.GoodsIssuedWZ", null)
                        .WithMany()
                        .HasForeignKey("GoodsIssuedWZsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("warehouseManagementSystem.DataAcces.Entities.Item", null)
                        .WithMany()
                        .HasForeignKey("ItemsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("InterBranchTransferRWItem", b =>
                {
                    b.HasOne("warehouseManagementSystem.DataAcces.Entities.InterBranchTransferRW", null)
                        .WithMany()
                        .HasForeignKey("InterBranchTransferRWsId")
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

            modelBuilder.Entity("ItemReceptionOfGoodsPZ", b =>
                {
                    b.HasOne("warehouseManagementSystem.DataAcces.Entities.Item", null)
                        .WithMany()
                        .HasForeignKey("ItemsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("warehouseManagementSystem.DataAcces.Entities.ReceptionOfGoodsPZ", null)
                        .WithMany()
                        .HasForeignKey("ReceptionOfGoodsPZsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
