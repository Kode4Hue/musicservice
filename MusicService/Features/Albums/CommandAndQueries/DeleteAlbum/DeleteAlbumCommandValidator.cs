using FluentValidation;

namespace MusicService.Features.Albums.CommandAndQueries.DeleteAlbum
{
    public class DeleteAlbumCommandValidator: AbstractValidator<DeleteAlbumCommand>
    {
        public DeleteAlbumCommandValidator()
        {
            RuleFor(x => x.Id)
                .NotEmpty()
                .GreaterThan(0);
        }
    }
}
