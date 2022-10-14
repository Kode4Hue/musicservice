using MediatR;
using MusicService.SharedLibrary.Music.Dtos;

namespace MusicService.Features.Music.CommandAndQueries.AddAlbum
{
    public class AddAlbumCommand: IRequest<AlbumDto>
    {
        public AddAlbumCommand(NewAlbumDto album)
        {
            Album = album;
        }

        public NewAlbumDto Album { get; set; }
    }
}
