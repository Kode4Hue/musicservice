using MediatR;
using Microsoft.EntityFrameworkCore;
using MusicService.Features.Artists.Extensions;
using MusicService.Features.Common.Persistence;
using MusicService.SharedLibrary.Artists.Dtos;

namespace MusicService.Features.Artists.CommandAndQueries.GetArtists
{
    public class GetArtistQueryHandler : IRequestHandler<GetArtistsQuery, List<ArtistDto>>
    {

        private readonly ApplicationDbContext _dbContext;

        public GetArtistQueryHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<ArtistDto>> Handle(GetArtistsQuery request, CancellationToken cancellationToken)
        {
            var artists = await _dbContext.Artists
                .Select(x => x.ConvertToDto())
                .ToListAsync(cancellationToken: cancellationToken);

            return artists;
        }
    }
}
