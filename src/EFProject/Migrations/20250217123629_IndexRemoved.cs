using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFProject.Migrations
{
    /// <inheritdoc />
    public partial class IndexRemoved : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "idx_1",
                schema: "ef",
                table: "Directors");

            migrationBuilder.DropIndex(
                name: "idx_1",
                schema: "ef",
                table: "Actors");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "idx_1",
                schema: "ef",
                table: "Directors",
                column: "FirstName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "idx_1",
                schema: "ef",
                table: "Actors",
                column: "FirstName",
                unique: true);
        }
    }
}
