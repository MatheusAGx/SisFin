using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dados;

namespace Negocio
{
    class ContaPagarService
    {
        private ContaPagarRepository _repository;

        public ContaPagarService()
        {
            _repository = new ContaPagarRepository();
        }

        public void Insert(int id, TipoPessoa tipoPessoa, string nome, string email, string cpf_cnpj, DateTime dataNascimento, string rua, int numero, string bairro, string complemento, string cep, string telefone, string celular, decimal limite)
        {
            // Insira as validações e regras de negócio aqui
            // Por exemplo, verificar se o email já está cadastrado

            var contaPagar = new ContaPagar();


            _repository.Insert(contaPagar);

        }

        public void Insert(ContaPagar contaPagar)
        {
            // Insira as validações e regras de negócio aqui
            // Por exemplo, verificar se o email já está cadastrado

            _repository.Insert(contaPagar);

        }

        public ContaPagar FindById(int id)
        {
            foreach (ContaPagar c in _repository.getAll())
            {
                if (c.id == id) return c;
            }
            return null;
        }

        public IEnumerable<ContaPagar> ObterTodos()
        {
            return _repository.ObterTodos();
        }
        public List<ContaPagar> getAll()
        {
            return _repository.ObterTodos().ToList<ContaPagar>();
        }
    }
}
