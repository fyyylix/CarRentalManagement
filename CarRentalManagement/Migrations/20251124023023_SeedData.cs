using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Colour",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 11, 24, 10, 30, 23, 55, DateTimeKind.Local).AddTicks(1788), new DateTime(2025, 11, 24, 10, 30, 23, 55, DateTimeKind.Local).AddTicks(1800), "Black", "System" },
                    { 2, "System", new DateTime(2025, 11, 24, 10, 30, 23, 55, DateTimeKind.Local).AddTicks(1803), new DateTime(2025, 11, 24, 10, 30, 23, 55, DateTimeKind.Local).AddTicks(1803), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Make",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 11, 24, 10, 30, 23, 55, DateTimeKind.Local).AddTicks(1998), new DateTime(2025, 11, 24, 10, 30, 23, 55, DateTimeKind.Local).AddTicks(1999), "BMW", "System" },
                    { 2, "System", new DateTime(2025, 11, 24, 10, 30, 23, 55, DateTimeKind.Local).AddTicks(2000), new DateTime(2025, 11, 24, 10, 30, 23, 55, DateTimeKind.Local).AddTicks(2000), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 11, 24, 10, 30, 23, 55, DateTimeKind.Local).AddTicks(2083), new DateTime(2025, 11, 24, 10, 30, 23, 55, DateTimeKind.Local).AddTicks(2083), "i4", "System" },
                    { 2, "System", new DateTime(2025, 11, 24, 10, 30, 23, 55, DateTimeKind.Local).AddTicks(2084), new DateTime(2025, 11, 24, 10, 30, 23, 55, DateTimeKind.Local).AddTicks(2085), "X5", "System" },
                    { 3, "System", new DateTime(2025, 11, 24, 10, 30, 23, 55, DateTimeKind.Local).AddTicks(2086), new DateTime(2025, 11, 24, 10, 30, 23, 55, DateTimeKind.Local).AddTicks(2086), "Prius", "System" },
                    { 4, "System", new DateTime(2025, 11, 24, 10, 30, 23, 55, DateTimeKind.Local).AddTicks(2087), new DateTime(2025, 11, 24, 10, 30, 23, 55, DateTimeKind.Local).AddTicks(2088), "C-HR", "System" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
