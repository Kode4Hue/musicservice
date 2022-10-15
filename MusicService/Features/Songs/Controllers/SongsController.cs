using MediatR;
using Microsoft.AspNetCore.Mvc;
using MusicService.Features.Common.Controllers;
using MusicService.Features.Songs.CommandAndQueries;
using MusicService.SharedLibrary.Songs.Dtos;

namespace MusicService.Features.Songs.Controllers
{
    public class SongsController : BaseApiController
    {
        public SongsController(ISender mediator) : base(mediator)
        {
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<SongDto>))]
        public async Task<IActionResult> GetSongs()
        {
            var query = new GetSongsQuery();
            var songs = await Mediator.Send(query);
            return Ok(songs);
        }
    }
}
