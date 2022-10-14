using MusicService.Features.Artists.Domain.Entities;
using MusicService.Features.Music.Domain.Entities;
using MusicService.SharedLibrary.Music.Dtos;

namespace MusicService.Features.Music.Extensions
{
    public static class AlbumExtensions
    {

        public static AlbumDto ConvertToDto(this Album album)
        {
            return new AlbumDto
            {
                Id = album.Id,
                Name = album.Name,
                YearReleased = album.YearReleased.ToString()
            };
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

        public static Album GenerateNewModel(this NewAlbumDto album, Artist artist)
        {
            if(album is null)
            {
                throw new ArgumentNullException(nameof(album));
            }

            if(artist is null)
            {
                throw new ArgumentNullException(nameof(artist));
            }

            var currentDate = DateTime.UtcNow;

            return new Album
            {
                Name = album.Name,
                Created = currentDate,
                LastModified = currentDate,
                Artist = artist
            };
        }
    }
}
