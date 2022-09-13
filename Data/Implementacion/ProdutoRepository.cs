using Data.Interfaces;
using Domain;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Implementacion
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly Contexto _db;

        public ProdutoRepository(Contexto db)

        public ProdutoRepository(AppDbContext contexto)
        {
            _db = db;
        }
  
        public async Task Add(Produto entity)
        {
            await _db.AddAsync(entity);
            await _db.SaveChangesAsync();
        }

        public IQueryable<Produto> GetAll()
        {
            return _db.Produto;
        }

        //---------------------------------------------------------
        public IEnumerable<Produto> GetStudents()
        {
            return _db.Produto.ToList();
        }

        public Produto GetStudentByID(int id)
        {
            return _db.Produto.Find(id);
        }

        public void InsertStudent(Produto produto)
        {
            _db.Produto.Add(produto);
        }

        public void DeleteStudent(int produtoID)
        {
            Produto produto = _db.Produto.Find(produtoID);
            _db.Produto.Remove(produto);
        }

        public void UpdateStudent(Produto produto)
        {
            // _db.Entry(student).State = EntityState.Modified;
        }

        public void Save()
        {
            _db.SaveChanges();
        }

        //---------------------------------------------------------

        public void SaveProdutos(List<Produto> produtos)
        {
            foreach (var produto in produtos)
            {
                //_db.SaveChanges();
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
