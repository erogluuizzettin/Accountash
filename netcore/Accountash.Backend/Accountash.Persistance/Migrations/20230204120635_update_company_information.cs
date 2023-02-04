using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Accountash.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class updatecompanyinformation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DatabaseName",
                table: "Companies",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DbPassword",
                table: "Companies",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DbUserId",
                table: "Companies",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ServerName",
                table: "Companies",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DatabaseName",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "DbPassword",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "DbUserId",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "ServerName",
                table: "Companies");
        }
    }
}
