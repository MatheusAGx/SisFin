using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dados;

namespace Negocio
{
    class CategoriaService
    {
        private CategoriaRepository _repository;

        public CategoriaService()
        {
            _repository = new CategoriaRepository();
        }

        public void Insert(int id, TipoPessoa tipoPessoa, string nome, string email, string cpf_cnpj, DateTime dataNascimento, string rua, int numero, string bairro, string complemento, string cep, string telefone, string celular, decimal limite)
        {
            // Insira as validações e regras de negócio aqui
            // Por exemplo, verificar se o email já está cadastrado

            var categoria = new Categoria();


            _repository.Insert(categoria);

        }

        public void Insert(Categoria categoria)
        {
            // Insira as validações e regras de negócio aqui
            // Por exemplo, verificar se o email já está cadastrado

            _repository.Insert(categoria);

        }

        public Categoria FindById(int id)
        {
            foreach (Categoria c in _repository.getAll())
            {
                if (c.id == id) return c;
            }
            return null;
        }

        public IEnumerable<Categoria> ObterTodos()
        {
            return _repository.ObterTodos();
        }
        public List<Categoria> getAll()
        {
            return _repository.ObterTodos().ToList<Categoria>();
        }
    }
}
