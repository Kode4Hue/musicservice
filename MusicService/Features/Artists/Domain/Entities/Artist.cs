using MusicService.Features.Common.Domain.Entities;
using MusicService.Features.Music.Domain.Entities;

namespace MusicService.Features.Artists.Domain.Entities
{
    public class Artist : BaseModel
    {
        public string Name { get; set; } = string.Empty;
        public ICollection<Album> Albums { get; set; } = new List<Album>();
    }
}
