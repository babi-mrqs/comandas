using Microsoft.EntityFrameworkCore;

namespace Comandas
{
    //classe que representa o bando de dados
    public class AppDbContext : DbContext
    {
        //propriedade que representa a tabela Usuario
        public DbSet<Usuario> Usuarios { get; set; }
        
        //metodo que configura e informa para o EF que o banco será SQLite
        protected override void OnConfiguring(DbContextOptionsBuilder
       optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=comandas.db");
        }
    }
}
