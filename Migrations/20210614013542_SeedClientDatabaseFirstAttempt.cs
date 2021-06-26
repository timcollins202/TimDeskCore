using Microsoft.EntityFrameworkCore.Migrations;

namespace TimDeskCore.Migrations
{
    public partial class SeedClientDatabaseFirstAttempt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Activities_Tickets_TicketId",
                table: "Activities");

            migrationBuilder.AlterColumn<int>(
                name: "TicketId",
                table: "Activities",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "AddressLine1", "AddressLine2", "City", "Email", "FirstName", "LastName", "PhoneNumber", "State", "ZipCode" },
                values: new object[] { 1, "3341 University Ave", null, "Utica", "charles@xavierschool.edu", "Charles", "Xavier", "332-333-1399", "NY", "10108" });

            migrationBuilder.AddForeignKey(
                name: "FK_Activities_Tickets_TicketId",
                table: "Activities",
                column: "TicketId",
                principalTable: "Tickets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Activities_Tickets_TicketId",
                table: "Activities");

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.AlterColumn<int>(
                name: "TicketId",
                table: "Activities",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Activities_Tickets_TicketId",
                table: "Activities",
                column: "TicketId",
                principalTable: "Tickets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
