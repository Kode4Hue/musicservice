using MediatR;
using Microsoft.AspNetCore.Mvc;
using MusicService.Features.Artists.CommandAndQueries.AddArtist;
using MusicService.Features.Artists.CommandAndQueries.GetArtists;
using MusicService.Features.Artists.CommandAndQueries.GetSingleArtist;
using MusicService.Features.Common.Controllers;
using MusicService.SharedLibrary.Artists.Dtos;

namespace MusicService.Features.Artists.Controllers
{
    [Route("api/[controller]")]
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
        public async Task<IActionResult> GetSingleArtist(long id)
        {
            var query = new GetSingleArtistQuery
            {
                Id = id
            };
            var artist = await Mediator.Send(query);

            if(artist is not null)
            {
                return Ok(new ArtistDto { });
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(ArtistDto))]
        public async Task<IActionResult> AddArtist(NewArtistDto newArtist)
        {
            var command = new AddArtistCommand
            {
                NewArtist = newArtist
            };
            var createdArtist = await Mediator.Send(command);
            return CreatedAtAction(nameof(GetSingleArtist), createdArtist);
        }

        //[HttpGet("{id}")]
        //[ProducesResponseType(StatusCodes.Status200OK)]
        //[ProducesResponseType(StatusCodes.Status404NotFound)]
        //public async Task<IActionResult> DeleteSingleArtist(long id)
        //{
        //}
}
