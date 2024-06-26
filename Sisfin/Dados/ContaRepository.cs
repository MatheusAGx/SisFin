﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    class ContaRepository
    {
        private IList<Conta> _conta = new List<Conta>();

        public Conta Insert(Conta conta)
        {
            // Aqui você poderia inserir o cliente em um banco de dados
            // Para simplificar, estamos apenas adicionando a uma lista em memória
            this._conta.Add(conta);
            return conta;
        }

        public Conta Update(Conta conta)
        {
            this._conta[this._conta.IndexOf(conta)] = conta;
            return conta;
        }

        public void Remove(Conta conta)
        {
            this._conta.Remove(conta);
        }

        public IEnumerable<Conta> ObterTodos()
        {
            return _conta;
        }

        public IList<Conta> getAll()
        {
            return _conta;
        }
    }
}
