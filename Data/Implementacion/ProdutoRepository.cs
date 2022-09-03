using Data.Interfaces;
using Domain;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Implementacion
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly AppDbContext _db;
        private readonly IProdutoRepository produtoRepository;

        //public ProdutoRepository(AppDbContext db)
        //{
        //    _db = db;
        //}
        public ProdutoRepository(AppDbContext contexto)
        {
            this._db = contexto;
            this.produtoRepository = produtoRepository;
        }

        public void SaveProdutos(List<Produto> produtos)
        {
            foreach (var produto in produtos)
            {
                _db.Set<Produto>().Add(new Produto(produto.Id, produto.Nome, produto.Quantidade, produto.Status));

            }
            _db.SaveChanges();
        }

        //public async Task Add(Produto entity)
        //{
        //    await _db.AddAsync(entity);
        //    await _db.SaveChangesAsync();
        //}

        //public IQueryable<Produto> GetAll()
        //{
        //    return _db.Produto;
        //}
    }
}
