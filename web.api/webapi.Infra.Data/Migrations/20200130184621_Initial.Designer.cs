﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using webapi.Infra.Data.Context;

namespace webapi.Infra.Data.Migrations
{
    [DbContext(typeof(LibraryContext))]
    [Migration("20200130184621_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("webapi.Domain.Models.BookObject", b =>
                {
                    b.Property<int>("IdBook")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BookAuthor")
                        .HasMaxLength(20);

                    b.Property<string>("BookName")
                        .HasMaxLength(30);

                    b.Property<string>("BookPublisher")
                        .HasMaxLength(20);

                    b.Property<string>("BookRegion")
                        .HasMaxLength(20);

                    b.Property<DateTime>("BookReleaseDate");

                    b.HasKey("IdBook");

                    b.ToTable("Books");
                });
#pragma warning restore 612, 618
        }
    }
}