using FluentValidation;
using MusicService.SharedLibrary.Albums.Validators;

namespace MusicService.Features.Albums.CommandAndQueries.AddAlbum
{
    public class AddAlbumCommandValidator: AbstractValidator<AddAlbumCommand>
    {
        public AddAlbumCommandValidator()
        {
            RuleFor(x => x.Album)
                .NotNull()
                .SetValidator(new NewAlbumDtoValidator());


        }
    }
}
