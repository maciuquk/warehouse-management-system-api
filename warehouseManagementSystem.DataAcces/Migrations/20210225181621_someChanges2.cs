using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace warehouseManagementSystem.DataAcces.Migrations
{
    public partial class someChanges2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GoodsIssuedWZItem");

            migrationBuilder.DropTable(
                name: "InterBranchTransferMMItem");

            migrationBuilder.DropTable(
                name: "ItemReceptionOfGoodsPZ");

            migrationBuilder.DropTable(
                name: "GoodsIssuedWZs");

            migrationBuilder.DropTable(
                name: "interBranchTransferMMs");

            migrationBuilder.DropTable(
                name: "ReceptionOfGoodsPZs");

            migrationBuilder.AddColumn<string>(
                name: "PhotoUrl",
                table: "Items",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "MMs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Number = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MMs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PZs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Number = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PZs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Warehouse",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Warehouse", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WZs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Number = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WZs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ItemMM",
                columns: table => new
                {
                    ItemsId = table.Column<int>(type: "int", nullable: false),
                    MMsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemMM", x => new { x.ItemsId, x.MMsId });
                    table.ForeignKey(
                        name: "FK_ItemMM_Items_ItemsId",
                        column: x => x.ItemsId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItemMM_MMs_MMsId",
                        column: x => x.MMsId,
                        principalTable: "MMs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItemPZ",
                columns: table => new
                {
                    ItemsId = table.Column<int>(type: "int", nullable: false),
                    PZsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemPZ", x => new { x.ItemsId, x.PZsId });
                    table.ForeignKey(
                        name: "FK_ItemPZ_Items_ItemsId",
                        column: x => x.ItemsId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItemPZ_PZs_PZsId",
                        column: x => x.PZsId,
                        principalTable: "PZs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItemWarehouse",
                columns: table => new
                {
                    ItemsId = table.Column<int>(type: "int", nullable: false),
                    WarehousesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemWarehouse", x => new { x.ItemsId, x.WarehousesId });
                    table.ForeignKey(
                        name: "FK_ItemWarehouse_Items_ItemsId",
                        column: x => x.ItemsId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItemWarehouse_Warehouse_WarehousesId",
                        column: x => x.WarehousesId,
                        principalTable: "Warehouse",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItemWZ",
                columns: table => new
                {
                    ItemsId = table.Column<int>(type: "int", nullable: false),
                    WZsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemWZ", x => new { x.ItemsId, x.WZsId });
                    table.ForeignKey(
                        name: "FK_ItemWZ_Items_ItemsId",
                        column: x => x.ItemsId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItemWZ_WZs_WZsId",
                        column: x => x.WZsId,
                        principalTable: "WZs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ItemMM_MMsId",
                table: "ItemMM",
                column: "MMsId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemPZ_PZsId",
                table: "ItemPZ",
                column: "PZsId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemWarehouse_WarehousesId",
                table: "ItemWarehouse",
                column: "WarehousesId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemWZ_WZsId",
                table: "ItemWZ",
                column: "WZsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ItemMM");

            migrationBuilder.DropTable(
                name: "ItemPZ");

            migrationBuilder.DropTable(
                name: "ItemWarehouse");

            migrationBuilder.DropTable(
                name: "ItemWZ");

            migrationBuilder.DropTable(
                name: "MMs");

            migrationBuilder.DropTable(
                name: "PZs");

            migrationBuilder.DropTable(
                name: "Warehouse");

            migrationBuilder.DropTable(
                name: "WZs");

            migrationBuilder.DropColumn(
                name: "PhotoUrl",
                table: "Items");

            migrationBuilder.CreateTable(
                name: "GoodsIssuedWZs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Number = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GoodsIssuedWZs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "interBranchTransferMMs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Number = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_interBranchTransferMMs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ReceptionOfGoodsPZs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Number = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReceptionOfGoodsPZs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GoodsIssuedWZItem",
                columns: table => new
                {
                    GoodsIssuedWZsId = table.Column<int>(type: "int", nullable: false),
                    ItemsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GoodsIssuedWZItem", x => new { x.GoodsIssuedWZsId, x.ItemsId });
                    table.ForeignKey(
                        name: "FK_GoodsIssuedWZItem_GoodsIssuedWZs_GoodsIssuedWZsId",
                        column: x => x.GoodsIssuedWZsId,
                        principalTable: "GoodsIssuedWZs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GoodsIssuedWZItem_Items_ItemsId",
                        column: x => x.ItemsId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InterBranchTransferMMItem",
                columns: table => new
                {
                    InterBranchTransferRWsId = table.Column<int>(type: "int", nullable: false),
                    ItemsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InterBranchTransferMMItem", x => new { x.InterBranchTransferRWsId, x.ItemsId });
                    table.ForeignKey(
                        name: "FK_InterBranchTransferMMItem_interBranchTransferMMs_InterBranchTransferRWsId",
                        column: x => x.InterBranchTransferRWsId,
                        principalTable: "interBranchTransferMMs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InterBranchTransferMMItem_Items_ItemsId",
                        column: x => x.ItemsId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItemReceptionOfGoodsPZ",
                columns: table => new
                {
                    ItemsId = table.Column<int>(type: "int", nullable: false),
                    ReceptionOfGoodsPZsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemReceptionOfGoodsPZ", x => new { x.ItemsId, x.ReceptionOfGoodsPZsId });
                    table.ForeignKey(
                        name: "FK_ItemReceptionOfGoodsPZ_Items_ItemsId",
                        column: x => x.ItemsId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItemReceptionOfGoodsPZ_ReceptionOfGoodsPZs_ReceptionOfGoodsPZsId",
                        column: x => x.ReceptionOfGoodsPZsId,
                        principalTable: "ReceptionOfGoodsPZs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GoodsIssuedWZItem_ItemsId",
                table: "GoodsIssuedWZItem",
                column: "ItemsId");

            migrationBuilder.CreateIndex(
                name: "IX_InterBranchTransferMMItem_ItemsId",
                table: "InterBranchTransferMMItem",
                column: "ItemsId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemReceptionOfGoodsPZ_ReceptionOfGoodsPZsId",
                table: "ItemReceptionOfGoodsPZ",
                column: "ReceptionOfGoodsPZsId");
        }
    }
}
