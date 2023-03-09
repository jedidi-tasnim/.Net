using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AM.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "VILLE DE DEPARTURE",
                table: "MyFlight",
                newName: "Departure");

            migrationBuilder.AlterColumn<string>(
                name: "Departure",
                table: "MyFlight",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nchar(100)",
                oldMaxLength: 100,
                oldDefaultValue: "Hammamet");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Departure",
                table: "MyFlight",
                newName: "VILLE DE DEPARTURE");

            migrationBuilder.AlterColumn<string>(
                name: "VILLE DE DEPARTURE",
                table: "MyFlight",
                type: "nchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "Hammamet",
                oldClrType: typeof(string),
                oldType: "nvarchar(120)",
                oldMaxLength: 120);
        }
    }
}
