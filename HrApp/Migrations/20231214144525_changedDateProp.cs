using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HrApp.Migrations
{
    public partial class changedDateProp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AdvancePaymentDeadline",
                table: "AdvancePayments");

            migrationBuilder.DropColumn(
                name: "DateOfAdvanceReceived",
                table: "AdvancePayments");

            migrationBuilder.AddColumn<int>(
                name: "EndDay",
                table: "AdvancePayments",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EndMonth",
                table: "AdvancePayments",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EndYear",
                table: "AdvancePayments",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StartDay",
                table: "AdvancePayments",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StartMonth",
                table: "AdvancePayments",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StartYear",
                table: "AdvancePayments",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EndDay",
                table: "AdvancePayments");

            migrationBuilder.DropColumn(
                name: "EndMonth",
                table: "AdvancePayments");

            migrationBuilder.DropColumn(
                name: "EndYear",
                table: "AdvancePayments");

            migrationBuilder.DropColumn(
                name: "StartDay",
                table: "AdvancePayments");

            migrationBuilder.DropColumn(
                name: "StartMonth",
                table: "AdvancePayments");

            migrationBuilder.DropColumn(
                name: "StartYear",
                table: "AdvancePayments");

            migrationBuilder.AddColumn<string>(
                name: "AdvancePaymentDeadline",
                table: "AdvancePayments",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DateOfAdvanceReceived",
                table: "AdvancePayments",
                type: "text",
                nullable: false,
                defaultValue: "");
        }
    }
}
