using MediatR;
using MusicService.SharedLibrary.Music.Dtos;

namespace MusicService.Features.Music.CommandAndQueries.GetAlbums
{
    public class GetAlbumsQuery: IRequest<List<AlbumDto>>
    {
    }
}
