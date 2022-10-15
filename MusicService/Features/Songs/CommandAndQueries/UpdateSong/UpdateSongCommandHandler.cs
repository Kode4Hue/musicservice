using MediatR;
using Microsoft.EntityFrameworkCore;
using MusicService.Features.Common.Exceptions;
using MusicService.Features.Common.Persistence;
using MusicService.Features.Songs.Domain.Entities;
using MusicService.Features.Songs.Extensions;
using MusicService.SharedLibrary.Songs.Dtos;

namespace MusicService.Features.Songs.CommandAndQueries.UpdateSong
{
    public class UpdateSongCommandHandler : IRequestHandler<UpdateSongCommand, SongDto>
    {
        private readonly ApplicationDbContext _dbContext;

        public UpdateSongCommandHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<SongDto> Handle(UpdateSongCommand request, CancellationToken cancellationToken)
        {
            var song = await _dbContext.Songs.FindAsync(new object[] { request.Id }, cancellationToken);
            if (song is not null)
            {
                await UpdateModel(song, request.UpdateSongInfo, cancellationToken);
                return song.ConvertToDto();
            }
            else
            {
                throw new ResourceNotFoundException();
            }

        }

        private async Task UpdateModel(Song song, UpdateSongDto updateSongDto, CancellationToken cancellationToken)
        {
            if (song is null)
            {
                throw new ArgumentNullException(nameof(song));
            }

            if (updateSongDto is null)
            {
                throw new ArgumentNullException(nameof(updateSongDto));
            }

            song.Track = updateSongDto.Track;
            song.Name = updateSongDto.Name;
            song.LastModified = DateTime.UtcNow;

            if(await ShouldUpdateAlbumAsync(song.AlbumId, updateSongDto.AlbumId, cancellationToken))
            {
                song.AlbumId = updateSongDto.AlbumId;
            }

            _dbContext.Entry(song).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync(cancellationToken);
        }

        private async Task<bool> ShouldUpdateAlbumAsync(long currentAlbumId, long? newAlbumId, CancellationToken cancellationToken)
        {
            return newAlbumId is not null
                && currentAlbumId != newAlbumId
                && await _dbContext.Albums.AnyAsync(x => x.Id == newAlbumId, cancellationToken);
        }

    }
}

