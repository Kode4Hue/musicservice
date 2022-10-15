using MediatR;
using MusicService.SharedLibrary.Albums.Dtos;

namespace MusicService.Features.Albums.CommandAndQueries.GetSingleAlbum
{
    public class GetSingleAlbumQuery : IRequest<AlbumDto?>
    {
        public long Id { get; set; }
    }
}
