using FernandoStore.Dominio.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace FernandoStore.Repositorio.Config
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.HasKey(u => u.Id);

            //Build utiliza o pradrão fluent
            builder.Property(u => u.Email).IsRequired().HasMaxLength(50);
            builder.Property(u => u.Nome).IsRequired().HasMaxLength(50);
            builder.Property(u => u.SobreNome).IsRequired().HasMaxLength(150);
            builder.Property(u => u.Senha).IsRequired().HasMaxLength(500);

            builder.HasMany(u => u.Pedidos).WithOne( p => p.Usuario);

        }
    }
}
