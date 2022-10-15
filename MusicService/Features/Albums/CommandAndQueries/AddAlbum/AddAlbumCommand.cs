using MediatR;
using MusicService.SharedLibrary.Albums.Dtos;

namespace MusicService.Features.Albums.CommandAndQueries.AddAlbum
{
    public class AddAlbumCommand : IRequest<AlbumDto>
    {
        public AddAlbumCommand(NewAlbumDto album)
        {
            Album = album;
        }

        public NewAlbumDto Album { get; set; }
    }
}
