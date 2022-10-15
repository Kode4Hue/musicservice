using MediatR;
using MusicService.SharedLibrary.Songs.Dtos;

namespace MusicService.Features.Songs.CommandAndQueries.GetSingleSong
{
    public class GetSingleSong: IRequest<SongDto>
    {
        public long Id { get; set; }

        public GetSingleSong(long id)
        {
            Id = id;
        }
    }
}
