using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MusicService.Features.Common.Controllers;
using MusicService.Features.Music.CommandAndQueries.GetAlbums;
using MusicService.Features.Music.Domain.Entities;
using MusicService.SharedLibrary.Music.Dtos;
using System.Security.Cryptography.X509Certificates;

namespace MusicService.Features.Music.Controllers
{
    public class AlbumsController : BaseApiController
    {
        public AlbumsController(ISender mediator) : base(mediator)
        {
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<AlbumDto>))]
        public async Task<IActionResult> GetAlbums()
        {
            var query = new GetAlbumsQuery();
            var albums = await Mediator.Send(query);
            return Ok(albums);
        }
    }
}
