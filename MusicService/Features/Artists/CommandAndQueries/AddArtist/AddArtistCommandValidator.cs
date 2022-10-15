using FluentValidation;
using MusicService.SharedLibrary.Artists.Validators;

namespace MusicService.Features.Artists.CommandAndQueries.AddArtist
{
    public class AddArtistCommandValidator : AbstractValidator<AddArtistCommand>
    {
        public AddArtistCommandValidator()
        {
            RuleFor(x => x.NewArtist)
                .NotEmpty();
            RuleFor(x => x.NewArtist)
                .SetValidator(new NewArtistDtoValidator());
        }
    }
}
