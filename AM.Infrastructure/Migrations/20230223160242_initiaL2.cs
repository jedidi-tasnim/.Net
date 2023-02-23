using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AM.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class initiaL2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_flights_planes_Planeid",
                table: "flights");

            migrationBuilder.DropPrimaryKey(
                name: "PK_planes",
                table: "planes");

            migrationBuilder.RenameTable(
                name: "planes",
                newName: "Plane");

            migrationBuilder.AddColumn<int>(
                name: "MyProperty",
                table: "passengers",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Plane",
                table: "Plane",
                column: "Planeid");

            migrationBuilder.AddForeignKey(
                name: "FK_flights_Plane_Planeid",
                table: "flights",
                column: "Planeid",
                principalTable: "Plane",
                principalColumn: "Planeid",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_flights_Plane_Planeid",
                table: "flights");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Plane",
                table: "Plane");

            migrationBuilder.DropColumn(
                name: "MyProperty",
                table: "passengers");

            migrationBuilder.RenameTable(
                name: "Plane",
                newName: "planes");

            migrationBuilder.AddPrimaryKey(
                name: "PK_planes",
                table: "planes",
                column: "Planeid");

            migrationBuilder.AddForeignKey(
                name: "FK_flights_planes_Planeid",
                table: "flights",
                column: "Planeid",
                principalTable: "planes",
                principalColumn: "Planeid",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
