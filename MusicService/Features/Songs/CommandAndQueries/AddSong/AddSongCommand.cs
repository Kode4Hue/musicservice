using MediatR;
using MusicService.SharedLibrary.Songs.Dtos;

namespace MusicService.Features.Songs.CommandAndQueries.AddSong
{
    public class AddSongCommand: IRequest<SongDto>
    {
        public NewSongDto NewSong { get; set; }
        public AddSongCommand(NewSongDto newSong)
        {
            NewSong = newSong;
        }
    }
}
