using MediatR;
using Microsoft.EntityFrameworkCore;
using MusicService.Features.Common.Persistence;
using MusicService.Features.Songs.Extensions;
using MusicService.SharedLibrary.Songs.Dtos;

namespace MusicService.Features.Songs.CommandAndQueries
{
    public class GetSongQueryHandler : IRequestHandler<GetSongsQuery, List<SongDto>>
    {

        private readonly ApplicationDbContext _dbContext;

        public GetSongQueryHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<SongDto>> Handle(GetSongsQuery request, CancellationToken cancellationToken)
        {
            var songs = await _dbContext.Songs
                .Select(x => x.ConvertToDto())
                .ToListAsync(cancellationToken);

            return songs;
        }
    }
}
