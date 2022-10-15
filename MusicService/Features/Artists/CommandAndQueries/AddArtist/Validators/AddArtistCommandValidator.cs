using FluentValidation;

namespace MusicService.Features.Artists.CommandAndQueries.AddArtist.Validators
{
    public class AddArtistCommandValidator: AbstractValidator<AddArtistCommand>
    {
        public AddArtistCommandValidator()
        {
            RuleFor(x => x.NewArtist)
                .NotEmpty();
            RuleFor(x => x.NewArtist)
                .SetValidator(new NewArtistValidator());
        }
    }
}
