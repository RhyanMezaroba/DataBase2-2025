using FC_Imobiliaria.Models;
using Microsoft.EntityFrameworkCore;

namespace FC_Imobiliaria.Data
{
    public class ImobiliariaContext : DbContext
    {
        public ImobiliariaContext(DbContextOptions<ImobiliariaContext> options) : base(options)
        {
        }

        public DbSet<Imoveis> Imoveis { get; set; }
        public DbSet<Inquilino> Inquilinos { get; set; }
        public DbSet<InquilinoImoveis> InquilinoImoveis { get; set; }
    }
}
