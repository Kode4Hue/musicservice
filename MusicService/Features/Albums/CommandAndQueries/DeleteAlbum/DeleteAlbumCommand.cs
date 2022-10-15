using MediatR;

namespace MusicService.Features.Albums.CommandAndQueries.DeleteAlbum
{
    public class DeleteAlbumCommand : IRequest<Unit>
    {
        public long? Id { get; set; }
    }
}
