using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dados;

namespace Negocio
{
    class CompraService
    {
        private CompraRepository _repository;

        public CompraService()
        {
            _repository = new CompraRepository();
        }

        public void Insert(int id, TipoPessoa tipoPessoa, string nome, string email, string cpf_cnpj, DateTime dataNascimento, string rua, int numero, string bairro, string complemento, string cep, string telefone, string celular, decimal limite)
        {
            // Insira as validações e regras de negócio aqui
            // Por exemplo, verificar se o email já está cadastrado

            var compra = new Compra();


            _repository.Insert(compra);

        }

        public void Insert(Compra compra)
        {
            // Insira as validações e regras de negócio aqui
            // Por exemplo, verificar se o email já está cadastrado

            _repository.Insert(compra);

        }

        public Compra FindById(int id)
        {
            foreach (Compra c in _repository.getAll())
            {
                if (c.id == id) return c;
            }
            return null;
        }

        public IEnumerable<Compra> ObterTodos()
        {
            return _repository.ObterTodos();
        }
        public List<Compra> getAll()
        {
            return _repository.ObterTodos().ToList<Compra>();
        }
    }
}
