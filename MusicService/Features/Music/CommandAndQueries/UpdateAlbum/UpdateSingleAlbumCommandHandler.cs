﻿using MediatR;
using Microsoft.EntityFrameworkCore;
using MusicService.Features.Common.Exceptions;
using MusicService.Features.Common.Persistence;
using MusicService.Features.Music.Extensions;
using MusicService.SharedLibrary.Music.Dtos;

namespace MusicService.Features.Music.CommandAndQueries.UpdateAlbum
{
    public class UpdateSingleAlbumCommandHandler : IRequestHandler<UpdateSingleAlbumCommand, AlbumDto>
    {
        private readonly ApplicationDbContext _dbContext;

        public UpdateSingleAlbumCommandHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<AlbumDto> Handle(UpdateSingleAlbumCommand request, CancellationToken cancellationToken)
        {
            var album = await _dbContext.Albums.FindAsync(new object[] { request.Id }, cancellationToken);
            if(album is not null)
            {
                album = album.UpdateModelFromDto(request.AlbumToUpdate);
                _dbContext.Entry(album).State = EntityState.Modified;
                await _dbContext.SaveChangesAsync(cancellationToken);
                return album.ConvertToDto(); ;
            }
            else
            {
                throw new ResourceNotFoundException();
            }
        }
    }
}
