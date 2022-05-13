using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using mvcCleanArch.Domain.Entities;

namespace mvcCleanArch.Infra.Data.EntityConfiguration;

public class ProductConfiguration : IEntityTypeConfiguration<Product>
{
   public void Configure(EntityTypeBuilder<Product> builder)
   {
       builder.Property(p => p.Name).HasMaxLength(100).IsRequired();
       builder.Property(p => p.Description).HasMaxLength(100).IsRequired();
       builder.Property(p => p.Price).HasPrecision(10,2);

       builder.HasData(
           new Product
            {
                Id = 1,
                Name = "Caderno",
                Description = "Caderno Espiral 100 Folhas Capa Felipe Dylon",
                Price = 9.45m
            },
            new Product
            {   
                Id = 2,
                Name = "Lapis",
                Description = "Lapis preto",
                Price = 0.45m
            },
            new Product
            {   
                Id = 3,
                Name = "Caneta",
                Description = "Caneta Azul",
                Price = 1.45m
            }
       );
   }
}