using MediatR;
using MusicService.SharedLibrary.Music.Dtos;

namespace MusicService.Features.Music.CommandAndQueries.UpdateAlbum
{
    public class UpdateSingleAlbumCommand : IRequest<AlbumDto>
    {
        public long Id { get; set; }
        public UpdateAlbumDto AlbumToUpdate { get; set; }
    }
}
