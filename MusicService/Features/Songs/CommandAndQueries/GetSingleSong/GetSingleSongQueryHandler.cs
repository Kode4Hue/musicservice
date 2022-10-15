using MediatR;
using MusicService.Features.Common.Exceptions;
using MusicService.Features.Common.Persistence;
using MusicService.Features.Songs.Extensions;
using MusicService.SharedLibrary.Songs.Dtos;

namespace MusicService.Features.Songs.CommandAndQueries.GetSingleSong
{
    public class GetSingleSongQueryHandler : IRequestHandler<GetSingleSongQuery, SongDto>
    {
        private readonly ApplicationDbContext _dbContext;

        public GetSingleSongQueryHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<SongDto> Handle(GetSingleSongQuery request, CancellationToken cancellationToken)
        {
            var song = await _dbContext.Songs.FindAsync(new object[] { request.Id }, cancellationToken);

            if(song is not null)
            {
                return song.ConvertToDto();
            }
            else
            {
                throw new ResourceNotFoundException();
            }
        }
    }
}
