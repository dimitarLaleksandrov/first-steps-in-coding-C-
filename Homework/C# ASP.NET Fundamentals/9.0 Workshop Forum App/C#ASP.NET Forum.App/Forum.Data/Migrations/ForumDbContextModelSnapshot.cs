﻿// <auto-generated />
using System;
using Forum.App.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Forum.App.Data.Migrations
{
    [DbContext(typeof(ForumDbContext))]
    partial class ForumDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Forum.App.Data.Models.Post", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasMaxLength(1500)
                        .HasColumnType("nvarchar(1500)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Posts");

                    b.HasData(
                        new
                        {
                            Id = new Guid("eb500bc5-504a-4370-ab51-402d8591ec47"),
                            Content = "First Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin dictum metus nec magna auctor tincidunt. Fusce et dolor quis nunc.",
                            Title = "My first post"
                        },
                        new
                        {
                            Id = new Guid("01c2e06c-7517-4602-af1f-c126ae606521"),
                            Content = "Second Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin ornare turpis ornare purus laoreet porta. Donec semper nibh maximus mauris eleifend, quis mattis nunc rutrum.",
                            Title = "My second post"
                        },
                        new
                        {
                            Id = new Guid("382f43cd-995b-45fd-ac76-2ef809fb555b"),
                            Content = "Third Lorem ipsum dolor sit amet, consectetur adipiscing elit. Praesent feugiat, nunc sit amet sagittis vestibulum, sem dolor lacinia leo.",
                            Title = "My third post"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
