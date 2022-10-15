using MediatR;
using MusicService.Features.Albums.Domain.Entities;
using MusicService.Features.Common.Exceptions;
using MusicService.Features.Common.Persistence;
using MusicService.Features.Songs.Extensions;
using MusicService.SharedLibrary.Songs.Dtos;

namespace MusicService.Features.Songs.CommandAndQueries.AddSong
{
    public class AddSongCommandHandler : IRequestHandler<AddSongCommand, SongDto>
    {

        private readonly ApplicationDbContext _dbContext;

        public AddSongCommandHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<SongDto> Handle(AddSongCommand request, CancellationToken cancellationToken)
        {
            var newSongDto = request.NewSong;
            var album = await FindAlbumForNewSongAsync(request.NewSong.AlbumId, cancellationToken);
            var songModel = newSongDto.GenerateNewModel(album);
            await _dbContext.Songs.AddAsync(songModel, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);
            var createSongDto = songModel.ConvertToDto();
            return createSongDto;
        }

        private async Task<Album> FindAlbumForNewSongAsync(long id, CancellationToken cancellationToken)
        {
            var album = await _dbContext.Albums.FindAsync(new object[] { id }, cancellationToken);
            if (album is null)
            {
                throw new UnprocessibleEntityException($"Artist with Id {id} could not be found");
            }
            return album;
        }
    }
}
