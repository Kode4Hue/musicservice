using MediatR;
using MusicService.SharedLibrary.Albums.Dtos;

namespace MusicService.Features.Albums.CommandAndQueries.GetAlbums
{
    public class GetAlbumsQuery : IRequest<List<AlbumDto>>
    {
    }
}
