using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace warehouseManagementSystem.DataAcces.Migrations
{
    public partial class addOtherManyToMany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GoodsIssuedWZ",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Number = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GoodsIssuedWZ", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InterBranchTransferRW",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Number = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InterBranchTransferRW", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Place",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PositionX = table.Column<int>(type: "int", nullable: false),
                    PositionY = table.Column<int>(type: "int", nullable: false),
                    MaxCapacity = table.Column<double>(type: "float", nullable: false),
                    CurrentOccupied = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Place", x => x.Id);
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
                        name: "FK_GoodsIssuedWZItem_GoodsIssuedWZ_GoodsIssuedWZsId",
                        column: x => x.GoodsIssuedWZsId,
                        principalTable: "GoodsIssuedWZ",
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
                name: "InterBranchTransferRWItem",
                columns: table => new
                {
                    InterBranchTransferRWsId = table.Column<int>(type: "int", nullable: false),
                    ItemsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InterBranchTransferRWItem", x => new { x.InterBranchTransferRWsId, x.ItemsId });
                    table.ForeignKey(
                        name: "FK_InterBranchTransferRWItem_InterBranchTransferRW_InterBranchTransferRWsId",
                        column: x => x.InterBranchTransferRWsId,
                        principalTable: "InterBranchTransferRW",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InterBranchTransferRWItem_Items_ItemsId",
                        column: x => x.ItemsId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItemPlace",
                columns: table => new
                {
                    ItemsId = table.Column<int>(type: "int", nullable: false),
                    PlacesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemPlace", x => new { x.ItemsId, x.PlacesId });
                    table.ForeignKey(
                        name: "FK_ItemPlace_Items_ItemsId",
                        column: x => x.ItemsId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItemPlace_Place_PlacesId",
                        column: x => x.PlacesId,
                        principalTable: "Place",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GoodsIssuedWZItem_ItemsId",
                table: "GoodsIssuedWZItem",
                column: "ItemsId");

            migrationBuilder.CreateIndex(
                name: "IX_InterBranchTransferRWItem_ItemsId",
                table: "InterBranchTransferRWItem",
                column: "ItemsId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemPlace_PlacesId",
                table: "ItemPlace",
                column: "PlacesId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GoodsIssuedWZItem");

            migrationBuilder.DropTable(
                name: "InterBranchTransferRWItem");

            migrationBuilder.DropTable(
                name: "ItemPlace");

            migrationBuilder.DropTable(
                name: "GoodsIssuedWZ");

            migrationBuilder.DropTable(
                name: "InterBranchTransferRW");

            migrationBuilder.DropTable(
                name: "Place");
        }
    }
}
