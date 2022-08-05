using Microsoft.EntityFrameworkCore;

#nullable disable

namespace CuaHangTrangSuc.DomainClass
{
    public partial class CSharpContext : DbContext
    {
        public CSharpContext()
        {
        }

        public CSharpContext(DbContextOptions<CSharpContext> options)
            : base(options)
        {
        }

        public virtual DbSet<MauSacChuDao> MauSacChuDaos { get; set; }
        public virtual DbSet<NhaSanXuat> NhaSanXuats { get; set; }
        public virtual DbSet<TrangSuc> TrangSucs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=TANA\\SQLEXPRESS;Database=CSharp;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<MauSacChuDao>(entity =>
            {
                entity.HasKey(e => e.IdMauSac);

                entity.ToTable("MauSacChuDao");

                entity.Property(e => e.IdMauSac).ValueGeneratedNever();

                entity.Property(e => e.MaMauSac).HasMaxLength(50);

                entity.Property(e => e.TenMauSac).HasMaxLength(50);
            });

            modelBuilder.Entity<NhaSanXuat>(entity =>
            {
                entity.HasKey(e => e.IdNhaSanXuat);

                entity.ToTable("NhaSanXuat");

                entity.Property(e => e.IdNhaSanXuat).ValueGeneratedNever();

                entity.Property(e => e.MaNhaSanXuat).HasMaxLength(50);

                entity.Property(e => e.TenNhaSanXuat).HasMaxLength(50);
            });

            modelBuilder.Entity<TrangSuc>(entity =>
            {
                entity.ToTable("TrangSuc");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.MaTrangSuc).HasMaxLength(50);

                entity.Property(e => e.TenTrangSuc).HasMaxLength(50);

                entity.HasOne(d => d.IdMauChuDaoNavigation)
                    .WithMany(p => p.TrangSucs)
                    .HasForeignKey(d => d.IdMauChuDao)
                    .HasConstraintName("FK_TrangSuc_MauSacChuDao");

                entity.HasOne(d => d.IdNhaSanXuatNavigation)
                    .WithMany(p => p.TrangSucs)
                    .HasForeignKey(d => d.IdNhaSanXuat)
                    .HasConstraintName("FK_TrangSuc_NhaSanXuat");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
