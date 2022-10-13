using Microsoft.EntityFrameworkCore;
using MusicService.Features.Artists.Domain.Entities;
using MusicService.Features.Music.Domain.Entities;

namespace MusicService.Features.Common.Persistence
{
    public class ApplicationDbContext: DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {

        }

        public DbSet<Artist> Artists { get; set; }
        public DbSet<Album> Albums { get; set; }
        public DbSet<Song> Songs { get; set; }
    }
}
