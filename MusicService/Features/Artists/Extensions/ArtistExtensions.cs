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

        public static Artist UpdateModelFromDto(this Artist artist, ArtistDto incomingUpdates)
        {
            if(artist is null)
            {
                throw new ArgumentException(nameof(artist));
            }

            if(incomingUpdates is null)
            {
                throw new ArgumentNullException(nameof(incomingUpdates));
            }

            artist.Name = incomingUpdates.Name;
            artist.LastModified = DateTime.UtcNow;

            return artist;
        }

        public static Artist GenerateNewModel(this NewArtistDto artist)
        {
            if(artist is null)
            {
                throw new ArgumentNullException(nameof(artist));
            }

            var currentDate = DateTime.UtcNow;

            return new Artist
            {
                Name = artist.Name,
                Created = currentDate,
                LastModified = currentDate
            };
        }
    }
}
