using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    class CompraRepository
    {
        private IList<Compra> _compra = new List<Compra>();

        public Compra Insert(Compra compra)
        {
            // Aqui você poderia inserir o cliente em um banco de dados
            // Para simplificar, estamos apenas adicionando a uma lista em memória
            this._compra.Add(compra);
            return compra;
        }

        public Compra Update(Compra compra)
        {
            this._compra[this._compra.IndexOf(compra)] = compra;
            return compra;
        }

        public void Remove(Compra compra)
        {
            this._compra.Remove(compra);
        }

        public IEnumerable<Compra> ObterTodos()
        {
            return _compra;
        }

        public IList<Compra> getAll()
        {
            return _compra;
        }
    }
}
