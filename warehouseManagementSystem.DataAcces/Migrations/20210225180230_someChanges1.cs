using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace warehouseManagementSystem.DataAcces.Migrations
{
    public partial class someChanges1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GoodsIssuedWZItem_GoodsIssuedWZ_GoodsIssuedWZsId",
                table: "GoodsIssuedWZItem");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemPlace_Place_PlacesId",
                table: "ItemPlace");

            migrationBuilder.DropTable(
                name: "InterBranchTransferRWItem");

            migrationBuilder.DropTable(
                name: "InterBranchTransferRW");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Place",
                table: "Place");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GoodsIssuedWZ",
                table: "GoodsIssuedWZ");

            migrationBuilder.RenameTable(
                name: "Place",
                newName: "Places");

            migrationBuilder.RenameTable(
                name: "GoodsIssuedWZ",
                newName: "GoodsIssuedWZs");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Places",
                table: "Places",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GoodsIssuedWZs",
                table: "GoodsIssuedWZs",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "interBranchTransferMMs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Number = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_interBranchTransferMMs", x => x.Id);
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

            migrationBuilder.CreateIndex(
                name: "IX_InterBranchTransferMMItem_ItemsId",
                table: "InterBranchTransferMMItem",
                column: "ItemsId");

            migrationBuilder.AddForeignKey(
                name: "FK_GoodsIssuedWZItem_GoodsIssuedWZs_GoodsIssuedWZsId",
                table: "GoodsIssuedWZItem",
                column: "GoodsIssuedWZsId",
                principalTable: "GoodsIssuedWZs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ItemPlace_Places_PlacesId",
                table: "ItemPlace",
                column: "PlacesId",
                principalTable: "Places",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GoodsIssuedWZItem_GoodsIssuedWZs_GoodsIssuedWZsId",
                table: "GoodsIssuedWZItem");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemPlace_Places_PlacesId",
                table: "ItemPlace");

            migrationBuilder.DropTable(
                name: "InterBranchTransferMMItem");

            migrationBuilder.DropTable(
                name: "interBranchTransferMMs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Places",
                table: "Places");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GoodsIssuedWZs",
                table: "GoodsIssuedWZs");

            migrationBuilder.RenameTable(
                name: "Places",
                newName: "Place");

            migrationBuilder.RenameTable(
                name: "GoodsIssuedWZs",
                newName: "GoodsIssuedWZ");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Place",
                table: "Place",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GoodsIssuedWZ",
                table: "GoodsIssuedWZ",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "InterBranchTransferRW",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Number = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InterBranchTransferRW", x => x.Id);
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

            migrationBuilder.CreateIndex(
                name: "IX_InterBranchTransferRWItem_ItemsId",
                table: "InterBranchTransferRWItem",
                column: "ItemsId");

            migrationBuilder.AddForeignKey(
                name: "FK_GoodsIssuedWZItem_GoodsIssuedWZ_GoodsIssuedWZsId",
                table: "GoodsIssuedWZItem",
                column: "GoodsIssuedWZsId",
                principalTable: "GoodsIssuedWZ",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ItemPlace_Place_PlacesId",
                table: "ItemPlace",
                column: "PlacesId",
                principalTable: "Place",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
