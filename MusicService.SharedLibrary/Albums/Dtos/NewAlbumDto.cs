using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicService.SharedLibrary.Albums.Dtos
{
    public class NewAlbumDto
    {
        public string Name { get; set; } = string.Empty;
        public long? ArtistId { get; set; }
        public int? YearReleased { get; set; }
    }
}
