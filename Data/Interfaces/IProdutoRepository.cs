using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Interfaces
{
    public interface IProdutoRepository
    {
        IQueryable<Produto> GetAll();
        Task Add(Produto entity);

        //IQueryable<Produto> GetAll();
        //Task Add(Produto entity);

        public interface IProdutoRepository
        {            
            //void GetProdutos(List<Produto> produtos);
            IEnumerable<Produto> GetProdutos();
            Produto GetProdutoByID(int produtoId);
            void InsertProduto(Produto produto);
            void DeleteProduto(int produtoID);
            void UpdateProduto(Produto produto);
            //void Save();
            void SaveProdutos(List<Produto> produtos);

        }

        //public IEnumerable<Produto> GetProdutos()
        //{
        //    return _db.Produto.ToList();
        //}

        //public void SaveProdutos(List<Produto> produtos)
        //{
        //    foreach (var produto in produtos)
        //    {
        //        //_db.SaveChanges();
        //        _db.Set<Produto>().Add(new Produto(produto.Id, produto.Nome, produto.Quantidade, produto.Status));

        //    }
        //    _db.SaveChanges();
        //}
  
    }
}
