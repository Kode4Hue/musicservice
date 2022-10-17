using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MusicService.Migrations
{
    public partial class AddAlbumInitialSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("insert into album(id, name, year_released) values (1, 'Drones', 2015)\r\n" +
                "insert into album(id, name, year_released) values (2, 'Origin of Symmetry', 2001)\r\n" +
                "insert into album(id, name, year_released) values (3, 'Rio', 1982)\r\n" +
                "insert into album(id, name, year_released) values (4, '1984', 1984)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Delete FROM album where id = 1;" +
                "Delete FROM album where id = 2" +
                "Delete FROM album where id = 3" +
                "Delete FROM album where id = 4");
        }
    }
}
