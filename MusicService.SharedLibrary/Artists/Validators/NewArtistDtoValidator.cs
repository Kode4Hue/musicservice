using FluentValidation;
using MusicService.SharedLibrary.Artists.Dtos;

namespace MusicService.SharedLibrary.Artists.Validators
{
    public class NewArtistDtoValidator : AbstractValidator<NewArtistDto>
    {
        public NewArtistDtoValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty();
        }
    }
}
