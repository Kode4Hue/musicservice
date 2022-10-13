using MediatR;
using MusicService.SharedLibrary.Artists.Dtos;

namespace MusicService.Features.Artists.CommandAndQueries.GetArtists
{
    public class GetArtistsQuery : IRequest<List<ArtistDto>>
    {
    }
}
