using Microsoft.EntityFrameworkCore.Migrations;

namespace TFZRAutosalon.Data.Migrations
{
    public partial class fixv2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Manufacturers_FK_CarManufacturers_Cars1",
                table: "Cars");

            migrationBuilder.DropForeignKey(
                name: "FK_Cars_CarModels_FK_CarModels_Cars1",
                table: "Cars");

            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Categorizes_FK_Category_Cars1",
                table: "Cars");

            migrationBuilder.DropIndex(
                name: "IX_Cars_FK_CarManufacturers_Cars1",
                table: "Cars");

            migrationBuilder.DropIndex(
                name: "IX_Cars_FK_CarModels_Cars1",
                table: "Cars");

            migrationBuilder.DropIndex(
                name: "IX_Cars_FK_Category_Cars1",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "FK_CarManufacturers_Cars1",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "FK_CarModels_Cars1",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "FK_Category_Cars1",
                table: "Cars");

            migrationBuilder.RenameColumn(
                name: "FK_CarManufacturers_Cars",
                table: "Cars",
                newName: "ManufacturersId");

            migrationBuilder.RenameColumn(
                name: "FK_Category_Cars",
                table: "Cars",
                newName: "CategoryId");

            migrationBuilder.RenameColumn(
                name: "FK_CarModels_Cars",
                table: "Cars",
                newName: "CarModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_CarModelId",
                table: "Cars",
                column: "CarModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_CategoryId",
                table: "Cars",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_ManufacturersId",
                table: "Cars",
                column: "ManufacturersId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_CarModels_CarModelId",
                table: "Cars",
                column: "CarModelId",
                principalTable: "CarModels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Categorizes_CategoryId",
                table: "Cars",
                column: "CategoryId",
                principalTable: "Categorizes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Manufacturers_ManufacturersId",
                table: "Cars",
                column: "ManufacturersId",
                principalTable: "Manufacturers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cars_CarModels_CarModelId",
                table: "Cars");

            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Categorizes_CategoryId",
                table: "Cars");

            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Manufacturers_ManufacturersId",
                table: "Cars");

            migrationBuilder.DropIndex(
                name: "IX_Cars_CarModelId",
                table: "Cars");

            migrationBuilder.DropIndex(
                name: "IX_Cars_CategoryId",
                table: "Cars");

            migrationBuilder.DropIndex(
                name: "IX_Cars_ManufacturersId",
                table: "Cars");

            migrationBuilder.RenameColumn(
                name: "ManufacturersId",
                table: "Cars",
                newName: "FK_CarManufacturers_Cars");

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "Cars",
                newName: "FK_Category_Cars");

            migrationBuilder.RenameColumn(
                name: "CarModelId",
                table: "Cars",
                newName: "FK_CarModels_Cars");

            migrationBuilder.AddColumn<int>(
                name: "FK_CarManufacturers_Cars1",
                table: "Cars",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FK_CarModels_Cars1",
                table: "Cars",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FK_Category_Cars1",
                table: "Cars",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Cars_FK_CarManufacturers_Cars1",
                table: "Cars",
                column: "FK_CarManufacturers_Cars1");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_FK_CarModels_Cars1",
                table: "Cars",
                column: "FK_CarModels_Cars1");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_FK_Category_Cars1",
                table: "Cars",
                column: "FK_Category_Cars1");

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Manufacturers_FK_CarManufacturers_Cars1",
                table: "Cars",
                column: "FK_CarManufacturers_Cars1",
                principalTable: "Manufacturers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_CarModels_FK_CarModels_Cars1",
                table: "Cars",
                column: "FK_CarModels_Cars1",
                principalTable: "CarModels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Categorizes_FK_Category_Cars1",
                table: "Cars",
                column: "FK_Category_Cars1",
                principalTable: "Categorizes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
