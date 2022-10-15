using FluentValidation;

namespace MusicService.Features.Artists.CommandAndQueries.DeleteSingleArtist
{
    public class DeleteSingleArtistCommandValidator: AbstractValidator<DeleteSingleArtistCommand>
    {

        public DeleteSingleArtistCommandValidator()
        {
            RuleFor(x => x.Id)
                .NotEmpty()
                .GreaterThan(0);
        }
    }
}
