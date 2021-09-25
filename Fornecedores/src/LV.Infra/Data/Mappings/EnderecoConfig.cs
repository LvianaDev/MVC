using LV.Buniness.Models.Fornecedores;
using System.Data.Entity.ModelConfiguration;

namespace LV.Infra.Data.Mappings
{
    public class EnderecoConfig : EntityTypeConfiguration<Endereco>
    {
        public EnderecoConfig()
        {
            HasKey(p => p.Id);

            Property(c => c.Logradouro)
                .HasColumnName("Rua")
                .IsRequired()
                .HasMaxLength(200);

            Property(c => c.Numero)
               .IsRequired()
               .HasMaxLength(50);

            Property(c => c.Cep)
              .IsRequired()
              .HasMaxLength(8)
              .IsFixedLength();

            Property(c => c.Complemento)
              .HasMaxLength(250);

            Property(c => c.Bairro)
              .IsRequired()
              .HasMaxLength(100);

            Property(c => c.Cidade)
             .IsRequired()
             .HasMaxLength(100);

            Property(c => c.Estado)
             .IsRequired()
             .HasMaxLength(500);

            ToTable("Enderecos");
        }
    }
}
