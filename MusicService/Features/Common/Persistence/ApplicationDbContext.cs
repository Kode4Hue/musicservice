using Microsoft.EntityFrameworkCore;
using MusicService.Features.Artists.Domain.Entities;
using MusicService.Features.Common.Persistence.Extensions;
using MusicService.Features.Music.Domain.Entities;

namespace MusicService.Features.Common.Persistence
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Album> Albums { get; set; }
        public DbSet<Song> Songs { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Artist>()
                .Configure(x =>
                {
                    x.HasKey(a => a.Id);
                    x.Property(a => a.Name)
                        .IsRequired();
                    x.Property(a => a.Created)
                        .IsRequired();
                    x.Property(a => a.LastModified)
                        .IsRequired();
                });

            modelBuilder.Entity<Album>()
                .Configure(x =>
                {
                    x.HasKey(a => a.Id);
                    x.Property(a => a.Name)
                        .IsRequired();
                    x.Property(a => a.YearReleased)
                        .IsRequired();
                    x.Property(a => a.Created)
                        .IsRequired();
                    x.Property(a => a.LastModified)
                        .IsRequired();
                    x.HasOne<Artist>(a => a.Artist)
                        .WithMany(b => b.Albums)
                        .HasForeignKey(c => c.ArtistId);
                });

            modelBuilder.Entity<Song>()
                .Configure(x =>
                {
                    x.HasKey(a => a.Id);
                    x.Property(a => a.Track)
                        .IsRequired();
                    x.Property(a => a.Name)
                        .IsRequired();
                    x.Property(a => a.Created)
                        .IsRequired();
                    x.Property(a => a.LastModified)
                        .IsRequired();
                    x.HasOne<Album>(a => a.Album)
                        .WithMany(b => b.Songs)
                        .HasForeignKey(c => c.AlbumId);
                });
        }
    }
}
