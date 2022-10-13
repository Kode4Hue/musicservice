using MediatR;
using Microsoft.AspNetCore.Mvc;
using MusicService.Features.Artists.CommandAndQueries.GetArtists;
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
    }
}
