using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AM.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ex : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Planeid",
                table: "Passengers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "sections",
                columns: table => new
                {
                    IdSection = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sections", x => x.IdSection);
                });

            migrationBuilder.CreateTable(
                name: "seats",
                columns: table => new
                {
                    SeatId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    SeatNumber = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    size = table.Column<int>(type: "int", nullable: false),
                    Planeid = table.Column<int>(type: "int", nullable: false),
                    PlaneFk = table.Column<int>(type: "int", nullable: false),
                    SectionFk = table.Column<int>(type: "int", nullable: true),
                    PassengerPassportNumber = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_seats", x => x.SeatId);
                    table.ForeignKey(
                        name: "FK_seats_Passengers_PassengerPassportNumber",
                        column: x => x.PassengerPassportNumber,
                        principalTable: "Passengers",
                        principalColumn: "PassportNumber");
                    table.ForeignKey(
                        name: "FK_seats_Plane_Planeid",
                        column: x => x.Planeid,
                        principalTable: "Plane",
                        principalColumn: "Planeid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_seats_sections_SectionFk",
                        column: x => x.SectionFk,
                        principalTable: "sections",
                        principalColumn: "IdSection",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "reservations",
                columns: table => new
                {
                    DateReservation = table.Column<DateTime>(type: "date", nullable: false),
                    PassengerFK = table.Column<int>(type: "int", nullable: false),
                    SeatFK = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_reservations", x => new { x.PassengerFK, x.SeatFK, x.DateReservation });
                    table.ForeignKey(
                        name: "FK_reservations_Passengers_PassengerFK",
                        column: x => x.PassengerFK,
                        principalTable: "Passengers",
                        principalColumn: "PassportNumber",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_reservations_seats_SeatFK",
                        column: x => x.SeatFK,
                        principalTable: "seats",
                        principalColumn: "SeatId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Passengers_Planeid",
                table: "Passengers",
                column: "Planeid");

            migrationBuilder.CreateIndex(
                name: "IX_reservations_SeatFK",
                table: "reservations",
                column: "SeatFK");

            migrationBuilder.CreateIndex(
                name: "IX_seats_PassengerPassportNumber",
                table: "seats",
                column: "PassengerPassportNumber");

            migrationBuilder.CreateIndex(
                name: "IX_seats_Planeid",
                table: "seats",
                column: "Planeid");

            migrationBuilder.CreateIndex(
                name: "IX_seats_SectionFk",
                table: "seats",
                column: "SectionFk");

            migrationBuilder.AddForeignKey(
                name: "FK_Passengers_Plane_Planeid",
                table: "Passengers",
                column: "Planeid",
                principalTable: "Plane",
                principalColumn: "Planeid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Passengers_Plane_Planeid",
                table: "Passengers");

            migrationBuilder.DropTable(
                name: "reservations");

            migrationBuilder.DropTable(
                name: "seats");

            migrationBuilder.DropTable(
                name: "sections");

            migrationBuilder.DropIndex(
                name: "IX_Passengers_Planeid",
                table: "Passengers");

            migrationBuilder.DropColumn(
                name: "Planeid",
                table: "Passengers");
        }
    }
}
