using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    public class FornecedorRepository
    {
        private IList<Fornecedor> _fornecedor = new List<Fornecedor>();

        public Fornecedor Insert(Fornecedor fornecedor)
        {
            // Aqui você poderia inserir o cliente em um banco de dados
            // Para simplificar, estamos apenas adicionando a uma lista em memória
            this._fornecedor.Add(fornecedor);
            return fornecedor;
        }

        public Fornecedor Update(Fornecedor fornecedor)
        {
            this._fornecedor[this._fornecedor.IndexOf(fornecedor)] = fornecedor;
            return fornecedor;
        }

        public void Remove(Fornecedor fornecedor)
        {
            this._fornecedor.Remove(fornecedor);
        }

        public IEnumerable<Fornecedor> ObterTodos()
        {
            return _fornecedor;
        }

        public IList<Fornecedor> getAll()
        {
            return _fornecedor;
        }
    }
}
