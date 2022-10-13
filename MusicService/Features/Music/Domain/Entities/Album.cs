using MusicService.Features.Artists.Domain.Entities;
using MusicService.Features.Common.Domain.Entities;

namespace MusicService.Features.Music.Domain.Entities
{
    public class Album : BaseModel
    {
        public string Name { get; set; } = string.Empty;
        public int YearReleased { get; set; }

        public long ArtistId { get; set; }
        public Artist Artist { get; set; }
        public ICollection<Song> Songs { get; set; }
    }
}
