using MediatR;
using Microsoft.EntityFrameworkCore;
using MusicService.Features.Albums.Extensions;
using MusicService.Features.Common.Persistence;
using MusicService.SharedLibrary.Albums.Dtos;

namespace MusicService.Features.Albums.CommandAndQueries.GetAlbums
{
    public class GetAlbumsQueryHandler : IRequestHandler<GetAlbumsQuery, List<AlbumDto>>
    {
        private readonly ApplicationDbContext _dbContext;

        public GetAlbumsQueryHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<AlbumDto>> Handle(GetAlbumsQuery request, CancellationToken cancellationToken)
        {
            var albums = await _dbContext.Albums
                .Select(x => x.ConvertToDto())
                .ToListAsync();

            return albums;
        }
    }
}
