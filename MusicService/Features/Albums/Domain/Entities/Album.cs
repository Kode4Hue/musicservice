using MusicService.Features.Artists.Domain.Entities;
using MusicService.Features.Common.Domain.Entities;
using MusicService.Features.Songs.Domain.Entities;

namespace MusicService.Features.Albums.Domain.Entities
{
    public class Album : BaseModel
    {
        public string Name { get; set; } = string.Empty;
        public int YearReleased { get; set; }

        public ICollection<ArtistAlbum> ArtistAlbums { get; set; } = new List<ArtistAlbum>();
        public ICollection<Song> Songs { get; set; } = new List<Song>();
    }
}
