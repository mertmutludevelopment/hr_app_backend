using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HrApp.Migrations
{
    public partial class AddFullnameToApprovedLeaveTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Fullname",
                table: "ApprovedLeaves",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Fullname",
                table: "ApprovedLeaves");
        }
    }
}
