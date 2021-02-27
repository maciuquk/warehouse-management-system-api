using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace warehouseManagementSystem.DataAcces.Migrations
{
    public partial class addManyToMany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Items",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "ReceptionOfGoodsPZs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Number = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReceptionOfGoodsPZs", x => x.Id);
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
                name: "IX_ItemReceptionOfGoodsPZ_ReceptionOfGoodsPZsId",
                table: "ItemReceptionOfGoodsPZ",
                column: "ReceptionOfGoodsPZsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ItemReceptionOfGoodsPZ");

            migrationBuilder.DropTable(
                name: "ReceptionOfGoodsPZs");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Items",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250);
        }
    }
}
