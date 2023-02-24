using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreDeepDive.Migrations
{
    /// <inheritdoc />
    public partial class manytoanyrelationsadded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CinemaHall_Cinemas_CinemaId",
                table: "CinemaHall");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CinemaHall",
                table: "CinemaHall");

            migrationBuilder.RenameTable(
                name: "CinemaHall",
                newName: "CinemaHalls");

            migrationBuilder.RenameIndex(
                name: "IX_CinemaHall_CinemaId",
                table: "CinemaHalls",
                newName: "IX_CinemaHalls_CinemaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CinemaHalls",
                table: "CinemaHalls",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "CinemaHallMovie",
                columns: table => new
                {
                    CinemaHallsId = table.Column<int>(type: "int", nullable: false),
                    MoviesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CinemaHallMovie", x => new { x.CinemaHallsId, x.MoviesId });
                    table.ForeignKey(
                        name: "FK_CinemaHallMovie_CinemaHalls_CinemaHallsId",
                        column: x => x.CinemaHallsId,
                        principalTable: "CinemaHalls",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CinemaHallMovie_Movies_MoviesId",
                        column: x => x.MoviesId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GenreMovie",
                columns: table => new
                {
                    GenresId = table.Column<int>(type: "int", nullable: false),
                    MoviesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GenreMovie", x => new { x.GenresId, x.MoviesId });
                    table.ForeignKey(
                        name: "FK_GenreMovie_Genres_GenresId",
                        column: x => x.GenresId,
                        principalTable: "Genres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GenreMovie_Movies_MoviesId",
                        column: x => x.MoviesId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MovieActors",
                columns: table => new
                {
                    MovieId = table.Column<int>(type: "int", nullable: false),
                    ActorId = table.Column<int>(type: "int", nullable: false),
                    Charecter = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Order = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieActors", x => new { x.MovieId, x.ActorId });
                    table.ForeignKey(
                        name: "FK_MovieActors_Actors_ActorId",
                        column: x => x.ActorId,
                        principalTable: "Actors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MovieActors_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CinemaHallMovie_MoviesId",
                table: "CinemaHallMovie",
                column: "MoviesId");

            migrationBuilder.CreateIndex(
                name: "IX_GenreMovie_MoviesId",
                table: "GenreMovie",
                column: "MoviesId");

            migrationBuilder.CreateIndex(
                name: "IX_MovieActors_ActorId",
                table: "MovieActors",
                column: "ActorId");

            migrationBuilder.AddForeignKey(
                name: "FK_CinemaHalls_Cinemas_CinemaId",
                table: "CinemaHalls",
                column: "CinemaId",
                principalTable: "Cinemas",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CinemaHalls_Cinemas_CinemaId",
                table: "CinemaHalls");

            migrationBuilder.DropTable(
                name: "CinemaHallMovie");

            migrationBuilder.DropTable(
                name: "GenreMovie");

            migrationBuilder.DropTable(
                name: "MovieActors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CinemaHalls",
                table: "CinemaHalls");

            migrationBuilder.RenameTable(
                name: "CinemaHalls",
                newName: "CinemaHall");

            migrationBuilder.RenameIndex(
                name: "IX_CinemaHalls_CinemaId",
                table: "CinemaHall",
                newName: "IX_CinemaHall_CinemaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CinemaHall",
                table: "CinemaHall",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CinemaHall_Cinemas_CinemaId",
                table: "CinemaHall",
                column: "CinemaId",
                principalTable: "Cinemas",
                principalColumn: "Id");
        }
    }
}
