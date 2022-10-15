using FluentValidation;
using MusicService.SharedLibrary.Albums.Dtos;

namespace MusicService.SharedLibrary.Albums.Validators
{
    public class UpdateAlbumDtoValidator: AbstractValidator<UpdateAlbumDto>
    {
        public UpdateAlbumDtoValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty();
            RuleFor(x => x.YearReleased)
                .NotEmpty();
            RuleFor(x => x.ArtistId)
                .NotEmpty()
                .GreaterThan(0);
        }
    }
}
