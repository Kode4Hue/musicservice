using MediatR;
using MusicService.Features.Artists.Domain.Entities;
using MusicService.Features.Common;
using MusicService.Features.Common.Persistence;

namespace MusicService.Features.Artists.CommandAndQueries.DeleteSingleArtist
{
    public class DeleteSingleArtistCommandHandler : IRequestHandler<DeleteSingleArtistCommand, Unit>
    {

        private readonly ApplicationDbContext _dbContext;

        public DeleteSingleArtistCommandHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Unit> Handle(DeleteSingleArtistCommand request, CancellationToken cancellationToken)
        {

            if(!_dbContext.Artists.Any(x => x.Id == request.Id))
            {
                throw new ResourceNotFoundException();
            }

            var untrackedRecordToDelete = new Artist
            {
                Id = request.Id
            };

            _dbContext.Remove(untrackedRecordToDelete);
            await _dbContext.SaveChangesAsync(cancellationToken);
            return Unit.Value;
        }
    }
}
