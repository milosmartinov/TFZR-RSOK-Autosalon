using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TFZRAutosalon.Data.Migrations
{
    public partial class fix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Categorizes_CategorizId",
                table: "Cars");

            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Manufacturers_FK_CarManufacturers_Cars",
                table: "Cars");

            migrationBuilder.DropForeignKey(
                name: "FK_Cars_CarModels_FK_CarModels_Cars",
                table: "Cars");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Cars_FK_Cars_Orders",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Users_FK_Users_Orders",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_FK_Cars_Orders",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_FK_Users_Orders",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Cars_CategorizId",
                table: "Cars");

            migrationBuilder.DropIndex(
                name: "IX_Cars_FK_CarManufacturers_Cars",
                table: "Cars");

            migrationBuilder.DropIndex(
                name: "IX_Cars_FK_CarModels_Cars",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "CategorizId",
                table: "Cars");

            migrationBuilder.AlterColumn<Guid>(
                name: "FK_Users_Orders",
                table: "Orders",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "FK_Cars_Orders",
                table: "Orders",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FK_Cars_Orders1",
                table: "Orders",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FK_Users_Orders1",
                table: "Orders",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "FK_CarModels_Cars",
                table: "Cars",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "FK_CarManufacturers_Cars",
                table: "Cars",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FK_Category_Cars",
                table: "Cars",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "FK_CarManufacturers_Cars1",
                table: "Cars",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FK_CarModels_Cars1",
                table: "Cars",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FK_Category_Cars1",
                table: "Cars",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Orders_FK_Cars_Orders1",
                table: "Orders",
                column: "FK_Cars_Orders1");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_FK_Users_Orders1",
                table: "Orders",
                column: "FK_Users_Orders1");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Cars_FK_Cars_Orders1",
                table: "Orders",
                column: "FK_Cars_Orders1",
                principalTable: "Cars",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Users_FK_Users_Orders1",
                table: "Orders",
                column: "FK_Users_Orders1",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Cars_FK_Cars_Orders1",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Users_FK_Users_Orders1",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_FK_Cars_Orders1",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_FK_Users_Orders1",
                table: "Orders");

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
                name: "FK_Cars_Orders1",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "FK_Users_Orders1",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "FK_Category_Cars",
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

            migrationBuilder.AlterColumn<string>(
                name: "FK_Users_Orders",
                table: "Orders",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(Guid));

            migrationBuilder.AlterColumn<int>(
                name: "FK_Cars_Orders",
                table: "Orders",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "FK_CarManufacturers_Cars",
                table: "Cars",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "FK_CarModels_Cars",
                table: "Cars",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "CategorizId",
                table: "Cars",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Orders_FK_Cars_Orders",
                table: "Orders",
                column: "FK_Cars_Orders");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_FK_Users_Orders",
                table: "Orders",
                column: "FK_Users_Orders");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_CategorizId",
                table: "Cars",
                column: "CategorizId");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_FK_CarManufacturers_Cars",
                table: "Cars",
                column: "FK_CarManufacturers_Cars");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_FK_CarModels_Cars",
                table: "Cars",
                column: "FK_CarModels_Cars");

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Categorizes_CategorizId",
                table: "Cars",
                column: "CategorizId",
                principalTable: "Categorizes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Manufacturers_FK_CarManufacturers_Cars",
                table: "Cars",
                column: "FK_CarManufacturers_Cars",
                principalTable: "Manufacturers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_CarModels_FK_CarModels_Cars",
                table: "Cars",
                column: "FK_CarModels_Cars",
                principalTable: "CarModels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Cars_FK_Cars_Orders",
                table: "Orders",
                column: "FK_Cars_Orders",
                principalTable: "Cars",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Users_FK_Users_Orders",
                table: "Orders",
                column: "FK_Users_Orders",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
