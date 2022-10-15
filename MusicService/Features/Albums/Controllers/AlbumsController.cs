using MediatR;
using Microsoft.AspNetCore.Mvc;
using MusicService.Features.Albums.CommandAndQueries.AddAlbum;
using MusicService.Features.Albums.CommandAndQueries.DeleteAlbum;
using MusicService.Features.Albums.CommandAndQueries.GetAlbums;
using MusicService.Features.Albums.CommandAndQueries.GetSingleAlbum;
using MusicService.Features.Albums.CommandAndQueries.UpdateAlbum;
using MusicService.Features.Common.Controllers;
using MusicService.Features.Common.Exceptions;
using MusicService.SharedLibrary.Albums.Dtos;

namespace MusicService.Features.Albums.Controllers
{
    public class AlbumsController : BaseApiController
    {
        public AlbumsController(ISender mediator) : base(mediator)
        {
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<AlbumDto>))]
        public async Task<IActionResult> GetAlbums(CancellationToken cancellationToken)
        {
            var query = new GetAlbumsQuery();
            var albums = await Mediator.Send(query, cancellationToken);
            return Ok(albums);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(AlbumDto))]
        public async Task<IActionResult> GetSingleAlbum(long id, CancellationToken cancellationToken)
        {
            var query = new GetSingleAlbumQuery
            {
                Id = id
            };
            var album = await Mediator.Send(query, cancellationToken);

            if (album is not null)
            {
                return Ok(album);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(AlbumDto))]
        public async Task<IActionResult> AddAlbum(NewAlbumDto newAlbum, CancellationToken cancellationToken)
        {
            try
            {
                var command = new AddAlbumCommand(newAlbum);
                var albumCreated = await Mediator.Send(command, cancellationToken);
                return Ok(albumCreated);
            }
            catch (UnprocessibleEntityException)
            {

                return UnprocessableEntity();
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAlbum(long id, UpdateAlbumDto updateAlbum, CancellationToken cancellationToken)
        {

            try
            {
                var command = new UpdateSingleAlbumCommand
                {
                    Id = id,
                    AlbumToUpdate = updateAlbum
                };
                var updatedAlbum = await Mediator.Send(command, cancellationToken);
                return Ok(updatedAlbum);
            }
            catch (ResourceNotFoundException)
            {

                return NotFound();
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }


        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> DeleteSingleAlbum(long id, CancellationToken cancellationToken)
        {
            try
            {
                var command = new DeleteAlbumCommand
                {
                    Id = id
                };
                await Mediator.Send(command, cancellationToken);
                return Ok($"Deleted album with id {id}");
            }
            catch (ResourceNotFoundException)
            {
                return NotFound();
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

    }
}
