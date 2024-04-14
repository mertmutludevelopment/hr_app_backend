using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HrApp.Migrations
{
    public partial class AddNotifySenderFullnametoNotificationTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "NotificationSenderFullname",
                table: "Notifications",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NotificationSenderFullname",
                table: "Notifications");
        }
    }
}
