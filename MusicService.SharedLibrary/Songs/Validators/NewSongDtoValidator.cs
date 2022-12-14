using FluentValidation;
using MusicService.SharedLibrary.Songs.Dtos;

namespace MusicService.SharedLibrary.Songs.Validators
{
    public class NewSongDtoValidator: AbstractValidator<NewSongDto>
    {
        public NewSongDtoValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty();
            RuleFor(x => x.Track)
                .NotEmpty()
                .GreaterThan(0);
            RuleFor(x => x.AlbumId)
                .NotEmpty()
                .GreaterThan(0);
        }
    }
}
