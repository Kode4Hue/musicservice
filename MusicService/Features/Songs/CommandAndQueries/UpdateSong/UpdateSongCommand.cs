using MediatR;
using MusicService.SharedLibrary.Songs.Dtos;

namespace MusicService.Features.Songs.CommandAndQueries.UpdateSong
{
    public class UpdateSongCommand: IRequest<UpdateSongDto>
    {
        public long Id { get; set; }
        public UpdateSongDto UpdateSongInfo { get; set; }

        public UpdateSongCommand(long id, UpdateSongDto updateSongInfo)
        {
            Id = id;
            UpdateSongInfo = updateSongInfo;
        }
    }
}
