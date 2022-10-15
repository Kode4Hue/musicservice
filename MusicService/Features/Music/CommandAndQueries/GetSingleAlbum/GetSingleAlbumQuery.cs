using MediatR;
using MusicService.SharedLibrary.Music.Dtos;

namespace MusicService.Features.Music.CommandAndQueries.GetSingleAlbum
{
    public class GetSingleAlbumQuery : IRequest<AlbumDto?>
    {
        public long Id { get; set; }
    }
}
