using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    class CategoriaRepository
    {
        private IList<Categoria> _categoria = new List<Categoria>();

        public Categoria Insert(Categoria categoria)
        {
            // Aqui você poderia inserir o cliente em um banco de dados
            // Para simplificar, estamos apenas adicionando a uma lista em memória
            this._categoria.Add(categoria);
            return categoria;
        }

        public Categoria Update(Categoria categoria)
        {
            this._categoria[this._categoria.IndexOf(categoria)] = categoria;
            return categoria;
        }

        public void Remove(Categoria categoria)
        {
            this._categoria.Remove(categoria);
        }

        public IEnumerable<Categoria> ObterTodos()
        {
            return _categoria;
        }

        public IList<Categoria> getAll()
        {
            return _categoria;
        }
    }
}
