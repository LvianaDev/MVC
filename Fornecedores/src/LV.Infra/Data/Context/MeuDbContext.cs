using LV.Buniness.Models.Fornecedores;
using LV.Buniness.Models.Produtos;
using LV.Infra.Data.Mappings;
using System.Data.Entity;

namespace LV.Infra.Data.Context
{
    class MeuDbContext : DbContext
    {
        public MeuDbContext() : base(nameOrConnectionString: "DefaultConnection") 
        { }

        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Fornecedor> Fornecedores { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new FornecedorConfig());
            modelBuilder.Configurations.Add(new EnderecoConfig());
            modelBuilder.Configurations.Add(new ProdutoConfig());
        }
    }
}
