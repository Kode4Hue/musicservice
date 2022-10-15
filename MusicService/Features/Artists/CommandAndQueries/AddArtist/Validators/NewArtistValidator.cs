using FluentValidation;
using MusicService.SharedLibrary.Artists.Dtos;

namespace MusicService.Features.Artists.CommandAndQueries.AddArtist.Validators
{
    public class NewArtistValidator: AbstractValidator<NewArtistDto>
    {
        public NewArtistValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty();
        }
    }
}
