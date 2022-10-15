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
        public AlbumDto(
            long id, DateTime created, DateTime lastModified, string name, 
            string yearReleased, ArtistPreviewDto artist, IEnumerable<SongPreviewDto>? songs) : base(id, created, lastModified)
        {
            Name = name;
            YearReleased = yearReleased;
            Artist = artist;
            Songs = songs;
        }

        public string Name { get; set; } = string.Empty;
        public string YearReleased { get; set; } = string.Empty;
        public ArtistPreviewDto Artist { get; set; }
        public IEnumerable<SongPreviewDto>? Songs { get; set; }
    }
}
