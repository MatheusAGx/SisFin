using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dados;

namespace Negocio
{
    public class ItemCompraService
    {
        private ItemCompraRepository _repository;

        public ItemCompraService()
        {
            _repository = new ItemCompraRepository();
        }

        public void Insert(int id, TipoPessoa tipoPessoa, string nome, string email, string cpf_cnpj, DateTime dataNascimento, string rua, int numero, string bairro, string complemento, string cep, string telefone, string celular, decimal limite)
        {
            // Insira as validações e regras de negócio aqui
            // Por exemplo, verificar se o email já está cadastrado

            var itemCompra = new ItemCompra();


            _repository.Insert(itemCompra);

        }

        public void Insert(ItemCompra itemCompra)
        {
            // Insira as validações e regras de negócio aqui
            // Por exemplo, verificar se o email já está cadastrado

            _repository.Insert(itemCompra);

        }

        public ItemCompra FindById(int id)
        {
            foreach (ItemCompra c in _repository.getAll())
            {
                if (c.id == id) return c;
            }
            return null;
        }

        public IEnumerable<ItemCompra> ObterTodos()
        {
            return _repository.ObterTodos();
        }
        public List<ItemCompra> getAll()
        {
            return _repository.ObterTodos().ToList<ItemCompra>();
        }

        }
    }

}
}
