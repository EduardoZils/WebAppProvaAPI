using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppProvaAPI.Model;

namespace WebAppProvaAPI.Repository
{
    public class DestinoRepository : IDestinoRepository
    {
        private readonly WebAppProvaContext _context;

        public void Delete(int codigo)
        {
            var destinoRemover = _context.Destinos.Where(m => m.Codigo == codigo).FirstOrDefault();
            _context.Destinos.Remove(destinoRemover);
            _context.SaveChanges();
        }

        public void Dispose()
        {
        }

        public List<Destino> GetAll() =>
            _context.Destinos.ToList();

        public Destino GetById(int id) =>
            _context.Destinos.Where(m => m.Codigo == id).FirstOrDefault();

        public void Save(Destino destino)
        {
            _context.Destinos.Add(destino);
            _context.SaveChanges();
        }

        public void Update(Destino destino)
        {
            _context.Destinos.Update(destino);
            _context.SaveChanges();
        }
    }
        
    
}
