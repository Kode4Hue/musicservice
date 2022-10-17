using MusicService.SharedLibrary.Artists.Dtos;
using MusicService.SharedLibrary.Common.Dtos;
using MusicService.SharedLibrary.Songs.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicService.SharedLibrary.Albums.Dtos
{
    public class AlbumDto : BaseModelDto
    {

        public AlbumDto()
        {
            
        }

        public AlbumDto(
            long id, DateTime created, DateTime lastModified, string name,
            string yearReleased, IEnumerable<SongPreviewDto>? songs) : base(id, created, lastModified)
        {
            Name = name;
            YearReleased = yearReleased;
            Songs = songs;
        }

        public string Name { get; set; } = string.Empty;
        public string YearReleased { get; set; } = string.Empty;
        public IEnumerable<SongPreviewDto>? Songs { get; set; }
    }
}
