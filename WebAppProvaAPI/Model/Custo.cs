using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppProvaAPI.Model
{
    public class Custo
    {
        public int Codigo { get; set; }
        public int CodigoDestino { get; set; }
        public string DescricaoCusto { get; set; }
        public int Tipo { get; set; }
        public double ValorCusto { get; set; }
        public Destino Destino { get; set; }
    }
}
