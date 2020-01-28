using Microsoft.EntityFrameworkCore.Migrations;

namespace BulkCopy.Infrastructure.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Transfers",
                columns: table => new
                {
                    FromAccount = table.Column<int>(nullable: false),
                    ToAccount = table.Column<int>(nullable: false),
                    TransferAmount = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Transfers");
        }
    }
}
