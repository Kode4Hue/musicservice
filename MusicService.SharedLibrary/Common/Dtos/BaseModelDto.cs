namespace MusicService.SharedLibrary.Common.Dtos
{
    public abstract class BaseModelDto
    {
        public long Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime LastModified { get; set; }

        public BaseModelDto()
        {

        }

        protected BaseModelDto(long id, DateTime created, DateTime lastModified)
        {
            Id = id;
            Created = created;
            LastModified = lastModified;
        }
    }
}
