using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicService.SharedLibrary.Music.Dtos
{
    public class SongPreviewDto
    {
        public long Id { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}
