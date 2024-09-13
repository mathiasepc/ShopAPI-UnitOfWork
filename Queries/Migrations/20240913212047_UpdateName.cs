using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Queries.Migrations
{
    /// <inheritdoc />
    public partial class UpdateName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "name",
                table: "Models",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Makes",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Items",
                newName: "Name");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Models",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Makes",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Items",
                newName: "name");
        }
    }
}
