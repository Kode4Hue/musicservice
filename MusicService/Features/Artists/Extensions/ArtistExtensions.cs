using MusicService.Features.Artists.Domain.Entities;
using MusicService.Features.Music;
using MusicService.SharedLibrary.Artists.Dtos;

namespace MusicService.Features.Artists.Extensions
{
    public static class ArtistExtensions
    {

        public static ArtistDto ConvertToDto(this Artist artist)
        {
            return new ArtistDto
            {
                Id = artist.Id,
                Name = artist.Name,
                Albums = artist.Albums.Select(x => x.ConvertToPreviewDto())
            };
        }
    }
}
