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
    }
}
