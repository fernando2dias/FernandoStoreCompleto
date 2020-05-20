using FernandoStore.Dominio.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace FernandoStore.Repositorio.Config
{
    public class ProdutoConfiguration : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Nome).IsRequired().HasMaxLength(50);
            builder.Property(p => p.Preco).IsRequired().HasColumnType("decimal(10,2)");
            builder.Property(p => p.Descricao).IsRequired().HasMaxLength(500);
        }
    }
}
