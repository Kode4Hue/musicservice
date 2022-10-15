using FluentValidation;

namespace MusicService.Features.Artists.CommandAndQueries.GetSingleArtist
{
    public class GetSingleArtistQueryValidator: AbstractValidator<GetSingleArtistQuery>
    {
        public GetSingleArtistQueryValidator()
        {
            RuleFor(x => x.Id)
                .NotEmpty()
                .GreaterThan(0);
        }
    }
}
