using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FIX.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddingCarPartServiceRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MechanicId",
                table: "Services",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "WorkshopId",
                table: "Services",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CarPartShopId",
                table: "CarParts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Services_MechanicId",
                table: "Services",
                column: "MechanicId");

            migrationBuilder.CreateIndex(
                name: "IX_Services_WorkshopId",
                table: "Services",
                column: "WorkshopId");

            migrationBuilder.CreateIndex(
                name: "IX_CarParts_CarPartShopId",
                table: "CarParts",
                column: "CarPartShopId");

            migrationBuilder.AddForeignKey(
                name: "FK_CarParts_CarPartShops_CarPartShopId",
                table: "CarParts",
                column: "CarPartShopId",
                principalTable: "CarPartShops",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Services_Mechanics_MechanicId",
                table: "Services",
                column: "MechanicId",
                principalTable: "Mechanics",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Services_Workshops_WorkshopId",
                table: "Services",
                column: "WorkshopId",
                principalTable: "Workshops",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CarParts_CarPartShops_CarPartShopId",
                table: "CarParts");

            migrationBuilder.DropForeignKey(
                name: "FK_Services_Mechanics_MechanicId",
                table: "Services");

            migrationBuilder.DropForeignKey(
                name: "FK_Services_Workshops_WorkshopId",
                table: "Services");

            migrationBuilder.DropIndex(
                name: "IX_Services_MechanicId",
                table: "Services");

            migrationBuilder.DropIndex(
                name: "IX_Services_WorkshopId",
                table: "Services");

            migrationBuilder.DropIndex(
                name: "IX_CarParts_CarPartShopId",
                table: "CarParts");

            migrationBuilder.DropColumn(
                name: "MechanicId",
                table: "Services");

            migrationBuilder.DropColumn(
                name: "WorkshopId",
                table: "Services");

            migrationBuilder.DropColumn(
                name: "CarPartShopId",
                table: "CarParts");
        }
    }
}
