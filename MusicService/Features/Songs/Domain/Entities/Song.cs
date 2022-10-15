using MusicService.Features.Albums.Domain.Entities;
using MusicService.Features.Common.Domain.Entities;

namespace MusicService.Features.Songs.Domain.Entities
{
    public class Song : BaseModel
    {
        public int Track { get; set; }
        public string Name { get; set; } = string.Empty;
        public long AlbumId { get; set; }
        public Album Album { get; set; }
    }
}
