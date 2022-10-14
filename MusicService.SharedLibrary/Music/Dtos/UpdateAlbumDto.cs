using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicService.SharedLibrary.Music.Dtos
{
    public class UpdateAlbumDto
    {
        public string Name { get; set; } = string.Empty;
        public int? YearReleased { get; set; }
        public int ArtistId { get; set; }
    }
}
