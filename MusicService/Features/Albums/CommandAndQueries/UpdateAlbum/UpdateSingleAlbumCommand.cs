using MediatR;
using MusicService.SharedLibrary.Albums.Dtos;

namespace MusicService.Features.Albums.CommandAndQueries.UpdateAlbum
{
    public class UpdateSingleAlbumCommand : IRequest<AlbumDto>
    {
        public long Id { get; set; }
        public UpdateAlbumDto AlbumToUpdate { get; set; }
    }
}
