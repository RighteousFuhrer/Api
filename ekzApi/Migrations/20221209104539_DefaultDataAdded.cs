using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ekzApi.Migrations
{
    /// <inheritdoc />
    public partial class DefaultDataAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Cost",
                table: "Expenses",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.InsertData(
                table: "Expenses",
                columns: new[] { "Id", "Category", "Cost", "Name", "Time" },
                values: new object[,]
                {
                    { 1, 0, 200.0, "Cinema ticket purchase", new DateTime(2022, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 3, 150.0, "Taxi ride", new DateTime(2022, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 1, 3000.0, "Rental", new DateTime(2022, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 4, 50.0, "Charity", new DateTime(2022, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 2, 500.0, "Tracksuit purchase", new DateTime(2022, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, 2, 1500.0, "Table purchase", new DateTime(2022, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, 1, 350.0, "Food", new DateTime(2022, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, 4, 2000.0, "Gambling", new DateTime(2022, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, 3, 400.0, "Haircut", new DateTime(2022, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, 0, 100.0, "Netflix subscription", new DateTime(2022, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DropColumn(
                name: "Cost",
                table: "Expenses");
        }
    }
}
