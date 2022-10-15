namespace MusicService.SharedLibrary.Songs.Dtos
{
    public class NewSongDto
    {
        public int Track { get; set; }
        public string Name { get; set; } = string.Empty;
        public long AlbumId { get; set; }

        public NewSongDto(int track, string name)
        {
            Track = track;
            Name = name;
        }

    }
}
