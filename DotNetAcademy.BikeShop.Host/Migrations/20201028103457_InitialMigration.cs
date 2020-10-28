using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DotNetAcademy.BikeShop.Host.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    FirstName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    Price = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ShoppingBags",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(nullable: false, defaultValueSql: "getdate()"),
                    CustomerId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingBags", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShoppingBags_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ShoppingItems",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quantity = table.Column<int>(nullable: false),
                    BagId = table.Column<int>(nullable: false),
                    ProductId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShoppingItems_ShoppingBags_BagId",
                        column: x => x.BagId,
                        principalTable: "ShoppingBags",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ShoppingItems_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "xbql52za", 257.7m },
                    { 28, "4ar4pm5y", 432.69m },
                    { 29, "xp0nsutm", 335.38m },
                    { 30, "oyuwdc2c", 288.07m },
                    { 31, "1b0bqwds", 307.34m },
                    { 32, "aaixrj10", 139.9m },
                    { 33, "mzdxoaom", 496.67m },
                    { 34, "zzj3nhg1", 473.94m },
                    { 35, "4tbk5iwp", 53.02m },
                    { 36, "1bqs3bu1", 457.35m },
                    { 37, "2u0ex4rl", 488.16m },
                    { 38, "y4ityerx", 490.01m },
                    { 39, "1xfl5ouv", 323.58m },
                    { 40, "m05xhabz", 320.71m },
                    { 41, "00dneyy1", 174.83m },
                    { 42, "lizyqna5", 309.85m },
                    { 43, "z1puc4u4", 180.76m },
                    { 44, "vprqaj5u", 328.04m },
                    { 45, "1kbtooes", 421.96m },
                    { 46, "ksu5hvo3", 31.27m },
                    { 47, "glwj0y5b", 241.99m },
                    { 48, "otjm3keg", 26.6m },
                    { 27, "0jhkjvwf", 496.52m },
                    { 26, "jvtteamk", 377.98m },
                    { 25, "hbwa4cg4", 209.12m },
                    { 24, "wakpcogx", 218.07m },
                    { 2, "0bbo104h", 207.32m },
                    { 3, "pagvzybw", 31.41m },
                    { 4, "1tdsvfre", 396.52m },
                    { 5, "3wwjr5af", 162.73m },
                    { 6, "rx5a5uif", 357.42m },
                    { 7, "n4idaifn", 124.46m },
                    { 8, "lyecnqyz", 183.41m },
                    { 9, "hydcj3pq", 95.63m },
                    { 10, "55mkjfza", 169.94m },
                    { 11, "kgjwdpiz", 324.1m },
                    { 49, "hipnup04", 417.38m },
                    { 12, "r3fyde4u", 255.12m },
                    { 14, "suc20vqk", 269.78m },
                    { 15, "go3pvt45", 453.02m },
                    { 16, "uwsz0ktz", 383.34m },
                    { 17, "utfsrazf", 356.02m },
                    { 18, "nd1muem2", 474.36m },
                    { 19, "i3gj0fzs", 304.66m },
                    { 20, "qyc3zcrc", 341.16m },
                    { 21, "hik15flb", 72.49m },
                    { 22, "otbqpwrp", 115.86m },
                    { 23, "cfvlclvx", 137.22m },
                    { 13, "ee5hai2b", 390.12m },
                    { 50, "sbwv2mro", 471.6m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingBags_CustomerId",
                table: "ShoppingBags",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingItems_BagId",
                table: "ShoppingItems",
                column: "BagId");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingItems_ProductId",
                table: "ShoppingItems",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ShoppingItems");

            migrationBuilder.DropTable(
                name: "ShoppingBags");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
