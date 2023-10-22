using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WinForms_database.fanDB;

public partial class FanDbContext : DbContext
{
    public FanDbContext()
    {
    }

    public FanDbContext(DbContextOptions<FanDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<아이돌> 아이돌s { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySQL("server=localhost;database=fanDB;uid=root;pwd=201104");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<아이돌>(entity =>
        {
            entity.HasKey(e => e.한자이름).HasName("PRIMARY");

            entity.ToTable("아이돌");

            entity.Property(e => e.한자이름).HasMaxLength(10);
            entity.Property(e => e.그룹명).HasMaxLength(30);
            entity.Property(e => e.데뷔연도).HasColumnType("date");
            entity.Property(e => e.분야).HasMaxLength(10);
            entity.Property(e => e.소속사).HasMaxLength(30);
            entity.Property(e => e.이름).HasMaxLength(20);
            entity.Property(e => e.팬네임).HasMaxLength(10);
            entity.Property(e => e.혈액형).HasMaxLength(2);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
