using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ocean.Migrations
{
    /// <inheritdoc />
    public partial class newPhoto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 1,
                column: "PathPhoto",
                value: "/images/Animal/new2.png");

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 2,
                column: "PathPhoto",
                value: "/images/Animal/3new.png");

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 3,
                column: "PathPhoto",
                value: "/images/Animal/new4.png");

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 4,
                column: "PathPhoto",
                value: "/images/Animal/new5.png");

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 5,
                column: "PathPhoto",
                value: "/images/Animal/new6.png");

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 6,
                column: "PathPhoto",
                value: "/images/Animal/new7.png");

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 7,
                column: "PathPhoto",
                value: "/images/Animal/8new.png");

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "PathPhoto", "Rating" },
                values: new object[] { "/images/Animal/9new.png", 4 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 9,
                column: "PathPhoto",
                value: "/images/Animal/10new.png");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 1,
                column: "PathPhoto",
                value: "/images/Animal/2.png");

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 2,
                column: "PathPhoto",
                value: "/images/Animal/3.png");

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 3,
                column: "PathPhoto",
                value: "/images/Animal/4.png");

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 4,
                column: "PathPhoto",
                value: "/images/Animal/5.png");

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 5,
                column: "PathPhoto",
                value: "/images/Animal/6.png");

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 6,
                column: "PathPhoto",
                value: "/images/Animal/7.png");

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 7,
                column: "PathPhoto",
                value: "/images/Animal/8.png");

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "PathPhoto", "Rating" },
                values: new object[] { "/images/Animal/9.png", 5 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 9,
                column: "PathPhoto",
                value: "/images/Animal/10.png");
        }
    }
}
