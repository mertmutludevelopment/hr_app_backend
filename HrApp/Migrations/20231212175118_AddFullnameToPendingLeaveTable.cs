using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HrApp.Migrations
{
    public partial class AddFullnameToPendingLeaveTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Fullname",
                table: "PendingLeaves",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Fullname",
                table: "PendingLeaves");
        }
    }
}
