using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFProject.Migrations
{
    /// <inheritdoc />
    public partial class NewMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EmailAddress",
                schema: "ef",
                table: "Actors");

            migrationBuilder.AddColumn<string>(
                name: "FullName",
                schema: "ef",
                table: "Directors",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FullName",
                schema: "ef",
                table: "Directors");

            migrationBuilder.AddColumn<string>(
                name: "EmailAddress",
                schema: "ef",
                table: "Actors",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);
        }
    }
}
