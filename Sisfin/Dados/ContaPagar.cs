using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    class ContaPagar
    {
        public int id { get; set; }
        public decimal valor { get; set; }
        public Conta conta { get; set; }
        public Compra compra { get; set; }
        public DateTime dataCadastro { get; set; }
        public DateTime dataVencimento { get; set; }
        public DateTime dataPagamento { get; set; }
        public MeioPagamento meioPagamento { get; set; }
        public EstadoPagamento estadoPagamento { get; set; }

        public override bool Equals(object obj)
        {
            return obj is ContaPagar pagar &&
                   id == pagar.id &&
                   valor == pagar.valor &&
                   EqualityComparer<Conta>.Default.Equals(conta, pagar.conta) &&
                   EqualityComparer<Compra>.Default.Equals(compra, pagar.compra) &&
                   dataCadastro == pagar.dataCadastro &&
                   dataVencimento == pagar.dataVencimento &&
                   dataPagamento == pagar.dataPagamento &&
                   meioPagamento == pagar.meioPagamento &&
                   estadoPagamento == pagar.estadoPagamento;
        }

        public override int GetHashCode()
        {
            int hashCode = 1310630238;
            hashCode = hashCode * -1521134295 + id.GetHashCode();
            hashCode = hashCode * -1521134295 + valor.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<Conta>.Default.GetHashCode(conta);
            hashCode = hashCode * -1521134295 + EqualityComparer<Compra>.Default.GetHashCode(compra);
            hashCode = hashCode * -1521134295 + dataCadastro.GetHashCode();
            hashCode = hashCode * -1521134295 + dataVencimento.GetHashCode();
            hashCode = hashCode * -1521134295 + dataPagamento.GetHashCode();
            hashCode = hashCode * -1521134295 + meioPagamento.GetHashCode();
            hashCode = hashCode * -1521134295 + estadoPagamento.GetHashCode();
            return hashCode;
        }
    }
}
