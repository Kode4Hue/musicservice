using FluentValidation;
using MusicService.SharedLibrary.Artists.Dtos;
using MusicService.SharedLibrary.Artists.Validators;

namespace MusicService.Features.Artists.CommandAndQueries.UpdateSingleArtist
{
    public class UpdateSingleArtistCommandValidator: AbstractValidator<UpdateSingleArtistCommand>
    {
        public UpdateSingleArtistCommandValidator()
        {
            RuleFor(x => x.Id)
                .NotEmpty()
                .GreaterThan(0);

            RuleFor(x => x.ArtistToUpdate)
                .NotEmpty()
                .SetValidator(new UpdateArtistDtoValidator());
        }
    }
}
