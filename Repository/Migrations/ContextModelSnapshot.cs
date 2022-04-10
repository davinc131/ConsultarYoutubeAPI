﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Repository;

namespace Repository.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.15");

            modelBuilder.Entity("Dommain.Entidades.CanalHost.CanalRoot", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid>("PageInfoID")
                        .HasColumnType("char(36)");

                    b.Property<string>("etag")
                        .HasColumnType("longtext");

                    b.Property<string>("kind")
                        .HasColumnType("longtext");

                    b.Property<string>("nextPageToken")
                        .HasColumnType("longtext");

                    b.Property<string>("regionCode")
                        .HasColumnType("longtext");

                    b.HasKey("ID");

                    b.HasIndex("PageInfoID");

                    b.ToTable("CanalRoot");
                });

            modelBuilder.Entity("Dommain.Entidades.CanalHost.ConsultaCanal", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid>("CanalRootID")
                        .HasColumnType("char(36)");

                    b.Property<string>("TermoConsulta")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("ID");

                    b.HasIndex("CanalRootID");

                    b.ToTable("Canais");
                });

            modelBuilder.Entity("Dommain.Entidades.Comum.Default", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<int>("height")
                        .HasColumnType("int");

                    b.Property<string>("url")
                        .HasColumnType("longtext");

                    b.Property<int>("width")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Default");
                });

            modelBuilder.Entity("Dommain.Entidades.Comum.High", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<int>("height")
                        .HasColumnType("int");

                    b.Property<string>("url")
                        .HasColumnType("longtext");

                    b.Property<int>("width")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("High");
                });

            modelBuilder.Entity("Dommain.Entidades.Comum.Id", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("channelId")
                        .HasColumnType("longtext");

                    b.Property<string>("kind")
                        .HasColumnType("longtext");

                    b.Property<string>("videoId")
                        .HasColumnType("longtext");

                    b.HasKey("ID");

                    b.ToTable("Id");
                });

            modelBuilder.Entity("Dommain.Entidades.Comum.Item", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid?>("CanalRootID")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("IdID")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("SnippetID")
                        .HasColumnType("char(36)");

                    b.Property<Guid?>("VideoRootID")
                        .HasColumnType("char(36)");

                    b.Property<string>("etag")
                        .HasColumnType("longtext");

                    b.Property<string>("kind")
                        .HasColumnType("longtext");

                    b.HasKey("ID");

                    b.HasIndex("CanalRootID");

                    b.HasIndex("IdID");

                    b.HasIndex("SnippetID");

                    b.HasIndex("VideoRootID");

                    b.ToTable("Item");
                });

            modelBuilder.Entity("Dommain.Entidades.Comum.Medium", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<int>("height")
                        .HasColumnType("int");

                    b.Property<string>("url")
                        .HasColumnType("longtext");

                    b.Property<int>("width")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Medium");
                });

            modelBuilder.Entity("Dommain.Entidades.Comum.PageInfo", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<int>("resultsPerPage")
                        .HasColumnType("int");

                    b.Property<int>("totalResults")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("PageInfo");
                });

            modelBuilder.Entity("Dommain.Entidades.Comum.Snippet", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid>("ThumbnailsID")
                        .HasColumnType("char(36)");

                    b.Property<string>("channelId")
                        .HasColumnType("longtext");

                    b.Property<string>("channelTitle")
                        .HasColumnType("longtext");

                    b.Property<string>("description")
                        .HasColumnType("longtext");

                    b.Property<string>("liveBroadcastContent")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("publishTime")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("publishedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("title")
                        .HasColumnType("longtext");

                    b.HasKey("ID");

                    b.HasIndex("ThumbnailsID");

                    b.ToTable("Snippet");
                });

            modelBuilder.Entity("Dommain.Entidades.Comum.Thumbnails", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid>("DefaultID")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("HighID")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("MediumID")
                        .HasColumnType("char(36)");

                    b.HasKey("ID");

                    b.HasIndex("DefaultID");

                    b.HasIndex("HighID");

                    b.HasIndex("MediumID");

                    b.ToTable("Thumbnails");
                });

            modelBuilder.Entity("Dommain.Entidades.VideoHost.ConsultaVideo", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("TermoConsulta")
                        .HasColumnType("longtext");

                    b.Property<Guid>("VideoRootID")
                        .HasColumnType("char(36)");

                    b.HasKey("ID");

                    b.HasIndex("VideoRootID");

                    b.ToTable("Videos");
                });

            modelBuilder.Entity("Dommain.Entidades.VideoHost.VideoRoot", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid>("PageInfoID")
                        .HasColumnType("char(36)");

                    b.Property<string>("TermoConsulta")
                        .HasColumnType("longtext");

                    b.Property<string>("etag")
                        .HasColumnType("longtext");

                    b.Property<string>("kind")
                        .HasColumnType("longtext");

                    b.Property<string>("nextPageToken")
                        .HasColumnType("longtext");

                    b.Property<string>("regionCode")
                        .HasColumnType("longtext");

                    b.HasKey("ID");

                    b.HasIndex("PageInfoID");

                    b.ToTable("VideoRoot");
                });

            modelBuilder.Entity("Dommain.Entidades.CanalHost.CanalRoot", b =>
                {
                    b.HasOne("Dommain.Entidades.Comum.PageInfo", "pageInfo")
                        .WithMany()
                        .HasForeignKey("PageInfoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("pageInfo");
                });

            modelBuilder.Entity("Dommain.Entidades.CanalHost.ConsultaCanal", b =>
                {
                    b.HasOne("Dommain.Entidades.CanalHost.CanalRoot", "CanalRoot")
                        .WithMany()
                        .HasForeignKey("CanalRootID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CanalRoot");
                });

            modelBuilder.Entity("Dommain.Entidades.Comum.Item", b =>
                {
                    b.HasOne("Dommain.Entidades.CanalHost.CanalRoot", "CanalRoot")
                        .WithMany("items")
                        .HasForeignKey("CanalRootID");

                    b.HasOne("Dommain.Entidades.Comum.Id", "id")
                        .WithMany()
                        .HasForeignKey("IdID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Dommain.Entidades.Comum.Snippet", "snippet")
                        .WithMany()
                        .HasForeignKey("SnippetID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Dommain.Entidades.VideoHost.VideoRoot", "VideoRoot")
                        .WithMany("items")
                        .HasForeignKey("VideoRootID");

                    b.Navigation("CanalRoot");

                    b.Navigation("id");

                    b.Navigation("snippet");

                    b.Navigation("VideoRoot");
                });

            modelBuilder.Entity("Dommain.Entidades.Comum.Snippet", b =>
                {
                    b.HasOne("Dommain.Entidades.Comum.Thumbnails", "thumbnails")
                        .WithMany()
                        .HasForeignKey("ThumbnailsID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("thumbnails");
                });

            modelBuilder.Entity("Dommain.Entidades.Comum.Thumbnails", b =>
                {
                    b.HasOne("Dommain.Entidades.Comum.Default", "default")
                        .WithMany()
                        .HasForeignKey("DefaultID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Dommain.Entidades.Comum.High", "high")
                        .WithMany()
                        .HasForeignKey("HighID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Dommain.Entidades.Comum.Medium", "medium")
                        .WithMany()
                        .HasForeignKey("MediumID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("default");

                    b.Navigation("high");

                    b.Navigation("medium");
                });

            modelBuilder.Entity("Dommain.Entidades.VideoHost.ConsultaVideo", b =>
                {
                    b.HasOne("Dommain.Entidades.VideoHost.VideoRoot", "VideoRoot")
                        .WithMany()
                        .HasForeignKey("VideoRootID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("VideoRoot");
                });

            modelBuilder.Entity("Dommain.Entidades.VideoHost.VideoRoot", b =>
                {
                    b.HasOne("Dommain.Entidades.Comum.PageInfo", "pageInfo")
                        .WithMany()
                        .HasForeignKey("PageInfoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("pageInfo");
                });

            modelBuilder.Entity("Dommain.Entidades.CanalHost.CanalRoot", b =>
                {
                    b.Navigation("items");
                });

            modelBuilder.Entity("Dommain.Entidades.VideoHost.VideoRoot", b =>
                {
                    b.Navigation("items");
                });
#pragma warning restore 612, 618
        }
    }
}
