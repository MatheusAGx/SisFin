using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    class CaixaRepository
    {
        private IList<Caixa> _caixa = new List<Caixa>();

        public Caixa Insert(Caixa caixa)
        {
            // Aqui você poderia inserir o cliente em um banco de dados
            // Para simplificar, estamos apenas adicionando a uma lista em memória
            this._caixa.Add(caixa));
            return caixa;
        }

        public Caixa Update(Caixa caixa)
        {
            this._caixa[this._caixa.IndexOf(caixa)] = caixa;
            return caixa;
        }

        public void Remove(Caixa controleCaixa)
        {
            this._caixa.Remove(controleCaixa);
        }

        public IEnumerable<Caixa> ObterTodos()
        {
            return _caixa;
        }

        public IList<Caixa> getAll()
        {
            return _caixa;
        }
    }
}
