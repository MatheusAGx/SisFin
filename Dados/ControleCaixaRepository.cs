using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    public class ControleCaixaRepository
    {
        private IList<ControleCaixa> _controleCaixa = new List<ControleCaixa>();

        public ControleCaixa Insert(ControleCaixa controleCaixa)
        {
            // Aqui você poderia inserir o cliente em um banco de dados
            // Para simplificar, estamos apenas adicionando a uma lista em memória
            this._controleCaixa.Add(controleCaixa);
            return controleCaixa;
        }

        public ControleCaixa Update(ControleCaixa controleCaixa)
        {
            this._controleCaixa[this._controleCaixa.IndexOf(controleCaixa)] = controleCaixa;
            return controleCaixa;
        }

        public void Remove(ControleCaixa controleCaixa)
        {
            this._controleCaixa.Remove(controleCaixa);
        }

        public IEnumerable<ControleCaixa> ObterTodos()
        {
            return _controleCaixa;
        }

        public IList<ControleCaixa> getAll()
        {
            return _controleCaixa;
        }
    }
}
