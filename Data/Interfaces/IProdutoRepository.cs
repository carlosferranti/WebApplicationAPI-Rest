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
        //IQueryable<Produto> GetAll();
        //Task Add(Produto entity);

        public interface IProdutoRepository
        {
            void SaveProdutos(List<Produto> livros);
        }
    }
}
