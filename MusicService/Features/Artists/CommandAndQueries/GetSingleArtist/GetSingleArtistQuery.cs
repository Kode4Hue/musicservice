using MediatR;
using MusicService.SharedLibrary.Artists.Dtos;

namespace MusicService.Features.Artists.CommandAndQueries.GetSingleArtist
{
    public class GetSingleArtistQuery : IRequest<ArtistDto?>
    {
        public long Id { get; set; }
    }
}
