using MediatR;
using Microsoft.EntityFrameworkCore;
using MusicService.Features.Common.Exceptions;
using MusicService.Features.Common.Persistence;

namespace MusicService.Features.Songs.CommandAndQueries.DeleteSong
{
    public class DeleteSongCommandHandler : IRequestHandler<DeleteSongCommand, Unit>
    {
        private readonly ApplicationDbContext _dbContext;

        public DeleteSongCommandHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Unit> Handle(DeleteSongCommand request, CancellationToken cancellationToken)
        {
            var song = await _dbContext.Songs.FindAsync(new object[] { request.Id }, cancellationToken);
           if (song is not null)
            {
                _dbContext.Remove(song);
                await _dbContext.SaveChangesAsync(cancellationToken);
                return Unit.Value;
            }
            else
            {
                throw new ResourceNotFoundException();
            }
        }
    }
}
