using MediatR;
using MusicService.Features.Artists.Extensions;
using MusicService.Features.Common.Persistence;
using MusicService.SharedLibrary.Artists.Dtos;

namespace MusicService.Features.Artists.CommandAndQueries.AddArtist
{
    public class AddArtistCommandHandler : IRequestHandler<AddArtistCommand, ArtistDto>
    {

        private readonly ApplicationDbContext _dbContext;

        public AddArtistCommandHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<ArtistDto> Handle(AddArtistCommand request, CancellationToken cancellationToken)
        {
            var artistModel = request.NewArtist.GenerateNewModel();
            _dbContext.Artists.Add(artistModel);
            await _dbContext.SaveChangesAsync(cancellationToken);
            var artistDto = artistModel.ConvertToDto();
            return artistDto;
        }
    }
}
