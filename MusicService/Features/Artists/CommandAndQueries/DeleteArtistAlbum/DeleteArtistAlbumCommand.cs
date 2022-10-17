using MediatR;

namespace MusicService.Features.Artists.CommandAndQueries.DeleteArtistAlbum
{
    public class DeleteArtistAlbumCommand: IRequest<Unit>
    {
        public long ArtistId { get; set; }
        public long AlbumId { get; set; }
    }
}
