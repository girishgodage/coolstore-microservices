﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VND.CoolStore.Services.Review.Infrastructure.Db;

namespace VND.CoolStore.Services.Review.Migrations
{
    [DbContext(typeof(ReviewDbContext))]
    [Migration("20180810131836_InitReviewDb")]
    partial class InitReviewDb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("VND.CoolStore.Services.Review.Domain.Review", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Content")
                        .IsRequired();

                    b.Property<DateTime>("Created");

                    b.Property<Guid>("ReviewAuthorId");

                    b.Property<Guid>("ReviewProductId");

                    b.Property<DateTime>("Updated");

                    b.HasKey("Id");

                    b.HasIndex("ReviewAuthorId");

                    b.HasIndex("ReviewProductId");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("VND.CoolStore.Services.Review.Domain.ReviewAuthor", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("UserId");

                    b.HasKey("Id");

                    b.ToTable("ReviewAuthors");
                });

            modelBuilder.Entity("VND.CoolStore.Services.Review.Domain.ReviewProduct", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("ProductId");

                    b.HasKey("Id");

                    b.ToTable("ReviewProducts");
                });

            modelBuilder.Entity("VND.CoolStore.Services.Review.Domain.Review", b =>
                {
                    b.HasOne("VND.CoolStore.Services.Review.Domain.ReviewAuthor", "ReviewAuthor")
                        .WithMany()
                        .HasForeignKey("ReviewAuthorId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("VND.CoolStore.Services.Review.Domain.ReviewProduct", "ReviewProduct")
                        .WithMany()
                        .HasForeignKey("ReviewProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
