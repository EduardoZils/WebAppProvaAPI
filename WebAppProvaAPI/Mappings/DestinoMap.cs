using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppProvaAPI.Model;

namespace WebAppProvaAPI.Mappings
{
    public class DestinoMap : IEntityTypeConfiguration<Destino>
    { 
        public void Configure(EntityTypeBuilder<Destino> builder)
        {
            builder.ToTable("destino");
            builder.Property(e => e.Codigo).HasColumnName("cd_destino");
            builder.Property(e => e.Descricao).HasColumnName("ds_destino");
            builder.Property(e => e.DataInicial).HasColumnName("dt_inicio");
            builder.Property(e => e.DataTermino).HasColumnName("dt_termino");
            builder.Property(e => e.ValorTotal).HasColumnName("vl_total");
            builder.HasMany(e => e.listaCustos).WithOne(m => m.Destino)
                .HasForeignKey(e => e.CodigoDestino);
            builder.HasKey(e => e.Codigo);
        }
    }
}
