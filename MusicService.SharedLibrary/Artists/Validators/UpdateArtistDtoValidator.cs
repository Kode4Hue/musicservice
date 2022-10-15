using FluentValidation;
using MusicService.SharedLibrary.Artists.Dtos;

namespace MusicService.SharedLibrary.Artists.Validators
{
    public class UpdateArtistDtoValidator : AbstractValidator<UpdateArtistDto>
    {
        public UpdateArtistDtoValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty();
        }
    }
}
