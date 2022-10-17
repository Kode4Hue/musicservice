using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MusicService.Migrations
{
    public partial class AddSongInitialData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("insert into song(id, album_id, track, name) values(1, 1, 1, 'Dead Inside')\r\n" +
                "insert into song(id, album_id, track, name) values(2, 1, 2, 'Drill Sargeant')\r\n" +
                "insert into song(id, album_id, track, name) values(3, 1, 3, 'Psycho')\r\n" +
                "insert into song(id, album_id, track, name) values(4, 1, 4, 'Mercy')\r\n" +
                "insert into song(id, album_id, track, name) values(5, 1, 5, 'Reapers')\r\n" +
                "insert into song(id, album_id, track, name) values(6, 1, 6, 'The Handler')\r\n" +
                "insert into song(id, album_id, track, name) values(7, 1, 7, 'JFK')\r\n" +
                "insert into song(id, album_id, track, name) values(8, 1, 8, 'Defector')\r\n" +
                "insert into song(id, album_id, track, name) values(9, 1, 9, 'Revolt')\r\n" +
                "insert into song(id, album_id, track, name) values(10, 1, 10, 'Aftermath')\r\n" +
                "insert into song(id, album_id, track, name) values(11, 1, 11, 'The Globalist')\r\n" +
                "insert into song(id, album_id, track, name) values(12, 1, 12, 'Drones')" +

                "insert into song(id, album_id, track, name) values(13, 2, 1, 'Intro')\r\n" +
                "insert into song(id, album_id, track, name) values(14, 2, 2, 'Apocolypse Please')\r\n" +
                "insert into song(id, album_id, track, name) values(15, 2, 3, 'Time is Running Out')\r\n" +
                "insert into song(id, album_id, track, name) values(16, 2, 4, 'Sing for Absolution')\r\n" +
                "insert into song(id, album_id, track, name) values(17, 2, 5, 'Stokholm Syndrome')\r\n" +
                "insert into song(id, album_id, track, name) values(18, 2, 6, 'Falling Away With you')\r\n" +
                "insert into song(id, album_id, track, name) values(19, 2, 7, 'Interlude')\r\n" +
                "insert into song(id, album_id, track, name) values(20, 2, 8, 'Hysteria')\r\n" +
                "insert into song(id, album_id, track, name) values(21, 2, 9, 'Blackout')\r\n" +
                "insert into song(id, album_id, track, name) values(22, 2, 10, 'Butterflies and Hurricanes')\r\n" +
                "insert into song(id, album_id, track, name) values(23, 2, 11, 'The Small Print')\r\n" +
                "insert into song(id, album_id, track, name) values(24, 2, 12, 'Endlessly')\r\n" +
                "insert into song(id, album_id, track, name) values(25, 2, 13, 'Thoughts of a Dying Athiest')\r\n" +
                "insert into song(id, album_id, track, name) values(26, 2, 14, 'Ruled by Secrecy')\r\n" +
                "insert into song(id, album_id, track, name) values(27, 2, 15, 'Fury')\r\n" +

                "insert into song(id, album_id, track, name) values(28, 3, 1, 'Rio')\r\n" +
                "insert into song(id, album_id, track, name) values(29, 3, 2, 'My Own Way')\r\n" +
                "insert into song(id, album_id, track, name) values(30, 3, 3, 'Lonely in Your Nightmare')\r\n" +
                "insert into song(id, album_id, track, name) values(31, 3, 4, 'Hungry Like the Wolf')\r\n" +
                "insert into song(id, album_id, track, name) values(32, 3, 5, 'Hold Back the Rain')\r\n" +
                "insert into song(id, album_id, track, name) values(33, 3, 6, 'New Religion')\r\n" +
                "insert into song(id, album_id, track, name) values(34, 3, 7, 'Last Chance on the Stairway')\r\n" +
                "insert into song(id, album_id, track, name) values(35, 3, 8, 'Save a Prayer')\r\n" +
                "insert into song(id, album_id, track, name) values(36, 3, 9, 'The Chauffeur')\r\n" +

                "insert into song(id, album_id, track, name) values(37, 4, 1, '1984')\r\n" +
                "insert into song(id, album_id, track, name) values(38, 4, 2, 'Jump')\r\n" +
                "insert into song(id, album_id, track, name) values(39, 4, 3, 'Panama')\r\n" +
                "insert into song(id, album_id, track, name) values(40, 4, 4, 'Top Jimmy')\r\n" +
                "insert into song(id, album_id, track, name) values(41, 4, 5, 'Drop Dead Legs')\r\n" +
                "insert into song(id, album_id, track, name) values(42, 4, 6, 'Hot for Teacher')\r\n" +
                "insert into song(id, album_id, track, name) values(43, 4, 7, 'Ill Wait')\r\n" +
                "insert into song(id, album_id, track, name) values(44, 4, 8, 'Girl Gone Bad')\r\n" +
                "insert into song(id, album_id, track, name) values(45, 4, 9, 'House of Pain')");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Delete from song");
        }
    }
}
