using Data.Interfaces;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Implementacion
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly Contexto _db;

        public ProdutoRepository(Contexto db)
        {
            _db = db;
        }

        public async Task Add(ProdutoRepository entity)
        {
            await _db.AddAsync(entity);
            await _db.SaveChangesAsync();
        }

        public Task Add(Produto entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Produto> GetAll()
        {

            return _db.Produto;

        }
    }
}
