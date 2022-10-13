using MusicService.Features.Common.Domain.Entities;

namespace MusicService.Features.Music.Domain.Entities
{
    public class Album : BaseModel
    {
        public string Name { get; set; } = string.Empty;
        public int YearReleased { get; set; }
    }
}
