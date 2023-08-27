using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Coin",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "VARCHAR", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coin", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CoinResults",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Level = table.Column<int>(type: "integer", nullable: false),
                    Rolls = table.Column<int>(type: "integer", nullable: false),
                    Sides = table.Column<int>(type: "integer", nullable: false),
                    Multiplier = table.Column<int>(type: "integer", nullable: false),
                    CoinId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoinResults", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CoinResults_Coin_CoinId",
                        column: x => x.CoinId,
                        principalTable: "Coin",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Coin",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Iron" },
                    { 2, "Half Copper" },
                    { 3, "Copper" },
                    { 4, "Nickel" },
                    { 5, "Silver" },
                    { 6, "Electrum" },
                    { 7, "Gold" },
                    { 8, "Platinum" }
                });

            migrationBuilder.InsertData(
                table: "CoinResults",
                columns: new[] { "Id", "CoinId", "Level", "Multiplier", "Rolls", "Sides" },
                values: new object[,]
                {
                    { 1, 3, 1, 1000, 2, 6 },
                    { 2, 4, 1, 100, 4, 6 },
                    { 3, 5, 1, 100, 2, 6 },
                    { 4, 7, 1, 10, 2, 8 },
                    { 5, 8, 1, 10, 1, 4 },
                    { 6, 3, 2, 1000, 2, 10 },
                    { 7, 4, 2, 100, 4, 10 },
                    { 8, 5, 2, 100, 2, 10 },
                    { 9, 7, 2, 10, 3, 10 },
                    { 10, 8, 2, 10, 1, 6 },
                    { 11, 3, 3, 1000, 3, 10 },
                    { 12, 4, 3, 1000, 2, 4 },
                    { 13, 5, 3, 1000, 1, 6 },
                    { 14, 7, 3, 100, 2, 4 },
                    { 15, 8, 3, 10, 2, 6 },
                    { 16, 3, 4, 1000, 4, 10 },
                    { 17, 4, 4, 1000, 2, 6 },
                    { 18, 5, 4, 100, 2, 4 },
                    { 19, 7, 4, 100, 2, 6 },
                    { 20, 8, 4, 10, 2, 8 },
                    { 21, 3, 5, 1000, 5, 10 },
                    { 22, 4, 5, 1000, 2, 8 },
                    { 23, 5, 5, 1000, 2, 6 },
                    { 24, 7, 5, 100, 2, 8 },
                    { 25, 8, 5, 10, 2, 10 },
                    { 26, 3, 6, 10000, 2, 4 },
                    { 27, 4, 6, 1000, 4, 6 },
                    { 28, 5, 6, 1000, 2, 6 },
                    { 29, 7, 6, 100, 2, 8 },
                    { 30, 8, 6, 10, 3, 6 },
                    { 31, 3, 7, 10000, 2, 6 },
                    { 32, 4, 7, 1000, 4, 8 },
                    { 33, 5, 7, 1000, 3, 6 },
                    { 34, 7, 7, 100, 3, 8 },
                    { 35, 8, 7, 10, 4, 6 },
                    { 36, 3, 8, 10000, 3, 6 },
                    { 37, 4, 8, 1000, 6, 8 },
                    { 38, 5, 8, 1000, 3, 8 },
                    { 39, 7, 8, 100, 4, 8 },
                    { 40, 8, 8, 10, 5, 8 },
                    { 41, 3, 9, 10000, 3, 8 },
                    { 42, 4, 9, 1000, 6, 8 },
                    { 43, 5, 9, 1000, 4, 6 },
                    { 44, 7, 9, 100, 4, 8 },
                    { 45, 8, 9, 10, 4, 10 },
                    { 46, 4, 10, 10000, 1, 6 },
                    { 47, 5, 10, 1000, 4, 10 },
                    { 48, 7, 10, 100, 4, 12 },
                    { 49, 8, 10, 10, 5, 10 },
                    { 50, 4, 11, 10000, 2, 4 },
                    { 51, 5, 11, 1000, 5, 10 },
                    { 52, 7, 11, 100, 5, 12 },
                    { 53, 8, 11, 100, 2, 4 },
                    { 54, 4, 12, 10000, 2, 4 },
                    { 55, 5, 12, 1000, 5, 10 },
                    { 56, 7, 12, 1000, 1, 6 },
                    { 57, 8, 12, 100, 2, 4 },
                    { 58, 5, 13, 1000, 1, 6 },
                    { 59, 7, 13, 1000, 2, 4 },
                    { 60, 8, 13, 100, 2, 6 },
                    { 61, 5, 14, 10000, 2, 4 },
                    { 62, 7, 14, 1000, 2, 6 },
                    { 63, 8, 14, 100, 2, 8 },
                    { 64, 5, 15, 10000, 2, 6 },
                    { 65, 7, 15, 1000, 3, 6 },
                    { 67, 8, 15, 100, 3, 8 },
                    { 68, 5, 16, 10000, 3, 6 },
                    { 69, 7, 16, 1000, 3, 8 },
                    { 70, 8, 16, 100, 3, 10 },
                    { 71, 5, 17, 10000, 3, 8 },
                    { 72, 7, 17, 1000, 3, 10 },
                    { 73, 8, 17, 100, 3, 12 },
                    { 74, 5, 18, 10000, 3, 10 },
                    { 75, 7, 18, 1000, 3, 12 },
                    { 76, 8, 18, 100, 4, 10 },
                    { 77, 5, 19, 10000, 4, 8 },
                    { 78, 7, 19, 1000, 4, 10 },
                    { 79, 8, 19, 100, 4, 12 },
                    { 80, 5, 20, 10000, 4, 10 },
                    { 81, 7, 20, 1000, 4, 12 },
                    { 82, 8, 20, 100, 5, 10 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CoinResults_CoinId",
                table: "CoinResults",
                column: "CoinId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CoinResults");

            migrationBuilder.DropTable(
                name: "Coin");
        }
    }
}
