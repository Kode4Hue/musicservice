using MusicService.Features.Music.Domain.Entities;
using MusicService.SharedLibrary.Songs.Dtos;

namespace MusicService.Features.Songs.Extensions
{
    public static class SongExtensions
    {
        public static SongDto ConvertToDto(this Song song)
        {
            return new SongDto
            {
                Id = song.Id,
                Created = song.Created,
                LastModified = song.LastModified,
                Name = song.Name,
                Track = song.Track,
            };
        }
    }
}
