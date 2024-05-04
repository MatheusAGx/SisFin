using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dados;

namespace Negocio
{
    class ContaService
    {
        private ContaRepository _repository;

        public ContaService()
        {
            _repository = new ContaRepository();
        }

        public void Insert(int id, TipoPessoa tipoPessoa, string nome, string email, string cpf_cnpj, DateTime dataNascimento, string rua, int numero, string bairro, string complemento, string cep, string telefone, string celular, decimal limite)
        {
            // Insira as validações e regras de negócio aqui
            // Por exemplo, verificar se o email já está cadastrado

            var conta = new Conta();


            _repository.Insert(conta);

        }

        public void Insert(Conta conta)
        {
            // Insira as validações e regras de negócio aqui
            // Por exemplo, verificar se o email já está cadastrado

            _repository.Insert(conta);

        }

        public Conta FindById(int id)
        {
            foreach (Conta c in _repository.getAll())
            {
                if (c.id == id) return c;
            }
            return null;
        }

        public IEnumerable<Conta> ObterTodos()
        {
            return _repository.ObterTodos();
        }
        public List<Conta> getAll()
        {
            return _repository.ObterTodos().ToList<Conta>();
        }
    }
}
