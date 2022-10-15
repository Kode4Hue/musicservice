using MediatR;
using MusicService.Features.Common.Persistence;
using MusicService.Features.Music.Extensions;
using MusicService.SharedLibrary.Music.Dtos;

namespace MusicService.Features.Music.CommandAndQueries.GetSingleAlbum
{
    public class GetSingleAlbumQueryHandler : IRequestHandler<GetSingleAlbumQuery, AlbumDto?>
    {
        private readonly ApplicationDbContext _dbContext;

        public GetSingleAlbumQueryHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<AlbumDto?> Handle(GetSingleAlbumQuery request, CancellationToken cancellationToken)
        {
            var album = await _dbContext.Albums.FindAsync(new object[] { request.Id }, cancellationToken);

            if (album is not null)
            {
                return album.ConvertToDto();
            }
            else
            {
                return null;
            }
        }
    }
}
