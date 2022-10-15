using MediatR;

namespace MusicService.Features.Artists.CommandAndQueries.DeleteSingleArtist
{
    public class DeleteSingleArtistCommand : IRequest<Unit>
    {
        public long Id { get; set; }
    }
}
