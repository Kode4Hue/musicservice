using MusicService.Features.Artists.Domain.Entities;
using MusicService.Features.Artists.Extensions;
using MusicService.Features.Music.Domain.Entities;
using MusicService.SharedLibrary.Music.Dtos;

namespace MusicService.Features.Music.Extensions
{
    public static class AlbumExtensions
    {

        public static AlbumDto ConvertToDto(this Album album)
        {
            return new AlbumDto(
                album.Id,
                album.Created,
                album.LastModified,
                album.Name,
                album.YearReleased.ToString(),
                album.Artist.ConvertToPreviewDto(),
                album.Songs.Select(x => x.ConvertToPreviewDto()));
        }

        public static AlbumPreviewDto ConvertToPreviewDto(this Album album)
        {
            return new AlbumPreviewDto
            {
                Id = album.Id,
                Name = album.Name,
                YearReleased = album.YearReleased.ToString()
            };
        }

        public static Album UpdateModelFromDto(this Album album, UpdateAlbumDto incomingUpdates)
        {
            if (album is null)
            {
                throw new ArgumentNullException(nameof(album));
            }

            if (incomingUpdates is null)
            {
                throw new ArgumentNullException(nameof(incomingUpdates));
            }

            album.Name = incomingUpdates.Name;
            album.LastModified = DateTime.UtcNow;
            album.ArtistId = incomingUpdates.ArtistId;

            return album;
        }

        public static Album GenerateNewModel(this NewAlbumDto album, Artist artist)
        {
            if (album is null)
            {
                throw new ArgumentNullException(nameof(album));
            }

            if (artist is null)
            {
                throw new ArgumentNullException(nameof(artist));
            }

            var currentDate = DateTime.UtcNow;

            return new Album
            {
                Name = album.Name,
                YearReleased = album.YearReleased.Value,
                Created = currentDate,
                LastModified = currentDate,
                Artist = artist
            };
        }
    }
}
