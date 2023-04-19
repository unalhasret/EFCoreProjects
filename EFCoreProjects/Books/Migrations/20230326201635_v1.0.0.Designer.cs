﻿// <auto-generated />
using Books.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Books.Migrations
{
    [DbContext(typeof(BookDbContext))]
    [Migration("20230326201635_v1.0.0")]
    partial class v100
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Books.Models.Author", b =>
                {
                    b.Property<int>("AuthorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AuthorId"));

                    b.Property<string>("AuthorName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AuthorId");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            AuthorId = 1,
                            AuthorName = "Frank Herbert"
                        },
                        new
                        {
                            AuthorId = 2,
                            AuthorName = "Bram Stoker"
                        },
                        new
                        {
                            AuthorId = 3,
                            AuthorName = "Mary Shelley"
                        },
                        new
                        {
                            AuthorId = 4,
                            AuthorName = "Ursula K. Le Guin"
                        });
                });

            modelBuilder.Entity("Books.Models.Book", b =>
                {
                    b.Property<int>("BookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookId"));

                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BookId");

                    b.HasIndex("AuthorId");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            BookId = 1,
                            AuthorId = 1,
                            Title = "Dune"
                        },
                        new
                        {
                            BookId = 2,
                            AuthorId = 2,
                            Title = "Dracula"
                        },
                        new
                        {
                            BookId = 3,
                            AuthorId = 3,
                            Title = "Frankenstein"
                        },
                        new
                        {
                            BookId = 4,
                            AuthorId = 4,
                            Title = "Mülksüzler"
                        },
                        new
                        {
                            BookId = 5,
                            AuthorId = 1,
                            Title = "Dune Mesihi"
                        },
                        new
                        {
                            BookId = 6,
                            AuthorId = 1,
                            Title = "Dune Çocukları"
                        },
                        new
                        {
                            BookId = 7,
                            AuthorId = 1,
                            Title = "Dune Tanrı İmparatoru"
                        },
                        new
                        {
                            BookId = 8,
                            AuthorId = 3,
                            Title = "Son İnsan"
                        },
                        new
                        {
                            BookId = 9,
                            AuthorId = 4,
                            Title = "Karanlığın Sol Eli"
                        });
                });

            modelBuilder.Entity("Books.Models.Book", b =>
                {
                    b.HasOne("Books.Models.Author", "Author")
                        .WithMany("Books")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");
                });

            modelBuilder.Entity("Books.Models.Author", b =>
                {
                    b.Navigation("Books");
                });
#pragma warning restore 612, 618
        }
    }
}
