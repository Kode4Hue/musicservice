using MediatR;
using Microsoft.AspNetCore.Mvc;
using MusicService.Features.Common.Controllers;
using MusicService.Features.Songs.CommandAndQueries.AddSong;
using MusicService.Features.Songs.CommandAndQueries.DeleteSong;
using MusicService.Features.Songs.CommandAndQueries.GetSingleSong;
using MusicService.Features.Songs.CommandAndQueries.GetSongs;
using MusicService.Features.Songs.CommandAndQueries.UpdateSong;
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

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SongDto))]
        public async Task<IActionResult> GetSingleSong(long id, CancellationToken cancellationToken)
        {
            var query = new GetSingleSongQuery(id);
            var song = await Mediator.Send(query, cancellationToken);
            return Ok(song);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(SongDto))]
        public async Task<IActionResult> AddSong(NewSongDto newSong, CancellationToken cancellationToken)
        {
            var command = new AddSongCommand(newSong);
            var createdSong = await Mediator.Send(command, cancellationToken);
            return StatusCode(StatusCodes.Status201Created,createdSong);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SongDto))]
        public async Task<IActionResult> UpdateSong(long id, UpdateSongDto updateSongInfo, CancellationToken cancellationToken)
        {
            var command = new UpdateSongCommand(id, updateSongInfo);
            var updateSong = await Mediator.Send(command, cancellationToken);
            return Ok(updateSong);
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> DeleteSong(long id, CancellationToken cancellationToken)
        {
            var command = new DeleteSongCommand(id);
            await Mediator.Send(command, cancellationToken);
            return Ok($"Deleted song with id {id}");
        }
    }
}
