using Microsoft.EntityFrameworkCore;
using Projeto_API.DataServices.Mappins;
using Projeto_API.Entities;

namespace Projeto_API.DataServices
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> option) : base(option) { }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<EnderecoCliente> EnderecoCliente { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region MAPPINGS ENTITIES
            modelBuilder = MappingEntities.MappingAllEntities(modelBuilder);
            #endregion MAPPINGS ENTITIES
            base.OnModelCreating(modelBuilder);
        }
    }
}
