using MusicService.Features.Albums.Domain.Entities;
using MusicService.SharedLibrary.Songs.Dtos;
using MusicService.Features.Songs.Domain.Entities;
using MusicService.Features.Albums.Extensions;

namespace MusicService.Features.Songs.Extensions
{
    public static class SongExtensions
    {

        public static SongDto ConvertToDto(this Song song)
        {
            return new SongDto(
                song.Track, 
                song.Name, 
                song.Album.ConvertToPreviewDto(), 
                song.Id, 
                song.Created, 
                song.LastModified);
        }

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
            return new Song
            {
                Track = song.Track,
                Name = song.Name,
                Created = currentDate,
                LastModified = currentDate,
                Album = album
            };
        }
    }
}
