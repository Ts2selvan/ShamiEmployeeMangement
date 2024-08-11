using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using ShamiEmployeeMangement.Models;

namespace ShamiEmployeeMangement.Databaseconnectivity;

public partial class EmployeeShamContext : DbContext
{
    public EmployeeShamContext()
    {
    }

    public EmployeeShamContext(DbContextOptions<EmployeeShamContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Signup> Signups { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Name=DevConnection");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Signup>(entity =>
        {
            entity.HasKey(e => e.Username).HasName("PK__signup__F3DBC5737AB6D649");

            entity.ToTable("signup");

            entity.Property(e => e.Username)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("username");
            entity.Property(e => e.Confirmpassword)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("confirmpassword");
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("password");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
