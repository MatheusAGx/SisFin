using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dados;

namespace Negocio
{
    public class ClienteService
    {
        private ClienteRepository _repository;

        public ClienteService()
        {
            _repository = new ClienteRepository();
        }

        public void Insert(int id, TipoPessoa tipoPessoa, string nome, string email, string cpf_cnpj, DateTime dataNascimento, string rua, int numero, string bairro, string complemento, string cep, string telefone, string celular, decimal limite)
        {
            // Insira as validações e regras de negócio aqui
            // Por exemplo, verificar se o email já está cadastrado

            var cliente = new Cliente(id, tipoPessoa, nome, email, cpf_cnpj, dataNascimento, rua, numero, bairro, complemento, cep, telefone, celular, limite);
        

            _repository.Insert(cliente);

        }

        public void Insert(Cliente cliente)
        {
            // Insira as validações e regras de negócio aqui
            // Por exemplo, verificar se o email já está cadastrado

            _repository.Insert(cliente);

        }

        public Cliente FindById(int id)
        {
            foreach(Cliente c in _repository.getAll())
            {
                if (c.id == id) return c;
            }
            return null;
        }

        public IEnumerable<Cliente> ObterTodos()
        {
            return _repository.ObterTodos();
        }
        public List<Cliente> getAll()
        {
            return _repository.ObterTodos().ToList<Cliente>();
        }

    }
}
