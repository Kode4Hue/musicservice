using MediatR;
using MusicService.Features.Artists.Extensions;
using MusicService.Features.Common.Persistence;
using MusicService.SharedLibrary.Artists.Dtos;

namespace MusicService.Features.Artists.CommandAndQueries.GetSingleArtist
{
    public class GetSingleArtistQueryHandler : IRequestHandler<GetSingleArtistQuery, ArtistDto?>
    {
        private readonly ApplicationDbContext _dbContext;

        public GetSingleArtistQueryHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<ArtistDto?> Handle(GetSingleArtistQuery request, CancellationToken cancellationToken)
        {
            var artist = await _dbContext.Artists.FindAsync(request.Id);

            if (artist is not null)
            {
                return artist.ConvertToDto();
            }
            else
            {
                return null;
            }
        }
    }
}
