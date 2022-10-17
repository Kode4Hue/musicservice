using MediatR;
using Microsoft.EntityFrameworkCore;
using MusicService.Features.Artists.Domain.Entities;
using MusicService.Features.Common.Exceptions;
using MusicService.Features.Common.Persistence;

namespace MusicService.Features.Artists.CommandAndQueries.DeleteArtistAlbum
{
    public class DeleteArtistAlbumCommandHandler : IRequestHandler<DeleteArtistAlbumCommand, Unit>
    {
        private readonly ApplicationDbContext _dbContext;

        public DeleteArtistAlbumCommandHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Unit> Handle(DeleteArtistAlbumCommand request, CancellationToken cancellationToken)
        {
            if (await _dbContext.ArtistAlbums.AnyAsync(x => x.ArtistId == request.ArtistId
                && x.AlbumId == request.AlbumId, cancellationToken))
            {
                var artistAlbum = new ArtistAlbum
                {
                    ArtistId = request.ArtistId,
                    AlbumId = request.AlbumId
                };

                _dbContext.Remove(artistAlbum);
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
