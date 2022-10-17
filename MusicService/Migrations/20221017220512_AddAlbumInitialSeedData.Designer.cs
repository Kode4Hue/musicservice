﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MusicService.Features.Common.Persistence;

#nullable disable

namespace MusicService.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20221017220512_AddAlbumInitialSeedData")]
    partial class AddAlbumInitialSeedData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("MusicService.Features.Albums.Domain.Entities.Album", b =>
                {
                    b.Property<long>("Id")
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    b.Property<DateTime>("Created")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasColumnName("created")
                        .HasDefaultValueSql("getutcdate()");

                    b.Property<DateTime>("LastModified")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasColumnName("last_modified")
                        .HasDefaultValueSql("getutcdate()");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("name");

                    b.Property<int>("YearReleased")
                        .HasColumnType("int")
                        .HasColumnName("year_released");

                    b.HasKey("Id");

                    b.ToTable("album", (string)null);
                });

            modelBuilder.Entity("MusicService.Features.Artists.Domain.Entities.Artist", b =>
                {
                    b.Property<long>("Id")
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    b.Property<DateTime>("Created")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasColumnName("created")
                        .HasDefaultValueSql("getutcdate()");

                    b.Property<DateTime>("LastModified")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasColumnName("last_modified")
                        .HasDefaultValueSql("getutcdate()");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("artist", (string)null);
                });

            modelBuilder.Entity("MusicService.Features.Artists.Domain.Entities.ArtistAlbum", b =>
                {
                    b.Property<long>("ArtistId")
                        .HasColumnType("bigint")
                        .HasColumnName("artist_id");

                    b.Property<long>("AlbumId")
                        .HasColumnType("bigint")
                        .HasColumnName("albums_id");

                    b.HasKey("ArtistId", "AlbumId");

                    b.HasIndex("AlbumId");

                    b.ToTable("artist_albums", (string)null);
                });

            modelBuilder.Entity("MusicService.Features.Songs.Domain.Entities.Song", b =>
                {
                    b.Property<long>("Id")
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    b.Property<long>("AlbumId")
                        .HasColumnType("bigint")
                        .HasColumnName("album_id");

                    b.Property<DateTime>("Created")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasColumnName("created")
                        .HasDefaultValueSql("getutcdate()");

                    b.Property<DateTime>("LastModified")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasColumnName("last_modified")
                        .HasDefaultValueSql("getutcdate()");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("name");

                    b.Property<int>("Track")
                        .HasColumnType("int")
                        .HasColumnName("track");

                    b.HasKey("Id");

                    b.HasIndex("AlbumId");

                    b.ToTable("song", (string)null);
                });

            modelBuilder.Entity("MusicService.Features.Artists.Domain.Entities.ArtistAlbum", b =>
                {
                    b.HasOne("MusicService.Features.Albums.Domain.Entities.Album", "Album")
                        .WithMany("ArtistAlbums")
                        .HasForeignKey("AlbumId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MusicService.Features.Artists.Domain.Entities.Artist", "Artist")
                        .WithMany("ArtistAlbums")
                        .HasForeignKey("ArtistId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Album");

                    b.Navigation("Artist");
                });

            modelBuilder.Entity("MusicService.Features.Songs.Domain.Entities.Song", b =>
                {
                    b.HasOne("MusicService.Features.Albums.Domain.Entities.Album", "Album")
                        .WithMany("Songs")
                        .HasForeignKey("AlbumId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("Album");
                });

            modelBuilder.Entity("MusicService.Features.Albums.Domain.Entities.Album", b =>
                {
                    b.Navigation("ArtistAlbums");

                    b.Navigation("Songs");
                });

            modelBuilder.Entity("MusicService.Features.Artists.Domain.Entities.Artist", b =>
                {
                    b.Navigation("ArtistAlbums");
                });
#pragma warning restore 612, 618
        }
    }
}
