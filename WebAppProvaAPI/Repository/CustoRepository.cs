using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppProvaAPI.Model;

namespace WebAppProvaAPI.Repository
{
    public class CustoRepository : ICustoRepository
    {

        private readonly WebAppProvaContext _context;

        public CustoRepository(WebAppProvaContext context)
        {
            _context = context;
        }

        public void Delete(int codigo)
        {
            var custoRemover = _context.Custos.Where(m => m.Codigo == codigo).FirstOrDefault();
            _context.Custos.Remove(custoRemover);
            _context.SaveChanges();
        }

        public void Dispose()
        {
        }

        public List<Custo> GetAll() =>
            _context.Custos.ToList();


        public IEnumerable<Custo> GetByDestino(int codigo) =>
            _context.Custos.Where(m => m.CodigoDestino == codigo);

        public Custo GetById(int id) =>
            _context.Custos.Where(m => m.Codigo == id).FirstOrDefault();

        public void Save(Custo custo)
        {
            _context.Custos.Add(custo);
            _context.SaveChanges();
        }

        public void Update(Custo custo)
        {
            _context.Custos.Update(custo);
            _context.SaveChanges();
        }
    }
}
