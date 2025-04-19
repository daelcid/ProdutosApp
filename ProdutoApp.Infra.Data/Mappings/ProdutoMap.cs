using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProdutoApp.Domain.Models.Entities;

namespace ProdutoApp.Infra.Data.Mappings
{
    public class ProdutoMap : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.ToTable("PRODUTO");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id).HasColumnName("ID");
            builder.Property(p => p.Nome).HasColumnName("NOME").HasMaxLength(100).IsRequired();
            builder.Property(p => p.Preco).HasColumnName("PRECO").HasColumnType("decimal(10,2)").IsRequired();
            builder.Property(p => p.Quantidade).HasColumnName("QUANTIDADE").IsRequired();   
            builder.Property(p => p.FornecedorId).HasColumnName("FORNECEDOR_ID").IsRequired();

            builder.HasOne(p => p.Fornecedor)
                .WithMany(f => f.Produtos)
                .HasForeignKey(p => p.FornecedorId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired();
        }
    }
}
