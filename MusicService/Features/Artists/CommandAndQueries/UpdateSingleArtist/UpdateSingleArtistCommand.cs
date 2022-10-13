using MediatR;
using MusicService.SharedLibrary.Artists.Dtos;

namespace MusicService.Features.Artists.CommandAndQueries.UpdateSingleArtist
{
    public class UpdateSingleArtistCommand: IRequest<ArtistDto>
    {
        public ArtistDto ArtistToUpdate { get; set; }
    }
}
