using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TFZRAutosalon.Data.Migrations
{
    public partial class additionaltables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categorizes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorizes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Manufacturers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Manufacturers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CarModels",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    FK_Categorizes_CarModels = table.Column<int>(nullable: true),
                    FK_Manufacturer_CarModels = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarModels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CarModels_Categorizes_FK_Categorizes_CarModels",
                        column: x => x.FK_Categorizes_CarModels,
                        principalTable: "Categorizes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CarModels_Manufacturers_FK_Manufacturer_CarModels",
                        column: x => x.FK_Manufacturer_CarModels,
                        principalTable: "Manufacturers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FK_CarModels_Cars = table.Column<int>(nullable: true),
                    FK_CarManufacturers_Cars = table.Column<int>(nullable: true),
                    CategorizId = table.Column<int>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    HorsePower = table.Column<long>(nullable: false),
                    Torque = table.Column<long>(nullable: false),
                    NumberOfDoors = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cars_Categorizes_CategorizId",
                        column: x => x.CategorizId,
                        principalTable: "Categorizes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Cars_Manufacturers_FK_CarManufacturers_Cars",
                        column: x => x.FK_CarManufacturers_Cars,
                        principalTable: "Manufacturers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Cars_CarModels_FK_CarModels_Cars",
                        column: x => x.FK_CarModels_Cars,
                        principalTable: "CarModels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FK_Users_Orders = table.Column<string>(nullable: true),
                    FK_Cars_Orders = table.Column<int>(nullable: true),
                    Status = table.Column<int>(nullable: false),
                    DateOfPurchase = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Cars_FK_Cars_Orders",
                        column: x => x.FK_Cars_Orders,
                        principalTable: "Cars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Orders_Users_FK_Users_Orders",
                        column: x => x.FK_Users_Orders,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CarModels_FK_Categorizes_CarModels",
                table: "CarModels",
                column: "FK_Categorizes_CarModels");

            migrationBuilder.CreateIndex(
                name: "IX_CarModels_FK_Manufacturer_CarModels",
                table: "CarModels",
                column: "FK_Manufacturer_CarModels");

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

            migrationBuilder.CreateIndex(
                name: "IX_Orders_FK_Cars_Orders",
                table: "Orders",
                column: "FK_Cars_Orders");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_FK_Users_Orders",
                table: "Orders",
                column: "FK_Users_Orders");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Cars");

            migrationBuilder.DropTable(
                name: "CarModels");

            migrationBuilder.DropTable(
                name: "Categorizes");

            migrationBuilder.DropTable(
                name: "Manufacturers");
        }
    }
}
