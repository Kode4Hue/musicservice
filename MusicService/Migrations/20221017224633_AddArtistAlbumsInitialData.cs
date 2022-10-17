using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MusicService.Migrations
{
    public partial class AddArtistAlbumsInitialData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("insert into artist_albums(artist_id, albums_id) values(1, 1)\r\n" +
                "insert into artist_albums(artist_id, albums_id) values(1, 2)\r\n" +
                "insert into artist_albums(artist_id, albums_id) values(2, 3)\r\n" +
                "insert into artist_albums(artist_id, albums_id) values(3, 4)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("delete from artist_albums where artist_id = 1 and albums_id =1;" +
                "delete from artist_albums where artist_id = 1 and albums_id =2;" +
                "delete from artist_albums where artist_id = 2 and albums_id =3;" +
                "delete from artist_albums where artist_id = 3 and albums_id =4;");
        }
    }
}
