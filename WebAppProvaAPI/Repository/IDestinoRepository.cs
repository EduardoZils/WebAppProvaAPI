using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppProvaAPI.Model;

namespace WebAppProvaAPI.Repository
{
    public interface IDestinoRepository : IDisposable
    {
        void Save(Destino destino);

        void Update(Destino destino);

        void Delete(int codigo);

        List<Destino> GetAll();

        Destino GetById(int id);

    }
}
