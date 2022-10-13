using MediatR;
using MusicService.SharedLibrary.Artists.Dtos;

namespace MusicService.Features.Artists.CommandAndQueries.UpdateSingleArtist
{
    public class UpdateSingleArtistCommand: IRequest<ArtistDto>
    {

        public long Id { get; set; }
        public UpdateArtistDto ArtistToUpdate { get; set; }
    }
}
