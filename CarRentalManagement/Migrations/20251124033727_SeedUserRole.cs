using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 24, 11, 37, 27, 8, DateTimeKind.Local).AddTicks(5998), new DateTime(2025, 11, 24, 11, 37, 27, 8, DateTimeKind.Local).AddTicks(6022) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 24, 11, 37, 27, 8, DateTimeKind.Local).AddTicks(6024), new DateTime(2025, 11, 24, 11, 37, 27, 8, DateTimeKind.Local).AddTicks(6025) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 24, 11, 37, 27, 8, DateTimeKind.Local).AddTicks(6312), new DateTime(2025, 11, 24, 11, 37, 27, 8, DateTimeKind.Local).AddTicks(6314) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 24, 11, 37, 27, 8, DateTimeKind.Local).AddTicks(6316), new DateTime(2025, 11, 24, 11, 37, 27, 8, DateTimeKind.Local).AddTicks(6316) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 24, 11, 37, 27, 8, DateTimeKind.Local).AddTicks(6469), new DateTime(2025, 11, 24, 11, 37, 27, 8, DateTimeKind.Local).AddTicks(6470) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 24, 11, 37, 27, 8, DateTimeKind.Local).AddTicks(6474), new DateTime(2025, 11, 24, 11, 37, 27, 8, DateTimeKind.Local).AddTicks(6475) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 24, 11, 37, 27, 8, DateTimeKind.Local).AddTicks(6476), new DateTime(2025, 11, 24, 11, 37, 27, 8, DateTimeKind.Local).AddTicks(6477) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 24, 11, 37, 27, 8, DateTimeKind.Local).AddTicks(6478), new DateTime(2025, 11, 24, 11, 37, 27, 8, DateTimeKind.Local).AddTicks(6479) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 24, 11, 25, 26, 807, DateTimeKind.Local).AddTicks(9072), new DateTime(2025, 11, 24, 11, 25, 26, 807, DateTimeKind.Local).AddTicks(9083) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 24, 11, 25, 26, 807, DateTimeKind.Local).AddTicks(9086), new DateTime(2025, 11, 24, 11, 25, 26, 807, DateTimeKind.Local).AddTicks(9086) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 24, 11, 25, 26, 807, DateTimeKind.Local).AddTicks(9285), new DateTime(2025, 11, 24, 11, 25, 26, 807, DateTimeKind.Local).AddTicks(9286) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 24, 11, 25, 26, 807, DateTimeKind.Local).AddTicks(9288), new DateTime(2025, 11, 24, 11, 25, 26, 807, DateTimeKind.Local).AddTicks(9288) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 24, 11, 25, 26, 807, DateTimeKind.Local).AddTicks(9381), new DateTime(2025, 11, 24, 11, 25, 26, 807, DateTimeKind.Local).AddTicks(9382) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 24, 11, 25, 26, 807, DateTimeKind.Local).AddTicks(9383), new DateTime(2025, 11, 24, 11, 25, 26, 807, DateTimeKind.Local).AddTicks(9384) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 24, 11, 25, 26, 807, DateTimeKind.Local).AddTicks(9385), new DateTime(2025, 11, 24, 11, 25, 26, 807, DateTimeKind.Local).AddTicks(9385) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 24, 11, 25, 26, 807, DateTimeKind.Local).AddTicks(9386), new DateTime(2025, 11, 24, 11, 25, 26, 807, DateTimeKind.Local).AddTicks(9386) });
        }
    }
}
