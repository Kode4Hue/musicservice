using MusicService.Features.Music.Domain.Entities;
using MusicService.SharedLibrary.Music.Dtos;

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
    }
}
