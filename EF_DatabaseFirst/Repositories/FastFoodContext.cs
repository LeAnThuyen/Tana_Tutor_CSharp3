using Microsoft.EntityFrameworkCore;

#nullable disable

namespace EF_DatabaseFirst.Repositories
{
    public partial class FastFoodContext : DbContext
    {
        public FastFoodContext()
        {
        }

        public FastFoodContext(DbContextOptions<FastFoodContext> options)
            : base(options)
        {
        }

        public virtual DbSet<FoodTour> FoodTours { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=TANA\\SQLEXPRESS;Database=FastFoodForThuyen;Persist Security Info=True;User ID=thuyen;Password=123;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<FoodTour>(entity =>
            {
                entity.HasKey(c => c.Id);

                entity.ToTable("FoodTour");

                entity.Property(e => e.MaMonAn).HasMaxLength(50);

                entity.Property(e => e.TenMonAn).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
