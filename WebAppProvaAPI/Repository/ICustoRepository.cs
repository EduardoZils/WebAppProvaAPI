using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppProvaAPI.Model;

namespace WebAppProvaAPI.Repository
{
    public interface ICustoRepository : IDisposable
    {
        void Save(Custo custo);

        void Update(Custo custo);

        void Delete(int codigo);

        List<Custo> GetAll();

        Custo GetById(int id);

        IEnumerable<Custo> GetByDestino(int codigo);
    }
}
