using Microsoft.EntityFrameworkCore;
using projeto_crud.Models;
using System.Security.Cryptography.X509Certificates;

namespace projeto_crud.Data
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto>options)
            :base(options)
        {
    
        }
        public DbSet<Usuario> Usuario { get; set; } 
    }
}
