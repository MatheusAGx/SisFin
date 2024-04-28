using Dados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    class FornecedorService
    {
        private FornecedorRepository _repository;

        public FornecedorService()
        {
            _repository = new FornecedorRepository();
        }

        public void Insert(int id, TipoPessoa tipoFornecedor, string cpf_cnpj, string razao_social, string nome, string rua, int numero, string bairro, string cidade, string complemento, string cep, string telefone, string celular, string email)
        {
            // Insira as validações e regras de negócio aqui
            // Por exemplo, verificar se o email já está cadastrado

            var fornecedor = new Fornecedor
            {
                Id = id,
                tipoFornecedor = tipoFornecedor,
                cpf_cnpj = cpf_cnpj,
                razao_social = razao_social,
                nome = nome,
                rua = rua,
                numero = numero,
                bairro = bairro,
                cidade = cidade,
                complemento = complemento,
                cep = cep,
                telefone = telefone,
                celular = celular,
                email = email,
        };

            _repository.Insert(fornecedor);

        }

        public void Insert(Fornecedor fornecedor)
        {
            // Insira as validações e regras de negócio aqui
            // Por exemplo, verificar se o email já está cadastrado

            _repository.Insert(fornecedor);

        }

        public Fornecedor FindById(int id)
        {
            foreach (Fornecedor c in _repository.getAll())
            {
                if (c.Id == id) return c;
            }
            return null;
        }

        public IEnumerable<Fornecedor> ObterTodos()
        {
            return _repository.ObterTodos();
        }
        public List<Fornecedor> getAll()
        {
            return _repository.ObterTodos().ToList<Fornecedor>();
        }
    }
}
