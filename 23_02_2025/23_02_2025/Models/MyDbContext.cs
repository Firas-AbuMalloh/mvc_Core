using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace _23_02_2025.Models;

public partial class MyDbContext : DbContext
{
    public MyDbContext()
    {
    }

    public MyDbContext(DbContextOptions<MyDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Department> Departments { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-HBCC5GE ; Database=Orange ;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Department>(entity =>
        {
            entity.ToTable("Department");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Requirment)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.ToTable("Product");

            entity.Property(e => e.Description)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("description");
            entity.Property(e => e.Image)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("image");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Price).HasColumnName("price");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Users__3214EC0741055E54");

            entity.HasIndex(e => e.Email, "UQ__Users__A9D10534E2A23D37").IsUnique();

            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.Name).HasMaxLength(100);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
