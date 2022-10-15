using MediatR;
using Microsoft.AspNetCore.Mvc;
using MusicService.Features.Artists.CommandAndQueries.AddArtist;
using MusicService.Features.Artists.CommandAndQueries.DeleteSingleArtist;
using MusicService.Features.Artists.CommandAndQueries.GetArtists;
using MusicService.Features.Artists.CommandAndQueries.GetSingleArtist;
using MusicService.Features.Artists.CommandAndQueries.UpdateSingleArtist;
using MusicService.Features.Common.Controllers;
using MusicService.Features.Common.Exceptions;
using MusicService.SharedLibrary.Artists.Dtos;

namespace MusicService.Features.Artists.Controllers
{

    public class ArtistsController : BaseApiController
    {
        public ArtistsController(ISender mediator) : base(mediator)
        {
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<ArtistDto>))]
        public async Task<IActionResult> GetArtists()
        {
            var query = new GetArtistsQuery();
            var result = await Mediator.Send(query);
            return Ok(result);
        }


        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ArtistDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetSingleArtist(long id, CancellationToken cancellationToken)
        {
            var query = new GetSingleArtistQuery
            {
                Id = id
            };
            var artist = await Mediator.Send(query, cancellationToken);

            if (artist is not null)
            {
                return Ok(artist);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(ArtistDto))]
        public async Task<IActionResult> AddArtist(NewArtistDto newArtist, CancellationToken cancellationToken)
        {
            var command = new AddArtistCommand
            {
                NewArtist = newArtist
            };
            var createdArtist = await Mediator.Send(command, cancellationToken);
            var actionName = nameof(GetSingleArtist);
            var routeValues = new { id = createdArtist.Id };
            return CreatedAtAction(actionName, routeValues, createdArtist);
        }


        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateArtist(long id, UpdateArtistDto updateArtist, CancellationToken cancellationToken)
        {
            try
            {
                var command = new UpdateSingleArtistCommand
                {
                    Id = id,
                    ArtistToUpdate = updateArtist
                };
                var updatedArtist = await Mediator.Send(command, cancellationToken);
                return Ok(updatedArtist);
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
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> DeleteSingleArtist(long id, CancellationToken cancellationToken)
        {
            try
            {
                var command = new DeleteSingleArtistCommand
                {
                    Id = id
                };
                await Mediator.Send(command, cancellationToken);
                return Ok($"Deleted artist with id {id}");
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
