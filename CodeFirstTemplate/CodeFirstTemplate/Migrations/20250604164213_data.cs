using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CodeFirstTemplate.Migrations
{
    /// <inheritdoc />
    public partial class data : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "id", "FirstName", "LastName", "PhoneNumber" },
                values: new object[,]
                {
                    { -3, "John", "Doe", "123456789" },
                    { -2, "John", "Doe", "123456789" },
                    { -1, "John", "Doe", "123456789" }
                });

            migrationBuilder.InsertData(
                table: "TicketConcerts",
                columns: new[] { "Id", "Price" },
                values: new object[,]
                {
                    { -3, 1000.0 },
                    { -2, 1000.0 },
                    { -1, 1000.0 }
                });

            migrationBuilder.InsertData(
                table: "PurchasedTickets",
                columns: new[] { "Id", "CustomerId", "TicketConcertId" },
                values: new object[] { -1, -1, -1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "id",
                keyValue: -3);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "id",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "PurchasedTickets",
                keyColumn: "Id",
                keyValue: -1);

            migrationBuilder.DeleteData(
                table: "TicketConcerts",
                keyColumn: "Id",
                keyValue: -3);

            migrationBuilder.DeleteData(
                table: "TicketConcerts",
                keyColumn: "Id",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "id",
                keyValue: -1);

            migrationBuilder.DeleteData(
                table: "TicketConcerts",
                keyColumn: "Id",
                keyValue: -1);
        }
    }
}
