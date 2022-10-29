using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SqlLite.Migrations
{
    public partial class dbv4usgaeGadget : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TimesUsed",
                table: "Gadgets",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TimesUsed",
                table: "Gadgets");
        }
    }
}
