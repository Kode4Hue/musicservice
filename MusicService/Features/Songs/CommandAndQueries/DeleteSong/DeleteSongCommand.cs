using MediatR;

namespace MusicService.Features.Songs.CommandAndQueries.DeleteSong
{
    public class DeleteSongCommand: IRequest<Unit>
    {
        public long Id { get; set; }
        public DeleteSongCommand(long id)
        {
            Id = id;
        }
    }
}
