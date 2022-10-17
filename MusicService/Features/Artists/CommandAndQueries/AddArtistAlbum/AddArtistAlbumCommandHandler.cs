using MediatR;
using Microsoft.EntityFrameworkCore;
using MusicService.Features.Artists.Domain.Entities;
using MusicService.Features.Common.Exceptions;
using MusicService.Features.Common.Persistence;
using MusicService.Features.Songs.Extensions;
using MusicService.SharedLibrary.Albums.Dtos;

namespace MusicService.Features.Artists.CommandAndQueries.AddArtistAlbum
{
    public class AddArtistAlbumCommandHandler : IRequestHandler<AddArtistAlbumCommand, AlbumDto>
    {
        private readonly ApplicationDbContext _dbContext;

        public AddArtistAlbumCommandHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<AlbumDto> Handle(AddArtistAlbumCommand request, CancellationToken cancellationToken)
        {
            if(!await _dbContext.ArtistAlbums.AnyAsync(x => x.ArtistId == request.ArtistId 
            && x.AlbumId == request.NewArtistAlbum.AlbumId, cancellationToken))
            {
                var model = new ArtistAlbum
                {
                    AlbumId = request.ArtistId,
                    ArtistId = request.NewArtistAlbum.AlbumId,
                };

                _dbContext.ArtistAlbums.Add(model);
                await _dbContext.SaveChangesAsync(cancellationToken);
                var createdDate = DateTime.Now;
                var albumDto = new AlbumDto
                {
                    Id = model.AlbumId,
                    Created = createdDate,
                    Songs = model.Album.Songs.Select(x => x.ConvertToPreviewDto()).ToList()
                };
                return albumDto;
            }
            else
            {
                throw new UnprocessibleEntityException($"Artist Album with Artist Id {request.ArtistId} and Album  " +
                    $"Id {request.NewArtistAlbum.AlbumId} already exists");
            }
        }
    }
}
