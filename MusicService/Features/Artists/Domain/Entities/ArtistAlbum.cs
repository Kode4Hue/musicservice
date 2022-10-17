using MusicService.Features.Albums.Domain.Entities;
using MusicService.Features.Common.Domain.Entities;

namespace MusicService.Features.Artists.Domain.Entities
{
    public class ArtistAlbum
    {
        public long ArtistId { get; set; }
        public long AlbumId { get; set; }
        public Artist Artist { get; set; }
        public Album Album { get; set; }
    }
}
