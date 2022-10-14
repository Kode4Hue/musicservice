using MusicService.SharedLibrary.Artists.Dtos;
using MusicService.SharedLibrary.Common.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicService.SharedLibrary.Music.Dtos
{
    public class AlbumDto: BaseModelDto
    {
        public string Name { get; set; } = string.Empty;
        public string YearReleased { get; set; } = string.Empty;
        public ArtistPreviewDto Artist { get; set; }
        public IEnumerable<SongPreviewDto>? Songs { get; set; }
    }
}
