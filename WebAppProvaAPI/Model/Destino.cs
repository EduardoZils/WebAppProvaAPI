using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppProvaAPI.Model
{
    public class Destino
    {
        public int Codigo { get; set; }
        public string Descricao { get; set; }
        public DateTime DataInicial { get; set; }
        public DateTime DataTermino { get; set; }
        public double ValorTotal { get; set; }
        public List<Custo> listaCustos { get; set; }
    }
}
