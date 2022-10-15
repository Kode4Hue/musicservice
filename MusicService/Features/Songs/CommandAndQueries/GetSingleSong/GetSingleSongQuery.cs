using MediatR;
using MusicService.SharedLibrary.Songs.Dtos;

namespace MusicService.Features.Songs.CommandAndQueries.GetSingleSong
{
    public class GetSingleSongQuery: IRequest<SongDto>
    {
        public long Id { get; set; }

        public GetSingleSongQuery(long id)
        {
            Id = id;
        }
    }
}
