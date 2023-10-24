using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WinForms_database.orderDB;

public partial class OrderDbContext : DbContext
{
    public OrderDbContext()
    {
    }

    public OrderDbContext(DbContextOptions<OrderDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<주문메뉴정보> 주문메뉴정보s { get; set; }

    public virtual DbSet<주문자정보> 주문자정보s { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySQL("server=localhost;database=orderDB;uid=root;pwd=201104");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<주문메뉴정보>(entity =>
        {
            entity.HasKey(e => e.날짜및시간).HasName("PRIMARY");

            entity.ToTable("주문메뉴정보");

            entity.HasIndex(e => e.첫번째테이블의날짜및시간, "첫번째테이블의날짜및시간");

            entity.Property(e => e.날짜및시간).HasColumnType("datetime");
            entity.Property(e => e.메뉴명).HasMaxLength(10);
            entity.Property(e => e.첫번째테이블의날짜및시간).HasColumnType("datetime");

            entity.HasOne(d => d.첫번째테이블의날짜및시간Navigation).WithMany(p => p.주문메뉴정보s)
                .HasForeignKey(d => d.첫번째테이블의날짜및시간)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("주문메뉴정보_ibfk_1");
        });

        modelBuilder.Entity<주문자정보>(entity =>
        {
            entity.HasKey(e => e.날짜및시간).HasName("PRIMARY");

            entity.ToTable("주문자정보");

            entity.Property(e => e.날짜및시간).HasColumnType("datetime");
            entity.Property(e => e.주문상태).HasMaxLength(4);
            entity.Property(e => e.주문타입)
                .HasMaxLength(2)
                .IsFixedLength();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
