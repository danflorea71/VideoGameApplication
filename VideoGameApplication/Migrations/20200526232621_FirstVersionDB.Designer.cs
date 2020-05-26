﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VideoGameApplication.Models;

namespace VideoGameApplication.Migrations
{
    [DbContext(typeof(VideoGameApplicationContext))]
    [Migration("20200526232621_FirstVersionDB")]
    partial class FirstVersionDB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("VideoGameApplication.Models.VideoGame", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("MaximumPlayers");

                    b.Property<int>("MinimumPlayers");

                    b.Property<int>("PublicationYear");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("VideoGame");
                });
#pragma warning restore 612, 618
        }
    }
}
