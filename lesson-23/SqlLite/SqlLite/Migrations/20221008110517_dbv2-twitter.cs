using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SqlLite.Migrations
{
    public partial class dbv2twitter : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Twiter",
                table: "Persons",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Twiter",
                table: "Persons");
        }
    }
}
