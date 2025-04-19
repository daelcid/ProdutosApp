using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProdutoApp.Domain.Models.Entities;

namespace ProdutoApp.Infra.Data.Mappings
{
    public class FornecedorMap : IEntityTypeConfiguration<Fornecedor>
    {
        public void Configure(EntityTypeBuilder<Fornecedor> builder)
        {
            builder.ToTable("FORNECEDOR");

            builder.HasKey(f => f.Id);

            builder.Property(f => f.Id).HasColumnName("ID");
            builder.Property(f => f.Nome).HasColumnName("NOME").HasMaxLength(100).IsRequired();
        }
    }
}
