namespace MusicService.Features.Common.Exceptions
{

    [Serializable]
    public class UnprocessibleEntityException : Exception
    {
        public UnprocessibleEntityException(string? message) : base(message)
        {
        }
    }
}
