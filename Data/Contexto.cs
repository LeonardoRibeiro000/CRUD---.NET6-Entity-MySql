using Microsoft.EntityFrameworkCore;
using CrudMySql.Models;

namespace CrudMySql.Data
{
    public class Contexto : DbContext
    
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {}
        public DbSet<Produto> Produto { get; set; }
    }
}
