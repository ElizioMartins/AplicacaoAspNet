using Microsoft.EntityFrameworkCore; 


namespace AplicacaoAspNet.Models
{
    public class Context : DbContext 
    {
       public DbSet<Categoria> Categorias { get; set; }
       protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
       {
           optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Cursomvc;Integrated Security=True");
       }
    }
}