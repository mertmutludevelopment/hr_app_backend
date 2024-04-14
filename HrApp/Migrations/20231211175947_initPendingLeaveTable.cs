using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace HrApp.Migrations
{
    public partial class initPendingLeaveTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PendingLeaves",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Reason = table.Column<string>(type: "text", nullable: false),
                    StartLeaveDay = table.Column<int>(type: "integer", nullable: false),
                    StartLeaveMonth = table.Column<int>(type: "integer", nullable: false),
                    StartLeaveYear = table.Column<int>(type: "integer", nullable: false),
                    EndLeaveDay = table.Column<int>(type: "integer", nullable: false),
                    EndLeaveMonth = table.Column<int>(type: "integer", nullable: false),
                    EndLeaveYear = table.Column<int>(type: "integer", nullable: false),
                    NumberOfLeaveDay = table.Column<int>(type: "integer", nullable: false),
                    UserId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PendingLeaves", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PendingLeaves");
        }
    }
}
