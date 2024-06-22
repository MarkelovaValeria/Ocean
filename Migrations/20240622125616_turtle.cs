using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Ocean.Migrations
{
    /// <inheritdoc />
    public partial class turtle : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employers",
                columns: new[] { "Id", "DescriptionEmployer", "FullName", "PathPhoto" },
                values: new object[,]
                {
                    { 1, "Lorem ipsum dolor sit amet.", "Catherine Shevchenko", "/images/Employers/1.jpeg" },
                    { 2, "Lorem ipsum dolor sit amet.", "Matthew Tkachenko", "/images/Employers/2.jpeg" },
                    { 3, "Lorem ipsum dolor sit amet.", "Lilia Petrenko", "/images/Employers/3.jpeg" },
                    { 4, "Lorem ipsum dolor sit amet.", "Martin Goncharenko", "/images/Employers/4.jpeg" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Employers",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
