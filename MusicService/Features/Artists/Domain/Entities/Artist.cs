using MusicService.Features.Albums.Domain.Entities;
using MusicService.Features.Common.Domain.Entities;

namespace MusicService.Features.Artists.Domain.Entities
{
    public class Artist : BaseModel
    {
        public string Name { get; set; } = string.Empty;
        public ICollection<ArtistAlbum> ArtistAlbums { get; set; } = new List<ArtistAlbum>();
    }
}
