using System;
using System.Collections.Generic;
using Lab1.Model;

namespace Lab1.Repository
{
    public interface IProdutoRepository
    {
        IList<Produto> GetAll();
        Produto Get(Guid id);
        void Add(Produto produto);
        void Update(Produto produto);
        void Remove(Guid id);

    }
}