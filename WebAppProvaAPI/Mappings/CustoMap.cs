using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppProvaAPI.Model;

namespace WebAppProvaAPI.Mappings
{
    public class CustoMap : IEntityTypeConfiguration<Custo>
    {
        public void Configure(EntityTypeBuilder<Custo> builder)
        {
            builder.ToTable("custo");
            builder.Property(e => e.Codigo).HasColumnName("cd_custo");
            builder.Property(e => e.CodigoDestino).HasColumnName("cd_destino");
            builder.Property(e => e.DescricaoCusto).HasColumnName("ds_custo");
            builder.Property(e => e.Tipo).HasColumnName("tp_custo");
            builder.Property(e => e.ValorCusto).HasColumnName("vl_custo");
            builder.HasOne(e => e.Destino).WithMany(m => m.listaCustos)
                .HasForeignKey(e => e.CodigoDestino);
            builder.HasKey(e => e.Codigo);
            
        }
    }
}
