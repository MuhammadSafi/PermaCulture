using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace PermaCulture.Api.Models
{
    public partial class PermaCultureContext : DbContext
    {
        public PermaCultureContext()
        {
        }

        public PermaCultureContext(DbContextOptions<PermaCultureContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Content> Content { get; set; }
        public virtual DbSet<ContentImage> ContentImage { get; set; }
        public virtual DbSet<ContentVariation> ContentVariation { get; set; }
        public virtual DbSet<Variation> Variation { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
// To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=SAFI\\SQLEXPRESS;Database=PermaCulture;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>(entity =>
            {
                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(256);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<Content>(entity =>
            {
                entity.Property(e => e.Content1)
                    .IsRequired()
                    .HasColumnName("Content")
                    .HasMaxLength(256);

                entity.Property(e => e.Footer).HasMaxLength(256);

                entity.Property(e => e.Header).HasMaxLength(256);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Content)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Content_Category");
            });

            modelBuilder.Entity<ContentImage>(entity =>
            {
                entity.Property(e => e.ImagesUrl)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<ContentVariation>(entity =>
            {
                entity.HasOne(d => d.Content)
                    .WithMany(p => p.ContentVariation)
                    .HasForeignKey(d => d.ContentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ContentVariation_ContentVariation");
            });

            modelBuilder.Entity<Variation>(entity =>
            {
                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(250);
            });
        }
    }
}
