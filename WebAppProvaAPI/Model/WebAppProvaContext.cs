using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppProvaAPI.Mappings;

namespace WebAppProvaAPI.Model
{
    public class WebAppProvaContext : DbContext
    {
        public WebAppProvaContext(DbContextOptions<WebAppProvaContext> options) : base(options)
        {

        }

        /// <summary>
        /// Classe Responsável por Relacionar o MAP com a sua Entidade
        /// </summary>
        /// <param name="modelBuilder"></param>
        /// 

        public DbSet<Destino> Destinos { get; set; }
        public DbSet<Custo> Custos { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new DestinoMap());
            modelBuilder.ApplyConfiguration(new CustoMap());
        }
    }
}
