using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TimDeskCore.Migrations
{
    public partial class SeedClientTechnicianActivityData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "AddressLine1", "AddressLine2", "City", "Email", "FirstName", "LastName", "PhoneNumber", "State", "ZipCode" },
                values: new object[] { 1, "3341 University Ave", null, "Utica", "charles@xavierschool.edu", "Charles", "Xavier", "332-333-1399", "NY", "10108" });

            migrationBuilder.InsertData(
                table: "Technicians",
                columns: new[] { "Id", "AddressLine1", "AddressLine2", "City", "Email", "FirstName", "LastName", "PhoneNumber", "State", "ZipCode" },
                values: new object[] { 1, "737 Renholm St", null, "London", "moss@itsolutions.net", "Morris", "Moss", "819-847-2185", "MA", "37662" });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "Id", "ClientId", "DateClosed", "DateSubmitted", "Description", "TechnicianId", "TicketStatus" },
                values: new object[] { 1, 1, null, new DateTime(2021, 6, 25, 22, 20, 6, 382, DateTimeKind.Local).AddTicks(6305), "Cerebro is down again.", 1, "Open" });

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "ActivityStatus", "DateClosed", "DateSubmitted", "Description", "IsSolution", "TechnicianId", "TicketId" },
                values: new object[] { 1, "Open", null, new DateTime(2021, 6, 25, 22, 20, 6, 385, DateTimeKind.Local).AddTicks(2740), "Turned it off and back on again.", false, 1, 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Technicians",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
