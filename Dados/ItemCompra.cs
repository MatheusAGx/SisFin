using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    class ItemCompra
    {
        public int quantidade { get; set; }
        public decimal preco { get; set; }

        public override bool Equals(object obj)
        {
            return obj is ItemCompra compra &&
                   quantidade == compra.quantidade &&
                   preco == compra.preco;
        }

        public override int GetHashCode()
        {
            int hashCode = 2007030259;
            hashCode = hashCode * -1521134295 + quantidade.GetHashCode();
            hashCode = hashCode * -1521134295 + preco.GetHashCode();
            return hashCode;
        }
    }
}
