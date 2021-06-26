using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TimDeskCore.Migrations
{
    public partial class ModifyActivityModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Activities_Technicians_TechnicianId",
                table: "Activities");

            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Clients_RequestedById",
                table: "Tickets");

            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Technicians_AssignedTechnicianId",
                table: "Tickets");

            migrationBuilder.DropIndex(
                name: "IX_Tickets_AssignedTechnicianId",
                table: "Tickets");

            migrationBuilder.DropIndex(
                name: "IX_Tickets_RequestedById",
                table: "Tickets");

            migrationBuilder.DropIndex(
                name: "IX_Activities_TechnicianId",
                table: "Activities");

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "AssignedTechnicianId",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "RequestedById",
                table: "Tickets");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateClosed",
                table: "Tickets",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<int>(
                name: "ClientId",
                table: "Tickets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TechnicianId",
                table: "Tickets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "TechnicianId",
                table: "Activities",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateClosed",
                table: "Activities",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_ClientId",
                table: "Tickets",
                column: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Clients_ClientId",
                table: "Tickets",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Clients_ClientId",
                table: "Tickets");

            migrationBuilder.DropIndex(
                name: "IX_Tickets_ClientId",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "ClientId",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "TechnicianId",
                table: "Tickets");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateClosed",
                table: "Tickets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AssignedTechnicianId",
                table: "Tickets",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RequestedById",
                table: "Tickets",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TechnicianId",
                table: "Activities",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateClosed",
                table: "Activities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "AddressLine1", "AddressLine2", "City", "Email", "FirstName", "LastName", "PhoneNumber", "State", "ZipCode" },
                values: new object[] { 1, "3341 University Ave", null, "Utica", "charles@xavierschool.edu", "Charles", "Xavier", "332-333-1399", "NY", "10108" });

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_AssignedTechnicianId",
                table: "Tickets",
                column: "AssignedTechnicianId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_RequestedById",
                table: "Tickets",
                column: "RequestedById");

            migrationBuilder.CreateIndex(
                name: "IX_Activities_TechnicianId",
                table: "Activities",
                column: "TechnicianId");

            migrationBuilder.AddForeignKey(
                name: "FK_Activities_Technicians_TechnicianId",
                table: "Activities",
                column: "TechnicianId",
                principalTable: "Technicians",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Clients_RequestedById",
                table: "Tickets",
                column: "RequestedById",
                principalTable: "Clients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Technicians_AssignedTechnicianId",
                table: "Tickets",
                column: "AssignedTechnicianId",
                principalTable: "Technicians",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
