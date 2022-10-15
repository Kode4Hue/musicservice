using FluentValidation;
using MusicService.SharedLibrary.Albums.Validators;

namespace MusicService.Features.Albums.CommandAndQueries.UpdateAlbum
{
    public class UpdateSingleAlbumCommandValidator: AbstractValidator<UpdateSingleAlbumCommand>
    {
        public UpdateSingleAlbumCommandValidator()
        {
            RuleFor(x => x.Id)
                .NotEmpty()
                .GreaterThan(0);
            RuleFor(x => x.AlbumToUpdate)
                .NotNull()
                .SetValidator(new UpdateAlbumDtoValidator());
        }
    }
}
