using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace DreamLikeDAL.Models
{
    public partial class DreamlikeContext : DbContext
    {
        public DreamlikeContext()
        {
        }

        public DreamlikeContext(DbContextOptions<DreamlikeContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Agent> Agents { get; set; }
        public virtual DbSet<BlockedCategory> BlockedCategories { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Coupon> Coupons { get; set; }
        public virtual DbSet<Event> Events { get; set; }
        public virtual DbSet<Manager> Managers { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<SelectedProduct> SelectedProducts { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-EH0K74B;Initial Catalog=Dreamlike;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Hebrew_CI_AS");

            modelBuilder.Entity<Agent>(entity =>
            {
                entity.ToTable("agent");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.BusinessName)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.Mail)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<BlockedCategory>(entity =>
            {
                entity.HasKey(e => new { e.CategoryId, e.CouponId })
                    .HasName("PK_blockedCategories");

                entity.ToTable("blockedCategory");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.BlockedCategories)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__blockedCa__Categ__1FCDBCEB");

                entity.HasOne(d => d.Coupon)
                    .WithMany(p => p.BlockedCategories)
                    .HasForeignKey(d => d.CouponId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__blockedCa__Coupo__20C1E124");
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.ToTable("category");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(15);
            });

            modelBuilder.Entity<City>(entity =>
            {
                entity.ToTable("city");

                entity.Property(e => e.CityName)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<Coupon>(entity =>
            {
                entity.ToTable("coupon");

                entity.Property(e => e.CouponId).ValueGeneratedNever();

                entity.Property(e => e.DateOrder).HasColumnType("date");

                entity.Property(e => e.GreetingCard).HasMaxLength(1);

                entity.Property(e => e.MusicFile).HasMaxLength(10);

                entity.Property(e => e.RecipientName)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.ShippingAddress)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.HasOne(d => d.Event)
                    .WithMany(p => p.Coupons)
                    .HasForeignKey(d => d.EventId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__coupon__EventId__1920BF5C");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Coupons)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__coupon__UserId__182C9B23");
            });

            modelBuilder.Entity<Event>(entity =>
            {
                entity.ToTable("event");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<Manager>(entity =>
            {
                entity.ToTable("manager");

                entity.Property(e => e.Address).HasMaxLength(20);

                entity.Property(e => e.Mail)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("product");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__product__Categor__239E4DCF");
            });

            modelBuilder.Entity<SelectedProduct>(entity =>
            {
                entity.HasKey(e => new { e.ProductId, e.CouponId })
                    .HasName("PK_selectedProducts");

                entity.ToTable("selectedProduct");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.HasOne(d => d.Coupon)
                    .WithMany(p => p.SelectedProducts)
                    .HasForeignKey(d => d.CouponId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__selectedP__Coupo__276EDEB3");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.SelectedProducts)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__selectedP__Produ__267ABA7A");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("user");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.Mail)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(10);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
