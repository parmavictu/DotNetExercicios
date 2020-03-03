using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
        
            RepositorioGenerico<Cliente> cli = new RepositorioGenerico<Cliente>();
            RepositorioGenerico<Produto> prod = new RepositorioGenerico<Produto>();

        }
    }

    public class RepositorioGenerico<T> where T : class, new()
    {
        public Guid Save(T obj)
        {
            return Guid.NewGuid();
        }

        public void Update(T obj)
        {
        }

        public void Delete(T obj)
        {
        }

        public T Get(int id)
        {
            return null;
        }
    }

    public class Cliente
    {
    }

    public class Produto
    {
    }
}
