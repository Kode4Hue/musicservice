using MusicService.Features.Common.Domain.Entities;

namespace MusicService.Features.Music.Domain.Entities
{
    public class Song : BaseModel
    {
        public int Track { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}
