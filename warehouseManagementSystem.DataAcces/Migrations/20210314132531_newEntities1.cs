using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace warehouseManagementSystem.DataAcces.Migrations
{
    public partial class newEntities1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ItemMM");

            migrationBuilder.DropTable(
                name: "ItemPZ");

            migrationBuilder.DropTable(
                name: "ItemWZ");

            migrationBuilder.DropTable(
                name: "MMs");

            migrationBuilder.DropTable(
                name: "PZs");

            migrationBuilder.DropTable(
                name: "WZs");

            migrationBuilder.CreateTable(
                name: "GoodsIssueds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Number = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GoodsIssueds", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GoodsReceiveds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Number = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GoodsReceiveds", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InterBranchTransfers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Number = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InterBranchTransfers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GoodsIssuedItem",
                columns: table => new
                {
                    GoodsIssuedsId = table.Column<int>(type: "int", nullable: false),
                    ItemsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GoodsIssuedItem", x => new { x.GoodsIssuedsId, x.ItemsId });
                    table.ForeignKey(
                        name: "FK_GoodsIssuedItem_GoodsIssueds_GoodsIssuedsId",
                        column: x => x.GoodsIssuedsId,
                        principalTable: "GoodsIssueds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GoodsIssuedItem_Items_ItemsId",
                        column: x => x.ItemsId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GoodsReceiveItem",
                columns: table => new
                {
                    GoodsReceivesId = table.Column<int>(type: "int", nullable: false),
                    ItemsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GoodsReceiveItem", x => new { x.GoodsReceivesId, x.ItemsId });
                    table.ForeignKey(
                        name: "FK_GoodsReceiveItem_GoodsReceiveds_GoodsReceivesId",
                        column: x => x.GoodsReceivesId,
                        principalTable: "GoodsReceiveds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GoodsReceiveItem_Items_ItemsId",
                        column: x => x.ItemsId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InterBranchTransferItem",
                columns: table => new
                {
                    InterBranchTransfersId = table.Column<int>(type: "int", nullable: false),
                    ItemsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InterBranchTransferItem", x => new { x.InterBranchTransfersId, x.ItemsId });
                    table.ForeignKey(
                        name: "FK_InterBranchTransferItem_InterBranchTransfers_InterBranchTransfersId",
                        column: x => x.InterBranchTransfersId,
                        principalTable: "InterBranchTransfers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InterBranchTransferItem_Items_ItemsId",
                        column: x => x.ItemsId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GoodsIssuedItem_ItemsId",
                table: "GoodsIssuedItem",
                column: "ItemsId");

            migrationBuilder.CreateIndex(
                name: "IX_GoodsReceiveItem_ItemsId",
                table: "GoodsReceiveItem",
                column: "ItemsId");

            migrationBuilder.CreateIndex(
                name: "IX_InterBranchTransferItem_ItemsId",
                table: "InterBranchTransferItem",
                column: "ItemsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GoodsIssuedItem");

            migrationBuilder.DropTable(
                name: "GoodsReceiveItem");

            migrationBuilder.DropTable(
                name: "InterBranchTransferItem");

            migrationBuilder.DropTable(
                name: "GoodsIssueds");

            migrationBuilder.DropTable(
                name: "GoodsReceiveds");

            migrationBuilder.DropTable(
                name: "InterBranchTransfers");

            migrationBuilder.CreateTable(
                name: "MMs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Number = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Number = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PZs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WZs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Number = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                name: "IX_ItemWZ_WZsId",
                table: "ItemWZ",
                column: "WZsId");
        }
    }
}
