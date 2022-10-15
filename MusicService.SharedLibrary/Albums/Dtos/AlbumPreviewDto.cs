using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicService.SharedLibrary.Albums.Dtos
{
    public class AlbumPreviewDto
    {
        public long Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string YearReleased { get; set; } = string.Empty;
    }
}
