using MusicService.SharedLibrary.Common.Dtos;
using MusicService.SharedLibrary.Music.Dtos;

namespace MusicService.SharedLibrary.Songs.Dtos
{
    public class SongDto: BaseModelDto
    {
        public SongDto(
            int track, string name, 
            AlbumPreviewDto album, long id, 
            DateTime created, DateTime lastModified) :base(id,created, lastModified)
        {
            Track = track;
            Name = name;
            Album = album;
        }

        public int Track { get; set; }
        public string Name { get; set; } = string.Empty;
        public AlbumPreviewDto Album { get; set; }
    }
}
