using MusicService.Features.Music.Domain.Entities;
using MusicService.SharedLibrary.Music.Dtos;
using MusicService.SharedLibrary.Songs.Dtos;

namespace MusicService.Features.Music.Extensions
{
    public static class SongExtensions
    {

        public static SongPreviewDto ConvertToPreviewDto(this Song song)
        {
            return new SongPreviewDto
            {
                Id = song.Id,
                Name = song.Name
            };
        }

        public static Song GenerateNewModel(this NewSongDto song, Album album)
        {
            if (song is null)
            {
                throw new ArgumentNullException(nameof(song));
            }
            if (album is null)
            {
                throw new ArgumentNullException(nameof(album));
            }

            var currentDate = DateTime.UtcNow;
            return new Song {
                Track = song.Track,
                Name = song.Name,
                Created = currentDate,
                LastModified = currentDate,
                Album = album
            };
        }
    }
}
