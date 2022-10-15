using MusicService.SharedLibrary.Albums.Dtos;
using MusicService.SharedLibrary.Common.Dtos;

namespace MusicService.SharedLibrary.Artists.Dtos
{
    public class ArtistDto: BaseModelDto
    {
        public ArtistDto(
            string name, IEnumerable<AlbumPreviewDto>? albums, 
            long id, DateTime created, DateTime lastModified) : base(id, created, lastModified)
        {
            Name = name;
            Albums = albums;
        }

        public string Name { get; set; } = string.Empty;
        public IEnumerable<AlbumPreviewDto>? Albums { get; set; }
    }
}
