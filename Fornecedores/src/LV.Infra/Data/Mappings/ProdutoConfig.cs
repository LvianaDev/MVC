using LV.Buniness.Models.Fornecedores;
using LV.Buniness.Models.Produtos;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;

namespace LV.Infra.Data.Mappings
{
    public class ProdutoConfig: EntityTypeConfiguration<Produto>
    {
        public ProdutoConfig()
        {
            HasKey(f => f.Id);

            Property(f => f.Nome)
                .IsRequired()
                .HasMaxLength(200);

            Property(f => f.Descricao)
                .IsRequired()
                .HasMaxLength(1000);

            Property(f => f.Imagem)
                .IsRequired()
                .HasMaxLength(100);

            HasRequired(p => p.Fornecedor)
                .WithMany(f => f.Produtos)
                .HasForeignKey(p => p.FornecedorId);
               
            ToTable("Produtos");
        }
            
    }
}
