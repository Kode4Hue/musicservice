using FluentValidation;
using MusicService.SharedLibrary.Albums.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicService.SharedLibrary.Albums.Validators
{
    public class NewAlbumDtoValidator: AbstractValidator<NewAlbumDto>
    {
        public NewAlbumDtoValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty();
            RuleFor(x => x.YearReleased)
                .NotEmpty();
            RuleFor(x => x.ArtistId)
                .NotEmpty()
                .GreaterThan(0).WithMessage("Please enter a valid Artist Id");
        }
    }
}
