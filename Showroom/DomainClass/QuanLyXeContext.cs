using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Showroom.DomainClass
{
    public partial class QuanLyXeContext : DbContext
    {
        public QuanLyXeContext()
        {
        }

        public QuanLyXeContext(DbContextOptions<QuanLyXeContext> options)
            : base(options)
        {
        }

        public virtual DbSet<HangXe> HangXes { get; set; }
        public virtual DbSet<Xe> Xes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=TANA\\SQLEXPRESS;Database=QuanLyXe;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<HangXe>(entity =>
            {
                entity.ToTable("HangXe");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Xe>(entity =>
            {
                entity.ToTable("Xe");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.IdHangXeNavigation)
                    .WithMany(p => p.Xes)
                    .HasForeignKey(d => d.IdHangXe)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Xe_HangXe");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
