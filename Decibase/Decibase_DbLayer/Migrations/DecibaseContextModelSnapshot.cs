﻿// <auto-generated />
using System;
using Decibase_DbLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Decibase_DbLayer.Migrations
{
    [DbContext(typeof(DecibaseContext))]
    partial class DecibaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Decibase_DbLayer.Album", b =>
                {
                    b.Property<int>("AlbumId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TotalDiscs")
                        .HasColumnType("int");

                    b.Property<int>("TotalTracks")
                        .HasColumnType("int");

                    b.Property<string>("Year")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AlbumId");

                    b.ToTable("Albums");
                });

            modelBuilder.Entity("Decibase_DbLayer.Artist", b =>
                {
                    b.Property<int>("ArtistId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nationality")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ArtistId");

                    b.ToTable("Artists");
                });

            modelBuilder.Entity("Decibase_DbLayer.Track", b =>
                {
                    b.Property<int>("TrackId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AlbumId")
                        .HasColumnType("int");

                    b.Property<int>("DiscNumber")
                        .HasColumnType("int");

                    b.Property<string>("Genre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TrackNumber")
                        .HasColumnType("int");

                    b.HasKey("TrackId");

                    b.HasIndex("AlbumId");

                    b.ToTable("Tracks");
                });

            modelBuilder.Entity("Decibase_DbLayer.TrackArtist_JunctionTable", b =>
                {
                    b.Property<int>("TrackId")
                        .HasColumnType("int");

                    b.Property<int>("ArtistId")
                        .HasColumnType("int");

                    b.Property<int?>("TrackId1")
                        .HasColumnType("int");

                    b.Property<int?>("TrackId2")
                        .HasColumnType("int");

                    b.HasKey("TrackId", "ArtistId");

                    b.HasIndex("ArtistId");

                    b.HasIndex("TrackId1");

                    b.HasIndex("TrackId2");

                    b.ToTable("TrackArtists");
                });

            modelBuilder.Entity("Decibase_DbLayer.Track", b =>
                {
                    b.HasOne("Decibase_DbLayer.Album", "Album")
                        .WithMany("Tracks")
                        .HasForeignKey("AlbumId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Decibase_DbLayer.TrackArtist_JunctionTable", b =>
                {
                    b.HasOne("Decibase_DbLayer.Artist", "Artist")
                        .WithMany("Tracks")
                        .HasForeignKey("ArtistId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Decibase_DbLayer.Track", "Track")
                        .WithMany("Artists")
                        .HasForeignKey("TrackId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Decibase_DbLayer.Track", null)
                        .WithMany("Features")
                        .HasForeignKey("TrackId1");

                    b.HasOne("Decibase_DbLayer.Track", null)
                        .WithMany("Remixers")
                        .HasForeignKey("TrackId2");
                });
#pragma warning restore 612, 618
        }
    }
}
