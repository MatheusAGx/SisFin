using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dados;

namespace Negocio
{
    class ContaReceberService
    {
        private ContaReceberRepository _repository;

        public ContaReceberService()
        {
            _repository = new ContaReceberRepository();
        }

        public void Insert(int id, TipoPessoa tipoPessoa, string nome, string email, string cpf_cnpj, DateTime dataNascimento, string rua, int numero, string bairro, string complemento, string cep, string telefone, string celular, decimal limite)
        {
            // Insira as validações e regras de negócio aqui
            // Por exemplo, verificar se o email já está cadastrado

            var contaReceber = new ContaReceber();


            _repository.Insert(contaReceber);

        }

        public void Insert(ContaReceber contaReceber)
        {
            // Insira as validações e regras de negócio aqui
            // Por exemplo, verificar se o email já está cadastrado

            _repository.Insert(contaReceber);

        }

        public ContaReceber FindById(int id)
        {
            foreach (ContaReceber c in _repository.getAll())
            {
                if (c.id == id) return c;
            }
            return null;
        }

        public IEnumerable<ContaReceber> ObterTodos()
        {
            return _repository.ObterTodos();
        }
        public List<ContaReceber> getAll()
        {
            return _repository.ObterTodos().ToList<ContaReceber>();
        }
    }
}
