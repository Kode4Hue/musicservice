using MediatR;
using Microsoft.EntityFrameworkCore;
using MusicService.Features.Common.Exceptions;
using MusicService.Features.Common.Persistence;

namespace MusicService.Features.Music.CommandAndQueries.DeleteAlbum
{
    public class DeleteAlbumCommandHandler : IRequestHandler<DeleteAlbumCommand, Unit>
    {
        private readonly ApplicationDbContext _dbContext;

        public DeleteAlbumCommandHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Unit> Handle(DeleteAlbumCommand request, CancellationToken cancellationToken)
        {

            if (await _dbContext.Albums.AnyAsync(x => x.Id == request.Id.Value, cancellationToken) is not true)
            {
                throw new ResourceNotFoundException();
            }

            var album = await _dbContext.Albums.FirstOrDefaultAsync(x => x.Id == request.Id.Value, cancellationToken);
            if (album is null)
            {
                throw new ResourceNotFoundException();
            }


            _dbContext.Remove(album);
            await _dbContext.SaveChangesAsync(cancellationToken);
            return Unit.Value;
        }
    }
}
