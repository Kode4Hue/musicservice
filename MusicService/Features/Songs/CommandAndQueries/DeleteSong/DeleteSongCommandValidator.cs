using FluentValidation;

namespace MusicService.Features.Songs.CommandAndQueries.DeleteSong
{
    public class DeleteSongCommandValidator: AbstractValidator<DeleteSongCommand>   
    {
        public DeleteSongCommandValidator()
        {
            RuleFor(x => x.Id)
                .NotEmpty()
                .GreaterThan(0);
        }
    }
}
