namespace MusicService.SharedLibrary.Common.Dtos
{
    public abstract class BaseModelDto
    {
        public long Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime LastModified { get; set; }
    }
}
