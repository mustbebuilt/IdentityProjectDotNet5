using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyFilmMVCV1.Migrations
{
    public partial class mvcSet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    FilmID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FilmTitle = table.Column<string>(nullable: false),
                    FilmCertificate = table.Column<string>(nullable: false),
                    FilmDescription = table.Column<string>(nullable: true),
                    FilmImage = table.Column<string>(nullable: true),
                    FilmPrice = table.Column<decimal>(nullable: false),
                    Stars = table.Column<int>(nullable: false),
                    ReleaseDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.FilmID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movies");
        }
    }
}
