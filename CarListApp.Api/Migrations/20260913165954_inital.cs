using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarListApp.Api.Migrations
{
    /// <inheritdoc />
    public partial class inital : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Make = table.Column<string>(type: "TEXT", nullable: false),
                    Model = table.Column<string>(type: "TEXT", nullable: false),
                    Vin = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "Make", "Model", "Vin" },
                values: new object[,]
                {
                    { 1, "Toyota", "Camry", "1234567890" },
                    { 2, "Honda", "Civic", "0987654321" },
                    { 3, "Ford", "Mustang", "5678901234" },
                    { 4, "BMW", "3 Series", "LLLFY2M0Y8XUC9WPW" },
                    { 5, "Nissan", "Altima", "V61PMGG7AEJW9ZT8D" },
                    { 6, "Audi", "A4", "4EE57GJKBAUTKG9LH" },
                    { 7, "Ford", "F-150", "1FTFW1ED5MFA12345" },
                    { 8, "Chevrolet", "Silverado", "1GCEKEDC0LF543210" },
                    { 9, "Hyundai", "Elantra", "5NPDH4AE7LH987654" },
                    { 10, "Jeep", "Wrangler", "1C4HJXDG0LW135792" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cars");
        }
    }
}
