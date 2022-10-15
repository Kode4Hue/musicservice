using MediatR;

namespace MusicService.Features.Music.CommandAndQueries.DeleteAlbum
{
    public class DeleteAlbumCommand : IRequest<Unit>
    {
        public long? Id { get; set; }
    }
}
