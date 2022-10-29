using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SqlLite.Migrations
{
    public partial class dbv1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Persons_EMail",
                table: "Persons",
                column: "EMail",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Persons_Phone",
                table: "Persons",
                column: "Phone",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Persons_EMail",
                table: "Persons");

            migrationBuilder.DropIndex(
                name: "IX_Persons_Phone",
                table: "Persons");
        }
    }
}
