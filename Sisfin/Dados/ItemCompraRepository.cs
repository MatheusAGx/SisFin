using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    class ItemCompraRepository
    {
        private IList<ItemCompra> _itemCompra = new List<ItemCompra>();

        public ItemCompra Insert(ItemCompra itemCompra)
        {
            // Aqui você poderia inserir o cliente em um banco de dados
            // Para simplificar, estamos apenas adicionando a uma lista em memória
            this._itemCompra.Add(itemCompra);
            return itemCompra;
        }

        public ItemCompra Update(ItemCompra itemCompra)
        {
            this._itemCompra[this._itemCompra.IndexOf(itemCompra)] = itemCompra;
            return itemCompra;
        }

        public void Remove(ItemCompra itemCompra)
        {
            this._itemCompra.Remove(itemCompra);
        }

        public IEnumerable<ItemCompra> ObterTodos()
        {
            return _itemCompra;
        }

        public IList<ItemCompra> getAll()
        {
            return _itemCompra;
        }
    }
}
