using MediatR;
using MusicService.Features.Albums.Extensions;
using MusicService.Features.Common.Exceptions;
using MusicService.Features.Common.Persistence;
using MusicService.SharedLibrary.Albums.Dtos;

namespace MusicService.Features.Albums.CommandAndQueries.AddAlbum
{
    public class AddAlbumCommandHandler : IRequestHandler<AddAlbumCommand, AlbumDto>
    {

        private readonly ApplicationDbContext _dbContext;

        public AddAlbumCommandHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<AlbumDto> Handle(AddAlbumCommand request, CancellationToken cancellationToken)
        {
            var album = request.Album;
            var artist = await _dbContext.Artists.FindAsync(new object[] { album.ArtistId.Value }, cancellationToken);
            if (artist is null)
            {
                throw new UnprocessibleEntityException($"Artist with Id {album.ArtistId} could not be found");
            }

            var albumModel = album.GenerateNewModel(artist);
            await _dbContext.Albums.AddAsync(albumModel, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);
            var albumDto = albumModel.ConvertToDto();
            return albumDto;
        }
    }
}
