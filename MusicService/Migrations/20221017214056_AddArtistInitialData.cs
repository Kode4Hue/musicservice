using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MusicService.Migrations
{
    public partial class AddArtistInitialData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("insert into artist(id, name) values (1, 'Muse')\r\ninsert into artist(id, name) values (2, 'Duran Duran')\r\ninsert into artist(id, name) values (3, 'Van Halen')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Delete FROM artist WHERE id = 1");
            migrationBuilder.Sql("Delete FROM artist WHERE id = 2");
            migrationBuilder.Sql("Delete FROM artist WHERE id = 3");
        }
    }
}
