using MusicService.SharedLibrary.Common.Dtos;
using MusicService.SharedLibrary.Music.Dtos;

namespace MusicService.SharedLibrary.Artists.Dtos
{
    public class ArtistDto: BaseModelDto
    {
        public string Name { get; set; } = string.Empty;
        public IEnumerable<AlbumPreviewDto>? Albums { get; set; }
    }
}
