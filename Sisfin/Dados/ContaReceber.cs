using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    class ContaReceber
    {
        public int id { get; set; }
        public decimal valor { get; set; }
        public Venda vendas { get; set; }
        public Conta conta { get; set; }
        public DateTime dataCadastro { get; set; }
        public DateTime dataVencimento { get; set; }
        public DateTime dataRecebimento { get; set; }
        public decimal valorRecebido { get; set; }
        public MeioPagamento meioPagamento { get; set; }
        public EstadoPagamento situacao { get; set; }

        public override bool Equals(object obj)
        {
            return obj is ContaReceber receber &&
                   id == receber.id &&
                   valor == receber.valor &&
                   EqualityComparer<Venda>.Default.Equals(vendas, receber.vendas) &&
                   EqualityComparer<Conta>.Default.Equals(conta, receber.conta) &&
                   dataCadastro == receber.dataCadastro &&
                   dataVencimento == receber.dataVencimento &&
                   dataRecebimento == receber.dataRecebimento &&
                   valorRecebido == receber.valorRecebido &&
                   meioPagamento == receber.meioPagamento &&
                   situacao == receber.situacao;
        }

        public override int GetHashCode()
        {
            int hashCode = -1463015627;
            hashCode = hashCode * -1521134295 + id.GetHashCode();
            hashCode = hashCode * -1521134295 + valor.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<Venda>.Default.GetHashCode(vendas);
            hashCode = hashCode * -1521134295 + EqualityComparer<Conta>.Default.GetHashCode(conta);
            hashCode = hashCode * -1521134295 + dataCadastro.GetHashCode();
            hashCode = hashCode * -1521134295 + dataVencimento.GetHashCode();
            hashCode = hashCode * -1521134295 + dataRecebimento.GetHashCode();
            hashCode = hashCode * -1521134295 + valorRecebido.GetHashCode();
            hashCode = hashCode * -1521134295 + meioPagamento.GetHashCode();
            hashCode = hashCode * -1521134295 + situacao.GetHashCode();
            return hashCode;
        }
    }
}
