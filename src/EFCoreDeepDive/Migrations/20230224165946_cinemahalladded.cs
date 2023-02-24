using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreDeepDive.Migrations
{
    /// <inheritdoc />
    public partial class cinemahalladded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "Cinemas");

            migrationBuilder.CreateTable(
                name: "CinemaHall",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Cost = table.Column<decimal>(type: "decimal(5,2)", precision: 5, scale: 2, nullable: false),
                    HallType = table.Column<int>(type: "int", nullable: false, defaultValue: 1),
                    CinemaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CinemaHall", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CinemaHall_Cinemas_CinemaId",
                        column: x => x.CinemaId,
                        principalTable: "Cinemas",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_CinemaHall_CinemaId",
                table: "CinemaHall",
                column: "CinemaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CinemaHall");

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Cinemas",
                type: "decimal(5,2)",
                precision: 5,
                scale: 2,
                nullable: false,
                defaultValue: 0m);
        }
    }
}
