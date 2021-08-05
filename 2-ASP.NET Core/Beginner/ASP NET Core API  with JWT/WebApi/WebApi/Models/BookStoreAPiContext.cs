using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace WebApi.Models
{
    public partial class BookStoreAPiContext : DbContext
    {
        

        public BookStoreAPiContext(DbContextOptions<BookStoreAPiContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Userr> Userrs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Book>(entity =>
            {
                entity.Property(e => e.BookAuthor).HasMaxLength(100);

                entity.Property(e => e.BookCategory).HasMaxLength(50);

                entity.Property(e => e.BookName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.BookPrice).HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<Userr>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__Userr__1788CC4C09C22E75");

                entity.ToTable("Userr");

                entity.Property(e => e.UserCreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UserEmail).HasMaxLength(100);

                entity.Property(e => e.UserFirstName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UserLastName).HasMaxLength(50);

                entity.Property(e => e.UserPassword)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
