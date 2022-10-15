using FluentValidation;
using MusicService.SharedLibrary.Songs.Validators;

namespace MusicService.Features.Songs.CommandAndQueries.AddSong
{
    public class AddSongCommandValidator: AbstractValidator<AddSongCommand>
    {
        public AddSongCommandValidator()
        {
            RuleFor(x => x.NewSong)
                .NotEmpty()
                .SetValidator(new NewSongDtoValidator());
        }
    }
}
