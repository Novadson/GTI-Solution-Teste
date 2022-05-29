using Microsoft.EntityFrameworkCore;
using Projeto_API.Entities;

namespace Projeto_API.DataServices.Mappins
{
    public class MappingEntities
    {
        public static ModelBuilder MappingAllEntities(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>().Property(u => u.IdCliente).IsRequired().HasDefaultValueSql("newsequentialid()");
            modelBuilder.Entity<EnderecoCliente>().Property(u => u.IdEnderecoCliente).IsRequired().HasDefaultValueSql("newsequentialid()");

            modelBuilder.Entity<Cliente>()
                        .HasOne(s => s.Endereco)
                        .WithOne(en => en.Cliente)
                        .HasForeignKey<EnderecoCliente>(en => en.IdCliente).IsRequired(true).OnDelete(DeleteBehavior.Cascade);

            return modelBuilder;
        }
    }
}
