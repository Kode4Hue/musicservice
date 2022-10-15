namespace MusicService.SharedLibrary.Songs.Dtos
{
    public class UpdateSongDto
    {
        public int Track { get; set; }
        public string Name { get; set; } = string.Empty;
        public long AlbumId { get; set; }

        public UpdateSongDto(int track, string name, long albumId)
        {
            Track = track;
            Name = name;
            AlbumId = albumId;
        }
    }
}
