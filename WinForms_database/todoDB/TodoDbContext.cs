using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WinForms_database.todoDB;

public partial class TodoDbContext : DbContext
{
    public TodoDbContext()
    {
    }

    public TodoDbContext(DbContextOptions<TodoDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Todo> Todos { get; set; }

    public virtual DbSet<TodoContent> TodoContents { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySQL("server=localhost;database=todoDB;uid=root;pwd=201104");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Todo>(entity =>
        {
            entity.HasKey(e => e.날짜).HasName("PRIMARY");

            entity.ToTable("todo");

            entity.Property(e => e.날짜).HasColumnType("date");
            entity.Property(e => e.수행자).HasMaxLength(10);
        });

        modelBuilder.Entity<TodoContent>(entity =>
        {
            entity.HasKey(e => e.현재시간).HasName("PRIMARY");

            entity.ToTable("todo_content");

            entity.HasIndex(e => e.Todo날짜, "todo날짜");

            entity.Property(e => e.현재시간).HasColumnType("datetime");
            entity.Property(e => e.Todo날짜)
                .HasColumnType("date")
                .HasColumnName("todo날짜");
            entity.Property(e => e.할일내용).HasMaxLength(100);

            entity.HasOne(d => d.Todo날짜Navigation).WithMany(p => p.TodoContents)
                .HasForeignKey(d => d.Todo날짜)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("todo_content_ibfk_1");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
