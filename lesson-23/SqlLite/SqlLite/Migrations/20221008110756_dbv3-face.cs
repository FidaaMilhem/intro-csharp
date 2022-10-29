using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SqlLite.Migrations
{
    public partial class dbv3face : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Facebook",
                table: "Persons",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Facebook",
                table: "Persons");
        }
    }
}
