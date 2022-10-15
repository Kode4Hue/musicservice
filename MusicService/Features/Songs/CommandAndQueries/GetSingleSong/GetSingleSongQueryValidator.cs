using FluentValidation;

namespace MusicService.Features.Songs.CommandAndQueries.GetSingleSong
{
    public class GetSingleSongQueryValidator: AbstractValidator<GetSingleSongQuery>
    {
        public GetSingleSongQueryValidator()
        {
            RuleFor(x => x.Id)
                .NotEmpty()
                .GreaterThan(0);
        }
    }
}
