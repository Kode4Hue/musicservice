using FluentValidation;

namespace MusicService.Features.Albums.CommandAndQueries.GetSingleAlbum
{
    public class GetSingleAlbumQueryValidator: AbstractValidator<GetSingleAlbumQuery>
    {
        public GetSingleAlbumQueryValidator()
        {
            RuleFor(x => x.Id)
                .NotEmpty()
                .GreaterThan(0);
        }
    }
}
