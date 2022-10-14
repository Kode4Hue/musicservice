﻿using Microsoft.EntityFrameworkCore;
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
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Artist>()
                .Configure(x =>
                {
                    x.ToTable("artist");
                    x.HasKey(a => a.Id);
                    x.Property(a => a.Id)
                        .HasColumnName("id");
                    x.Property(a => a.Id)
                        .ValueGeneratedOnAdd();
                    x.Property(a => a.Name)
                        .HasColumnName("name");
                    x.Property(a => a.Name)
                        .IsRequired();
                    x.Property(a => a.Created)
                        .HasColumnName("created");
                    x.Property(a => a.Created)
                        .IsRequired();
                    x.Property(a => a.Created)
                        .HasDefaultValueSql("getutcdate()");
                    x.Property(a => a.LastModified)
                        .HasColumnName("last_modified");
                    x.Property(a => a.LastModified)
                        .IsRequired();
                    x.Property(a => a.LastModified)
                        .HasDefaultValueSql("getutcdate()");
                });

            modelBuilder.Entity<Album>()
                .Configure(x =>
                {
                    x.ToTable("album");
                    x.Property(a => a.Id)
                        .HasColumnName("id");
                    x.HasKey(a => a.Id);
                    x.Property(a => a.Id)
                        .ValueGeneratedOnAdd();
                    x.Property(a => a.Name)
                        .HasColumnName("name");
                    x.Property(a => a.Name)
                        .IsRequired();
                    x.Property(a => a.YearReleased)
                        .HasColumnName("year_released");
                    x.Property(a => a.YearReleased)
                        .IsRequired();
                    x.Property(a => a.Created)
                        .HasColumnName("created");
                    x.Property(a => a.Created)
                        .IsRequired();
                    x.Property(a => a.Created)
                        .HasDefaultValueSql("getutcdate()");
                    x.Property(a => a.LastModified)
                        .HasColumnName("last_modified");
                    x.Property(a => a.LastModified)
                        .IsRequired();
                    x.Property(a => a.LastModified)
                        .HasDefaultValueSql("getutcdate()");
                    x.Property(a => a.ArtistId)
                        .HasColumnName("artist_id");
                    x.HasOne<Artist>(a => a.Artist)
                        .WithMany(b => b.Albums)
                        .HasForeignKey(c => c.ArtistId)
                        .OnDelete(DeleteBehavior.ClientCascade);
                });

            modelBuilder.Entity<Song>()
                .Configure(x =>
                {
                    x.ToTable("song");
                    x.Property(a => a.Id)
                        .HasColumnName("id");
                    x.HasKey(a => a.Id);
                    x.Property(a => a.Id)
                        .ValueGeneratedOnAdd();
                    x.Property(a => a.Track)
                        .HasColumnName("track");
                    x.Property(a => a.Track)
                        .IsRequired();
                    x.Property(a => a.Name)
                        .HasColumnName("name");
                    x.Property(a => a.Name)
                        .IsRequired();
                    x.Property(a => a.Created)
                        .HasColumnName("created");
                    x.Property(a => a.Created)
                        .IsRequired();
                    x.Property(a => a.Created)
                        .HasDefaultValueSql("getutcdate()");
                    x.Property(a => a.LastModified)
                        .HasColumnName("last_modified");
                    x.Property(a => a.LastModified)
                        .IsRequired();
                    x.Property(a => a.LastModified)
                        .HasDefaultValueSql("getutcdate()");
                    x.Property(a => a.AlbumId)
                        .HasColumnName("album_id");
                    x.HasOne<Album>(a => a.Album)
                        .WithMany(b => b.Songs)
                        .HasForeignKey(c => c.AlbumId)
                        .OnDelete(DeleteBehavior.ClientCascade);
                });


        }
    }
}
