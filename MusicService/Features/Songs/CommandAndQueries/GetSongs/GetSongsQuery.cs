using MediatR;
using MusicService.SharedLibrary.Songs.Dtos;

namespace MusicService.Features.Songs.CommandAndQueries.GetSongs
{
    public class GetSongsQuery : IRequest<List<SongDto>>
    {
    }
}
