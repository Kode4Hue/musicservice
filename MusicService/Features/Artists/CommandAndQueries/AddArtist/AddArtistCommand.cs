using MediatR;
using MusicService.SharedLibrary.Artists.Dtos;

namespace MusicService.Features.Artists.CommandAndQueries.AddArtist
{
    public class AddArtistCommand : IRequest<ArtistDto>
    {
        public NewArtistDto NewArtist { get; set; }
    }
}
