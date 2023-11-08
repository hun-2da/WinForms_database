﻿using System;
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

    public virtual DbSet<Member> Members { get; set; }

    public virtual DbSet<Porder> Porders { get; set; }

    public virtual DbSet<Porderdetail> Porderdetails { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySQL("server=localhost;database=orderDB;uid=root;pwd=201104");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Member>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("member");

            entity.Property(e => e.Id)
                .HasMaxLength(20)
                .HasColumnName("id");
            entity.Property(e => e.Address)
                .HasMaxLength(25)
                .HasColumnName("address");
            entity.Property(e => e.Age).HasColumnName("age");
            entity.Property(e => e.Name)
                .HasMaxLength(10)
                .HasColumnName("name");
        });

        modelBuilder.Entity<Porder>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("porder");

            entity.HasIndex(e => e.MemberId, "member_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Created)
                .HasColumnType("date")
                .HasColumnName("created");
            entity.Property(e => e.MemberId)
                .HasMaxLength(20)
                .HasColumnName("member_id");

            entity.HasOne(d => d.Member).WithMany(p => p.Porders)
                .HasForeignKey(d => d.MemberId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("porder_ibfk_1");
        });

        modelBuilder.Entity<Porderdetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("porderdetail");

            entity.HasIndex(e => e.PorderId, "porder_id");

            entity.HasIndex(e => e.ProductId, "product_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.PorderId).HasColumnName("porder_id");
            entity.Property(e => e.ProductId).HasColumnName("product_id");
            entity.Property(e => e.Qty).HasColumnName("qty");

            entity.HasOne(d => d.Porder).WithMany(p => p.Porderdetails)
                .HasForeignKey(d => d.PorderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("porderdetail_ibfk_1");

            entity.HasOne(d => d.Product).WithMany(p => p.Porderdetails)
                .HasForeignKey(d => d.ProductId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("porderdetail_ibfk_2");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("product");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(20)
                .HasColumnName("name");
            entity.Property(e => e.Price).HasColumnName("price");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
