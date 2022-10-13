using MediatR;
using Microsoft.EntityFrameworkCore;
using MusicService.Features.Artists.Extensions;
using MusicService.Features.Common;
using MusicService.Features.Common.Persistence;
using MusicService.SharedLibrary.Artists.Dtos;

namespace MusicService.Features.Artists.CommandAndQueries.UpdateSingleArtist
{
    public class UpdateSingleArtistCommandHandler : IRequestHandler<UpdateSingleArtistCommand, ArtistDto>
    {

        private readonly ApplicationDbContext _dbContext;

        public UpdateSingleArtistCommandHandler(ApplicationDbContext applicationDbContext)
        {
            this._dbContext = applicationDbContext;
        }

        public async Task<ArtistDto> Handle(UpdateSingleArtistCommand request, CancellationToken cancellationToken)
        {
            var artist = await _dbContext.Artists.FindAsync(new object[] {request.Id}, cancellationToken);
            if (artist is not null)
            {
                artist = artist.UpdateModelFromDto(request.ArtistToUpdate);
                _dbContext.Entry(artist).State = EntityState.Modified;
                await _dbContext.SaveChangesAsync(cancellationToken);
                return artist.ConvertToDto();
            }
            else
            {
                throw new ResourceNotFoundException();
            }
        }
    }
}
