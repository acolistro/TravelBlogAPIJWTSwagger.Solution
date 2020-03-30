﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TravelBlog.Models;

namespace TravelBlog.Migrations
{
    [DbContext(typeof(TravelBlogContext))]
    partial class TravelBlogContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("TravelBlog.Models.Destination", b =>
                {
                    b.Property<int>("DestinationId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Location");

                    b.Property<int>("Year");

                    b.HasKey("DestinationId");

                    b.ToTable("Destinations");

                    b.HasData(
                        new
                        {
                            DestinationId = 6,
                            Location = "Oregon",
                            Year = 1859
                        },
                        new
                        {
                            DestinationId = 7,
                            Location = "Washington",
                            Year = 1889
                        },
                        new
                        {
                            DestinationId = 8,
                            Location = "Idaho",
                            Year = 1890
                        });
                });

            modelBuilder.Entity("TravelBlog.Models.Review", b =>
                {
                    b.Property<int>("ReviewId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("DestinationId");

                    b.Property<int?>("DestinationId1");

                    b.Property<string>("Title");

                    b.HasKey("ReviewId");

                    b.HasIndex("DestinationId1");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("TravelBlog.Models.Review", b =>
                {
                    b.HasOne("TravelBlog.Models.Destination", "Destination")
                        .WithMany("Reviews")
                        .HasForeignKey("DestinationId1");
                });
#pragma warning restore 612, 618
        }
    }
}
