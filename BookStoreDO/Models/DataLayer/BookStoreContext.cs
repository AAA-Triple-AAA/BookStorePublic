using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace BookStoreDO.Models.DataLayer;

public partial class BookStoreContext : DbContext
{
    public BookStoreContext()
    {
    }

    public BookStoreContext(DbContextOptions<BookStoreContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Author> Authors { get; set; }

    public virtual DbSet<Discount> Discounts { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<Job> Jobs { get; set; }

    public virtual DbSet<PubInfo> PubInfos { get; set; }

    public virtual DbSet<Publisher> Publishers { get; set; }

    public virtual DbSet<Roysched> Royscheds { get; set; }

    public virtual DbSet<Sale> Sales { get; set; }

    public virtual DbSet<Store> Stores { get; set; }

    public virtual DbSet<Title> Titles { get; set; }

    public virtual DbSet<Titleauthor> Titleauthors { get; set; }

    public virtual DbSet<Titleview> Titleviews { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            // Try to read from config first (for your WinForms app)
            var connFromConfig = ConfigurationManager
                .ConnectionStrings["BookStore"]?
                .ConnectionString;

            var connString = string.IsNullOrWhiteSpace(connFromConfig)
                ? "Server=(localdb)\\MSSQLLocalDB;Database=BookStore;Integrated Security=True;MultipleActiveResultSets=True;"
                : connFromConfig;

            optionsBuilder.UseSqlServer(connString);
        }
    }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Author>(entity =>
        {
            entity.HasKey(e => e.AuId).HasName("UPKCL_auidind");

            entity.Property(e => e.Phone)
                .HasDefaultValue("UNKNOWN")
                .IsFixedLength();
            entity.Property(e => e.State).IsFixedLength();
            entity.Property(e => e.Zip).IsFixedLength();
        });

        modelBuilder.Entity<Discount>(entity =>
        {
            entity.Property(e => e.StorId).IsFixedLength();

            entity.HasOne(d => d.Stor).WithMany().HasConstraintName("FK__discounts__stor___286302EC");
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.EmpId)
                .HasName("PK_emp_id")
                .IsClustered(false);

            entity.ToTable("employee", tb => tb.HasTrigger("employee_insupd"));

            entity.HasIndex(e => new { e.Lname, e.Fname, e.Minit }, "employee_ind").IsClustered();

            entity.Property(e => e.EmpId).IsFixedLength();
            entity.Property(e => e.HireDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.JobId).HasDefaultValue((short)1);
            entity.Property(e => e.JobLvl).HasDefaultValue((byte)10);
            entity.Property(e => e.Minit).IsFixedLength();
            entity.Property(e => e.PubId)
                .HasDefaultValue("9952")
                .IsFixedLength();

            entity.HasOne(d => d.Job).WithMany(p => p.Employees)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__employee__job_id__34C8D9D1");

            entity.HasOne(d => d.Pub).WithMany(p => p.Employees)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__employee__pub_id__37A5467C");
        });

        modelBuilder.Entity<Job>(entity =>
        {
            entity.HasKey(e => e.JobId).HasName("PK__jobs__6E32B6A5D7554D16");

            entity.Property(e => e.JobDesc).HasDefaultValue("New Position - title not formalized yet");
        });

        modelBuilder.Entity<PubInfo>(entity =>
        {
            entity.HasKey(e => e.PubId).HasName("UPKCL_pubinfo");

            entity.Property(e => e.PubId).IsFixedLength();

            entity.HasOne(d => d.Pub).WithOne(p => p.PubInfo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__pub_info__pub_id__300424B4");
        });

        modelBuilder.Entity<Publisher>(entity =>
        {
            entity.HasKey(e => e.PubId).HasName("UPKCL_pubind");

            entity.Property(e => e.PubId).IsFixedLength();
            entity.Property(e => e.Country).HasDefaultValue("USA");
            entity.Property(e => e.State).IsFixedLength();
        });

        modelBuilder.Entity<Roysched>(entity =>
        {
            entity.HasOne(d => d.Title).WithMany()
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__roysched__title___267ABA7A");
        });

        modelBuilder.Entity<Sale>(entity =>
        {
            entity.HasKey(e => new { e.StorId, e.OrdNum, e.TitleId }).HasName("UPKCL_sales");

            entity.Property(e => e.StorId).IsFixedLength();

            entity.HasOne(d => d.Stor).WithMany(p => p.Sales)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__sales__stor_id__239E4DCF");

            entity.HasOne(d => d.Title).WithMany(p => p.Sales)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__sales__title_id__24927208");
        });

        modelBuilder.Entity<Store>(entity =>
        {
            entity.HasKey(e => e.StorId).HasName("UPK_storeid");

            entity.Property(e => e.StorId).IsFixedLength();
            entity.Property(e => e.State).IsFixedLength();
            entity.Property(e => e.Zip).IsFixedLength();
        });

        modelBuilder.Entity<Title>(entity =>
        {
            entity.HasKey(e => e.TitleId).HasName("UPKCL_titleidind");

            entity.Property(e => e.PubId).IsFixedLength();
            entity.Property(e => e.Pubdate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.Type)
                .HasDefaultValue("UNDECIDED")
                .IsFixedLength();

            entity.HasOne(d => d.Pub).WithMany(p => p.Titles).HasConstraintName("FK__titles__pub_id__1A14E395");
        });

        modelBuilder.Entity<Titleauthor>(entity =>
        {
            entity.HasKey(e => new { e.AuId, e.TitleId }).HasName("UPKCL_taind");

            entity.HasOne(d => d.Au).WithMany(p => p.Titleauthors)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__titleauth__au_id__1DE57479");

            entity.HasOne(d => d.Title).WithMany(p => p.Titleauthors)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__titleauth__title__1ED998B2");
        });

        modelBuilder.Entity<Titleview>(entity =>
        {
            entity.ToView("titleview");

            entity.Property(e => e.PubId).IsFixedLength();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
