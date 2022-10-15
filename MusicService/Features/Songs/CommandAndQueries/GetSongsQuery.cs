using MediatR;
using MusicService.SharedLibrary.Songs.Dtos;

namespace MusicService.Features.Songs.CommandAndQueries
{
    public class GetSongsQuery: IRequest<List<SongDto>>
    {
    }
}
