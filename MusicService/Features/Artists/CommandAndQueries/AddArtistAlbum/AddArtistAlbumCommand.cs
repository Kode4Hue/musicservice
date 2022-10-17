using MediatR;
using MusicService.SharedLibrary.Albums.Dtos;
using MusicService.SharedLibrary.Artists.Dtos;

namespace MusicService.Features.Artists.CommandAndQueries.AddArtistAlbum
{
    public class AddArtistAlbumCommand: IRequest<AlbumDto>
    {
        public long ArtistId { get; set; }
        public NewArtistAlbumDto NewArtistAlbum { get; set; }
    }
}
