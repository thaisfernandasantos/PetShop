using System.Data.Entity;

namespace PetShopSolution2.Models
{
    public class contexto : DbContext
    {
        public DbSet<animal> animals { get; set; }
        public DbSet<cliente> clientes { get; set; }
        public DbSet<produto> produtos { get; set; }
        
    }
}