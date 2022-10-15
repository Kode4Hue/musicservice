using MediatR;
using MusicService.Features.Albums.Extensions;
using MusicService.Features.Common.Persistence;
using MusicService.SharedLibrary.Albums.Dtos;

namespace MusicService.Features.Albums.CommandAndQueries.GetSingleAlbum
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
