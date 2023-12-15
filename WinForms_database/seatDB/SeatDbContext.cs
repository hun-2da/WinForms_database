using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WinForms_database.seatDB;

public partial class SeatDbContext : DbContext
{
    public SeatDbContext()
    {
    }

    public SeatDbContext(DbContextOptions<SeatDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Seat> Seats { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySQL("server=localhost;database=seatDB;uid=root;pwd=201104");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Seat>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("seat");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Used).HasColumnName("used");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
