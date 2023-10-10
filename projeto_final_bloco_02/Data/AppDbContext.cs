using Microsoft.EntityFrameworkCore;
using projeto_final_bloco_02.Model;

namespace projeto_final_bloco_02.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

            this.ChangeTracker.LazyLoadingEnabled = false;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //MODEL GERA AS TABELAS
            modelBuilder.Entity<Produto>().ToTable("tb_produtos");
        }

        public DbSet<Produto> Produtos { get; set; } = null!;

    }
}
