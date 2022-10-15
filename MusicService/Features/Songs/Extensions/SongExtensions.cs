using MusicService.Features.Music.Domain.Entities;
using MusicService.Features.Music.Extensions;
using MusicService.SharedLibrary.Songs.Dtos;

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
    }
}
