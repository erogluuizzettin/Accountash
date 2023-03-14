using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Accountash.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class Change_userId_and_password_in_the_company : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DbUserId",
                table: "Companies",
                newName: "ServerUserId");

            migrationBuilder.RenameColumn(
                name: "DbPassword",
                table: "Companies",
                newName: "ServerPassword");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ServerUserId",
                table: "Companies",
                newName: "DbUserId");

            migrationBuilder.RenameColumn(
                name: "ServerPassword",
                table: "Companies",
                newName: "DbPassword");
        }
    }
}
