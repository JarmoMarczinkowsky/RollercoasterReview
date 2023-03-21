using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RollercoasterReview.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Park",
                columns: table => new
                {
                    ParkId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Park", x => x.ParkId);
                });

            migrationBuilder.CreateTable(
                name: "Rollercoaster",
                columns: table => new
                {
                    RollercoasterId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BackgroundInfo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Year = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ParkId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rollercoaster", x => x.RollercoasterId);
                    table.ForeignKey(
                        name: "FK_Rollercoaster_Park_ParkId",
                        column: x => x.ParkId,
                        principalTable: "Park",
                        principalColumn: "ParkId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Rating",
                columns: table => new
                {
                    RatingId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RollercoasterId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    UserId1 = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    RatingValue = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rating", x => x.RatingId);
                    table.ForeignKey(
                        name: "FK_Rating_AspNetUsers_UserId1",
                        column: x => x.UserId1,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Rating_Rollercoaster_RollercoasterId",
                        column: x => x.RollercoasterId,
                        principalTable: "Rollercoaster",
                        principalColumn: "RollercoasterId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Review",
                columns: table => new
                {
                    ReviewId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Partner = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RollercoasterId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    UserId1 = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Review", x => x.ReviewId);
                    table.ForeignKey(
                        name: "FK_Review_AspNetUsers_UserId1",
                        column: x => x.UserId1,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Review_Rollercoaster_RollercoasterId",
                        column: x => x.RollercoasterId,
                        principalTable: "Rollercoaster",
                        principalColumn: "RollercoasterId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Rating_RollercoasterId",
                table: "Rating",
                column: "RollercoasterId");

            migrationBuilder.CreateIndex(
                name: "IX_Rating_UserId1",
                table: "Rating",
                column: "UserId1");

            migrationBuilder.CreateIndex(
                name: "IX_Review_RollercoasterId",
                table: "Review",
                column: "RollercoasterId");

            migrationBuilder.CreateIndex(
                name: "IX_Review_UserId1",
                table: "Review",
                column: "UserId1");

            migrationBuilder.CreateIndex(
                name: "IX_Rollercoaster_ParkId",
                table: "Rollercoaster",
                column: "ParkId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Rating");

            migrationBuilder.DropTable(
                name: "Review");

            migrationBuilder.DropTable(
                name: "Rollercoaster");

            migrationBuilder.DropTable(
                name: "Park");
        }
    }
}
