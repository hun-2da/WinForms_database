using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WinForms_database.testDB;

public partial class TestDbContext : DbContext
{
    public TestDbContext()
    {
    }

    public TestDbContext(DbContextOptions<TestDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<FriendsLog> FriendsLogs { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySQL("server=localhost;database=testDB;uid=root;pwd=201104");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<FriendsLog>(entity =>
        {
            entity.HasKey(e => e.Phonenumber).HasName("PRIMARY");

            entity.ToTable("friends_log");

            entity.Property(e => e.Phonenumber)
                .HasMaxLength(13)
                .IsFixedLength()
                .HasColumnName("phonenumber");
            entity.Property(e => e.Birthday)
                .HasColumnType("date")
                .HasColumnName("birthday");
            entity.Property(e => e.Content)
                .HasMaxLength(100)
                .HasColumnName("content");
            entity.Property(e => e.Name)
                .HasMaxLength(20)
                .HasColumnName("name");
            entity.Property(e => e.Relationship).HasColumnName("relationship");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
