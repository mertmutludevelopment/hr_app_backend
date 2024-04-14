using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HrApp.Migrations
{
    public partial class seedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "BirthDay", "BirthMonth", "BirthYear", "Department", "Email", "Fullname", "Password", "PhoneNumber" },
                values: new object[] { 1, 1, 1, 2001, "Mobile", "mert@gmail.com", "MERT MUTLU", "mert123", "5380329797" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
