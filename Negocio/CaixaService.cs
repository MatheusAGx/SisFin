using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dados;

namespace Negocio
{
    class CaixaService
    {
        private CaixaRepository _repository;

        public CaixaService()
        {
            _repository = new CaixaRepository();
        }

        public void Insert(int id, TipoPessoa tipoPessoa, string nome, string email, string cpf_cnpj, DateTime dataNascimento, string rua, int numero, string bairro, string complemento, string cep, string telefone, string celular, decimal limite)
        {
            // Insira as validações e regras de negócio aqui
            // Por exemplo, verificar se o email já está cadastrado

            var caixa = new Caixa();


            _repository.Insert(caixa);

        }

        public void Insert(Caixa caixa)
        {
            // Insira as validações e regras de negócio aqui
            // Por exemplo, verificar se o email já está cadastrado

            _repository.Insert(caixa);

        }

        public Caixa FindById(int id)
        {
            foreach (Caixa c in _repository.getAll())
            {
                if (c.id == id) return c;
            }
            return null;
        }

        public IEnumerable<Caixa> ObterTodos()
        {
            return _repository.ObterTodos();
        }
        public List<Caixa> getAll()
        {
            return _repository.ObterTodos().ToList<Caixa>();
        }
    }
}
