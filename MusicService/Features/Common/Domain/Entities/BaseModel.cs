namespace MusicService.Features.Common.Domain.Entities
{
    public abstract class BaseModel
    {
        public long Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime LastModified { get; set; }
    }
}